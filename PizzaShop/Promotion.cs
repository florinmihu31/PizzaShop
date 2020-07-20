using System;
using System.Collections.Generic;

namespace PizzaShop {
    public class Promotion {
        // Lista utilizatorilor ce urmaresc promotia
        private List<User> users;

        // Numele, descrierea si ziua saptamanii a promotiei
        public string Name { get; set; }
        public string Description { get; set; }
        public DayOfWeek DayOfWeek { get; set; }

        /**
         * Constructor ce initializeaza numele si descrierea promotiei
         * in functie de ziua saptamanii
         */
        public Promotion(DayOfWeek dayOfWeek) {
            users = new List<User>();
            DayOfWeek = dayOfWeek;

            switch (DayOfWeek) {
                case DayOfWeek.Monday:
                    Name = "Promotie Luni";
                    Description = "2x Pizza + 1x Quattro Formaggi gratis";
                    break;

                case DayOfWeek.Tuesday:
                    Name = "Promotie Marti";
                    Description = "2x Pizza + 1x Quattro Stagioni gratis";
                    break;

                case DayOfWeek.Wednesday:
                    Name = "Promotie Miercuri";
                    Description = "2x Pizza + 1x Carnivora gratis";
                    break;

                case DayOfWeek.Thursday:
                    Name = "Promotie Joi";
                    Description = "2x Pizza + 1x Mexicana gratis";
                    break;

                case DayOfWeek.Friday:
                    Name = "Promotie Vineri";
                    Description = "1x Pizza + 1x Pizza 50% Reducere";
                    break;

                case DayOfWeek.Saturday:
                    Name = "Promotie Sambata";
                    Description = "1x Pizza + 1x Pizza 75% Reducere";
                    break;

                case DayOfWeek.Sunday:
                    Name = "Promotie Duminica";
                    Description = "1x Pizza + 1x Pizza gratis";
                    break;
            }
        }

        // Metoda ce executa o strategie in functie de ziua curenta
        public Pizza ExecuteStrategy() {
            Strategy strategy;

            switch (DayOfWeek) {
                case DayOfWeek.Monday:
                    strategy = new MondayStrategy();
                    return strategy.Execute(this);

                case DayOfWeek.Tuesday:
                    strategy = new TuesdayStrategy();
                    return strategy.Execute(this);

                case DayOfWeek.Wednesday:
                    strategy = new WednesdayStrategy();
                    return strategy.Execute(this);

                case DayOfWeek.Thursday:
                    strategy = new ThursdayStrategy();
                    return strategy.Execute(this);

                case DayOfWeek.Friday:
                    strategy = new FridayStrategy();
                    return strategy.Execute(this);

                case DayOfWeek.Saturday:
                    strategy = new SaturdayStrategy();
                    return strategy.Execute(this);

                case DayOfWeek.Sunday:
                    strategy = new SundayStrategy();
                    return strategy.Execute(this);

                default:
                    return null;
            }
        }

        // Metoda ce adauga un urmaritor
        public void AddObserver(User user) {
            if (!users.Contains(user)) {
                users.Add(user);
            }
        }

        // Metoda ce sterge un urmaritor
        public void RemoveObserver(User user) {
            if (users.Contains(user)) {
                users.Remove(user);
            }
        }

        // Metoda ce notifica toti urmaritorii
        public void NotifyAllObservers(Notification notification) {
            foreach (User user in users) {
                user.Update(notification);
            }
        }

        // Metoda de afisare a promotiei
        public override string ToString() {
            return DayOfWeek + ": " + Name + " -> " + Description;
        }
    }
}
