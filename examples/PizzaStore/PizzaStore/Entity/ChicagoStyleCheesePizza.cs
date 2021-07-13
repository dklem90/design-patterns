namespace PizzaStore.Entity
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Append("Shredded Mozzarella Cheese");
        }

        public override void Cut() => Console.WriteLine("Cutting the pizza into square slices");
    }
}
