
namespace dataTypes
{
    partial class dataTypes
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
            this.numDataBttn = new System.Windows.Forms.Button();
            this.boolDataBttn = new System.Windows.Forms.Button();
            this.constantDataBttn = new System.Windows.Forms.Button();
            this.stringDataBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numDataBttn
            // 
            this.numDataBttn.Location = new System.Drawing.Point(12, 12);
            this.numDataBttn.Name = "numDataBttn";
            this.numDataBttn.Size = new System.Drawing.Size(187, 23);
            this.numDataBttn.TabIndex = 0;
            this.numDataBttn.Text = "Numeric Data";
            this.numDataBttn.UseVisualStyleBackColor = true;
            this.numDataBttn.Click += new System.EventHandler(this.numDataBttn_Click);
            // 
            // boolDataBttn
            // 
            this.boolDataBttn.Location = new System.Drawing.Point(12, 78);
            this.boolDataBttn.Name = "boolDataBttn";
            this.boolDataBttn.Size = new System.Drawing.Size(187, 23);
            this.boolDataBttn.TabIndex = 1;
            this.boolDataBttn.Text = "Bool Data";
            this.boolDataBttn.UseVisualStyleBackColor = true;
            // 
            // constantDataBttn
            // 
            this.constantDataBttn.Location = new System.Drawing.Point(12, 144);
            this.constantDataBttn.Name = "constantDataBttn";
            this.constantDataBttn.Size = new System.Drawing.Size(187, 23);
            this.constantDataBttn.TabIndex = 2;
            this.constantDataBttn.Text = "Constant Data";
            this.constantDataBttn.UseVisualStyleBackColor = true;
            // 
            // stringDataBttn
            // 
            this.stringDataBttn.Location = new System.Drawing.Point(12, 207);
            this.stringDataBttn.Name = "stringDataBttn";
            this.stringDataBttn.Size = new System.Drawing.Size(187, 23);
            this.stringDataBttn.TabIndex = 3;
            this.stringDataBttn.Text = "String Data";
            this.stringDataBttn.UseVisualStyleBackColor = true;
            // 
            // dataTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 273);
            this.Controls.Add(this.stringDataBttn);
            this.Controls.Add(this.constantDataBttn);
            this.Controls.Add(this.boolDataBttn);
            this.Controls.Add(this.numDataBttn);
            this.Name = "dataTypes";
            this.Text = "Data Types";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button numDataBttn;
        private System.Windows.Forms.Button boolDataBttn;
        private System.Windows.Forms.Button constantDataBttn;
        private System.Windows.Forms.Button stringDataBttn;
    }
}

