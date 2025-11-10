using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Estagiario : Colaborador
    {
        public override void CalcularValeAlimentacao(double salario) 
        {
            Console.WriteLine("O valor do vale é de: " + salario * 1.30);
        }
        public override void CalcularImposto(double salario)
        {
            Console.WriteLine("O valor do salário líquido é de: " + salario);
        }
    }
}
