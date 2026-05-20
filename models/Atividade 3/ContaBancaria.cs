using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_20_05.models
{
    public class ContaBancaria
    {

        public int Numero { get; set; }
        public string Titular { get; set; }

        private double saldo;

        public double Saldo
        {
            get { return saldo; }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public virtual void Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        protected void AlterarSaldo(double valor)
        {
            saldo = valor;
        }
    }
}
