using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_20_05.models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public void MostrarNota()
        {
            Apresentar();
            Console.WriteLine($"Minha Nota é: {Nota}\n");
        }
    }
}