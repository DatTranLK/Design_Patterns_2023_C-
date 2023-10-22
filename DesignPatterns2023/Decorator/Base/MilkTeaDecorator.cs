using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Decorator.Base
{
    public abstract class MilkTeaDecorator : IMilkTea
    {
        private IMilkTea _milkTea;
        protected MilkTeaDecorator(IMilkTea inner)
        {
            _milkTea = inner;
        }
        public virtual double Cost()
        {
            return _milkTea.Cost();
        }
    }
}
