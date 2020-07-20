namespace PizzaShop {
    public class Mexicana : Pizza {
        public Mexicana() {
            PizzaDough = 150;
            TomatoSauce = 50;
            Mozzarella = 50;
            Salami = 65;
            Jalapeno = 20;
            Corn = 35;
            Bacon = 30;

            Price = 30;
        }

        public override string GetWeight() {
            return PizzaDough + TomatoSauce + Mozzarella + Salami + Jalapeno 
                + Corn + Bacon + WeightMeasureUnit;
        }
    }
}
