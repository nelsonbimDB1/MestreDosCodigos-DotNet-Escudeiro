using System;

namespace Exercicio_POO_3
{
    public class ContaEspecial : ContaBancaria, IImprimivel
    {
        private const double Limite = 500;
        
        public override bool Depositar(double valor)
        {
            Saldo += valor;
            return true;
        }

        public override bool Sacar(double valor)
        {
            if ((Saldo - valor) < (Limite * -1))
                return false;

            Saldo = Saldo - valor;
            return true;
        }

        public double LimiteEspecialDisponivel()
        {
            if (Saldo >= 0)
                return Limite;

            return Limite - Saldo;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Numero da conta: {NumeroDaConta}");
            Console.WriteLine($"Saldo em conta: R${Saldo}");
            Console.WriteLine($"Limite disponivel: R${LimiteEspecialDisponivel()}");
        }
    }
}
