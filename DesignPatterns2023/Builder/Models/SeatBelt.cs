using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Builder.Models
{
    public class SeatBelt
    {
        public string Brand { get; set; }
        public SeatBelt(string brand)
        {
            Brand = brand;
        }
    }
}
