using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmiInterface
{
    class Validacao
    {
        public void campo(string campo)
        {
            if(campo.Equals("") || campo == null)
            {
                throw new FormatException();
            }
        }
    }
}
