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
        string[] customerArray = new string[20];
        string[] addressArray = new string[20];
        string[] orderArray = new string[20];
        int[] contactArray = new int[20];
        int[] quantityArray = new int[20];
        int[] priceArray = new int[20];
        

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
                Contact = Convert.ToInt32(contactTextBox.Text);
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
                    displayTextBox.Text = "Custmar Purchase Information:\n\n" + message + "\n________________________\n Total Price is: " +price;
                }
                if(orderComboBox.Text == "Cold Coffee  - 100")
                {
                    price = Convert.ToInt32(quantityTextBox.Text) * 100;
                    MessageBox.Show(message);
                    displayTextBox.Text = "Custmar Purchase Information:\n\n" + message + "\n________________________\n Total Price is: " + price;

                }
                if (orderComboBox.Text == "Hot Coffee - 90")
                {
                    price = Convert.ToInt32(quantityTextBox.Text) * 90;
                    MessageBox.Show(message);
                    displayTextBox.Text = "Custmar Purchase Information:\n\n"+ message + "\n________________________\n Total Price is: " + price;

                }
                if (orderComboBox.Text == "Reguler coffee - 80")
                {
                    price = Convert.ToInt32(quantityTextBox.Text) * 80;
                    MessageBox.Show(message);
                    displayTextBox.Text = "Custmar Purchase Information:\n\n"+ message + "\n________________________\n Total Price is: " + price;

                }
                customerArray[index] = customerNameTextBox.Text;
                contactArray[index] = Convert.ToInt32(contactTextBox.Text);
                addressArray[index] = addressTextBox.Text;
                orderArray[index] = orderComboBox.Text;
                quantityArray[index] = Convert.ToInt32(quantityTextBox.Text);
                priceArray[index] = price;
                index++;
                


            }
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            string Show_Result = "";
            int Size = Convert.ToInt32(sizeTextBox.Text);
            for(index=0;index<Size;index++)
                //string message = " Customar Name: " + Customer + " \n Contact No: " + Contact + "\n Address: " + Address +
                //        "\n\n Order: " + Order + "\n Quantity: " + Quantity;
            {
                Show_Result += " \n\n\n"+ " Customar Name: " + customerArray[index] + " \n Contact No: " + contactArray[index]
                    + "\n Address: " + addressArray[index]+ "\n\n Order: " + orderArray[index]+ "\n Quantity: " +
                    quantityArray[index]+ "\n________________________\n Total Price is: " + priceArray[index];
            }
            displayTextBox.Text = Show_Result;

        }
    }
}
