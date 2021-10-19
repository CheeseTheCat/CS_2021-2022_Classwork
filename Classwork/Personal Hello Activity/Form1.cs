//James Hooper
//10/19/2021
//Personal Hello Activity


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Hello_Activity
{
    public partial class PersonalHelloActivity : Form
    {
        public PersonalHelloActivity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this is a message box");
        }
    }
}
