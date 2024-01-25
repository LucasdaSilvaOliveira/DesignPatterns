using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela()
        {
            Ingredientes.Add("Mussarela");
            Preco = 49.99;
        }
    }
}
