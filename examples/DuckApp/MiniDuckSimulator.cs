using DuckApp.Behaviors;

namespace DuckApp
{
    public class MiniDuckSimulator
    {
        public static void Main()
        {
            Duck modelDuck = new ModelDuck();
            modelDuck.setFlyBehavior(new FlyWithRocketPower());
            modelDuck.display();
            modelDuck.performQuack();
            modelDuck.performFly();
        }
    }
}