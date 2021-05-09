namespace FITZONE
{
    partial class AddUpdateProgress
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
            this.lblsearchcust = new System.Windows.Forms.Label();
            this.cbsearchcust = new System.Windows.Forms.ComboBox();
            this.customerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fITZONEDataSet8 = new FITZONE.FITZONEDataSet8();
            this.lblbmi = new System.Windows.Forms.Label();
            this.tbday = new System.Windows.Forms.TextBox();
            this.lblday = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.tbdate = new System.Windows.Forms.TextBox();
            this.lblcustomer = new System.Windows.Forms.PictureBox();
            this.lblTF = new System.Windows.Forms.Label();
            this.btnUpdateCustExe = new System.Windows.Forms.Button();
            this.customer_InfoTableAdapter = new FITZONE.FITZONEDataSet8TableAdapters.Customer_InfoTableAdapter();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.txtFocus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsearchcust
            // 
            this.lblsearchcust.AutoSize = true;
            this.lblsearchcust.Location = new System.Drawing.Point(37, 30);
            this.lblsearchcust.Name = "lblsearchcust";
            this.lblsearchcust.Size = new System.Drawing.Size(85, 13);
            this.lblsearchcust.TabIndex = 54;
            this.lblsearchcust.Text = "Customer Name:";
            // 
            // cbsearchcust
            // 
            this.cbsearchcust.DataSource = this.customerInfoBindingSource;
            this.cbsearchcust.DisplayMember = "Customer_Name";
            this.cbsearchcust.FormattingEnabled = true;
            this.cbsearchcust.Location = new System.Drawing.Point(152, 22);
            this.cbsearchcust.Name = "cbsearchcust";
            this.cbsearchcust.Size = new System.Drawing.Size(230, 21);
            this.cbsearchcust.TabIndex = 55;
            this.cbsearchcust.ValueMember = "Customer_Name";
            this.cbsearchcust.SelectedIndexChanged += new System.EventHandler(this.cbsearchcust_SelectedIndexChanged);
            // 
            // customerInfoBindingSource
            // 
            this.customerInfoBindingSource.DataMember = "Customer_Info";
            this.customerInfoBindingSource.DataSource = this.fITZONEDataSet8;
            // 
            // fITZONEDataSet8
            // 
            this.fITZONEDataSet8.DataSetName = "FITZONEDataSet8";
            this.fITZONEDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblbmi
            // 
            this.lblbmi.AutoSize = true;
            this.lblbmi.Location = new System.Drawing.Point(37, 76);
            this.lblbmi.Name = "lblbmi";
            this.lblbmi.Size = new System.Drawing.Size(29, 13);
            this.lblbmi.TabIndex = 63;
            this.lblbmi.Text = "BMI:";
            // 
            // tbday
            // 
            this.tbday.Location = new System.Drawing.Point(152, 128);
            this.tbday.Name = "tbday";
            this.tbday.ReadOnly = true;
            this.tbday.Size = new System.Drawing.Size(156, 20);
            this.tbday.TabIndex = 247;
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Location = new System.Drawing.Point(37, 131);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(26, 13);
            this.lblday.TabIndex = 248;
            this.lblday.Text = "Day";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(370, 131);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(30, 13);
            this.lbldate.TabIndex = 250;
            this.lbldate.Text = "Date";
            // 
            // tbdate
            // 
            this.tbdate.Location = new System.Drawing.Point(485, 128);
            this.tbdate.Name = "tbdate";
            this.tbdate.ReadOnly = true;
            this.tbdate.Size = new System.Drawing.Size(156, 20);
            this.tbdate.TabIndex = 249;
            // 
            // lblcustomer
            // 
            this.lblcustomer.Image = global::FITZONE.Properties.Resources.FitZone_Label2;
            this.lblcustomer.Location = new System.Drawing.Point(564, 12);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(160, 77);
            this.lblcustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lblcustomer.TabIndex = 53;
            this.lblcustomer.TabStop = false;
            this.lblcustomer.Click += new System.EventHandler(this.lblcustomer_Click);
            // 
            // lblTF
            // 
            this.lblTF.AutoSize = true;
            this.lblTF.Location = new System.Drawing.Point(709, 131);
            this.lblTF.Name = "lblTF";
            this.lblTF.Size = new System.Drawing.Size(76, 13);
            this.lblTF.TabIndex = 253;
            this.lblTF.Text = "Today\'s Focus";
            this.lblTF.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUpdateCustExe
            // 
            this.btnUpdateCustExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustExe.Location = new System.Drawing.Point(797, 280);
            this.btnUpdateCustExe.Name = "btnUpdateCustExe";
            this.btnUpdateCustExe.Size = new System.Drawing.Size(174, 31);
            this.btnUpdateCustExe.TabIndex = 256;
            this.btnUpdateCustExe.Text = "Update Exercise For Customer";
            this.btnUpdateCustExe.UseVisualStyleBackColor = true;
            this.btnUpdateCustExe.Click += new System.EventHandler(this.button1_Click);
            // 
            // customer_InfoTableAdapter
            // 
            this.customer_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(152, 73);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.ReadOnly = true;
            this.txtBMI.Size = new System.Drawing.Size(120, 20);
            this.txtBMI.TabIndex = 257;
            // 
            // txtFocus
            // 
            this.txtFocus.Location = new System.Drawing.Point(830, 128);
            this.txtFocus.Name = "txtFocus";
            this.txtFocus.ReadOnly = true;
            this.txtFocus.Size = new System.Drawing.Size(111, 20);
            this.txtFocus.TabIndex = 258;
            this.txtFocus.TextChanged += new System.EventHandler(this.txtFocus_TextChanged);
            // 
            // AddUpdateProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1299, 470);
            this.Controls.Add(this.txtFocus);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.btnUpdateCustExe);
            this.Controls.Add(this.lblTF);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.tbdate);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.tbday);
            this.Controls.Add(this.lblbmi);
            this.Controls.Add(this.cbsearchcust);
            this.Controls.Add(this.lblsearchcust);
            this.Controls.Add(this.lblcustomer);
            this.Name = "AddUpdateProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Update Progress";
            this.Load += new System.EventHandler(this.AddUpdateProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lblcustomer;
        private System.Windows.Forms.Label lblsearchcust;
        private System.Windows.Forms.ComboBox cbsearchcust;
        private System.Windows.Forms.Label lblbmi;
        private System.Windows.Forms.TextBox tbday;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox tbdate;
        private System.Windows.Forms.Label lblTF;
        private System.Windows.Forms.Button btnUpdateCustExe;
        private FITZONEDataSet8 fITZONEDataSet8;
        private System.Windows.Forms.BindingSource customerInfoBindingSource;
        private FITZONEDataSet8TableAdapters.Customer_InfoTableAdapter customer_InfoTableAdapter;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.TextBox txtFocus;
    }
}