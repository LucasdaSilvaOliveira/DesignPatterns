using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Massa
    {
        public List<string> Ingredientes { get; set; }

        public double Preco {  get; set; }

        public Massa()
        {
            Ingredientes = [];
        }
    }
}
