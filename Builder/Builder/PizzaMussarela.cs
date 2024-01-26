using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public class PizzaMussarela : PizzaBuilder
    {
        public override void MontarMassa()
        {
            pizza.Tamanho = 45;
            pizza.Borda = "Recheada";
            pizza.Ingredientes.Add("Mussarela");
        }
    }
}
