using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.FactoryMethod
{
    public class VeiculoSimpleFactory
    {
        public static Veiculo RetornaVeiculo(string tipoVeiculo)
        {
            switch (tipoVeiculo)
            {
                case "M":
                    return new Moto();
                case "C":
                    return new Carro();
                default:
                    throw new ApplicationException("Veículo não encontrado.");
            }
        }
    }
}
