//
//Class: frmTeamRoster
//Author: Annie Nguyen
//Date: 2/10/2021
//Lab: Lab 6 Part 2
//Class Description: Using an array to create a team roster that will display how many people are in the
//team and how many spots are left
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

namespace _2._0
{
    public partial class frmTeamRoster : Form
    {
        public frmTeamRoster()
        {
            InitializeComponent();
        }

        //Declaring gloabl array
        int[] TeamRosterArray;
        int intSpotsOpen = 0, intLimit = 0, i = 0;


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //Convert to int and pass to CreateArray method
                int size = Convert.ToInt32(txtNumPeople.Text);
                CreateArray(size);
            }

            //Exception handling
            catch (FormatException)
            {
                MessageBox.Show("Incorrect format. Please enter an integer.", "Format Error");
            }

            catch (ArgumentNullException)
            {
                MessageBox.Show("Field cannot be blank. Please enter a value.", "Error");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnAddToTeam_Click(object sender, EventArgs e)
        {
            try
            {
                string memberName = Convert.ToString(txtTeamName.Text);

                AddTeamMember(memberName);
               
            }          
            //catches exceptions and displays error message
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearRoster();
        }

        public void ClearRoster()
        {
            //Clears all fields in application
            lstTeamMembers.Items.Clear();
            txtNumPeople.Text = "";
            txtTeamName.Text = "";
            lblTeamMem.Text = "0";
            lblSpots.Text = "0";

            //Allows users to enter array size and click submit button
            txtNumPeople.Enabled = true;
            this.btnSubmit.Enabled = true;
        }

        public void AddTeamMember(string memberName)
        {
            if (intSpotsOpen > 0 && i < intLimit)
            {
                //Decrease spot open
                intSpotsOpen -= 1;

                //Adds one spot to team members
                i += 1;

                //Display remaining slots open
                this.lblSpots.Text = intSpotsOpen.ToString();

                //Show how many team members there are
                this.lblTeamMem.Text = i.ToString();

                //Adds team member name to listbox
                lstTeamMembers.Items.Add(memberName);
            }
            //Tells user there are no spots left
            else
                MessageBox.Show("There are no spots open.");
        }
        public void CreateArray(int size)
        {
            //Get user input and create array, array size and spots open dependent on number that user inputs
            TeamRosterArray = new int[size];
            intLimit = size;
            intSpotsOpen = size;


            //Disable new array creation
            txtNumPeople.Enabled = false;
            this.btnSubmit.Enabled = false;
        }
    }
}
