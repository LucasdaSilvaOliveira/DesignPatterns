using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.Builder
{
    public class PizzaMussarela : PizzaBuilder
    {
        public override void MontaIngredientes()
        {
            pizza.Tamanho = 45;
            pizza.Sabor = "Mussarela";
        }
    }
}
