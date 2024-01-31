using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.AbstractFactory
{
    public class BoloLaranja : Bolo
    {
        public BoloLaranja()
        {
            Sabor = "Laranja";

            Ingredientes.Add(Sabor);
        }
    }
}
