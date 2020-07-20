using System;
using System.Collections.Generic;

namespace PizzaShop {
    public class User {
        // Lista notificarilor utilizatorului
        private List<Notification> notifications;
        // Lista pizzelor comandate
        private List<Pizza> orderedPizzas;
        // Variabila ce este true daca a fost completata comanda
        private bool orderCompleted;

        // Numele utilizatorului
        public string Name { get; set; }

        public User(string name) {
            notifications = new List<Notification>();
            orderedPizzas = new List<Pizza>();
            Name = name;
            orderCompleted = false;
        }

        // Metoda ce actualizeaza lista de notificari a utilizatorului
        public void Update(Notification notification) {
            if (!notifications.Contains(notification)) {
                notifications.Add(notification);
            }
        }

        // Metoda ce afiseaza in consola toate notificarile utilizatorului
        public void ListNotifications() {
            foreach (Notification notification in notifications) {
                Console.WriteLine(notification);
            }
        }

        // Metoda ce intoarce un sir cu toate notificarile utilizatorului
        public string ListNotificationsToString() {
            string result = "";

            foreach (Notification notification in notifications) {
                result += notification + "\n";
            }

            return result;
        }

        // Metoda ce adauga la comanda o pizza cu numele dat
        public void AddToOrderList(string pizzaName) {
            orderedPizzas.Add(PizzaShop.GetPizzaShop().CreatePizza(pizzaName));
        }

        // Metoda ce completeaza comanda
        public void CompleteOrder() {
            // Promotia curenta
            Promotion promotion = PizzaShop.GetPizzaShop().GetPromotion();
            // Numarul de pizza deja comandate
            int numberOfPizzas = orderedPizzas.Count;

            /*
             * In functie de ziua curenta si de numarul de pizza deja comandate
             * se adauga pizzele primite la promotie
             */ 
            switch (promotion.DayOfWeek) {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    for (uint i = 0; i < numberOfPizzas / 2; i++) {
                        orderedPizzas.Add(promotion.ExecuteStrategy());
                    }
                    break;

                case DayOfWeek.Friday:
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    for (uint i = 0; i < numberOfPizzas; i++) {
                        orderedPizzas.Add(promotion.ExecuteStrategy());
                    }
                    break;
            }

            // Variabile primeste valoarea true la finalizarea comenzii
            orderCompleted = true;
        }

        // Metoda ce afiseaza pizzele pe care le va primi utilizatorul
        public void ListOrderedPizzas() {
            // Daca comanda nu a fost finalizata se arunca o exceptie
            if (!orderCompleted) {
                throw new Exception("Comanda nu a fost finalizata!");
            }

            foreach (Pizza pizza in orderedPizzas) {
                Console.Write(pizza + " ");
            }

            Console.WriteLine();
        }

        // Metoda ce intoarce lista de pizze comandate
        public List<Pizza> GetOrderedPizzas() {
            return orderedPizzas;
        }

        // Metoda ce intoarce totalul de plata
        public double GetTotalPrice() {
            // Daca comanda nu a fost finalizata se arunca o exceptie
            if (!orderCompleted) {
                throw new Exception("Comanda nu a fost finalizata!");
            }

            double totalPrice = 0;

            foreach (Pizza pizza in orderedPizzas) {
                totalPrice += pizza.Price;
            }

            return totalPrice;
        }

        // Metoda ce afiseaza numele utilizatorului
        public override string ToString() {
            return Name;
        }
    }
}
