using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Gato : Animal
    {
        public Gato()
        {
            Nome = "Ajato";
        }
        public override string Apresentacao()
        {
            return $"Olá, meu nome é {Nome}!";
        }

        public override string FazerBarulho()
        {
            return "MIAUUU";
        }
    }
}
