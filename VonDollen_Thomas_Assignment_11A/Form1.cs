using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace VonDollen_Thomas_Assignment_11A
{
    public partial class OrderForm : Form
    {
        //indices of each size in array
        /*0 = XS 
         *1 = S
         *2 = M
         *3 = L
         *4 = XL
         *5 = XXL
         */

        int[] orderAmt = new int[6]; //holds amount of each size

        public OrderForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string amountStr = quantityInput.Text;

            if(!int.TryParse(amountStr, out int result) || int.Parse(amountStr) <= 0)   /*if invalid amount input, give message
                                                                                         * to user saying that their input must
                                                                                         * be greater than 0*/
            {
                MessageBox.Show("Invalid input. Enter integer value greater than 0");

            } else if (sizeListBox.SelectedIndex == -1)                                 /*if no size is selected, give message
                                                                                         * to user saying that they must indicate
                                                                                         * the size*/
            {
                MessageBox.Show("Indicate which sizes you would like to order");
            }
            else
            {
                int amount = int.Parse(amountStr);                                      //add amount to appropriate indices
                foreach (int item in sizeListBox.SelectedIndices)
                {
                    orderAmt[item] += amount;
                }

                quantityInput.Clear();
                sizeListBox.ClearSelected();
            }
        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            float[] prices = new float[] { 10f, 10f, 12f, 12f, 14f, 14f };
            float total = 0f;
            for(int i=0; i<orderAmt.Length; i++)
            {
                float amount = orderAmt[i];
                total += amount *= prices[i];
            }
            string results = "XS\t" + orderAmt[0]
                + "\nS\t" + orderAmt[1]
                + "\nM\t" + orderAmt[2]
                + "\nL\t" + orderAmt[3]
                + "\nXL\t" + orderAmt[4]
                + "\nXXL\t" + orderAmt[5]
                + "\n\nTotal\t" + total.ToString("C");

            MessageBox.Show("Size\tAmount\n" + results, "Review Order");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Array.Clear(orderAmt,0,6);
        }
    }
}
