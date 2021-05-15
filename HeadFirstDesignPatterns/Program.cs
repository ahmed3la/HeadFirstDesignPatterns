using System;
using System.Linq;

namespace HeadFirstDesignPatterns
{
    interface ITest { }
    class Test1 : ITest { }
    class Test2  { }
    class Test3 : ITest { }
    class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(ITest);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p));

        }
    }
}
