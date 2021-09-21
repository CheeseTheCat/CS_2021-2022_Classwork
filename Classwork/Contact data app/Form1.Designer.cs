
namespace Contact_data_app
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneNumLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label jobTitleLabel;
            this.logo_picbx = new System.Windows.Forms.PictureBox();
            this.database1DataSet = new Contact_data_app.Database1DataSet();
            this.contactsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsInfoTableAdapter = new Contact_data_app.Database1DataSetTableAdapters.ContactsInfoTableAdapter();
            this.tableAdapterManager = new Contact_data_app.Database1DataSetTableAdapters.TableAdapterManager();
            this.contactsInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.contactsInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.jobTitleTextBox = new System.Windows.Forms.TextBox();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneNumLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            jobTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsInfoBindingNavigator)).BeginInit();
            this.contactsInfoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo_picbx
            // 
            this.logo_picbx.BackColor = System.Drawing.Color.White;
            this.logo_picbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo_picbx.BackgroundImage")));
            this.logo_picbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo_picbx.Location = new System.Drawing.Point(640, 45);
            this.logo_picbx.Name = "logo_picbx";
            this.logo_picbx.Size = new System.Drawing.Size(261, 171);
            this.logo_picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_picbx.TabIndex = 12;
            this.logo_picbx.TabStop = false;
            this.logo_picbx.Click += new System.EventHandler(this.logo_picbx_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactsInfoBindingSource
            // 
            this.contactsInfoBindingSource.DataMember = "ContactsInfo";
            this.contactsInfoBindingSource.DataSource = this.database1DataSet;
            // 
            // contactsInfoTableAdapter
            // 
            this.contactsInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContactsInfoTableAdapter = this.contactsInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Contact_data_app.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contactsInfoBindingNavigator
            // 
            this.contactsInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contactsInfoBindingNavigator.BindingSource = this.contactsInfoBindingSource;
            this.contactsInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contactsInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contactsInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.contactsInfoBindingNavigatorSaveItem});
            this.contactsInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contactsInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contactsInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contactsInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contactsInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contactsInfoBindingNavigator.Name = "contactsInfoBindingNavigator";
            this.contactsInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contactsInfoBindingNavigator.Size = new System.Drawing.Size(913, 25);
            this.contactsInfoBindingNavigator.TabIndex = 13;
            this.contactsInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // contactsInfoBindingNavigatorSaveItem
            // 
            this.contactsInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contactsInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contactsInfoBindingNavigatorSaveItem.Image")));
            this.contactsInfoBindingNavigatorSaveItem.Name = "contactsInfoBindingNavigatorSaveItem";
            this.contactsInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contactsInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.contactsInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.contactsInfoBindingNavigatorSaveItem_Click);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(12, 48);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 13;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsInfoBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(78, 45);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 14;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(37, 87);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 14;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsInfoBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(104, 84);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 15;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(79, 128);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsInfoBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(120, 125);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 16;
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Location = new System.Drawing.Point(95, 157);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new System.Drawing.Size(66, 13);
            phoneNumLabel.TabIndex = 16;
            phoneNumLabel.Text = "Phone Num:";
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsInfoBindingSource, "PhoneNum", true));
            this.phoneNumTextBox.Location = new System.Drawing.Point(167, 154);
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumTextBox.TabIndex = 17;
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(126, 188);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(54, 13);
            companyLabel.TabIndex = 17;
            companyLabel.Text = "Company:";
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsInfoBindingSource, "Company", true));
            this.companyTextBox.Location = new System.Drawing.Point(186, 185);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyTextBox.TabIndex = 18;
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Location = new System.Drawing.Point(157, 223);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(33, 13);
            dOBLabel.TabIndex = 18;
            dOBLabel.Text = "DOB:";
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contactsInfoBindingSource, "DOB", true));
            this.dOBDateTimePicker.Location = new System.Drawing.Point(196, 219);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dOBDateTimePicker.TabIndex = 19;
            // 
            // jobTitleLabel
            // 
            jobTitleLabel.AutoSize = true;
            jobTitleLabel.Location = new System.Drawing.Point(193, 263);
            jobTitleLabel.Name = "jobTitleLabel";
            jobTitleLabel.Size = new System.Drawing.Size(50, 13);
            jobTitleLabel.TabIndex = 19;
            jobTitleLabel.Text = "Job Title:";
            // 
            // jobTitleTextBox
            // 
            this.jobTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsInfoBindingSource, "JobTitle", true));
            this.jobTitleTextBox.Location = new System.Drawing.Point(249, 260);
            this.jobTitleTextBox.Name = "jobTitleTextBox";
            this.jobTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.jobTitleTextBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(913, 497);
            this.Controls.Add(jobTitleLabel);
            this.Controls.Add(this.jobTitleTextBox);
            this.Controls.Add(dOBLabel);
            this.Controls.Add(this.dOBDateTimePicker);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(phoneNumLabel);
            this.Controls.Add(this.phoneNumTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.contactsInfoBindingNavigator);
            this.Controls.Add(this.logo_picbx);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Company DataBase";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_picbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsInfoBindingNavigator)).EndInit();
            this.contactsInfoBindingNavigator.ResumeLayout(false);
            this.contactsInfoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logo_picbx;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource contactsInfoBindingSource;
        private Database1DataSetTableAdapters.ContactsInfoTableAdapter contactsInfoTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contactsInfoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton contactsInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneNumTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.TextBox jobTitleTextBox;
    }
}

