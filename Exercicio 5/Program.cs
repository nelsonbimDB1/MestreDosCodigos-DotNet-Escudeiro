using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;

            do
            {
                Console.WriteLine("Digite o valor A:");
            } while (!double.TryParse(Console.ReadLine(), out a));

            do
            {
                Console.WriteLine("Digite o valor B:");
            } while (!double.TryParse(Console.ReadLine(), out b));

            do
            {
                Console.WriteLine("Digite o valor C:");
            } while (!double.TryParse(Console.ReadLine(), out c));

            double delta;

            delta = Math.Pow(b, 2) - (4 * a * c);

            if (delta >= 0)
            {
                Console.WriteLine($"O valor de R1 é : {((-b) + Math.Sqrt(delta)) / 2 * a}");
                Console.WriteLine($"O valor de R2 é : {((-b) - Math.Sqrt(delta)) / 2 * a}");
            }
            else
                Console.WriteLine("Delta < 0");
        }
    }
}
