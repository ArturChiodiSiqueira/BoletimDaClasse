using System;

namespace BoletimDaClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade = QuantidadeAlunos();
            string[,] boletimClasse = new string[quantidade, 4];

            ColetaDadosNomeNota(quantidade, boletimClasse);

            Console.Clear();
            
            ImprimeResultado(quantidade, boletimClasse);
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
                Console.WriteLine("\tBoletim do aluno " + boletimClasse[alunos, 0]);
                Console.WriteLine("nota 1: {0}\tnota 2: {1}\tmedia: {2}", boletimClasse[alunos, 1], boletimClasse[alunos, 2], boletimClasse[alunos, 3]);

                if (Convert.ToDecimal(boletimClasse[alunos, 3]) >= 6)
                {
                    Console.WriteLine("\tAluno Aprovado!");
                }
                else
                {
                    Console.WriteLine("\tAluno Reprovado!");
                }
                Console.ReadKey();
                Console.WriteLine();
            }
        }
    }
}