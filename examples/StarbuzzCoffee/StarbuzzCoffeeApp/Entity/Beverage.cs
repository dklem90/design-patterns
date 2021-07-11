namespace StarbuzzCoffeeApp.Entity
{
    public abstract class Beverage
    {
        public enum Size { Tall, Grande, Venti };
        
        public string _description = "Unknown beverage";

        public virtual string GetDescription() => _description;

        public abstract double Cost();

        public Size CoffeeSize { get; set; }
    }
}