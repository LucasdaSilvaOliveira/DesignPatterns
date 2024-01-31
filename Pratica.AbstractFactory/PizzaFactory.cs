using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.AbstractFactory
{
    public class PizzaFactory : MassaAbstractFactory
    {
        public override Pizza RetornaSabor(string saborPizza)
        {
            if (saborPizza == "Mussarela")
            {
                return new PizzaMussarela();
            }
            else if (saborPizza == "Calabresa")
            {
                return new PizzaCalabresa();
            }
            else
            {
                throw new ArgumentException("Sabor não encontrado.");
            }
        }
    }
}
