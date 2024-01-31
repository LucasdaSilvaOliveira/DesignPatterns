using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.AbstractFactory
{
    public abstract class Massa
    {
        public List<string> Ingredientes { get; set; }
        public string Sabor { get; set; }
        public string Tipo { get; set; }

        public Massa()
        {
            Ingredientes = new List<string>();
        }
    }
}
