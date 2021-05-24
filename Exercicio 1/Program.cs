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

            
            
            
            
            

            int opcaoEscolhida = 0;

            do
            {
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
                    Console.WriteLine("6 - Sair");
                    int.TryParse(Console.ReadLine(), out opcaoEscolhida);

                    opcaoValida = opcaoEscolhida >= 1 && opcaoEscolhida <= 6;
                }

                Console.Clear();

                switch (opcaoEscolhida)
                {
                    case 1:
                        decimal soma = A + B;
                        Console.WriteLine($"A Soma de A: {A} + B: {B} e igual a {soma}");
                        Console.WriteLine("Pressione enter para voltar");
                        Console.ReadLine();
                        break;
                    case 2:
                        decimal subtracao = A - B;
                        Console.WriteLine($"A Subtracao de A: {A}  B: {B} e igual a {subtracao}");
                        Console.WriteLine("Pressione enter para voltar");
                        Console.ReadLine();
                        break;
                    case 3:
                        if (A == 0)
                        {
                            Console.WriteLine("Nao e possivel dividir nenhum numero por 0");
                            Console.WriteLine("Pressione enter para voltar");
                            Console.ReadLine();
                            break;
                        }
                        decimal divisao = B / A;
                        Console.WriteLine($"A Divisao de B: {B} / A: {A} e igual a {divisao}");
                        Console.WriteLine("Pressione enter para voltar");
                        Console.ReadLine();
                        break;
                    case 4:
                        decimal multiplicacao = A * B;
                        Console.WriteLine($"A Multiplicacao de A: {A} x B: {B} e igual a {multiplicacao}");
                        Console.WriteLine("Pressione enter para voltar");
                        Console.ReadLine();
                        break;
                    case 5:
                        var numeroAEhPrimo = ehNumeroPrimo(A);
                        var numeroBEhPrimo = ehNumeroPrimo(B);
                        Console.WriteLine(numeroAEhPrimo ? $"O Numero A: {A} é primo" : $"O Numero A: {A} não é primo");
                        Console.WriteLine(numeroBEhPrimo ? $"O Numero B: {B} é primo" : $"O Numero B: {B} não é primo");
                        Console.WriteLine("Pressione enter para voltar");
                        Console.ReadLine();
                        break;
                }
            } while (opcaoEscolhida != 6);
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
