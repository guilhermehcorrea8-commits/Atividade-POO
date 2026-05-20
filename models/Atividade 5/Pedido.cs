using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_20_05.models
{
    public class Pedido
    {
        public double ValorTotal { get; set; }

        public virtual double CalcularEntrega()
        {
            return 0;
        }
    }
}