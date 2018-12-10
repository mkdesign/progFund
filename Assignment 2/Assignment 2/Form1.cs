using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] mealIndex = new int[3];
        string[] quantities = new string[3];
        double[] prices = new double[3] { 3.95, 10.95,11.95};
        double tax = 0.13;
        double taxAmount=0, total=0, subTotal=0;
        Boolean validated;
        private void store()
        {
            taxAmount = total = subTotal = 0;
            mealIndex[0] = cb1.SelectedIndex;
            mealIndex[1] = cb2.SelectedIndex;
            mealIndex[2] = cb3.SelectedIndex;
            quantities[0] = txtQuantity1.Text;
            quantities[1] = txtQuantity2.Text;
            quantities[2] = txtQuantity3.Text;

        }

        private Boolean validator(int index, string quantity)
        {
            int indexNum;
            int quantityAmount;
            bool isNum = int.TryParse(quantity, out quantityAmount);
            if (isNum && quantityAmount > 0 && index > -1) {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        private void calculator(int index, string quantity) 
        {
            subTotal += (prices[index] * Convert.ToInt32(quantity));
            taxAmount = 0.13 * subTotal;
            total = subTotal + taxAmount;
        }

        public void printReceipt()
        {
            if(validated)
            {
                lblSubAmount.Text = String.Format("{0:c}",subTotal);
                lblTaxAmount.Text = String.Format("{0:c}", taxAmount);
                lblTotalAmount.Text= String.Format("{0:c}", total);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
            store();
            for( int i =0; i <quantities.Length;i++)
            {
                if(validator(mealIndex[i], quantities[i]))
                {
                    calculator(mealIndex[i], quantities[i]);
                    validated = true;
                }
                else
                {
                    validated = false;
                    MessageBox.Show("Some field is not valid. Try again");
                }
            }

            printReceipt();
        }
    }
}
