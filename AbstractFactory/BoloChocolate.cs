using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BoloChocolate : Bolo
    {
        public BoloChocolate()
        {
            Ingredientes.Add("Chocolate");
            Preco = 24.95;
        }
    }
}
