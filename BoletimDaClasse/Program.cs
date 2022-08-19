using System;

namespace BoletimDaClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade = QuantidadeAlunos();
            string[,] boletimClasse = new string[quantidade, 4];

            Console.Clear();

            ColetaDadosNomeNota(quantidade, boletimClasse);

            Console.WriteLine("\n\nPressione qualquer tecla para continuar.");
            Console.ReadKey();

            Console.Clear();

            ImprimeResultado(quantidade, boletimClasse);
            Console.WriteLine("Pressione qualquer tecla para finalizar a aplicacao.");
            Console.ReadKey();
        }

        static int QuantidadeAlunos()
        {
            int quantidade;

            Console.Write("Informe a quantidade de aluno: ");
            quantidade = int.Parse(Console.ReadLine());

            return quantidade;
        }

        static void ColetaDadosNomeNota(int quantidade, string[,] boletimClasse)
        {
            for (int alunos = 0; alunos < quantidade; alunos++)
            {
                Console.Write("Digite o nome do aluno #" + (alunos + 1) + ": ");
                boletimClasse[alunos, 0] = Console.ReadLine();

                Console.Write("informe a nota 1: ");
                boletimClasse[alunos, 1] = Console.ReadLine();

                while (Convert.ToDecimal(boletimClasse[alunos, 1]) < 0 || Convert.ToDecimal(boletimClasse[alunos, 1]) > 10)
                {
                    Console.WriteLine("nota invalida");
                    Console.Write("informe a nota 1: ");
                    boletimClasse[alunos, 1] = Console.ReadLine();
                }
                Console.Write("informe a nota 2: ");
                boletimClasse[alunos, 2] = Console.ReadLine();

                while (Convert.ToDecimal(boletimClasse[alunos, 2]) < 0 || Convert.ToDecimal(boletimClasse[alunos, 2]) > 10)
                {
                    Console.WriteLine("nota invalida");
                    Console.Write("informe a nota 2: ");
                    boletimClasse[alunos, 2] = Console.ReadLine();
                }

                boletimClasse[alunos, 3] = ((Convert.ToDecimal(boletimClasse[alunos, 1]) + Convert.ToDecimal(boletimClasse[alunos, 2])) / 2).ToString();
            }
        }

        static void ImprimeResultado(int quantidade, string[,] boletimClasse)
        {
            for (int alunos = 0; alunos < quantidade; alunos++)
            {
                Console.WriteLine("\t\tBoletim do aluno " + boletimClasse[alunos, 0]);
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("nota 1: {0}\t||\tnota 2: {1}\t||\tmedia: {2}", boletimClasse[alunos, 1], boletimClasse[alunos, 2], boletimClasse[alunos, 3]);
                Console.WriteLine("------------------------------------------------------------");

                if (Convert.ToDecimal(boletimClasse[alunos, 3]) >= 6)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t   Aluno Aprovado!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t   Aluno Reprovado!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.ReadKey();
                Console.WriteLine();
            }
        }
    }
}