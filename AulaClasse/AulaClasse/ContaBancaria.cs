using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class ContaBancaria
    {
        public string titular;
        public double saldo;

        public void Depositar(double deposito)
        {
            Console.WriteLine("Digite seu saldo: ");
            double saldo = Convert.ToDouble(Console.ReadLine());
            this.saldo = saldo;
            
        }
        public void Sacar(double saldo)
        {
            this.saldo = saldo;
            if (saldo != 0)
            {
                Console.WriteLine("Digite o valor que deseja sacar");
                double saque = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine($"Sucesso, com o saque de {saque} reais, sua conta ficou com {saldo - saque}");
            }
            else
            {
                Console.WriteLine("Erro");
            }
        }
        public void ExibirInformacoes(double saldo, string titular)
        {
            this.saldo = saldo;
            this.titular = titular;
            Console.WriteLine($"O nome do titular é {titular} e seu saldo atual é {saldo}");
        }
    }
}
