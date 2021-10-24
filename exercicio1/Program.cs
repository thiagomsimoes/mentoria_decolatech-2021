using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Aluno[] alunos = new Aluno[5]; //Cria o array do tipo aluno com até 5 elementos
            var indicealuno=0;

            string opcaousuario = Obter_opcaousuario();

            while (opcaousuario.ToUpper()!="X")
            {
              switch(opcaousuario)
              {
                case "1":
                    Console.WriteLine("Insira o Nome do Aluno:");
                    Aluno aluno = new Aluno();
                    aluno.Nome = Console.ReadLine();
                    Console.WriteLine("Insira a Nota do Aluno:");

                    if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                    {
                        aluno.Nota = nota;
                    }

                    else
                    {
                        throw new ArgumentException("Valor da nota deve ser decimal");
                    }

                    alunos[indicealuno]=aluno;
                    indicealuno++;
                    
                    break;
                
                case "2":
                    foreach (var a in alunos)
                        if (a.Nome != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Nome do Aluno: {a.Nome} - Nota: {a.Nota}");     
                        
                        }       
                    break;
                
                case "3":
                    decimal notas = new decimal();
                    int n_alunos = 0;

                    foreach (var b in alunos)
                        if (b.Nome != null)
                        {
                            notas =+ b.Nota;
                            n_alunos++;
                        } 

                    decimal media=notas/n_alunos;       
                    
                        ConceitoEnum ConceitoGeral;

                        if (media<2)
                            ConceitoGeral = ConceitoEnum.E;
                        
                        else if (media <4)
                            ConceitoGeral = ConceitoEnum.D;

                        else if (media <6)
                            ConceitoGeral = ConceitoEnum.C;
                        
                        else if (media <8)
                            ConceitoGeral = ConceitoEnum.B;

                        else
                            ConceitoGeral = ConceitoEnum.A;

                    Console.WriteLine();
                    Console.WriteLine($"Média Geral: {media} - Conceito: {ConceitoGeral}");  

                    break;




              }

              opcaousuario = Obter_opcaousuario();
                 


            }

        }

        private static string Obter_opcaousuario()
        {
            string opcaousuario;
            Console.WriteLine();
            Console.WriteLine("Insira a opção desejada:");
            Console.WriteLine("1 - Adicionar Novo Aluno");
            Console.WriteLine("2 - Consultar Listagem de Alunos");
            Console.WriteLine("3 - Consultar Média Geral");
            Console.WriteLine("X - Sair");

            opcaousuario = Console.ReadLine();
            return opcaousuario;
        }
    }
}