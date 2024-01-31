using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.AbstractFactory
{
    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela()
        {
            Sabor = "Mussarela";
            Ingredientes.Add(Sabor);
        }
    }
}
