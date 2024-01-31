using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.AbstractFactory
{
    public abstract class Pizza : Massa
    {

        public Pizza()
        {
            Tipo = "Pizza";
            Ingredientes.Add("Queijo");
            Ingredientes.Add("Azeitona");
        }
    }
}
