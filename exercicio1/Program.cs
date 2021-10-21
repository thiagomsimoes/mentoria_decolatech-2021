using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Adicionar Novo Aluno");
            Console.WriteLine("2 - Exibir Listagem dos Alunos");
            Console.WriteLine("3 - Calcular Média Geral");
            Console.WriteLine("X - Sair");

            string opcaousuario=Console.ReadLine();

            while(opcaousuario.ToUpper()!="X")
            {
                switch(opcaousuario)
                {
                    case "1":
                        Console.WriteLine("--1--");
                        break;

                     case "2":
                         Console.WriteLine("--2--");
                        break;

                    case "3":
                        Console.WriteLine("--3--");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException("Error");
                }    
                
                opcaousuario=Console.ReadLine();
                 
            }

        }
    }
}
