namespace PizzaShop {
    public class TuesdayStrategy : Strategy {
        // Metoda ce intoarce o Quattro Stagioni gratis
        public Pizza Execute(Promotion promotion) {
            Pizza freePizza = PizzaShop.GetPizzaShop().CreatePizza("Quattro Stagioni");
            freePizza.Price = 0;

            return freePizza;
        }
    }
}