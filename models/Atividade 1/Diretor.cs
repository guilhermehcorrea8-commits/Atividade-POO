using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_20_05.models
{
    public class Diretor : Professor
    {
        public override void ApresentarSalario()
        {
            Apresentar();
            Console.WriteLine($"Meu salário é: {Salario * 2}\n");
        }
    }
}