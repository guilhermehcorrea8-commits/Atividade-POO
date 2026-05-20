using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_20_05.models
{
    public class ContaCorrente : ContaBancaria
    {
        public double TaxaSaque { get; set; }

        public override void Sacar(double valor)
        {
            double total = valor + TaxaSaque;

            if (Saldo >= total)
            {
                AlterarSaldo(Saldo - total);
                Console.WriteLine("Saque realizado com taxa!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
    }
}