using DesignPatterns2023.Decorator.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Decorator.Decorator
{
    public class WhiteBubble : MilkTeaDecorator
    {
        public WhiteBubble(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 1.5d + base.Cost();
        }
    }
}
