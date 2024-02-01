using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.Builder
{
    public class PizzaCalabresa : PizzaBuilder
    {
        public override void MontaIngredientes()
        {
            pizza.Tamanho = 30;
            pizza.Sabor = "Calabresa";
        }
    }
}
