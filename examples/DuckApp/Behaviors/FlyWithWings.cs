using System;

using DuckApp.Interfaces;

namespace DuckApp.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}