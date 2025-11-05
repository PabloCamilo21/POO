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
            if (saldo < 0 || deposito < 0)
            {
                Console.WriteLine("Erro, você digitou um valor negativado");
            }
            else
            {
                Console.WriteLine("Sucesso");
                double saldoAtual = saldo - deposito;
                Console.WriteLine("Com o depósito seu saldo ficou com: " + saldoAtual);
            }
        }
        public void Sacar(double saque)
        {
            if (saldo < 0 || saque < 0)
            {
                Console.WriteLine("Erro, você digitou um valor negativado");
            }
            else
            {
                Console.WriteLine("Sucesso");
                double saldoAtual = saldo - saque;
                Console.WriteLine("Com o saque seu saldo ficou com: " + saldoAtual);
            }
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"O nome do titular é {titular} e seu saldo atual é {saldo}");
        }
    }
}
