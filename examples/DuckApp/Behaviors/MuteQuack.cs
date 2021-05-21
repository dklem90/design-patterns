using System;

using DuckApp.Interfaces;

namespace DuckApp.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}