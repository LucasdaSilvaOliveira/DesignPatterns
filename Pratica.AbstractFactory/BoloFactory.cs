using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.AbstractFactory
{
    public class BoloFactory : MassaAbstractFactory
    {
        public override Bolo RetornaSabor(string saborBolo)
        {
            if(saborBolo == "Laranja")
            {
                return new BoloLaranja();
            } else if (saborBolo == "Chocolate")
            {
                return new BoloChocolate();
            } else
            {
                throw new ArgumentException("Sabor não encontrado.");
            }
        }
    }
}
