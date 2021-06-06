using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDecoratorPattern.Condiments
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;
        public override string Description => _beverage.Description + ", Whip";
        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }
 
        public override double Cost()
        {
            return _beverage.Cost() + .10;
        }
    }
}
