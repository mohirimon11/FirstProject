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


        List<string> customers = new List<string> { "rimon" };
        List<int> contacts = new List<int> { 01744775515 };
        List<string> address_all = new List<string> { "8/a" };
        List<string> orders = new List<string> { "Black Coffee - 120" };
        List<int> quantitys = new List<int>{2};
        List<int> prices = new List<int> {240};


        string Customer, Address, Order;
        int Contact, Quantity, price, index=0;


      

        public Coffee_Shop()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            if (contactTextBox.Text == "" || customerNameTextBox.Text == "" || addressTextBox.Text == "" || orderComboBox.Text == "" || quantityTextBox.Text == "")
            {
                MessageBox.Show("Enter value please");
            }
            else 
            {

                Customer = customerNameTextBox.Text;
                if(contacts.Count>0)
                {
                    for(int i=0;i<contacts.Count;i++)
                    {
                        if (contacts[i] == Convert.ToInt32(contactTextBox.Text))
                        {
                            MessageBox.Show("Contact number is duplicate");
                            return;
                        }
                        else
                        {
                            Contact = Convert.ToInt32(contactTextBox.Text);
                        }
                    }

                    
                }
                
                Address = addressTextBox.Text;
                Order = orderComboBox.Text;
                Quantity = Convert.ToInt32(quantityTextBox.Text);
                string Result = Order + Quantity;
                string message = " Customar Name: " + Customer + " \n Contact No: " + Contact + "\n Address: " + Address +
                        "\n\n Order: " + Order + "\n Quantity: " + Quantity;
               
                if (orderComboBox.Text== "Black Coffee - 120")
                {
                    price = Convert.ToInt32(quantityTextBox.Text) * 120;
                    MessageBox.Show(message);
                    displayTextBox.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\nCustmar Purchase Information:\n\n" + 
                        message + "\n_______________________\n Total Price is: " + price + "\n_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
                }
                if(orderComboBox.Text == "Cold Coffee  - 100")
                {
                    price = Convert.ToInt32(quantityTextBox.Text) * 100;
                    MessageBox.Show(message);
                    displayTextBox.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\nCustmar Purchase Information:\n\n" + 
                        message + "\n_______________________\n Total Price is: " + price + "\n_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";

                }
                if (orderComboBox.Text == "Hot Coffee - 90")
                {
                    price = Convert.ToInt32(quantityTextBox.Text) * 90;
                    MessageBox.Show(message);
                    displayTextBox.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\nCustmar Purchase Information:\n\n" +
                        message + "\n_______________________\n Total Price is: " + price + "\n_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
                }
                if (orderComboBox.Text == "Reguler coffee - 80")
                {
                    price = Convert.ToInt32(quantityTextBox.Text) * 80;
                    MessageBox.Show(message);
                    displayTextBox.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\nCustmar Purchase Information:\n\n" +
                        message + "\n_______________________\n Total Price is: " + price + "\n_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
                }
                customers.Add  (customerNameTextBox.Text);
                contacts.Add(Convert.ToInt32(contactTextBox.Text));
                address_all.Add(addressTextBox.Text);
                orders.Add(orderComboBox.Text);
                quantitys.Add(Convert.ToInt32(quantityTextBox.Text));
                prices.Add (price);
                index++;
                clear();
                


            }
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            string Show_Result = "";
            int Size=0;

            try
            {
                if (String.IsNullOrEmpty(sizeTextBox.Text))
                {
                    
                }
                if (Convert.ToInt32(sizeTextBox.Text) == customers.Count)
                {
                    Size = Convert.ToInt32(sizeTextBox.Text);
                    MessageBox.Show("Searching.....");
                }
                else
                {
                    MessageBox.Show("Enter right value..");
                    return;
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            for(index=0;index<Size;index++)
                //string message = " Customar Name: " + Customer + " \n Contact No: " + Contact + "\n Address: " + Address +
                //        "\n\n Order: " + Order + "\n Quantity: " + Quantity;
            {
                Show_Result += " \n_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\n" + " Customar Name: " + customers[index] + " \n Contact No: " + contacts[index]
                    + "\n Address: " + address_all[index]+ "\n\n Order: " + orders[index]+ "\n Quantity: " +
                    quantitys[index]+ "\n_______________________\n Total Price is: " + prices[index]+ "\n_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\n\n\n" ;
            }
            displayTextBox.Text = Show_Result;

        }
        public void clear()
        {
            customerNameTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
            orderComboBox.Text = "";
            quantityTextBox.Text = "";
        }
    }
}
