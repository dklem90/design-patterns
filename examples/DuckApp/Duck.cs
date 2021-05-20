using System;

using DuckApp.Interfaces;

namespace DuckApp
{
    public abstract class Duck
    {
        IQuackBehavior _quackBehavior;
        IFlyBehavior _flyBehavior;

        public void performQuack()
        {
            _quackBehavior.quack();
        }

        public void performFly()
        {
            _flyBehavior.fly();
        }
    }
}
