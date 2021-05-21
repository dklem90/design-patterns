using System;

using DuckApp;
using DuckApp.Behaviors;

namespace DuckApp
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _quackBehavior = new MuteQuack();
            _flyBehavior = new FlyNoWay();
        }

        public override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}