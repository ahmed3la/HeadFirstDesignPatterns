using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDecoratorPattern.Condiments
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Soy";
        public override double Cost()
        {
            return _beverage.Cost() + .15;
        }
    }
}
