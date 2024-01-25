using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BoloLaranja : Bolo
    {
        public BoloLaranja()
        {
            Ingredientes.Add("Laranja");
            Preco = 29.80;
        }
    }
}
