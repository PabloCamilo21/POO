using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Animal
    {
        public string Sexo;
        public string Raca;
        public string Cor;
        public int Idade;
        public string Habitat;
        public double Tamanho;
        public string Porte;
        public string Especie;

        public void Comer()
        {
            Console.WriteLine("O animal está comendo");
        }
        public void Correr()
        {
            Console.WriteLine("O animal está correndo");
        }
        public void Dormir()
        {
            Console.WriteLine("O animal está dormindo");
        }

    }
}
