using System;

using DuckApp.Interfaces;

namespace DuckApp.Behaviors
{
    public class FlyWithRocketPower : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}