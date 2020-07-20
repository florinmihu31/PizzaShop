using System;

namespace PizzaShop {
    public class Notification {
        private DateTime notificationDate;
        private Promotion promotion;

        public Notification() {
            // Initializarea datei notificarii cu data curenta
            notificationDate = DateTime.Now;
            // Promotia curenta
            promotion = PizzaShop.GetPizzaShop().GetPromotion();
        }

        // Afisarea notificarii
        public override string ToString() {
            return "[" + notificationDate.ToString("dd/mm/yy HH:mm:ss") + "] " +
                promotion;
        }
    }
}
