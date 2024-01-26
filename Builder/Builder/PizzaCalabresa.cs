using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public class PizzaCalabresa : PizzaBuilder
    {
        public override void MontarMassa()
        {
            pizza.Tamanho = 30;
            pizza.Borda = "Normal";
            pizza.Ingredientes.Add("Calabresa");
        }
    }
}
