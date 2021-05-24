using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b;

            ExemploREF(ref a);
            ExemploOUT(out b);

            Console.WriteLine($"O valor final de A eh: {a}");
            Console.WriteLine($"O valor final de B eh: {b}");
        }

        static void ExemploREF(ref int valor) => valor++;

        static void ExemploOUT(out int valor) => valor = 10;
    }
}
