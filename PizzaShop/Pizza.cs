namespace PizzaShop {
    public abstract class Pizza {
        private const string weightMeasureUnit = "g";
        private const string priceMeasureUnit = "lei";

        public string WeightMeasureUnit {
            get {
                return weightMeasureUnit;
            }
        }

        public string PriceMeasureUnit {
            get {
                return priceMeasureUnit;
            }
        }

        /*
         * Ingredientele pentru pizza in unitatea de masura a greutatii 
         * specificata
         */
        public int PizzaDough { get; set; }
        public int TomatoSauce { get; set; }
        public int Salami { get; set; }
        public int Ham { get; set; }
        public int Bacon { get; set; }
        public int Mushrooms { get; set; }
        public int Pepper { get; set; }
        public int Corn { get; set; }
        public int Jalapeno { get; set; }
        public int Parmesan { get; set; }
        public int Mozzarella { get; set; }
        public int MoldyCheese { get; set; }
        public int Gorgonzolla { get; set; }
        public double Price { get; set; }

        // Metoda ce intoarce greutatea unei pizza
        public abstract string GetWeight();

        // Metoda ce intoarce pretul unei pizza
        public string GetPrice() {
            return Price + PriceMeasureUnit;
        }

        // Metoda ce afiseaza numele unei pizza
        public override string ToString() {
            return GetType().Name;
        }
    }
}
