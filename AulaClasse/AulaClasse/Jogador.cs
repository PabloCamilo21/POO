using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Jogador
    {
        public string Nome;
        public int Idade;
        public double Peso;
        public double Altura;
        public string Time;
        public string Posicao;
        public string Pais;
        public string NumeroCamisa; 

        //Método correr
        public void Correr(int idade, string nome)
        {
            //Propriedade THIS
            this.Idade = idade;
            this.Nome = nome;

            if (idade >= 18)
            {
                Console.WriteLine("Atleta nível adulto");
            }
            else if (idade > 15 || idade < 18)
            {
                Console.WriteLine("Atleta Júnior");
            }
            else
            {
                Console.WriteLine("Atleta infantil");
            }

            Console.WriteLine("O nome do atleta é: " + nome);

        }

        public void Chutar()
        {

        }

        public void Pular()
        {

        }

        public void Driblar()
        {

        }

        public void Falar()
        {

        }
    }
}
