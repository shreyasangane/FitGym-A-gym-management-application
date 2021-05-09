namespace FITZONE
{
    partial class SearchEmpCust
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
            this.dgvcustemp = new System.Windows.Forms.DataGridView();
            this.lblsearchcustomer = new System.Windows.Forms.Label();
            this.txtsearchcustomer = new System.Windows.Forms.TextBox();
            this.lblcustomer = new System.Windows.Forms.PictureBox();
            this.btndltcst = new System.Windows.Forms.Button();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcustemp
            // 
            this.dgvcustemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcustemp.Location = new System.Drawing.Point(26, 139);
            this.dgvcustemp.Name = "dgvcustemp";
            this.dgvcustemp.Size = new System.Drawing.Size(888, 286);
            this.dgvcustemp.TabIndex = 3;
            this.dgvcustemp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // lblsearchcustomer
            // 
            this.lblsearchcustomer.AutoSize = true;
            this.lblsearchcustomer.Location = new System.Drawing.Point(23, 109);
            this.lblsearchcustomer.Name = "lblsearchcustomer";
            this.lblsearchcustomer.Size = new System.Drawing.Size(43, 13);
            this.lblsearchcustomer.TabIndex = 4;
            this.lblsearchcustomer.Text = "Choose";
            // 
            // txtsearchcustomer
            // 
            this.txtsearchcustomer.Location = new System.Drawing.Point(495, 110);
            this.txtsearchcustomer.Name = "txtsearchcustomer";
            this.txtsearchcustomer.Size = new System.Drawing.Size(227, 20);
            this.txtsearchcustomer.TabIndex = 6;
            this.txtsearchcustomer.TextChanged += new System.EventHandler(this.txtsearchcustomer_TextChanged);
            // 
            // lblcustomer
            // 
            this.lblcustomer.Image = global::FITZONE.Properties.Resources.FitZone_Label2;
            this.lblcustomer.Location = new System.Drawing.Point(390, 12);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(160, 77);
            this.lblcustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lblcustomer.TabIndex = 1;
            this.lblcustomer.TabStop = false;
            this.lblcustomer.Click += new System.EventHandler(this.lblcustomer_Click);
            // 
            // btndltcst
            // 
            this.btndltcst.Location = new System.Drawing.Point(619, 441);
            this.btndltcst.Name = "btndltcst";
            this.btndltcst.Size = new System.Drawing.Size(157, 36);
            this.btndltcst.TabIndex = 8;
            this.btndltcst.Text = "Delete Customer";
            this.btndltcst.UseVisualStyleBackColor = true;
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Location = new System.Drawing.Point(90, 109);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(69, 17);
            this.rbCustomer.TabIndex = 9;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "Customer";
            this.rbCustomer.UseVisualStyleBackColor = true;
            this.rbCustomer.CheckedChanged += new System.EventHandler(this.rbCustomer_CheckedChanged);
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Location = new System.Drawing.Point(206, 110);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(71, 17);
            this.rbEmployee.TabIndex = 10;
            this.rbEmployee.TabStop = true;
            this.rbEmployee.Text = "Employee";
            this.rbEmployee.UseVisualStyleBackColor = true;
            this.rbEmployee.CheckedChanged += new System.EventHandler(this.rbEmployee_CheckedChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(387, 113);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(87, 13);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search By Name";
            // 
            // SearchEmpCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 512);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.rbEmployee);
            this.Controls.Add(this.rbCustomer);
            this.Controls.Add(this.btndltcst);
            this.Controls.Add(this.txtsearchcustomer);
            this.Controls.Add(this.lblsearchcustomer);
            this.Controls.Add(this.dgvcustemp);
            this.Controls.Add(this.lblcustomer);
            this.Name = "SearchEmpCust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Customer/Employee";
            this.Load += new System.EventHandler(this.SearchEmpCust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lblcustomer;
        private System.Windows.Forms.DataGridView dgvcustemp;
        private System.Windows.Forms.Label lblsearchcustomer;
        private System.Windows.Forms.TextBox txtsearchcustomer;
        private System.Windows.Forms.Button btndltcst;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.RadioButton rbEmployee;
        private System.Windows.Forms.Label lblSearch;
    }
}