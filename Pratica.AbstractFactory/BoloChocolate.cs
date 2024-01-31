using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.AbstractFactory
{
    public class BoloChocolate : Bolo
    {
        public BoloChocolate()
        {
            Sabor = "Chocolate";
            Ingredientes.Add(Sabor);
        }
    }
}
