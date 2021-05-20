using System;

using DuckApp.Interfaces;

namespace DuckApp.Behaviors
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak Squeak Squeak...");
        }
    }
}