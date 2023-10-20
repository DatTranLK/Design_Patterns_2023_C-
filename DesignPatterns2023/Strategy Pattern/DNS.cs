using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Strategy_Pattern
{
    public class DNS : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Sending DNS request!");
        }
    }
}
