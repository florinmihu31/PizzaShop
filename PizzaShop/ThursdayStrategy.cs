namespace PizzaShop {
    public class ThursdayStrategy : Strategy {
        // Metoda ce intoarce o Mexicana gratis
        public Pizza Execute(Promotion promotion) {
            Pizza freePizza = PizzaShop.GetPizzaShop().CreatePizza("Mexicana");
            freePizza.Price = 0;

            return freePizza;
        }
    }
}