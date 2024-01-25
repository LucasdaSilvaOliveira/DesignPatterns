﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PizzaFactory : MassaAbstractFactory
    {
        public PizzaFactory()
        {
            Nome = "Pizza";
        }
        public override Pizza CriaMassa(string tipoDaMassa)
        {
            switch (tipoDaMassa)
            {
                case "Mussarela":
                    return new PizzaMussarela();
                    break;
                case "Calabresa":
                    return new PizzaCalabresa();
                    break;
                default:
                    throw new Exception("Erro ao fazer a massa.");
                    break;
            }
        }
    }
}