using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.Builder
{
    public class Pizzaria
    {
        private PizzaBuilder builder;
        public Pizzaria(PizzaBuilder builder)
        {
            this.builder = builder;
        }

        public void MontaPizza()
        {
            builder.CriaPizza();
            builder.MontaIngredientes();
        }

        public Pizza GetPizza()
        {
            return builder.GetPizza();
        }
    }
}
