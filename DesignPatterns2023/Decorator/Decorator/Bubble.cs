using DesignPatterns2023.Decorator.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Decorator.Decorator
{
    public class Bubble : MilkTeaDecorator
    {
        public Bubble(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 1d + base.Cost();
        }
    }
}
