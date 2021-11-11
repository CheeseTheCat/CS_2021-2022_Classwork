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
        Button[] grid = new Button[9];

        private void ticTacToeForm_Load(object sender, EventArgs e)
        {
            grid[0] = topLeftSquareBttn;
            grid[1] = topMidBttn;
            grid[2] = topRightBttn;
            grid[3] = midLeftBttn;
            grid[4] = midMidBttn;
            grid[5] = midRightBttn;
            grid[6] = botmLeftBttn;
            grid[7] = botmMidBttn;
            grid[8] = botmRightBttn;
        }

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
            string win = checkForWin();
            // Update scores
            if (win != "")
            {
                if (win == XToken)
                {
                    xScore++;
                }
                else
                {
                    oScore++;
                }
                update_scores();
            }
            // Reset board
            else
            {
            // Switch the turn
                switchTurn();
            }
            
            // Update Text
            update_message();
            // Disable button so it can't be clicked

        }

        private string checkForWin()
        {
            string win = "";
            for (int i = 0; i < 3; i++)
            {
                string first = grid[0 + i * 3].Text;
                string second = grid[1 + i * 3].Text;
                string third = grid[2 + i * 3].Text;

                if ((first == second && first == third) && first != "")
                {
                    win = first;
                }
            }
            if (win == "")
            {
                for (int i = 0; i < 3; i++)
                {
                    string first = grid[0 + i].Text;
                    string second = grid[3 + i].Text;
                    string third = grid[6 + i].Text;

                    if ((first == second && first == third) && first != "")
                    {
                        win = first;
                    }
                }
            }
            if (win == "")
            {
                if ((grid[0] == grid[4] && grid[0] == grid[8]) && grid[0].Text != "")
                {
                    win = grid[0].Text;
                }
            }
            if (win == "")
            {
                if ((grid[2] == grid[4] && grid[0] == grid[6]) && grid[0].Text != "")
                {
                    win = grid[0].Text;
                }
            }
            return win;
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
            topLeftSquareBttn.Text = "";
            topMidBttn.Text = "";
            topRightBttn.Text = "";
            midLeftBttn.Text = "";
            midMidBttn.Text = "";
            midRightBttn.Text = "";
            botmLeftBttn.Text = "";
            botmMidBttn.Text = "";
            botmRightBttn.Text = "";
            update_message();
        }

        private void scoreResetBttn_Click(object sender, EventArgs e)
        {

        }

        private void pieBttn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3.141592653589793238462643383279502884197169399" +
                "375105820974944592307816406286208998628034825342117067982" +
                "148086513282306647093844609550582231725359408128481117450" +
                "284102701938521105559644622948954930381964428810975665933" +
                "4461284756482337867831652712019091"+
                "45648566923460348610454326648213393607260249141273"+
                "72458700660631558817488152092096282925409171536436"+
                "78925903600113305305488204665213841469519415116094"+
                "33057270365759591953092186117381932611793105118548"+
                "07446237996274956735188575272489122793818301194912"+
                "98336733624406566430860213949463952247371907021798"+
                "60943702770539217176293176752384674818467669405132"+
                "00056812714526356082778577134275778960917363717872"+
                "14684409012249534301465495853710507922796892589235"+
                "42019956112129021960864034418159813629774771309960"+
                "51870721134999999837297804995105973173281609631859"+
                "50244594553469083026425223082533446850352619311881"+
                "71010003137838752886587533208381420617177669147303"+
                "59825349042875546873115956286388235378759375195778"+
                "18577805321712268066130019278766111959092164201989");
        }

        
    }
}
