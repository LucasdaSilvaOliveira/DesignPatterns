using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AnimalSimpleFactory
    {
        public IAnimal animal;
        public AnimalSimpleFactory(string tipoAnimal)
        {
            if(tipoAnimal == "C")
            {
                animal = new Cachorro();
            } else if(tipoAnimal == "G")
            {
                animal = new Gato();
            }
        }
    }
}
