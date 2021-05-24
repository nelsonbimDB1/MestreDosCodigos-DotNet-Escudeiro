using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal A, B;

            do
            {
                Console.WriteLine("Digite o valor A:");
            } while (!decimal.TryParse(Console.ReadLine(), out A));

            Console.Clear();

            do
            {
                Console.WriteLine("Digite o valor B:");
            } while (!decimal.TryParse(Console.ReadLine(), out B));


            Console.Clear();

            decimal soma = A + B;
            decimal subtracao = A - B;
            decimal divisao = B / A;
            decimal multiplicacao = A * B;
            var numeroAEhPrimo = ehNumeroPrimo(A);
            var numeroBEhPrimo = ehNumeroPrimo(B);

            int opcaoEscolhida = 0;
            bool opcaoValida = false;

            while (!opcaoValida)
            {
                Console.Clear();
                Console.WriteLine("Digite a opçao abaixo:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtracao");
                Console.WriteLine("3 - Divisao");
                Console.WriteLine("4 - Multiplicacao");
                Console.WriteLine("5 - Verifica Numero Primo");

                int.TryParse(Console.ReadLine(), out opcaoEscolhida);

                opcaoValida = opcaoEscolhida >= 1 && opcaoEscolhida <= 5;
            }

            Console.Clear();

            switch (opcaoEscolhida)
            {
                case 1:
                    Console.WriteLine($"A Soma de A: {A} + B: {B} e igual a {soma}");
                    break;
                case 2:
                    Console.WriteLine($"A Subtracao de A: {A}  B: {B} e igual a {subtracao}");
                    break;
                case 3:
                    Console.WriteLine($"A Divisao de B: {B} / A: {A} e igual a {divisao}");
                    break;
                case 4:
                    Console.WriteLine($"A Multiplicacao de A: {A} x B: {B} e igual a {multiplicacao}");
                    break;
                case 5:
                    Console.WriteLine(numeroAEhPrimo ? $"O Numero A: {A} é primo" : $"O Numero A: {A} não é primo");
                    Console.WriteLine(numeroBEhPrimo ? $"O Numero B: {B} é primo" : $"O Numero B: {B} não é primo");
                    break;
            }
        }

        static public bool ehNumeroPrimo(decimal x)
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

    }
}
