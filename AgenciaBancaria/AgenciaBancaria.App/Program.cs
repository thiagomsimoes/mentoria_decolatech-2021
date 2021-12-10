using AgenciaBancaria.Dominio;
using System;


namespace AgenciaBancaria.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja Bem-vindo ao Banco DIO");

            string opcao_usuario = MenuPrincipal();

            while (opcao_usuario.ToUpper() != "X")
            {
                switch (opcao_usuario)
                {
                    case "1":
                        {
                            break;
                        }

                    case "2":
                        {
                            break;
                        }
                }
                opcao_usuario = MenuPrincipal();
            }
            Console.WriteLine("Obrigado por utilizar o Banco DIO");




        }

        private static string MenuPrincipal()
        {
            Console.WriteLine("Digite a opção desejada:" +
                             "\n 1 - Gerenciar Contas" +
                             "\n 2 - Acesso Conta" +
                             "\n X - Sair"
                             );

            string opcao_cliente = Console.ReadLine();
            return opcao_cliente;
        }
    }
}
