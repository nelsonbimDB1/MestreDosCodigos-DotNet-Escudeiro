using System;
using System.Collections.Generic;

namespace Exercicio_POO_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContasCriadas contasCriadas = new ContasCriadas();
            while (CriacaoDasContas(contasCriadas));

            Console.Clear();
        }

        public static bool CriacaoDasContas(ContasCriadas contasCriadas)
        {
            Console.Clear();
            "Selecione a opção desejada?".Escrever();
            "A - Abrir Conta - I - Informacoes - S - SAIR".Escrever();

            switch (Console.ReadLine().ToUpper())
            {
                case "A":
                    Console.Clear();
                    "Qual tipo da conta?".Escrever();
                    "C - Corrente ou E - Especial".Escrever();

                    switch (Console.ReadLine().ToUpper())
                    {
                        case "C":
                            contasCriadas.ContasCorrentes.Add(CriaContaCorrenteEExecutaOperacoes());
                            break;
                        case "E":
                            contasCriadas.ContasEspeciais.Add(CriaContaEspecialEExecutaOperacoes());
                            break;
                        default:
                            break;
                    }
                    return true;
                case "I":
                    Console.Clear();

                    "Contas correntes criadas:".Escrever();
                    Utilidades.Separador();
                    contasCriadas.ContasCorrentes.ForEach(_ => { _.MostrarDados(); Utilidades.Separador(); });

                    "Contas especiais criadas:".Escrever();
                    Utilidades.Separador();
                    contasCriadas.ContasEspeciais.ForEach(_ => { _.MostrarDados(); Utilidades.Separador(); });
                    return true;
                case "S":
                    return false;
                default:
                    return true;

            }
        }

        public static ContaCorrente CriaContaCorrenteEExecutaOperacoes()
        {
            var contaCorrente = new ContaCorrente();

            string opcaoTransacao = "";

            do
            {
                Console.Clear();
                "Qual operacao deseja fazer?".Escrever();
                "D - Deposito , S - Saque, V - Voltar ao Menu".Escrever();

                opcaoTransacao = Console.ReadLine().ToUpper();
                switch (opcaoTransacao)
                {
                    case "D":

                        double valorDeposito = -1;

                        do
                        {
                            Console.Clear();
                            "Qual valor do deposito?".Escrever();
                            double.TryParse(Console.ReadLine().ToUpper(), out valorDeposito);
                        }
                        while (valorDeposito <= 0);

                        var retornoDeposito = contaCorrente.Depositar(valorDeposito);

                        if (!retornoDeposito)
                            "Valor invalido ou saldo insuficiente para Taxa de Operacao".EscreverEEsperar();

                        break;
                    case "S":

                        double valorSaque = -1;

                        do
                        {
                            Console.Clear();
                            "Qual valor do saque?".Escrever();
                            double.TryParse(Console.ReadLine().ToUpper(), out valorSaque);
                        }
                        while (valorSaque <= 0);

                        var retornoSaque = contaCorrente.Sacar(valorSaque);

                        if (!retornoSaque)
                            "Valor invalido ou saldo insuficiente para saque".EscreverEEsperar();
                        break;
                    case "V":
                        return contaCorrente;
                    default:
                        break;
                }
            } while (opcaoTransacao != "V");

            return contaCorrente;
        }

        public static ContaEspecial CriaContaEspecialEExecutaOperacoes()
        {
            var contaEspecial = new ContaEspecial();

            string opcaoTransacao = "";

            do
            {
                Console.Clear();
                "Qual operacao deseja fazer?".Escrever();
                "D - Deposito , S - Saque, V - Voltar ao Menu".Escrever();

               opcaoTransacao = Console.ReadLine().ToUpper();

                switch (opcaoTransacao)
                {
                    case "D":

                        double valorDeposito = -1;

                        do
                        {
                            Console.Clear();
                            "Qual valor do deposito?".Escrever();
                            double.TryParse(Console.ReadLine().ToUpper(), out valorDeposito);
                        }
                        while (valorDeposito <= 0);

                        var retornoDeposito = contaEspecial.Depositar(valorDeposito);

                        break;
                    case "S":

                        double valorSaque = -1;

                        do
                        {
                            Console.Clear();
                            "Qual valor do saque?".Escrever();
                            double.TryParse(Console.ReadLine().ToUpper(), out valorSaque);
                        }
                        while (valorSaque <= 0);

                        var retornoSaque = contaEspecial.Sacar(valorSaque);

                        if (!retornoSaque)
                            "Valor invalido ou limite insuficiente para saque!".EscreverEEsperar();
                        break;
                    case "V":
                        return contaEspecial;
                    default:
                        break;
                }
            } while (opcaoTransacao != "V");

            return contaEspecial;
        }

        public class ContasCriadas
        {
            public List<ContaCorrente> ContasCorrentes { get; set; } = new List<ContaCorrente>();
            public List<ContaEspecial> ContasEspeciais { get; set; } = new List<ContaEspecial>();
        }
    }
}
