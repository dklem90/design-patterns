using System;

using DuckApp.Interfaces;

namespace DuckApp.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly!!");
        }
    }
}