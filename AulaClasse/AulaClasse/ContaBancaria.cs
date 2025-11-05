using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class ContaBancaria
    {
        public string Titular; 
        public double Saldo;
        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Erro, você digitou um valor negativado");
            }
            else
            {
                this.Saldo += valor;
                Console.WriteLine("Depósito realizado com sucesso");
            }
        }
        public void Sacar(double valor)
        {
            if (valor <= 0 && valor > this.Saldo)
            {
                Console.WriteLine("Você está tentando sacar um valor inválido");
            }
            else
            {
                this.Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"O nome do titular é {this.Titular} e seu saldo atual é {this.Saldo}");
        }
    }
}
