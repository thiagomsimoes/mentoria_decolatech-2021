using AgenciaBancaria.Dominio;
using System;


namespace AgenciaBancaria.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("rua 1", "200000", "RJ", "Rio de Janeiro");
                Documentos doc = new Documentos("130.093.377-55", "123236569");
                Cliente cliente = new Cliente("asv", "afgs",endereco,doc);

                string senha = "ab123456";
                ContaBancaria conta = new ContaBancaria(cliente,senha);

                conta.AbrirConta(1000);

                conta.Sacar(100, senha);
                

                

                  

            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
