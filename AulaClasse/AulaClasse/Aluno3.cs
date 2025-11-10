using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Aluno3 : Pessoa1
    {
        private string Ra;

        public string ra
        {
            get 
            { 
                return Ra; 
            }
            set 
            { 
                if (Ra == null)
                {
                    Console.WriteLine("Valor inválido");
                }
                else
                {
                    Ra = value;
                } 
            }
        }
        public void ApresentarAluno()
        {
            while (Idade > 0 && Altura > 0)
            {
                Console.WriteLine("O nome do aluno é: " + this.Nome);
                Console.WriteLine("A idade do aluno é: " + this.Idade);
                Console.WriteLine("A altura do aluno é: " + this.Altura);
                Console.WriteLine("A cor do aluno é: " + this.Cor);
                Console.WriteLine("O RA do aluno é: " + this.ra);
                
                if (Idade == 0 && Altura == 0)
                {
                    Console.WriteLine("Valor inválido");
                    break;
                }
            }
        }
    }
}
