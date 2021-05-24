using System;

namespace Exercicio_POO_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            ControleRemoto controleRemoto = new ControleRemoto();

            while (!OperacaoTelevisaoControle(controleRemoto));


        }

        static bool OperacaoTelevisaoControle(ControleRemoto controle)
        {            
            Console.Clear();
            Console.WriteLine("Controle Remoto");
            Console.WriteLine("1 - Aumentar volume");
            Console.WriteLine("2 - Diminuir volume");
            Console.WriteLine("3 - Subir canal");
            Console.WriteLine("4 - Descer canal");
            Console.WriteLine("5 - Escolher canal");
            Console.WriteLine("6 - Informacoes");
            Console.WriteLine("7 - Sair");
            Console.WriteLine("Opção:");

            var opcaoSelecionada = Console.ReadLine();

            switch (opcaoSelecionada)
            {
                case "1":
                    controle.AumentarVolume();
                    return false;
                case "2":
                    controle.DiminuirVolume();
                    return false;
                case "3":
                    controle.SubirCanal();
                    return false;
                case "4":
                    controle.DescerCanal();
                    return false;
                case "5":
                    Console.Clear();
                    int canal = 0;

                    Console.WriteLine("Digite o canal selecionado");
                    while (!int.TryParse(Console.ReadLine(), out canal));

                    var retorno = controle.EscolherCanal(canal);

                    if (!retorno || canal <= 0)
                        Console.WriteLine("Canal informado invalido");
                    return false;
                case "6":
                    Console.Clear();
                    Console.WriteLine($"Canal selecionado: {controle.GetCanal()}");
                    Console.WriteLine($"Volume selecionado: {controle.GetVolume()}");
                    Console.WriteLine("Pressione enter para voltar");
                    Console.Read();
                    return false;
                case "7":
                    return true;
            }
            return false;
        }
    }
}
