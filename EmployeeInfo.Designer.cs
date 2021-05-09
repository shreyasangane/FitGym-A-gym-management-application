namespace FITZONE
{
    partial class EmployeeInfo
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
            this.lblcustomer = new System.Windows.Forms.PictureBox();
            this.rbempfemale = new System.Windows.Forms.RadioButton();
            this.rbempmale = new System.Windows.Forms.RadioButton();
            this.txtempage = new System.Windows.Forms.TextBox();
            this.lblempgender = new System.Windows.Forms.Label();
            this.txtempemail = new System.Windows.Forms.TextBox();
            this.lblempemail = new System.Windows.Forms.Label();
            this.txtempphone = new System.Windows.Forms.TextBox();
            this.lblempphone = new System.Windows.Forms.Label();
            this.txtempaddress = new System.Windows.Forms.TextBox();
            this.lblempaddress = new System.Windows.Forms.Label();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.lblempname = new System.Windows.Forms.Label();
            this.lblempage = new System.Windows.Forms.Label();
            this.lblshift = new System.Windows.Forms.Label();
            this.txtempsalary = new System.Windows.Forms.TextBox();
            this.lblempsalary = new System.Windows.Forms.Label();
            this.cbempshift = new System.Windows.Forms.ComboBox();
            this.btnempclear = new System.Windows.Forms.Button();
            this.btnempsubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lblcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcustomer
            // 
            this.lblcustomer.Image = global::FITZONE.Properties.Resources.FitZone_Label2;
            this.lblcustomer.Location = new System.Drawing.Point(384, 12);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(160, 77);
            this.lblcustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lblcustomer.TabIndex = 1;
            this.lblcustomer.TabStop = false;
            this.lblcustomer.Click += new System.EventHandler(this.lblcustomer_Click);
            // 
            // rbempfemale
            // 
            this.rbempfemale.AutoSize = true;
            this.rbempfemale.Location = new System.Drawing.Point(651, 241);
            this.rbempfemale.Name = "rbempfemale";
            this.rbempfemale.Size = new System.Drawing.Size(59, 17);
            this.rbempfemale.TabIndex = 48;
            this.rbempfemale.TabStop = true;
            this.rbempfemale.Text = "Female";
            this.rbempfemale.UseVisualStyleBackColor = true;
            // 
            // rbempmale
            // 
            this.rbempmale.AutoSize = true;
            this.rbempmale.Location = new System.Drawing.Point(563, 239);
            this.rbempmale.Name = "rbempmale";
            this.rbempmale.Size = new System.Drawing.Size(48, 17);
            this.rbempmale.TabIndex = 47;
            this.rbempmale.TabStop = true;
            this.rbempmale.Text = "Male";
            this.rbempmale.UseVisualStyleBackColor = true;
            // 
            // txtempage
            // 
            this.txtempage.Location = new System.Drawing.Point(563, 301);
            this.txtempage.Name = "txtempage";
            this.txtempage.Size = new System.Drawing.Size(162, 20);
            this.txtempage.TabIndex = 46;
            // 
            // lblempgender
            // 
            this.lblempgender.AutoSize = true;
            this.lblempgender.Location = new System.Drawing.Point(497, 241);
            this.lblempgender.Name = "lblempgender";
            this.lblempgender.Size = new System.Drawing.Size(45, 13);
            this.lblempgender.TabIndex = 45;
            this.lblempgender.Text = "Gender:";
            // 
            // txtempemail
            // 
            this.txtempemail.Location = new System.Drawing.Point(247, 297);
            this.txtempemail.Name = "txtempemail";
            this.txtempemail.Size = new System.Drawing.Size(162, 20);
            this.txtempemail.TabIndex = 44;
            // 
            // lblempemail
            // 
            this.lblempemail.AutoSize = true;
            this.lblempemail.Location = new System.Drawing.Point(181, 304);
            this.lblempemail.Name = "lblempemail";
            this.lblempemail.Size = new System.Drawing.Size(49, 13);
            this.lblempemail.TabIndex = 43;
            this.lblempemail.Text = "Email ID:";
            // 
            // txtempphone
            // 
            this.txtempphone.Location = new System.Drawing.Point(247, 252);
            this.txtempphone.Name = "txtempphone";
            this.txtempphone.Size = new System.Drawing.Size(162, 20);
            this.txtempphone.TabIndex = 42;
            // 
            // lblempphone
            // 
            this.lblempphone.AutoSize = true;
            this.lblempphone.Location = new System.Drawing.Point(181, 255);
            this.lblempphone.Name = "lblempphone";
            this.lblempphone.Size = new System.Drawing.Size(55, 13);
            this.lblempphone.TabIndex = 41;
            this.lblempphone.Text = "PhoneNo:";
            // 
            // txtempaddress
            // 
            this.txtempaddress.Location = new System.Drawing.Point(247, 157);
            this.txtempaddress.Multiline = true;
            this.txtempaddress.Name = "txtempaddress";
            this.txtempaddress.Size = new System.Drawing.Size(162, 67);
            this.txtempaddress.TabIndex = 40;
            // 
            // lblempaddress
            // 
            this.lblempaddress.AutoSize = true;
            this.lblempaddress.Location = new System.Drawing.Point(181, 157);
            this.lblempaddress.Name = "lblempaddress";
            this.lblempaddress.Size = new System.Drawing.Size(45, 13);
            this.lblempaddress.TabIndex = 39;
            this.lblempaddress.Text = "Address";
            // 
            // txtempname
            // 
            this.txtempname.Location = new System.Drawing.Point(247, 115);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(162, 20);
            this.txtempname.TabIndex = 38;
            this.txtempname.TextChanged += new System.EventHandler(this.txtempname_TextChanged);
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Location = new System.Drawing.Point(181, 115);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(38, 13);
            this.lblempname.TabIndex = 37;
            this.lblempname.Text = "Name:";
            // 
            // lblempage
            // 
            this.lblempage.AutoSize = true;
            this.lblempage.Location = new System.Drawing.Point(497, 308);
            this.lblempage.Name = "lblempage";
            this.lblempage.Size = new System.Drawing.Size(26, 13);
            this.lblempage.TabIndex = 49;
            this.lblempage.Text = "Age";
            // 
            // lblshift
            // 
            this.lblshift.AutoSize = true;
            this.lblshift.Location = new System.Drawing.Point(500, 175);
            this.lblshift.Name = "lblshift";
            this.lblshift.Size = new System.Drawing.Size(57, 13);
            this.lblshift.TabIndex = 52;
            this.lblshift.Text = "Shift Time:";
            // 
            // txtempsalary
            // 
            this.txtempsalary.Location = new System.Drawing.Point(563, 115);
            this.txtempsalary.Name = "txtempsalary";
            this.txtempsalary.Size = new System.Drawing.Size(162, 20);
            this.txtempsalary.TabIndex = 51;
            // 
            // lblempsalary
            // 
            this.lblempsalary.AutoSize = true;
            this.lblempsalary.Location = new System.Drawing.Point(497, 118);
            this.lblempsalary.Name = "lblempsalary";
            this.lblempsalary.Size = new System.Drawing.Size(39, 13);
            this.lblempsalary.TabIndex = 50;
            this.lblempsalary.Text = "Salary:";
            // 
            // cbempshift
            // 
            this.cbempshift.FormattingEnabled = true;
            this.cbempshift.Items.AddRange(new object[] {
            "6 AM - 2 PM",
            "3 PM - 11 PM"});
            this.cbempshift.Location = new System.Drawing.Point(563, 172);
            this.cbempshift.Name = "cbempshift";
            this.cbempshift.Size = new System.Drawing.Size(162, 21);
            this.cbempshift.TabIndex = 53;
            // 
            // btnempclear
            // 
            this.btnempclear.Location = new System.Drawing.Point(493, 410);
            this.btnempclear.Name = "btnempclear";
            this.btnempclear.Size = new System.Drawing.Size(126, 35);
            this.btnempclear.TabIndex = 55;
            this.btnempclear.Text = "Clear";
            this.btnempclear.UseVisualStyleBackColor = true;
            this.btnempclear.Click += new System.EventHandler(this.btnemp_Clear);
            // 
            // btnempsubmit
            // 
            this.btnempsubmit.Location = new System.Drawing.Point(317, 410);
            this.btnempsubmit.Name = "btnempsubmit";
            this.btnempsubmit.Size = new System.Drawing.Size(134, 35);
            this.btnempsubmit.TabIndex = 54;
            this.btnempsubmit.Text = "Submit";
            this.btnempsubmit.UseVisualStyleBackColor = true;
            this.btnempsubmit.Click += new System.EventHandler(this.btnempsubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 31);
            this.label2.TabIndex = 56;
            this.label2.Text = "Employee Details";
            // 
            // EmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnempclear);
            this.Controls.Add(this.btnempsubmit);
            this.Controls.Add(this.cbempshift);
            this.Controls.Add(this.lblshift);
            this.Controls.Add(this.txtempsalary);
            this.Controls.Add(this.lblempsalary);
            this.Controls.Add(this.lblempage);
            this.Controls.Add(this.rbempfemale);
            this.Controls.Add(this.rbempmale);
            this.Controls.Add(this.txtempage);
            this.Controls.Add(this.lblempgender);
            this.Controls.Add(this.txtempemail);
            this.Controls.Add(this.lblempemail);
            this.Controls.Add(this.txtempphone);
            this.Controls.Add(this.lblempphone);
            this.Controls.Add(this.txtempaddress);
            this.Controls.Add(this.lblempaddress);
            this.Controls.Add(this.txtempname);
            this.Controls.Add(this.lblempname);
            this.Controls.Add(this.lblcustomer);
            this.Name = "EmployeeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeInfo";
            ((System.ComponentModel.ISupportInitialize)(this.lblcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lblcustomer;
        private System.Windows.Forms.RadioButton rbempfemale;
        private System.Windows.Forms.RadioButton rbempmale;
        private System.Windows.Forms.TextBox txtempage;
        private System.Windows.Forms.Label lblempgender;
        private System.Windows.Forms.TextBox txtempemail;
        private System.Windows.Forms.Label lblempemail;
        private System.Windows.Forms.TextBox txtempphone;
        private System.Windows.Forms.Label lblempphone;
        private System.Windows.Forms.TextBox txtempaddress;
        private System.Windows.Forms.Label lblempaddress;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label lblempage;
        private System.Windows.Forms.Label lblshift;
        private System.Windows.Forms.TextBox txtempsalary;
        private System.Windows.Forms.Label lblempsalary;
        private System.Windows.Forms.ComboBox cbempshift;
        private System.Windows.Forms.Button btnempclear;
        private System.Windows.Forms.Button btnempsubmit;
        private System.Windows.Forms.Label label2;
    }
}