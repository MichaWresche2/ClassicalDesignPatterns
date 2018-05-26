using System;

namespace ClassicalDesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Singleton
            var simpleSingleton = SimpleSingleton.Instance;

            // Factory Method
            var computer = new ConcreteComputerFactory().GetComputer();

            Console.WriteLine("Hello World!");
        }
    }
}
