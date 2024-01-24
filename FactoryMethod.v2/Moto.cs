using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Moto : Veiculo
    {

        public Moto()
        {
            Tipo = "Moto";
            Cor = "Verde";
            QuantidadeRodas = 2;
        }
        public override string MontagemDoVeiculo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Tipo do veículo escolhido: {Tipo}.\n");
            sb.Append($"Pintando o veículo com a cor de {Cor}.\n");
            sb.Append($"Montando as {QuantidadeRodas} rodas.\n");
            sb.Append("Veículo pronto!");
            return sb.ToString();
        }
    }
}
