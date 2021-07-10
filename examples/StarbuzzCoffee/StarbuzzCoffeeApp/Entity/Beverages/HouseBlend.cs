namespace StarbuzzCoffeeApp.Entity.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _description = "House Blend Coffee";
        }

        public override double Cost() => .89;
    }
}