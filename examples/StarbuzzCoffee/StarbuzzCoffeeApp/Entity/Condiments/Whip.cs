namespace StarbuzzCoffeeApp.Entity.Condiments
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription() => this._beverage.GetDescription() + ", Whip";

        public override double Cost() => _beverage.Cost() + .10;
    }
}