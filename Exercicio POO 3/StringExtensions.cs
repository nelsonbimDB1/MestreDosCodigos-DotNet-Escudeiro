using System;

namespace Exercicio_POO_3
{
    public static class StringExtensions
    {
        public static void Escrever(this string valor)
        {
            if (valor?.Length > 0)
                Console.WriteLine(valor);
        }

        public static void EscreverEEsperar(this string valor)
        {
            if (valor?.Length > 0)
            {
                Console.WriteLine(valor);
                Console.Read();
            }
        }
    }
}
