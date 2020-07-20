using System;

namespace PizzaShop {
    public class FridayStrategy : Strategy {
        // Functie ce intoarce o pizza la intamplare la jumatate de pret
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

            discountPizza.Price /= 2;

            return discountPizza;
        }
    }
}