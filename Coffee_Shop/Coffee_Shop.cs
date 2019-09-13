using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class Coffee_Shop : Form
    {
        public Coffee_Shop()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string Customer, Address, Order;
            int Contact, Quantity;
            if (contactTextBox.Text == "" || CustomerNameTextBox.Text == "" || addressTextBox.Text == "" || OrderComboBox.Text == "" || quantityTextBox.Text == "")
            {
                MessageBox.Show("Enter value please");
            }
            else
            {
                Customer = CustomerNameTextBox.Text;
                Contact = Convert.ToInt32(contactTextBox.Text);
                Address = addressTextBox.Text;
                Order = OrderComboBox.Text;
                Quantity = Convert.ToInt32(quantityTextBox.Text);
               // string Result = Order + Quantity;
                MessageBox.Show(" Customar Name: " + Customer + " \n Contact No: " + Contact + "\n Address: " + Address +
                    "\n\n Order: " + Order + "\n Quantity: " + Quantity);
                displayTextBox.Text = "Custmar Purchase Information:\n\n Customar Name: " + Customer + " \n Contact No: " + Contact + "\n Address: " + Address +
                    "\n\n Order: " + Order + "\n Quantity: " + Quantity + "\n________________________\n Total Price is: ";
            }
        }
    }
}
