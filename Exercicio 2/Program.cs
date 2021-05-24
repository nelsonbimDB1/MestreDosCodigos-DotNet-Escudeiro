using System;
using System.Collections.Generic;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeFuncionarios = 0;
            bool quantidadeValida = false;
            while (!quantidadeValida)
            {
                Console.Clear();
                Console.WriteLine("Digite a quantidade de funcionarios:");
                int.TryParse(Console.ReadLine(), out quantidadeFuncionarios);
                quantidadeValida = quantidadeFuncionarios > 0;
            }

            Console.Clear();

            List<Funcionario> funcionarios = new List<Funcionario>();
            for (int i = 1; i <= quantidadeFuncionarios; i ++)
            {
                string nome = null;
                while (!(nome?.Length > 0))
                {
                    Console.Clear();
                    Console.WriteLine($"Digite o nome do funcionario {i}:");
                    nome = Console.ReadLine();
                }

                Console.Clear();

                decimal salario = 0;

                while (!(salario > 0))
                {
                    Console.Clear();
                    Console.WriteLine($"Digite o salario do funcionario {i}:");
                    decimal.TryParse(Console.ReadLine(), out salario);
                }

                funcionarios.Add(new Funcionario { Nome = nome, Salario = salario });

                Console.Clear();
            }

            var funcionarioMaiorSalario = maiorSalario(funcionarios);
            var funcionarioMenorSalario = menorSalario(funcionarios);


            Console.WriteLine($"Funcionario com maior salario eh o(a): {funcionarioMaiorSalario.Nome}, com o salario de: R${funcionarioMaiorSalario.Salario}");
            Console.WriteLine($"Funcionario com menor salario eh o(a): {funcionarioMenorSalario.Nome}, com o salario de: R${funcionarioMenorSalario.Salario}");
        }


        public static Funcionario maiorSalario(List<Funcionario> funcionarios)
        {
            var x = 0;
            Funcionario funcionarioMaiorSalario = null;

            while (x < funcionarios.Count)
            {
                if (funcionarioMaiorSalario == null || funcionarios[x].Salario > funcionarioMaiorSalario?.Salario)
                    funcionarioMaiorSalario = funcionarios[x];
                x++;
            }
            return funcionarioMaiorSalario;
        }

        public static Funcionario menorSalario(List<Funcionario> funcionarios)
        {
            var x = 0;
            Funcionario funcionarioMenorSalario = null;

            while (x < funcionarios.Count)
            {
                if (funcionarioMenorSalario == null || funcionarios[x].Salario < funcionarioMenorSalario?.Salario)
                    funcionarioMenorSalario = funcionarios[x];
                x++;
            }
            return funcionarioMenorSalario;
        }

        public class Funcionario
        {
            public string Nome { get; set; }
            public decimal Salario { get; set; }
        }
    }
}
