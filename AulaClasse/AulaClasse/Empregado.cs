using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Empregado
    {
        public string Nome;
        public int Idade;
        private double Salario;
        private string Departamento;

        public double salario
        {
            get
            {
                return Salario; 
            }
            set
            {
                Salario = value;
            }
        }
        public string departamento
        {
            get
            {
                return Departamento;
            }
            set
            {
                Departamento = value;
            }
        }
        public void CalcularSalario(double salarioAtual)
        {
            if (salarioAtual > 3500)
            {
                this.salario = salarioAtual * 1.08;

                Console.WriteLine($"Seu salário com aumento de 8% é: {salario} reais");

            }
            else if (salarioAtual > 2500)
            {
                Console.WriteLine($"Seu salário era {salarioAtual} e agora é: {salarioAtual * 1.10}");
            }
            else
            {
                Console.WriteLine($"Seu salário aumentou 12% e o mesmo ficou {salarioAtual * 1.12} reais");
            }
        }
        public void CalcularAlimentacao()
        {
            Console.Write("Digite o valor do seu vale alimentação: ");
            double valeAlimentacao = Convert.ToDouble(Console.ReadLine());

            if ( valeAlimentacao > 250)
            {
                Console.WriteLine($"Seu salário com desconto de 5% {Salario - (Salario * 0.05)}");
            }
            else if (valeAlimentacao > 100) 
            {
                Console.WriteLine($"Seu salário com desconto de 2% é {Salario - (Salario * 0.02)}");
            }
            else
            {
                Console.WriteLine($"Seu salário com desconto de 1% é {Salario - (Salario * 0.01)}");
            }
        }
    }
}
