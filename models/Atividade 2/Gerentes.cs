using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_20_05.models
{
    public class Gerentes : Funcionarios
    {
        public override double CalcularBonus()
        {
            return Salario * 0.20;
        }
    }
}