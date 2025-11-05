using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Aluno2
    {
        public string nome;
        public int idade;
        public int peso;
        public double altura;

        //Atributos privados encapsulamento
        private string cpf;
        private string rg;
        private string numCelular;

        // Propriedade Get e Set
        // Get é igual a obter; Set é igual a definir

        // exclusivo para atributos privados
        public string Cpf
        {
            get 
            { 
                return cpf;
            } 
            set
            {
                cpf = value;
            }
        }
    }
}
