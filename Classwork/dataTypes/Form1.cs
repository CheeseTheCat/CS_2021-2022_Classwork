using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataTypes
{
    public partial class dataTypes : Form
    {
        public dataTypes()
        {
            InitializeComponent();
        }

        private void numDataBttn_Click(object sender, EventArgs e)
        {
            // Create and  initialize an integer variable
            int myInteger = 123;

            //  Display the value of 'myInteger' in a Message Box
            // using  the 'ToString' method to convert the number to text
            MessageBox.Show("myInteger: " + myInteger.ToString());
        }
    }
}
