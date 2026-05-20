using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_20_05.models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public virtual void ApresentarSalario()
        {
            Apresentar();
            Console.WriteLine($"Meu salário é: {Salario}\n");
        }
    }
}