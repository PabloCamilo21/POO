using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class AlunoSesi
    {
        public string nome;
        public string rm;
        public string serie;
        public string escola;
        public int idade;

        public double SomarNotas(double nota, double nota1, double nota2, double nota3, double nota4)
        {
            double soma = nota + nota1 + nota2 + nota3 + nota4;

            return soma;
        }
        public string CalcularMedia()
        {
            double somaNotas = SomarNotas(4, 2, 9, 10, 8);

            double media = somaNotas / 5;

            if (media > 7)
            {
                return "Aprovado"; 
            }
            else if (media > 5)
            {
                return "Aluno de recuperação";
            }
            else
            {
                return "Aluno reprovado";
            }
        }
    }
}
