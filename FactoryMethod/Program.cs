    using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // new Client().Main();
            // Console.WriteLine("App: Launched with the ConcreteCreator1.");
            new Client().ClientCode(ConcreteCreator1.Invoke());
            new Client().ClientCode(ConcreteCreator2.Invoke());
        }

        public static readonly Func<Creator> ConcreteCreator1 = () => new ConcreteCreator1();
        public static readonly Func<Creator> ConcreteCreator2 = () => new ConcreteCreator2();
    }
}