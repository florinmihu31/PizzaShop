namespace PizzaShop {
    public class QuattroStagioni : Pizza {
        public QuattroStagioni() {
            PizzaDough = 150;
            TomatoSauce = 30;
            Mozzarella = 50;
            Mushrooms = 20;
            Salami = 50;
            Ham = 50;
            Corn = 20;
            Pepper = 30;

            Price = 27;
        }

        public override string GetWeight() {
            return PizzaDough + TomatoSauce + Mozzarella + Mushrooms + Salami 
                + Ham + Corn + Pepper + WeightMeasureUnit;
        }
    }
}
