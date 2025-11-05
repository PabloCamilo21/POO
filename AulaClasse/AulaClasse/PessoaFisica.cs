using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf;
        public int IdCarteiraDeTrabalho;
        private double Remuneracao; 
        public string Escolaridade; 

        public void Trabalhar()
        {
            Console.WriteLine("A pessoa está trabalhando");
        }
        public void PagarConta()
        {
            Console.WriteLine("A pessoa está pagando conta");
        }
        public void ReceberSalario()
        {
            Console.WriteLine("A pessoa está recebendo salário");
        }
        
        public double remuneracao
        {
            get
            {
                return Remuneracao;
            }
            set 
            { 
                remuneracao = value;
            }
        }
        public int idCarteiraDeTrabalho
        {
            get
            {
                return IdCarteiraDeTrabalho;
            }
            set
            {
                idCarteiraDeTrabalho = value;
            }
        }
        
    }
}
