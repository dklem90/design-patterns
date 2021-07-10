namespace StarbuzzCoffeeApp.Entity.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription() => _beverage.GetDescription() + ", Soy";

        public override double Cost() => _beverage.Cost() + .15;
    }
}