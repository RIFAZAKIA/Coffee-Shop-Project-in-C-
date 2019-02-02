using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2App
{
    public partial class CoffeeShopUi : Form
    {
        public CoffeeShopUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string customerName, contactNo, address, order;
            int quantity,price=0;

            customerName = customerNameTextBox.Text;
            contactNo = contactNoTextBox.Text;
            address = addressTextBox.Text;
            order = orderComboBox.Text;
            quantity = Convert.ToInt32(quantityTextBox.Text);


            if (order == " ")
            {
                MessageBox.Show("Please Select Some Order For You!");
            }

            else if (order == "Black")
            {
                price = quantity * 120;
            }
            else if (order == "Cold")
            {
                price = quantity * 100;
            }
            else if (order == "Hot")
            {
                price = quantity * 90;
            }
            else if(order =="Regular")
            {
                price = quantity * 80;
                    }

            richTextBox.Text=("********Order information**********\nCustomer Name:"+customerName+
                "\nContact No:"+contactNo+"\nAddress:"+address+"\nOrder Item:"
                +order+"\nOrder Quantity:"+quantity+"\nTotal Price:"+price);






        }
    }
}
