using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.FactoryMethod
{
    public class Moto : Veiculo
    {
        public Moto()
        {
            Tipo = "Moto";
            QuantidadeRodas = 2;
        }

        public override string Apresentacao()
        {
            var sb = new StringBuilder();
            sb.Append($"O tipo do veículo é {Tipo}\n");
            sb.Append($"Ele possui {QuantidadeRodas} rodas.");
            return sb.ToString();
        }
    }
}
