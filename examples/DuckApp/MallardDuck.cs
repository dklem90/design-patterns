using System;

using DuckApp.Behaviors;

namespace DuckApp
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _quackBehavior = new Quack();
            _flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I'm a real Mallard Duck");
        }
    }
}