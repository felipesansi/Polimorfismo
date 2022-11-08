using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    internal class Vendedor : Funcionario
    {
        // abristrçao
        public override string Name
        {
            get;
        }
        //public string Regiao { get; set; }
        //public double Calcular(int comissao)
        //{
        //    return Salario * comissao / 100;
        //}
    }
}
