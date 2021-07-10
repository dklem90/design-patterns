namespace StarbuzzCoffeeApp.Entity
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage _beverage;

        public override abstract string GetDescription();
    }
}