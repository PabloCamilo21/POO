using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Pessoa
    {
        public string Nome;
        public string Sobrenome;
        public string Cidade;
        public string Profissao;
        public int Idade;
        public double Altura;
        private double Peso;
        public void Andar()
        {
            Console.WriteLine("A pessoa está andando");
        }
        public void Correr()
        {
            Console.WriteLine("A pessoa está correndo");
        }
        public void Comprar()
        {
            Console.WriteLine("A pessoa está comprando");
        }
    }
}
