using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Singleton
{
    public class Singleton
    {
        static Singleton instance;
        public string Setting { get; private set; } = "Color blue";

        protected Singleton()
        {
            
        }
        public static Singleton Instance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
