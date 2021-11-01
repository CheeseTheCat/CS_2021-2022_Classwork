using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTacToe
{
    public partial class ticTacToeForm : Form
    {
        public ticTacToeForm()
        {
            InitializeComponent();
        }

        public string XToken = "X";
        public string OToken = "O";
        public string turn = "X";
        public int xScore = 0;
        public int oScore = 0;
        private void topLeftSquareBttn_Click(object sender, EventArgs e)
        {
            // set the text of the button to the turn's token
            Button button = (Button) sender;
            if (button.Text == "")
            {
                button.Text = turn;
                
            }
            else
            {
                return;
            }

            // Check for win
            // Switch the turn
            switchTurn();
            // Update Text
            update_message();
            // Disable button so it can't be clicked

        }

        private string checkForWin()
        {
            // Cheese for a win and return the winning token
            string winner = XToken;

            return winner;
        }

        private void switchTurn()
        {
            // switch our turns

            if (turn != XToken)
            {
                turn = XToken;
            }
            else
            {
                turn = OToken;
            }

        }

        private void update_scores()
        {
            // update the player scores
        }

        private void update_message()
        {
            // Update the hud message
            turnLbl.Text = "Turn: " + turn;
        }

        private void resetBttn_Click(object sender, EventArgs e)
        {
            // Clear our board
            turn = XToken;
            update_message();
            topLeftSquareBttn.Text = "";
            topMidBttn.Text = "";
            topRightBttn.Text = "";
            midLeftBttn.Text = "";
            midMidBttn.Text = "";
            midRightBttn.Text = "";
            botmLeftBttn.Text = "";
            botmMidBttn.Text = "";
            botmRightBttn.Text = "";
        }
    }
}
