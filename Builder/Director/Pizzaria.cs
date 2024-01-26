using Builder.Builder;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Director
{
    public class Pizzaria
    {
        protected PizzaBuilder builder;

        public Pizzaria(PizzaBuilder builder)
        {
            this.builder = builder;
        }

        public void MontarPizza()
        {
            builder.CriaPizza();
            builder.MontarMassa();
        }

        public Pizza GetPizza()
        {
            return builder.GetPizza();
        }
    }
}
