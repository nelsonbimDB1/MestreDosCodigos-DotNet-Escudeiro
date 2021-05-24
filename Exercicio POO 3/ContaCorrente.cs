using System;

namespace Exercicio_POO_3
{
    public class ContaCorrente : ContaBancaria, IImprimivel
    {
        private const double TaxaDeOperacao = 15;
        public override bool Depositar(double valor)
        {
            if ((Saldo < TaxaDeOperacao) && (valor < TaxaDeOperacao))
                return false;

            Saldo = Saldo + valor - TaxaDeOperacao;
            return true;
        }

        public override bool Sacar(double valor)
        {
            if ((Saldo - valor) < TaxaDeOperacao)
                return false;

            Saldo = Saldo - valor - TaxaDeOperacao;
            return true;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Numero da conta: {NumeroDaConta}");
            Console.WriteLine($"Saldo em conta: R${Saldo}");
        }
    }
}
