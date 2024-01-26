using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
    public class Pizza
    {
        public string Borda { get; set; }

        public int Tamanho { get; set; }

        public List<string> Ingredientes { get; set;}

        public Pizza()
        {
            Ingredientes =
            [
                "Azeitona",
                "Tomate"
            ];
        }
    }
}
