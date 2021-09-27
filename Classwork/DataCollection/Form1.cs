// James Hooper
// data Collection
// 9/23/21



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataCollection
{
    public partial class dataForm : Form
    {
        //this is the array of data used to stor data
        string[] data;
        public dataForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataForm_Load(object sender, EventArgs e)
        {
            // This is the window that shows before the form is shown
            String name = "User";
            
            MessageBox.Show("Warning "+ name + " if you dont fill out the folowing form you will not get a prize", "Form Approaching", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void formSubmit_btn_Click(object sender, EventArgs e)
        {
            // Thanks the user fore the data
            data[0] = firstName_txtbox.Text;
            MessageBox.Show("thanks " + data[0]+" "+data[1]);
        }

        private void firstName_txtbox_TextChanged(object sender, EventArgs e)
        {
            // collecting the data everytime they change a box
            data[0] = firstName_txtbox.Text;
            data[1] = lastName_txtbox.Text;
            data[2] = favIceCream_txtbox.Text;
            data[3] = favLicorice_txtbox.Text;
            data[4] = favChip_txtbox.Text;
            data[5] = favFruit_txtbox.Text;
            data[6] = favVegtable_txtbox.Text;
            data[7] = favCandy_txtbox.Text;
            data[8] = favchicken_txtbox.Text;
            data[9] = firstName_txtbox.Text;
            data[10] = firstName_txtbox.Text;
            data[11] = firstName_txtbox.Text;
            data[12] = firstName_txtbox.Text;
            data[13] = firstName_txtbox.Text;
            data[14] = firstName_txtbox.Text;
            data[15] = firstName_txtbox.Text;
            data[16] = firstName_txtbox.Text;
            data[17] = firstName_txtbox.Text;
            data[18] = firstName_txtbox.Text;
            data[19] = firstName_txtbox.Text;
            data[20] = firstName_txtbox.Text;
            data[21] = firstName_txtbox.Text;
            data[22] = firstName_txtbox.Text;
            data[23] = firstName_txtbox.Text;
            data[24] = firstName_txtbox.Text;
            data[25] = firstName_txtbox.Text;
            data[26] = firstName_txtbox.Text;
            data[27] = firstName_txtbox.Text;
            data[28] = firstName_txtbox.Text;
            data[29] = firstName_txtbox.Text;
        }
    }
}
