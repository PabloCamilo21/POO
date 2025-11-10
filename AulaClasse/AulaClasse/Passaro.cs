using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Passaro : Animal1 //Polimorfismo com a classe animal1 permite modificar o método de acordo com as caracteristicas proprias do animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O pássaro está cantando");
        }
    }
}
