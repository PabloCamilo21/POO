using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Aluno //Sempre trocar o interno para public
    {
        public string nome;
        public string rm;
        public int idade;
        public string email;
        public string cpf;
        public string serie;
        public string responsavel;
        public double peso;
        public double altura;
        public string telefone;
        public string cor;
        public string sexo;

        public void Estudar()
        {
            Console.WriteLine("O aluno está estudando");
        }
        public  void Escrever()
        {
            Console.WriteLine("O aluno está escrevendo");
        }

        public void Ler()
        {
            Console.WriteLine("O aluno está lendo");
        }

        public void Falar()
        {
            Console.WriteLine("O aluno está falando");
        }
        public void Andar() 
        {
            Console.WriteLine("O aluno está andando");
        }

        public void Aprender() 
        {
            Console.WriteLine("O aluno está aprendendo");
        }
    }
}
