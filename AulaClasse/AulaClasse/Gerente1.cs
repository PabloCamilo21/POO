using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Gerente1 : Empregado
    {
        private string Area;

        public string area
        {
            get
            {
                return Area;
            }
            set
            {
                Area = value;
            }
        }

    }
}
