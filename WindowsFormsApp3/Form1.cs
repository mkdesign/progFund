using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal[] classArray = new decimal[6];
            decimal average =0;
            string[] classTitles = new string[6];
            
            classArray[0] = Convert.ToInt32(txtCr1.Text);
            classArray[1] = Convert.ToInt32(txtCr2.Text);
            classArray[2] = Convert.ToInt32(txtCr3.Text);
            classArray[3] = Convert.ToInt32(txtCr4.Text);
            classArray[4] = Convert.ToInt32(txtCr5.Text);
            classArray[5] = Convert.ToInt32(txtCr6.Text);

            for (var i =0; i < 6; i++)
            {
                if(classArray[i] <= 100 && classArray[i] >=80)
                {
                    classTitles[i] = "A";
                }else if (classArray[i] < 80 && classArray[i] >= 70)
                {
                    classTitles[i] = "B";
                }
                else if (classArray[i] < 70 && classArray[i] >= 60)
                {
                    classTitles[i] = "C";
                }
                else if (classArray[i] < 60 && classArray[i] >= 50)
                {
                    classTitles[i] = "D";
                }
                else 
                {
                    classTitles[i] = "F";
                }

                average = ( average + classArray[i]);
       
                
            }

            lblClassAvg.Text = Convert.ToString(average/6);

            if (average <= 100 && average >= 80)
            {
                lblClassTitle.Text = "A";
            }
            else if (average < 80 && average >= 70)
            {
                lblClassTitle.Text = "B";
            }
            else if (average < 70 && average >= 60)
            {
                lblClassTitle.Text = "C";
            }
            else if (average < 60 && average >= 50)
            {
                lblClassTitle.Text = "D";
            }
            else
            {
                lblClassTitle.Text = "F";
            }

            lblCrTitle1.Text = classTitles[0];
            lblCrTitle2.Text = classTitles[1];
            lblCrTitle3.Text = classTitles[2];
            lblCrTitle4.Text = classTitles[3];
            lblCrTitle5.Text = classTitles[4];
            lblCrTitle6.Text = classTitles[5];
        }

       
    }
}
