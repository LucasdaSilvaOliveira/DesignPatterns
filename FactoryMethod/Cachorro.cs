using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Cachorro : Animal
    {
        public Cachorro()
        {
            Nome = "Luke";
        }
        public override string Apresentacao()
        {
            return $"Olá, meu nome é {Nome}!";
        }

        public override string FazerBarulho()
        {
            return "AU AU AU";
        }
    }
}
