using System;

namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeNumeros = 0;
            bool quantidadeValida = false;

            while (!quantidadeValida)
            {
                Console.Clear();
                Console.WriteLine("Digite a quantidade de funcionarios:");
                int.TryParse(Console.ReadLine(), out quantidadeNumeros);
                quantidadeValida = quantidadeNumeros > 0;
            }

            decimal[] numeros = new decimal[quantidadeNumeros];

            for (int i = 0; i < quantidadeNumeros; i++)
            {
                Console.Clear();
                do
                {
                    Console.WriteLine("Digite o valor:");
                } while (!decimal.TryParse(Console.ReadLine(), out numeros[i]));
            }

            Console.Clear();

            Array.Sort(numeros);
            Console.WriteLine("Numeros em ordem crescente:");

            ImprimeValores(numeros);

            Array.Reverse(numeros);
            Console.WriteLine("Numeros em ordem decrescente:");

            ImprimeValores(numeros);
        }

        static void ImprimeValores(decimal[] numeros)
        {
            foreach (int x in numeros)
            {
                Console.WriteLine(x);
            }
        }
    }
}
