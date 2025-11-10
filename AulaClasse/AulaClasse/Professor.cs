using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Professor : Pessoa1
    {
        private string Nif;
        private string Cpf;

        public string nif
        {
            get 
            {
                return Nif; 
            }
            set
            {
                if (Nif == null)
                {
                    Console.WriteLine("Valor inválido");
                }
                else
                {
                    Nif = value;
                }
            }
        }

        public string cpf 
        {
            get
            {
                return Cpf;
            }
            set
            {
                if (Cpf == null)
                {
                    Console.WriteLine("Valor inválido");
                }
                else
                {
                    Cpf = value;
                }
            }
        }

        public void ApresentarProfessor()
        {
            while (Idade > 0 && Altura > 0)
            {
                Console.WriteLine("O nome do professor é: " + this.Nome);
                Console.WriteLine("A idade do professor é: " + this.Idade);
                Console.WriteLine("A altura do professor é: " + this.Altura);
                Console.WriteLine("A cor do professor é: " + this.Cor);
                Console.WriteLine("O NIF do professor é: " + this.nif);
                Console.WriteLine("O CPF do professor é: " + this.cpf);

                if (Idade == 0 && Altura == 0)
                {
                    Console.WriteLine("Valor Inválido");
                    break; 
                }
            }
            
        }
    }
}
