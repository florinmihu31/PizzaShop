using System;
using System.Windows.Forms;

namespace PizzaShop {
    public partial class BillForm : Form {
        public BillForm() {
            InitializeComponent();
        }

        public BillForm(User currentCustomer) : this() {
            // Se completeaza comanda pentru utilizatorul curent
            currentCustomer.CompleteOrder();
            // Se afiseaza numele utilizatorului curent
            label4.Text = currentCustomer.ToString();

            // Se afiseaza numele si pretul fiecarei pizza
            foreach (Pizza pizza in currentCustomer.GetOrderedPizzas()) {
                label2.Text += pizza + "\n";
                label3.Text += pizza.GetPrice() + "\n";
            }

            // Se afiseaza pretul final
            label6.Text = currentCustomer.GetTotalPrice().ToString();
        }

        // Functie de achitare a notei ce incheie programul
        private void PayBill(object sender, EventArgs e) {
            const int SUCCESS_CODE = 0;

            Environment.Exit(SUCCESS_CODE);
        }
    }
}
