using System;

namespace PizzaShop {
    public class SundayStrategy : Strategy {
        // Metoda ce intoarce o pizza gratis la intamplare
        public Pizza Execute(Promotion promotion) {
            Random random = new Random();
            Pizza freePizza = null;

            switch (random.Next(1, 5)) {
                case 1:
                    freePizza = PizzaShop.GetPizzaShop().CreatePizza("Quattro Formaggi");
                    break;

                case 2:
                    freePizza = PizzaShop.GetPizzaShop().CreatePizza("Quattro Stagioni");
                    break;

                case 3:
                    freePizza = PizzaShop.GetPizzaShop().CreatePizza("Carnivora");
                    break;

                case 4:
                    freePizza = PizzaShop.GetPizzaShop().CreatePizza("Mexicana");
                    break;
            }

            freePizza.Price = 0;

            return freePizza;
        }
    }
}