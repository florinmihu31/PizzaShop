using System;
using System.Windows.Forms;

namespace PizzaShop {
    public partial class OrderForm : Form {
        public OrderForm() {
            InitializeComponent();
        }

        // Functie ce verifica daca casetele text sunt sau nu goale
        private bool ValidateInput() {
            if (textBox1.Text == null || textBox1.Text == "") {
                errorProvider1.SetError(textBox1, "Nu ai introdus un nume!");
                return false;
            }

            if (textBox2.Text == null || textBox2.Text == "") {
                errorProvider1.SetError(textBox2, "Nu ai comandat nicio pizza!");
                return false;
            }

            return true;
        }

        private void DisplayNotifications(object sender, EventArgs e) {
            if (textBox1.Text == null || textBox1.Text == "") {
                errorProvider1.SetError(textBox1, "Nu ai introdus un nume!");
                return;
            }

            PizzaShop pizzaShop = PizzaShop.GetPizzaShop();
            Promotion promotion = pizzaShop.GetPromotion();

            if (pizzaShop.CurrentCustomer == null) {
                pizzaShop.CurrentCustomer = new User(textBox1.Text);
            }

            promotion.AddObserver(pizzaShop.CurrentCustomer);
            promotion.NotifyAllObservers(new Notification());

            MessageBox.Show(pizzaShop.CurrentCustomer.ListNotificationsToString());
        }

        private void button2_Click(object sender, EventArgs e) {
            if (!ValidateInput()) {
                return;
            }

            PizzaShop pizzaShop = PizzaShop.GetPizzaShop();

            if (pizzaShop.CurrentCustomer == null) {
                pizzaShop.CurrentCustomer = new User(textBox1.Text);
            }

            try {
                pizzaShop.CurrentCustomer.AddToOrderList(textBox2.Text);
            } catch (Exception) {
                errorProvider1.SetError(textBox2, "Nu exista pizza comandata de tine!");
                return;
            }

            MessageBox.Show("Pizza a fost adaugata pe lista!");
        }

        private void button3_Click(object sender, EventArgs e) {
            if (!ValidateInput()) {
                return;
            }

            new BillForm(PizzaShop.GetPizzaShop().CurrentCustomer).Show();
        }
    }
}
