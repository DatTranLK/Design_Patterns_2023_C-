﻿using DesignPatterns2023.Decorator.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Decorator.Decorator
{
    public class EggPudding : MilkTeaDecorator
    {
        public EggPudding(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 3d + base.Cost();
        }
    }
}
