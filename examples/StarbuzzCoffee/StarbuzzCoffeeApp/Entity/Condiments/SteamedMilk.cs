namespace StarbuzzCoffeeApp.Entity.Condiments
{
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription() => this._beverage.GetDescription() + ", Steamed Milk";

        public override double Cost() => _beverage.Cost() + .10;
    }
}