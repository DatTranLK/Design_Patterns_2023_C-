using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Builder.Models
{
    public class Engine
    {
        public string Name { get; set; }
        public Engine(string name)
        {
            Name = name;
        }
    }
}
