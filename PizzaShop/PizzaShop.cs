using System;

namespace PizzaShop {
	public class PizzaShop {
		// Unica instanta a clasei
		private static PizzaShop pizzaShop = new PizzaShop();
		// Promotia zilei curente
		private Promotion promotion;
		// Utilizatorul curent
		public User CurrentCustomer { get; set; }
		
		/*
		 * Constructor privat, specific sablonului Singleton, se initializeaza
		 * promotia in functie de ziua curenta
		 */
		private PizzaShop() {
			promotion = new Promotion(DateTime.Now.DayOfWeek);
		}

		// Metoda ce intoarce unica instanta a clasei
		public static PizzaShop GetPizzaShop() {
			return pizzaShop;
		}

		// Metoda ce creeaza o pizza in functie de numele introdus
		public Pizza CreatePizza(string pizzaName) {
			switch(pizzaName) {
				case "Quattro Formaggi":
					return new QuattroFormaggi();

				case "Quattro Stagioni":
					return new QuattroStagioni();

				case "Carnivora":
					return new Carnivora();

				case "Mexicana":
					return new Mexicana();

				default:
					throw new ArgumentException("Nu exista pizza introdusa");
			}
		}

		// Metoda ce intoarce promotia din ziua curenta
		public Promotion GetPromotion() {
			return promotion;
		}
	}
}