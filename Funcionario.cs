using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    internal abstract class Funcionario
    {
        public abstract  string Name { get; }
       // public string Nome { get; set; }
       // public double Salario { get; set; }
       ////
       // public double Calcular(int tempo)
       // {
       //     return Salario / 12 * tempo;

       // }
       // public double Calcular()
       // {
       //     return Salario * 0.11;
       // }
    }
}
