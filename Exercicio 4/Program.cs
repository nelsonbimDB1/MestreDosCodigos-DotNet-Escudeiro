using System;
using System.Collections.Generic;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeAlunos = 0;
            bool quantidadeValida = false;

            while (!quantidadeValida)
            {
                Console.Clear();
                Console.WriteLine("Digite a quantidade de alunos:");
                int.TryParse(Console.ReadLine(), out quantidadeAlunos);
                quantidadeValida = quantidadeAlunos > 0;
            }

            Console.Clear();

            List<Aluno> alunosList = new List<Aluno>();

            for (int index = 1; index <= quantidadeAlunos; index++)
            {
                decimal nota = -1;

                while (!(nota >= 0))
                {
                    Console.Clear();
                    Console.WriteLine($"Digite a nota do aluno {index}:");
                    decimal.TryParse(Console.ReadLine(), out nota);
                }

                alunosList.Add(new Aluno { Id = index, Nota = nota });
            }

            Console.Clear();

            foreach (Aluno aluno in alunosList)
            {
                if (aluno.Nota > 7)
                {
                    Console.WriteLine($"O Aluno {aluno.Id} tirou uma nota maior que 7");
                }
            }
            
        }

        public class Aluno
        {
            public int Id { get; set; }
            public decimal Nota { get; set; }
        }
    }
}
