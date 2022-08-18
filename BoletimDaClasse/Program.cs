using System;

namespace BoletimDaClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] notas = new double[5, 3];

            Console.WriteLine("Informe as notas dos alunos: ");

            for (int aluno = 0; aluno < 5; aluno++)
            {
                Console.WriteLine("Aluno[{0}]:", (aluno +1));
                Console.WriteLine("informe a nota 1: ");
                notas[aluno, 0] = double.Parse(Console.ReadLine());
                Console.WriteLine("informe a nota 2: ");
                notas[aluno, 1] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("As notas dos alunos da turma são:");
            for (int aluno = 0; aluno < 5; aluno++)
            {
                Console.WriteLine("nota 1: {0}\tnota 2: {1}\tmedia: {2}", notas[aluno,0], notas[aluno, 1], notas[aluno, 2]);
            }



            //double media;
            //for (int coluna = 0; coluna < 2; coluna++)
            //{
            //    for (int linha = 0; linha < 5; linha++)
            //    {
            //        Console.Write("PARA O ALUNO #" + (linha + 1) + " INFORME A NOTA #" + (coluna + 1) + ": ");
            //        notas[linha, coluna] = double.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("    nota 1\t    nota 2\t    boletim");
            //for (int linha = 0; linha < 5; linha++)
            //{

            //    for (int coluna = 0; coluna < 3; coluna++)
            //    {
            //        media = (notas[linha, coluna] + notas[linha, coluna]) / 2;

            //        Console.Write("matriz[{0},{1}]={2}\t", linha, coluna, notas[linha, coluna]);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
