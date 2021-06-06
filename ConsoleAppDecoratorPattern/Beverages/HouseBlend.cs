using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDecoratorPattern.Beverages
{
    public class HouseBlend:Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }
        public override double Cost()
        {
            return .89;
        }
    }
}
