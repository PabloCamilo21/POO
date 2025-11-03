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
            //Instancia do Objeto
            //Aluno aluno = new Aluno();

            // aluno.nome = "Pablo";
            // aluno.rm = "3521";
            // aluno.email = "pablo.camilo@email.com";
            // aluno.idade = 17;
            // aluno.altura = 1.85;
            // aluno.peso = 75.6;
            // aluno.sexo = "Masculino";
            // aluno.responsavel = "Pai e mãe";

            // Console.WriteLine("O nome do aluno é " + aluno.nome);

            // // Os métodos não podem ter modificador static (Ex: public static void está incorreto)
            // aluno.Ler();
            // aluno.Estudar();
            // aluno.Falar();

            // //// Instância de um novo objeto
            // Aluno aluno1 = new Aluno();
            // aluno1.rm = "14573";

            // Console.WriteLine("o rm do aluno é: " + aluno1.rm);

            // Cachorro cachorro = new Cachorro();

            // cachorro.nome = "Scooby";
            // cachorro.raca = "PitBull";
            // cachorro.idade = 2;
            // cachorro.peso = 10;

            // Console.WriteLine("A raça do cachorro é: " + cachorro.raca);

            // cachorro.Latir();
            // cachorro.Brincar();
            // cachorro.Comer();

            // Funcionario funcionario = new Funcionario();

            // funcionario.nome = "Pablo Camilo";
            // funcionario.cargo = "Desenvolvedor Back End";
            // Console.Write("Digite a remuneração: ");
            // funcionario.remuneracao = Convert.ToDouble(Console.ReadLine());

            // funcionario.Lucrar();
            // Console.WriteLine($"O nome do funcionário é {funcionario.nome} e seu cargo é {funcionario.cargo}");

            //Jogador jogador = new Jogador();
            //jogador.Correr(17, "Pablo");

            //Metodos metodos = new Metodos();
            //int result = metodos.Multiplicar(20, 30); //Aqui retorna o resultado da multiplicação na variável resultado
            //Console.WriteLine(result);


            //metodos.Multiplicar(20, 30);
            //string validacao = metodos.Dividir();  // quando for método com return precisa de uma variável para armazenar um valor
            //Console.WriteLine(validacao);

            //Metodos metodos = new Metodos();
            //Console.WriteLine("Digite seu salário: ");
            //double salario = Convert.ToDouble(Console.ReadLine());

            //double novoSalario = metodos.ValidarSalario(salario); // Váriavel que armazena retorno do novo salário
            //Console.WriteLine($"Seu salário era {salario} e agora é {novoSalario}"); 

            //Metodos metodos = new Metodos();
            //int soma = metodos.Somar1(20, 90);

            //Console.WriteLine("Sua soma foi: " + soma);

            //metodos.Subtrair(20);

            MetodosSenai metodosSenai = new MetodosSenai();
            metodosSenai.nome = "Pablo";
            metodosSenai.sobrenome = "Camilo";
            metodosSenai.endereco = "Rua Carlos ferrari";
            metodosSenai.cidade = "Garça";
            metodosSenai.estado = "São Paulo";
            metodosSenai.pais = "Brasil";

            Console.WriteLine("Nome: " + metodosSenai.nome);
            Console.WriteLine("Sobrenome: " + metodosSenai.sobrenome);
            Console.WriteLine("Endereço: " + metodosSenai.endereco);
            Console.WriteLine("Cidade: " + metodosSenai.cidade);
            Console.WriteLine("Estado: " + metodosSenai.estado);
            Console.WriteLine("País: " + metodosSenai.pais);

            //metodosSenai.CalcularValorProduto();

            //metodosSenai.ValidarEscolaEstudante();

            //metodosSenai.CalcularMediaAluno(5, 10, 5, 8);

            //metodosSenai.CalcularAumentoRemuneracao(2000);

            Moeda moeda = new Moeda();
            moeda.ConverterRealParaDolar(2000);

            ContaBancaria conta = new ContaBancaria();

            Console.WriteLine("Digite seu nome: ");
            conta.titular = Console.ReadLine();

            Console.WriteLine("Informe seu saldo Atual: ");
            conta.saldo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Seu nome é {conta.titular} e seu saldo é {conta.saldo}");

            Console.WriteLine("Digite a quantidade que deseja depositar: "); 
            


        }
    }
}
