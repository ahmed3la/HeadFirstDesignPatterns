using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDecoratorPattern.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "DarkRoast";
        }

        public override double Cost()
        {
            return .99;
        }
    }
}
