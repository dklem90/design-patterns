using System;

using DuckApp.Interfaces;

namespace DuckApp.Behaviors
{
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}