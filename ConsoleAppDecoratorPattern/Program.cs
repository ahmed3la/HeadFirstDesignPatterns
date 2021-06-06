using System;

namespace ConsoleAppDecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Beverages.Espresso();
            Console.WriteLine(beverage.Description
                                    + " $" + beverage.Cost());

            Beverage beverage2 = new Beverages.DarkRoast();
            beverage2 = new Condiments.Mocha(beverage2);
            beverage2 = new Condiments.Mocha(beverage2);
            beverage2 = new Condiments.Whip(beverage2);
            Console.WriteLine(beverage2.Description
                                    + " $" + beverage2.Cost());

            Beverage beverage3 = new Beverages.HouseBlend();
            beverage3 = new Condiments.Soy(beverage3);
            beverage3 = new Condiments.Mocha(beverage3);
            beverage3 = new Condiments.Whip(beverage3);
            Console.WriteLine(beverage3.Description
                                + " $" + beverage3.Cost());
              
        }
    }
}
