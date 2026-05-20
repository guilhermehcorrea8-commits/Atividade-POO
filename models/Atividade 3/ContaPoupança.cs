using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_20_05.models
{

    public class ContaPoupanca : ContaBancaria
    {
        public double RendimentoMensal { get; set; }

        public void AplicarRendimento()
        {
            double novoSaldo = Saldo + (Saldo * RendimentoMensal / 100);

            AlterarSaldo(novoSaldo);

            Console.WriteLine("Rendimento aplicado!");
        }
    }
}
