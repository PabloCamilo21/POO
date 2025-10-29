using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancia do Objeto
            //Aluno aluno = new Aluno();

            //aluno.nome = "Pablo";
            //aluno.rm = "3521";
            //aluno.email = "pablo.camilo@email.com";
            //aluno.idade = 17;
            //aluno.altura = 1.85;
            //aluno.peso = 75.6;
            //aluno.sexo = "Masculino";
            //aluno.responsavel = "Pai e mãe";

            //Console.WriteLine("O nome do aluno é " + aluno.nome);

            //// Os métodos não podem ter modificador static (Ex: public static void está incorreto)
            //aluno.Ler();
            //aluno.Estudar();
            //aluno.Falar();

            ////// Instância de um novo objeto
            //Aluno aluno1 = new Aluno();
            //aluno1.rm = "14573";

            //Console.WriteLine("o rm do aluno é: " + aluno1.rm); 

            //Cachorro cachorro = new Cachorro();

            //cachorro.nome = "Scooby";
            //cachorro.raca = "PitBull";
            //cachorro.idade = 2;
            //cachorro.peso = 10;

            //Console.WriteLine("A raça do cachorro é: " + cachorro.raca);

            //cachorro.Latir();
            //cachorro.Brincar();
            //cachorro.Comer();

            Funcionario funcionario = new Funcionario();

            funcionario.nome = "Pablo Camilo";
            funcionario.cargo = "Desenvolvedor Back End";
            Console.Write("Digite a remuneração: ");
            funcionario.remuneracao = Convert.ToDouble(Console.ReadLine());
           
            funcionario.Lucrar();
            Console.WriteLine($"O nome do funcionário é {funcionario.nome} e seu cargo é {funcionario.cargo}");
        }
    }
}
