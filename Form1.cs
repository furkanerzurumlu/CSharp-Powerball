using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnResult_Click_1(object sender, EventArgs e)
        {
            int[] Powerball = new int[6]; 
            Random ranNum = new Random(); 
            int numbers = ranNum.Next(1, 2);
            for (int i = 0; i < 6; i++) 
            {
                Powerball[i] = ranNum.Next(1,50);
            }
            Array.Sort(Powerball); 
            lab1.Text = Convert.ToString(Powerball[0]); 
            lab2.Text = Convert.ToString(Powerball[1]);
            lab3.Text = Convert.ToString(Powerball[2]); 
            lab4.Text = Convert.ToString(Powerball[3]); 
            lab5.Text = Convert.ToString(Powerball[4]); 
            lab6.Text = Convert.ToString(Powerball[5]); 

            if (Convert.ToInt32(txt1.Text) < 1 || Convert.ToInt32(txt2.Text) < 1 || Convert.ToInt32(txt3.Text) < 1 || Convert.ToInt32(txt4.Text) < 1 || Convert.ToInt32(txt5.Text) < 1 || Convert.ToInt32(txt6.Text) < 1)
                { 
                MessageBox.Show("Please enter number between 1 and 49!");
            }


            if( Convert.ToInt32(txt1.Text)> 49 || Convert.ToInt32(txt2.Text) > 49 || Convert.ToInt32(txt3.Text) > 49 || Convert.ToInt32(txt4.Text) > 49 || Convert.ToInt32(txt5.Text) > 49 || Convert.ToInt32(txt6.Text) > 49)
                { 

                MessageBox.Show("Please enter number between 1 and 49!"); 
            }


            int[] guess = new int[6]; 
            guess[0] = Convert.ToInt32(txt1.Text); 
            guess[1] = Convert.ToInt32(txt2.Text); 
            guess[2] = Convert.ToInt32(txt3.Text); 
            guess[3] = Convert.ToInt32(txt4.Text); 
            guess[4] = Convert.ToInt32(txt5.Text); 
            guess[5] = Convert.ToInt32(txt6.Text); 


            int counter = 0; 
            for (int a = 0; a < 6; a++)
            {
                for (int b = 0; b < 6; b++)
                {
                    if (Powerball[b]==guess[a])
                {
                    counter++;
                    
                }     
                }
            }

            if (counter > 2)
            {
                MessageBox.Show("Congratulations -" + " "+ counter);
            }
            else MessageBox.Show("Unfortunately");





        }

      
    }
}
