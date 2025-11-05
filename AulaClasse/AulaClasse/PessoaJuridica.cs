using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj;
        public string Empresa;
        private double PagamentoDeRemuneracao;
        public int CargaHoraria;

        public void PagarFuncionario()
        {
            Console.WriteLine("O funcionário está sendo pago");
        }
        public void Contratar()
        {
            Console.WriteLine("A pessoa está contratando");
        }
        public void Demitir()
        {
            Console.WriteLine("A pessoa está demitindo");
        }

        public double pagamentoDeRemuneracao
        {
            get
            {
                return PagamentoDeRemuneracao;
            }
            set
            {
                pagamentoDeRemuneracao = value; 
            }
        }
    }
}
