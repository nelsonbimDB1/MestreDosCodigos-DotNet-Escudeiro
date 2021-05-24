using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;

            while (numero <= 100)
            {
                if (numero % 3 == 0)
                {
                    Console.WriteLine($"O numero {numero} eh multiplo de 3!");
                }

                numero++;
            }
        }
    }
}
