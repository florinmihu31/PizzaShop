namespace PizzaShop {
    public class WednesdayStrategy : Strategy {
        // Metoda ce intoarce o Carnivora gratis
        public Pizza Execute(Promotion promotion) {
            Pizza freePizza = PizzaShop.GetPizzaShop().CreatePizza("Carnivora");
            freePizza.Price = 0;

            return freePizza;
        }
    }
}