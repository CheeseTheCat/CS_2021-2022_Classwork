// James Hooper
// 9/2021
// calculator


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculator : Form
    {
        String output;
        int operand1;
        int operand2;
        String opp;


        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {
            output_txtbox.Text = "0";
            //setting the output to zero when the app is launched
            output = "0";

        }

        private void bttnEquals_Click(object sender, EventArgs e)
        {
            
        }

        private void bttn7_Click(object sender, EventArgs e)
        {
            // types 7 into the calculator output textbox
            // and if the output is 0 it replaces it
            if(output == "0")
            {
                output = "7"; 
            }
            else
            {
                output = output + "7";
            }
            output_txtbox.Text = output;
        }

        private void bttn8_Click(object sender, EventArgs e)
        {
            //types 8 into the calculator output textbox
            // and if the output is 0 it replaces it
            if (output == "0")
            {
                output = "8";
            }
            else
            {
                output = output + "8";
            }
            
            output_txtbox.Text = output;
        }

        private void bttn9_Click(object sender, EventArgs e)
        {
            //types 9 into the calculator output textbox
            // and if the output is 0 it replaces it
            if(output == "0")
            {
                output = "9"; 
            }
            else
            {
                output = output + "9";
            }
            output_txtbox.Text = output;
        }

        private void bttn4_Click(object sender, EventArgs e)
        {
            //types 4 into the calculator output textbox
            // and if the output is 0 it replaces it
            if(output == "0")
            {
                output = "4"; 
            }
            else
            {
                output = output + "4";
            }
            output_txtbox.Text = output;
        }             
                      
        private void bttn5_Click(object sender, EventArgs e)
        {             
            //types 5 into the calculator output textbox
            // and if the output is 0 it replaces it
            if(output == "0")
            {
                output = "5"; 
            }
            else
            {
                output = output + "5";
            }
            output_txtbox.Text = output;
        }

        private void bttn6_Click(object sender, EventArgs e)
        {
            //types 6 into the calculator output textbox
            // and if the output is 0 it replaces it
            if(output == "0")
            {
                output = "6"; 
            }
            else
            {
                output = output + "6";
            }
            output_txtbox.Text = output;
        }

        private void bttn1_Click(object sender, EventArgs e)
        {
            //types 1 into the calculator output textbox
            // and if the output is 0 it replaces it
            if(output == "0")
            {
                output = "1"; 
            }
            else
            {
                output = output + "1";
            }
            output_txtbox.Text = output;
        }

        private void bttn2_Click(object sender, EventArgs e)
        {
            //types 2 into the calculator output textbox
            // and if the output is 0 it replaces it
            if(output == "0")
            {
                output = "2"; 
            }
            else
            {
                output = output + "2";
            }
            output_txtbox.Text = output;
        }

        private void bttn3_Click(object sender, EventArgs e)
        {
            //types 3 into the calculator output textbox
            // and if the output is 0 it replaces it
            if(output == "0")
            {
                output = "3"; 
            }
            else
            {
                output = output + "3";
            }
            output_txtbox.Text = output;
        }

        private void bttn0_Click(object sender, EventArgs e)
        {
            //types 0 into the calculator output textbox
            // and if the output is 0 it replaces it
            if(output == "0")
            {
                output = "0"; 
            }
            else
            {
                output = output + "0";
            }
            output_txtbox.Text = output;
        }

        private void bttndot_Click(object sender, EventArgs e)
        {

        }

        private void bttnDiv_Click(object sender, EventArgs e)
        {

        }

        private void bttnTimes_Click(object sender, EventArgs e)
        {

        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            operand1 = Int32.Parse(output);
        }

        private void bttnSub_Click(object sender, EventArgs e)
        {

        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            output = "0";
            output_txtbox.Text = output;
        }
    }
}
