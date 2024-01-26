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
        public override Bolo CriaMassa(string saborDaMassa)
        {
            switch (saborDaMassa)
            {
                case "Laranja":
                    return new BoloLaranja();
                case "Chocolate":
                    return new BoloChocolate();
                default:
                    throw new InvalidOperationException("Erro ao fazer a massa.");
            }
        }
    }
}
