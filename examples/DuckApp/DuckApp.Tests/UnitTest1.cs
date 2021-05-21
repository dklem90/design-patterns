using System;
using Xunit;

using DuckApp;

namespace DuckAppTests
{
    public class UnitTest1
    {
        [Fact]
        public void MallardDuck_Quacks()
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
        }
    }
}
