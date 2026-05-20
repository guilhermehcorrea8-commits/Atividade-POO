using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_20_05.models
{
    public class Funcionarios
    {
        public string Nome {get; set;}
        public double Salario {get; set;}

        public virtual double CalcularBonus()
        {
            return 0;
        }
    }
}