using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Veiculo
    {
        public string Tipo { get; set; }
        public string Cor { get; set; }
        public int QuantidadeRodas { get; set; }

        public abstract string MontagemDoVeiculo();
    }
}
