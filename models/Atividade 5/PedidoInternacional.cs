using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_20_05.models
{
    public class PedidoInternacional : Pedido
    {
        public override double CalcularEntrega()
        {
            return 50;
        }
    }
}