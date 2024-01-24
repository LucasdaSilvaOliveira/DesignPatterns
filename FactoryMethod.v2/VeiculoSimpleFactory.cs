using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class VeiculoSimpleFactory
    {
        public static Veiculo CriarVeiculo(string tipoVeiculo)
        {
            if(tipoVeiculo.Equals("C"))
            {
                return new Carro();
            } else if(tipoVeiculo.Equals("M"))
            {
                return new Moto();
            } else
            {
                throw new ApplicationException("Veículo não existente!");
            }
        }
    }
}
