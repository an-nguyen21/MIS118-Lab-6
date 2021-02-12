//
//Class: frmScoreCalculator
//Author: Annie Nguyen
//Date: 2/9/2021
//Lab: Lab 6 Part 1
//Class Description: Using arrays to calculate scores
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._0
{
    public partial class frmScoreCalculator : Form
    {
        public frmScoreCalculator()
        {
            InitializeComponent();
        }

        //Creating an array
        int[] SingleArray = new int[20];
        int scoreCount = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes form
            this.Close();
        }

        
        public void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Convert score to int and increase scoreCount by 1 each time
                int userscore = Convert.ToInt32(txtScore.Text);
                
                scoreCount++;

                
                SingleArray[scoreCount] = userscore;
                //Display scorecount in textbox
                txtScoreCount.Text = scoreCount.ToString();


                txtScore.Focus();
                txtScore.SelectAll();

                //Add scores together and display in Score total
                int sum = SingleArray.Sum();
                
                txtScoreTotal.Text = Convert.ToString(sum);

                //Calculating average
                decimal average = sum / scoreCount;
                txtAverage.Text = Convert.ToString(average);
              
                
            }
            //format exception for input errors
            catch (FormatException)
            {
                MessageBox.Show("Invalid data type. Please enter an integer.", "Entry Error");
            }

            //catch other types of errors and display message
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        

             
            
        

        public void btnDisplayScores_Click(object sender, EventArgs e)
        {
            //linq statement that sorts array list and display in order from least to greatest value
            int[] numberScore = SingleArray.Where(v => v > 0).ToArray();
            Array.Sort(numberScore);

            string numbersString = "";
            for (int i = 0; i < numberScore.Length; i++)
                numbersString += numberScore[i] + "\n";
               
            MessageBox.Show(numbersString, "Sorted Scores");
        }

        

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            //Clears numbers in all fields
            this.txtScore.Clear();
            this.txtScoreCount.Clear();
            this.txtAverage.Clear();
            this.txtScoreTotal.Clear();
            this.scoreCount = 0;
            this.SingleArray = new int[20];


            txtScore.Focus();
        }
    }
}
