using System;

using DuckApp;

namespace DuckApp
{
    public class MiniDuckSimulator
    {
        public static void Main()
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
        }
    }
}