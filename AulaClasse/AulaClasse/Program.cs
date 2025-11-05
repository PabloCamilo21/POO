using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

            // Atividade 01 
            //MetodosSenai metodosSenai = new MetodosSenai();
            ////metodosSenai.nome = "Pablo";
            ////metodosSenai.sobrenome = "Camilo";
            ////metodosSenai.endereco = "Rua Carlos ferrari";
            ////metodosSenai.cidade = "Garça";
            ////metodosSenai.estado = "São Paulo";
            ////metodosSenai.pais = "Brasil";

            ////Console.WriteLine("Nome: " + metodosSenai.nome);
            ////Console.WriteLine("Sobrenome: " + metodosSenai.sobrenome);
            ////Console.WriteLine("Endereço: " + metodosSenai.endereco);
            ////Console.WriteLine("Cidade: " + metodosSenai.cidade);
            ////Console.WriteLine("Estado: " + metodosSenai.estado);
            ////Console.WriteLine("País: " + metodosSenai.pais);

            //// Atividade 02
            ////metodosSenai.CalcularValorProduto();

            //// Atividade 03
            ////metodosSenai.ValidarEscolaEstudante();

            //// Atividade 04 
            ////metodosSenai.CalcularRetângulo();
            ////metodosSenai.CalcularCirculo();
            ////metodosSenai.CalcularQuadrado();

            //// Atividade 05 
            ////metodosSenai.CadastrarProfessor();
            ////metodosSenai.CalcularMediaAluno(8, 9, 7, 10);

            //// Atividade 06
            //Console.Write("Digite seu salário: ");
            //double salario = Convert.ToDouble(Console.ReadLine());
            //metodosSenai.CalcularAumentoRemuneracao(salario);

            //// Atividade 07
            //Moeda moeda = new Moeda();
            //moeda.ConverterDolarParaReal(2000);

            //// Atividade 08
            //ContaBancaria conta = new ContaBancaria();

            //Console.Write("Digite seu nome: ");
            //conta.Titular = Console.ReadLine();

            //Console.Write("Digite seu saldo atual: ");
            //conta.Saldo = Convert.ToDouble(Console.ReadLine());

            //while (conta.Saldo < 0)
            //{
            //    Console.Write("Digite seu saldo atual: ");
            //    conta.Saldo = Convert.ToDouble(Console.ReadLine());
            //}

            //Console.WriteLine("Digite o valor do seu depósito: ");
            //double valor = Convert.ToDouble(Console.ReadLine());
            //conta.Depositar(valor);

            //Console.WriteLine("Digite o valor do seu saque: ");
            //double valorSaque = Convert.ToDouble(Console.ReadLine());
            //conta.Sacar(valorSaque);

            //// Atividade 09
            //AlunoSesi aluno = new AlunoSesi();
            //aluno.SomarNotas(7, 7, 7, 7, 7);
            //string notaFinal = aluno.CalcularMedia();
            //Console.WriteLine(notaFinal);

            //Aluno2 aluno2 = new Aluno2();
            //aluno2.Cpf = "0000";

            //Console.WriteLine(aluno2.Cpf);
            //Animal animal = new Animal();
            
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Pablo";
            pessoa.Sobrenome = "Camilo";
            pessoa.Idade = 17;
            pessoa.Profissao = "Repositor";
            Console.WriteLine($"Seu nome é {pessoa.Nome + pessoa.Sobrenome} , você tem {pessoa.Idade}, exerce o cargo de {pessoa.Profissao}");
            PessoaFisica pessoaFisica = new PessoaFisica();

            pessoaFisica.Profissao = "Professor";
            Console.WriteLine(pessoaFisica.Profissao);

            PessoaJuridica pj = new PessoaJuridica();
            pj.CargaHoraria = 8;
            Console.WriteLine("A carga horária é: " + pj.CargaHoraria);

            pj.pagamentoDeRemuneracao = 2500;
            pessoaFisica.remuneracao = 2500;
            Console.WriteLine($"A pessoa física recebe {pessoaFisica.remuneracao} da pessoa júridica, que paga a ela {pj.pagamentoDeRemuneracao}");

            pessoaFisica.idCarteiraDeTrabalho = 8675;
            Console.WriteLine($"O id do {pessoa.Nome + pessoa.Sobrenome} é {pessoaFisica.idCarteiraDeTrabalho}");
        }
    }
}
