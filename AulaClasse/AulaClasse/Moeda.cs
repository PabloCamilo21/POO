using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Moeda
    {
        public string tipo;
        public string unidadeDeValor;
        public string pais;

        public void ConverterRealParaDolar(double real)
        {
            double conversao = real / 5.36;
            Console.WriteLine("Sua conversão de real para dolar deu: " + conversao);
        }
        public void ConverterDolarParaReal(double dolar)
        {
            double conversao = dolar * 5.36;
            Console.WriteLine("Sua conversão de dólar para real deu: " + conversao);
        }
        public void ConverterRealParaEuro(double real1)
        {
            double conversao = real1 / 6.18;
            Console.WriteLine("Sua conversão de Real para Euro foi: " + conversao);
        }
    }
}
