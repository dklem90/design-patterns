namespace StarbuzzCoffeeApp.Entity.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _description = "Dark Roast Coffee";
        }

        public override double Cost() => .99;
    }
}