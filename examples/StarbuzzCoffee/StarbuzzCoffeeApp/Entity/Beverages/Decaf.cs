namespace StarbuzzCoffeeApp.Entity.Beverages
{
    public class Decaf : Beverage
    {
        public Decaf() { _description = "Decaf Coffee"; }

        public override double Cost() => 1.05;
    }
}