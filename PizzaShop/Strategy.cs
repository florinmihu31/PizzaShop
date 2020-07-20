namespace PizzaShop {
    // Interfata folosita pentru sablonul Strategy
    public interface Strategy {
        Pizza Execute(Promotion promotion);
    }
}
