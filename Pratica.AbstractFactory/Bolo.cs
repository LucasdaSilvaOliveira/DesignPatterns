using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.AbstractFactory
{
    public abstract class Bolo : Massa
    {
        public Bolo()
        {
            Tipo = "Bolo";
            Ingredientes.Add("Ovo");
            Ingredientes.Add("Leite");
        }
    }
}
