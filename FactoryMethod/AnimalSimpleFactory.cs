﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AnimalSimpleFactory
    {
        public Animal animal;

        public Animal RetornarAnimal(string tipoAnimal)
        {
            if (tipoAnimal == "C")
            {
                return new Cachorro();
            }
            else if (tipoAnimal == "G")
            {
               return new Gato();
            } else
            {
                throw new Exception("Animal não encontrado!");
            }
        }
    }
}
