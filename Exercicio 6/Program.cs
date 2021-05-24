using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //a variavel que for ser passada como REF deve ser instanciada
            //Quando passado como REF, não é passado o valor como parâmetro, apenas a referencia na memória
            //Já o parâmetro out não é necessario ser instanciado
            //Ao passar como OUT um parametro, é especificado que ele receberá um valor dentro do método


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
