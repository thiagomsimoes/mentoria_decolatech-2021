using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace AgenciaBancaria.Dominio
{
    public class ContaBancaria
    {
        public int NumerodaConta { get; init; }
        public int DigitoVerificador { get; init; }
        public decimal? Saldo { get; protected set; }
        public DateTime? DatadeAbertura { get; protected set; }
        public DateTime? DatadeEncerramento { get; protected set; }
        public Cliente Cliente { get; protected set; }
        public Situacao Situacao { get; protected set; }
        public string Senha { get;private set; }

        public ContaBancaria(Cliente cliente, string senha)
        {
            Cliente = cliente;

            var numerodaconta = new Random();
            NumerodaConta = numerodaconta.Next(123456, 999999);

            var digitoverificador = new Random();
            DigitoVerificador = digitoverificador.Next(0, 10);

            Situacao = Situacao.Criada;

            Saldo = 0;

            Senha = ValidaSenha(senha);

        }
        public string ValidaSenha(string senha)
        {
            if (!Regex.IsMatch(senha, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"))
                {
                throw new Exception("A senha não atende ao padrão de segurança");
                }
            return senha;
        }

        public bool ChecaSenha(string senha)
        {
            int i = 0;

            if (Senha != senha)
            {
                Console.WriteLine("Senha Inválida. Você possui mais 3 tentativas");

                do
                {
                    Console.WriteLine("Digite a senha novamente:");
                    senha = Console.ReadLine();
                    i++;

                }
                while (i <= 2 && senha != Senha);

                Situacao = Situacao.Suspensa;
                throw new Exception("A conta foi suspensa por questões de segurança. Entre em contato com o suporte do banco.");
            }

            else
            {
                Console.WriteLine($"Bem-vindo {Cliente.Nome}");
                return true;
            }
               
        }

        public void AbrirConta(decimal saldoabertura)
        {
            

            Situacao = Situacao.Aberta;

            DatadeAbertura = DateTime.Now;

            Saldo = saldoabertura;

            
        

        }

        public void EncerrarConta()
        {
            
            Situacao = Situacao.Encerrada;

            DatadeEncerramento = DateTime.Now;


        }

        public void Sacar(decimal saque,string senha)
        {
            ChecaSenha(senha);
            if(Saldo < saque)
            {
                throw new Exception("Saldo Insuficiente");
            }

            Saldo -= saque;
        }

        public void Deposito(decimal deposito, string senha)
        {
            ChecaSenha(senha);

            Saldo += deposito;
        }

        public void Transferencia(Cliente clientedestino, decimal valortransferencia, string senha)
        {
            ChecaSenha(senha);
            if (valortransferencia<Saldo)
            {
                throw new Exception("Saldo insuficiente");
            }
            
            Saldo -= valortransferencia;
            
        }

        public string RelatorioConta()
        {
            var relatorio = new StringBuilder();
            relatorio.AppendLine($"Nome: {Cliente.Nome} {Cliente.Sobrenome}");
            relatorio.AppendLine($"Agência: {NumerodaConta}-{DigitoVerificador}");
            relatorio.AppendLine($"Saldo: {Saldo}");
            relatorio.AppendLine($"Situação da Conta: {Situacao}");

            return relatorio.ToString();
        }


    }
}
