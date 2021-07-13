using PizzaStore.Entity;

namespace PizzaStore.Data
{
    public abstract class PizzaFactory
    {
        public abstract Pizza CreatePizza();
    }
}
