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
        double operand1;
        double operand2;
        String opp = "";


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
            // things

            double x = 0;
            operand2 = double.Parse(output);
            if (opp != "")
            {
                if (opp == "+")
                {
                    x = operand1 + operand2;
                }
                else if (opp == "-")
                {
                    x = operand1 - operand2;
                }
                else if (opp == "*")
                {
                    x = operand1 * operand2;
                }
                else if (opp == "/")
                {
                    if (operand2 != 0)
                    {
                        x = operand1 / operand2;
                    }
                    else
                    {
                        // If they try to divide by zero
                        MessageBox.Show("YoUr CalCulAtOr hAs dIeD", "iT diEd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                output = x.ToString();
                output_txtbox.Text = output;
                opp = "";

            }
            else
            {
                return;
            }


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
            if (output.Contains("."))
            {
                return;
            }
            else
            {
                output = output + ".";
                output_txtbox.Text = output;
            }
        }

        private void bttnDiv_Click(object sender, EventArgs e)
        {
            // storing operand1 and setting the opperator to "/" then clearing screen
            operand1 = double.Parse(output);
            opp = "/";
            output = "0";
            output_txtbox.Text = output;
        }

        private void bttnTimes_Click(object sender, EventArgs e)
        {
            // storing operand1 and setting the opperator to "*" then clearing screen
            operand1 = double.Parse(output);
            opp = "*";
            output = "0";
            output_txtbox.Text = output;
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            // storing operand1 and setting the opperator to "+" then clearing screen
            operand1 = double.Parse(output);
            opp = "+";
            output = "0";
            output_txtbox.Text = output;
        }

        private void bttnSub_Click(object sender, EventArgs e)
        {
            // storing operand1 and setting the opperator to "-" then clearing screen
            operand1 = double.Parse(output);
            opp = "-";
            output = "0";
            output_txtbox.Text = output;
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            // Clears everything
            output = "0";
            operand1 = 0;
            operand2 = 0;
            opp = "";
            output_txtbox.Text = output;
        }

        private void bttnNeg_Click(object sender, EventArgs e)
        {
            bool negitive = output.StartsWith("-");

            if (negitive)
            {
                output = output.Remove(0, 1);
            }
            else
            {
                output = "-" + output;
            }

            output_txtbox.Text = output;
        }

        private void bttnpie(object sender, EventArgs e)
        {
            output = "3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679";

            output_txtbox.Text = output;
        }
    }
}
