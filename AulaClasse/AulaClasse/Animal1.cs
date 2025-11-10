using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Animal1
    {
        public string especie;
        public string nome;

        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal está emitindo som");
        }
    }
}
