using System;

namespace PizzaShop {
    public class Test {
        static void Main(string[] args) {
            // Crearea instantei magazinului
            PizzaShop pizzaShop = PizzaShop.GetPizzaShop();
            // Crearea unei pizza si afisarea informatiilor despre aceasta
            Pizza quattroFormaggi = pizzaShop.CreatePizza("Quattro Formaggi");
            Console.WriteLine(quattroFormaggi.GetPrice());
            Console.WriteLine(quattroFormaggi.GetWeight());

            // Instantierea unor utilizatori
            User user1 = new User("Florin");
            User user2 = new User("Alex");

            // Instantierea unui obiect pentru promotia din ziua respectiva
            Promotion promotion = pizzaShop.GetPromotion();
            // Adaugarea urmaritorilor promotiei
            promotion.AddObserver(user1);
            promotion.AddObserver(user2);
            // Trimiterea notificarii catre urmaritori
            promotion.NotifyAllObservers(new Notification());

            // Afisarea notificarilor pentru utilizatorul 1
            user1.ListNotifications();
            // Adaugarea pe lista a comenzilor
            user1.AddToOrderList("Carnivora");
            user1.AddToOrderList("Carnivora");
            user1.AddToOrderList("Quattro Formaggi");
            // Finalizarea comenzii
            user1.CompleteOrder();
            // Afisarea pizzelor comandate de catre utilizatorul 1
            user1.ListOrderedPizzas();
            // Afisarea pretului de plata pentru primul utilizator
            Console.WriteLine("Suma totala este: {0}", user1.GetTotalPrice());
        }
    }
}
