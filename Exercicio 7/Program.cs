using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[4];

            do
            {
                Console.WriteLine("Digite o valor A:");
            } while (!double.TryParse(Console.ReadLine(), out numeros[0]));

            Console.Clear();

            do
            {
                Console.WriteLine("Digite o valor B:");
            } while (!double.TryParse(Console.ReadLine(), out numeros[1]));

            Console.Clear();

            do
            {
                Console.WriteLine("Digite o valor C:");
            } while (!double.TryParse(Console.ReadLine(), out numeros[2]));

            Console.Clear();

            do
            {
                Console.WriteLine("Digite o valor D:");
            } while (!double.TryParse(Console.ReadLine(), out numeros[3]));

            Console.Clear();

            double soma = 0;

            foreach (double numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    soma += numero;
                }
            }

            Console.WriteLine($"As somas dos numeros pares eh: {soma}");
        }
    }
}
