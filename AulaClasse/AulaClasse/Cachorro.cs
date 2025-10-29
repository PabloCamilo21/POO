using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Cachorro
    {
        public double peso;
        public double altura;
        public string raca;
        public string tipoHabitat;
        public int idade;
        public string cor;
        public string nome;
        public string porte;

        public void Latir()
        {
            if (idade <= 3)
            {
                Console.WriteLine("Cachorro não pode latir");
            }
            else
            {
                Console.WriteLine("Cachorro pode latir");
            }
        }
        public void Comer()
        {
            Console.WriteLine("O cachorro está comendo");
        }

        public void Beber()
        {
            Console.WriteLine("O cachorro está bebendo");
        }

        public void Morder()
        {
            Console.WriteLine("O cachorro está mordendo");
        }

        public void Brincar()
        {
            Console.WriteLine("O cachorro está brincando");
        }

        public void Correr()
        {
            Console.WriteLine("O cachorro está correndo");
        }

        public void Dormir()
        {
            Console.WriteLine("O cachorro está dormindo");
        }

    }
}
