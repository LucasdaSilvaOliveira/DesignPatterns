using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.AbstractFactory
{
    public abstract class MassaAbstractFactory
    {
       
        public static MassaAbstractFactory RetornaFactory(string tipoDaMassa)
        {
            switch (tipoDaMassa)
            {
                case "Pizza":
                    return new PizzaFactory();
                case "Bolo":
                    return new BoloFactory();
                default:
                    throw new ApplicationException("Massa não encontrada.");
            }
        }

        public abstract Massa RetornaSabor(string sabor);
    }
}
