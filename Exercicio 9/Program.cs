using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<int> { 16, 18, 14, 5, 7, 15, 20, 4, 12, 11, 8, 10, 17, 13, 9 };

            Console.WriteLine("Ordenacao padrao:");
            lista.ForEach(Console.WriteLine);

            Console.WriteLine("Ordem Crescente");
            lista.OrderBy(numero => numero).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("Ordem Decrescente");
            lista.OrderByDescending(numero => numero).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("Primeiro Numero");
            Console.WriteLine(lista.FirstOrDefault());

            Console.WriteLine("Ultimo Numero");
            Console.WriteLine(lista.LastOrDefault());

            Console.WriteLine("Inserir numero no inicio da lista");
            lista.Insert(0, 999);
            lista.ForEach(Console.WriteLine);

            Console.WriteLine("Inserir numero no fim da lista");
            lista.Add(998);
            lista.ForEach(Console.WriteLine);

            Console.WriteLine("Remover numero no Inicio da lista");
            lista.RemoveAt(0);
            lista.ForEach(Console.WriteLine);

            Console.WriteLine("Remover numero no Fim da lista");
            lista.RemoveAt(lista.Count - 1);
            lista.ForEach(Console.WriteLine);

            Console.WriteLine("Numeros Pares");
            lista.Where(p => p % 2 == 0).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("Numeros Impares");
            lista.Where(p => p % 2 != 0).ToList().ForEach(Console.WriteLine);

            var intArray = lista.ToArray();
        }
    }
}
