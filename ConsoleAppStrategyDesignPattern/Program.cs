using System;

namespace ConsoleAppStrategyDesignPattern
{

    public interface IFlyBehavior { void fly(); }
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
    public class FlyRocketPowered : IFlyBehavior
    {
        public void fly()
        { Console.WriteLine("I'm flying with a rocket!"); }
    }
    public interface IQuackBehavior { void quack(); }
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Silence");
        }
    }


    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;
        public Duck()
        { }
        public abstract void display();
        public void performFly()
        {
            flyBehavior.fly();
        }
        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }


    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        public override void display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }
        public override void display()
        {
            throw new NotImplementedException();
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
            Console.WriteLine("=======================");
            Duck model = new ModelDuck();
            model.performQuack();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();


        }
    }
}
