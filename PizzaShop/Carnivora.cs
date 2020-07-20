namespace PizzaShop {
    public class Carnivora : Pizza {
        public Carnivora() {
            PizzaDough = 150;
            TomatoSauce = 30;
            Salami = 50;
            Ham = 120;
            Bacon = 80;

            Price = 28;
        }

        public override string GetWeight() {
            return PizzaDough + TomatoSauce + Salami + Ham + Bacon 
                + WeightMeasureUnit;
        }
    }
}
