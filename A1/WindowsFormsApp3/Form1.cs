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
        Boolean isValidated;

        public Boolean validateIt(string grade)
        {
            int gradeNum;
            bool isNum = int.TryParse(grade, out gradeNum);
            if (isNum)
            {
                isValidated = true;
                return true;
            }
            else
            {
                isValidated = false;
                return false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            isValidated = true;
            decimal[] classArray = new decimal[6];
            string[] classGrades = new string[6];

            decimal average =0;
            string[] classTitles = new string[6];
            
            classGrades[0] = (txtCr1.Text);
            classGrades[1] = (txtCr2.Text);
            classGrades[2] = (txtCr3.Text);
            classGrades[3] = (txtCr4.Text);
            classGrades[4] = (txtCr5.Text);
            classGrades[5] = (txtCr6.Text);

            for (int j = 0; j < 6; j++)
            {
                if(validateIt(classGrades[j]))
                {
                    classArray[j] = Convert.ToInt32(classGrades[j]);
                }
            }
            if(isValidated)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (classArray[i] <= 100 && classArray[i] >= 80)
                    {
                        classTitles[i] = "A";
                    }
                    else if (classArray[i] < 80 && classArray[i] >= 70)
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

                    average = (average + classArray[i]);


                }

                average = average / 6;

                lblClassAvg.Text = Convert.ToString(average);

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
            else
            {
                MessageBox.Show("Wrong Entry");
            }
        }

            

     
       
    }
}
