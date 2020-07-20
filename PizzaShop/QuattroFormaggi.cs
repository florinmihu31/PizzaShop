namespace PizzaShop {
    public class QuattroFormaggi : Pizza {
        public QuattroFormaggi() {
            PizzaDough = 150;
            TomatoSauce = 30;
            Mozzarella = 50;
            MoldyCheese = 50;
            Parmesan = 50;
            Gorgonzolla = 30;

            Price = 25;
        }

        public override string GetWeight() {
            return PizzaDough + TomatoSauce + Mozzarella + MoldyCheese
                + Parmesan + Gorgonzolla + WeightMeasureUnit;
        }
    }
}
