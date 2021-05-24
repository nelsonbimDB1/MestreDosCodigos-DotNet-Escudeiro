using System;

namespace Exercicio_POO_3
{
    public abstract class ContaBancaria
    {
        public int NumeroDaConta { get; set; }
        public double Saldo { get; set; }

        public abstract bool Sacar(double valor);
        public abstract bool Depositar(double valor);

        public ContaBancaria()
        {
            NumeroDaConta = new Random().Next(1, 9999999);
            Saldo = 0;
        }
    }
}
