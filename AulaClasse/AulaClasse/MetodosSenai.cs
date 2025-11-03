using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class MetodosSenai
    {
        public string nome;
        public string sobrenome;
        public string endereco;
        public string cidade;
        public string estado;
        public string pais;

        public void CalcularValorProduto() 
        {
            Console.WriteLine("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite a marca do produto: ");
            string marcaProduto = Console.ReadLine();

            Console.WriteLine("Digite o código do produto: ");
            string codigo = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de produtos: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            if (quantidade < 10)
            {
                Console.WriteLine("Você irá pagar: " + quantidade * 20);
            }
            else if (quantidade < 20)
            {
                Console.WriteLine("Você irá pagar: " + quantidade * 25);
            }
            else
            {
                Console.WriteLine("Você irá pagar: " + quantidade * 5);
            }
        }
        public void ValidarEscolaEstudante()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int idade  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua escola: ");
            string escola = Console.ReadLine().ToUpper();

            Console.WriteLine($"Seu nome é {nome} \n Sua idade é {idade} \n Sua escola é {escola}");

            if (escola == "senai")
            {
                Console.WriteLine("Parábens, você pertence a uma ótima escola");
            }
            else
            {
                Console.WriteLine("Aluno não pertence ao Senai");
            }
        }
        public void CalcularRetângulo()
        {
            Console.WriteLine("Digite o comprimento do retangulo: ");
            int comprimento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a largura do retangulo");
            int largura = Convert.ToInt32(Console.ReadLine());

            int area = comprimento * largura;

            Console.WriteLine("A área do retângulo é: " + area);
        }
        public void CalcularQuadrado()
        {
            Console.WriteLine("Digite o tamanho do lado de um quadrado: ");
            int lado = Convert.ToInt32(Console.ReadLine());

            int area = lado * lado;

            Console.WriteLine("A área do quadrado é: " + area);
        }
        public void CalcularCirculo()
        {
            Console.WriteLine("Digite o raio do círculo: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double area = 3.14 * (raio * raio);

            Console.WriteLine("A área do círculo é: " + area);
        }
        public void CalcularMediaAluno(double nota, double nota1, double nota2, double nota3)
        {
           double media = (nota + nota1 + nota2 + nota3) / 4;

            Console.WriteLine("Digite o nome do aluno que deseja calcular a média: ");
            string aluno = Console.ReadLine();

            Console.WriteLine($"A média do {aluno} foi {media}");
        }
        public void CadastrarProfessor()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome1 = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int idade1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a matéria que leciona: ");
            string materia = Console.ReadLine();

            Console.WriteLine("Digite a escola em que trabalha: ");
            string escola1 = Console.ReadLine();

            Console.WriteLine($"Seu nome é {nome1}, você tem {idade1} anos e leciona a materia de {materia} na escola {escola1}");
        }
        public void CadastrarColaborador()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome1 = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int idade1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua escolaridade: ");
            string escolaridade = Console.ReadLine();

            Console.WriteLine("Digite seu rg");
            string rg = Console.ReadLine();

            Console.WriteLine("Digite seu CPF");
            string cpf = Console.ReadLine();

            Console.WriteLine($"Seu nome é {nome1}, você tem {idade1} anos tem escolaridade {escolaridade}" +
                $" seu CPF é {cpf} e seu rg é {rg}");
        }
        public void CalcularAumentoRemuneracao(double salario)
        {
            if (salario <= 1000)
            {
                Console.WriteLine("Seu salário novo é: " + salario * 1.25);
            }
            else if (salario <= 3000)
            {
                Console.WriteLine("Seu salário novo é: " + salario * 1.1);
            }
            else
            {
                Console.WriteLine("Seu salário novo é: " + salario * 1.05);
            }
        }

    }
}
