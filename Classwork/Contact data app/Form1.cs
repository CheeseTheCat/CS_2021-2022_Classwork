using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_data_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logo_picbx_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MOJANG AB HEADQUARTERS - Software Development\nSöder Mälarstrand 43\nStockholm, Sweden\nContact List 1.0\nWritten by: James Hooper");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ContactsInfo' table. You can move, or remove it, as needed.
            this.contactsInfoTableAdapter.Fill(this.database1DataSet.ContactsInfo);

        }

        private void textbox_first_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactsInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactsInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
