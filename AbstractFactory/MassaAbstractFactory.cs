using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class MassaAbstractFactory
    {
        public string Nome {  get; set; }

        public abstract Massa CriaMassa(string saborDaMassa);

        public static MassaAbstractFactory CriaFabricaMassa(string tipoMassaFabrica)
        {
            switch (tipoMassaFabrica)
            {
                case "Pizza":
                    return new PizzaFactory();
                    break;
                case "Bolo":
                    return new BoloFactory();
                    break;
                default:
                    throw new Exception("Erro ao criar a fábrica.");
                    break;
            }
        }
    }
}
