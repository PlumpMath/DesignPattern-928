﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Decorator.Component;

namespace DesignPattern.Decorator.ConcreteDecorator
{
    public class Fudge : Topping
    {

        public Fudge(IceCream iceCream) : base(iceCream)
        {

        }

        public override double Cost()
        {
            double price = 2.50;

            return price + IceCream.Cost();
        }
    }
}
