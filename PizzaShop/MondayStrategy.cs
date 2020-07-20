namespace PizzaShop {
    public class MondayStrategy : Strategy {
        // Functie ce intoarce o Quattro Formaggi gratis
        public Pizza Execute(Promotion promotion) {
            Pizza freePizza = PizzaShop.GetPizzaShop().CreatePizza("Quattro Formaggi");
            freePizza.Price = 0;

            return freePizza;
        }
    }
}
