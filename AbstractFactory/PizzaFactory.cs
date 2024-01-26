using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PizzaFactory : MassaAbstractFactory
    {
        public PizzaFactory()
        {
            Nome = "Pizza";
        }
        public override Pizza CriaMassa(string saborDaMassa)
        {
            switch (saborDaMassa)
            {
                case "Mussarela":
                    return new PizzaMussarela();
                case "Calabresa":
                    return new PizzaCalabresa();
                default:
                    throw new ArgumentException("Tipo de fábrica de massa desconhecido.", nameof(saborDaMassa));
            }
        }
    }
}
