using System;

namespace PizzaShop {
    public class SaturdayStrategy : Strategy {
        // Metoda ce intoarce o pizza la intamplare cu 75% reducere
        public Pizza Execute(Promotion promotion) {
            Random random = new Random();
            Pizza discountPizza = null;

            switch (random.Next(1, 5)) {
                case 1:
                    discountPizza = PizzaShop.GetPizzaShop().CreatePizza("Quattro Formaggi");
                    break;

                case 2:
                    discountPizza = PizzaShop.GetPizzaShop().CreatePizza("Quattro Stagioni");
                    break;

                case 3:
                    discountPizza = PizzaShop.GetPizzaShop().CreatePizza("Carnivora");
                    break;

                case 4:
                    discountPizza = PizzaShop.GetPizzaShop().CreatePizza("Mexicana");
                    break;
            }

            discountPizza.Price *= 0.25;

            return discountPizza;
        }
    }
}