using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Cachorro : IAnimal
    {
        public string FazerBarulho()
        {
            return "AU AU AU";
        }
    }
}
