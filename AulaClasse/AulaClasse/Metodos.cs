using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Metodos
    {
        public int Valor1;
        public int Valor2;
        public int Valor3;

        public void Somar(int valor1, int valor2, int valor3)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2; 
            this.Valor3 = valor3;

            int soma = Valor1 + Valor2 + Valor3;

            Console.WriteLine($"A soma de {Valor1} + {Valor2} + {Valor3} é: {soma}");
        }

        // void é usado para metodo sem retorno
        public int Multiplicar(int valor1, int valor2)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;

            return Valor1 * Valor2; // Retorna a multiplicação para a variável no main
        }
        public string Dividir()
        {
            int resultado = Multiplicar(Valor1, Valor2); //Chamada do método multiplicar()

            if (resultado % 2 == 0)
            {
                return "Valor par";
            }
            else
            {
                return "Valor ímpar";
            }
        }
        public double ValidarSalario(double salario)
        {
            if (salario >= 2000)
            {
                double aumento = salario * 1.2754;
                return aumento; 
            }
            else
            {
                double aumento1 = salario * 1.1523;
                return aumento1;
            }
        }
        public int Somar1(int valor1, int valor2)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;

            return Valor1 + Valor2;
        }
        public void Subtrair(int valor1)
        {
            int result = Somar1(Valor1, Valor2);
            
            if (valor1 > result)
            {
                Console.WriteLine("Valor da subtração maior");
            }
            else
            {
                Console.WriteLine("Valor da soma é maior");
            }
           
        }
    }
}
