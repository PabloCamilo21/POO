using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Gerente : Colaborador
    {
        public override void CalcularValeAlimentacao(double salario) 
        {
            double vale = salario * 1.10;

            Console.WriteLine("O valor do seu vale é de: " + vale);
        } 
        public override void CalcularImposto(double salario)
        {
            double salarioLiquido = salario - (salario * 0.25);

            Console.WriteLine("O valor do imposto é: " +  salarioLiquido); 
        }
    }
}
