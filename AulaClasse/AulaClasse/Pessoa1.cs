using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Pessoa1 
    {
        public string Nome;
        public int Idade;
        public string Cor;
        public double Altura;

        private string Rg;
        private string Cpf;
        private string Cidade;
        private string Estado;

        public string estado
        {
             
            get
            {
                return Estado;
            }
            set
            {
                Estado = value;
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
        public string cidade
        {
            get
            {
                return Cidade;
            }
            set
            {
                Cidade = value;
            }
        }
        public string rg
        {
            get
            {
                return Rg;
            }
            set
            {
                if (Rg == null)
                {
                    Console.WriteLine("Valor inválido");
                }
                else
                {
                    Rg = value;
                }
            }
        }

        public void ApresentarPessoa()
        {
            while (Idade > 0 && Altura > 0)
            {
                Console.WriteLine("Sua idade é: " + this.Idade);
                Console.WriteLine("Sua altura é: " + this.Altura);
                Console.WriteLine("Seu nome é: " + this.Nome);
                Console.WriteLine("Sua Cor é: " + this.Cor);
                Console.WriteLine("Sua cidade é: " + this.Cidade);
                Console.WriteLine("Seu Estado é: " + this.Estado);
                Console.WriteLine("Seu Cpf é: " + this.Cpf);
                Console.WriteLine("Seu Rg é: " + this.Rg);

                if (Idade == 0 && Altura == 0)
                {
                    Console.WriteLine("Valor inválido");
                    break;
                }
            }
        }
    }
}
