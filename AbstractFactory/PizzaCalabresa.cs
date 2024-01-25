using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa()
        {
            Ingredientes.Add("Calabresa");
            Preco = 39.99;
        }
    }
}
