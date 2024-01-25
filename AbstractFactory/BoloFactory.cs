using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BoloFactory : MassaAbstractFactory
    {

        public BoloFactory()
        {
            Nome = "Bolo";
        }
        public override Bolo CriaMassa(string tipoDaMassa)
        {
            switch (tipoDaMassa)
            {
                case "Laranja":
                    return new BoloLaranja();
                    break;
                case "Chocolate":
                    return new BoloChocolate();
                    break;
                default:
                    throw new Exception("Erro ao fazer a massa.");
                    break;
            }
        }
    }
}
