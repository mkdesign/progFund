using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textPass.PasswordChar = '*';
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {

            string passVal = "password";
            string userPass = textPass.Text;
            
            if(userPass!= passVal)
            {
                lblAlert.Text = "Wrong Password.Please Try again";
                textPass.Text = String.Empty;

            }
            else
            {
                lblAlert.Text = "Welcome!";
                btnLoop.Visible = false;
                textPass.Visible = false;
            }

           


            
        }
    }
}
