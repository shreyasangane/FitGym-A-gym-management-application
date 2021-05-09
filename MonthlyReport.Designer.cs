namespace FITZONE
{
    partial class MonthlyReport
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
            this.lblcustomer = new System.Windows.Forms.PictureBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblday = new System.Windows.Forms.Label();
            this.tbday = new System.Windows.Forms.TextBox();
            this.txtBMI = new System.Windows.Forms.Label();
            this.lblbmi = new System.Windows.Forms.Label();
            this.cbsearchcust = new System.Windows.Forms.ComboBox();
            this.customerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fITZONEDataSet9 = new FITZONE.FITZONEDataSet9();
            this.lblsearchcust = new System.Windows.Forms.Label();
            this.tbdate = new System.Windows.Forms.TextBox();
            this.datagvrecord = new System.Windows.Forms.DataGridView();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bicepsSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tricepsSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chestSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoulderSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legsSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyReportInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fITZONEDataSet10 = new FITZONE.FITZONEDataSet10();
            this.lblfat = new System.Windows.Forms.Label();
            this.txtfat = new System.Windows.Forms.TextBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.lblheight = new System.Windows.Forms.Label();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.lblweight = new System.Windows.Forms.Label();
            this.txtback = new System.Windows.Forms.TextBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.txtchest = new System.Windows.Forms.TextBox();
            this.lblchest = new System.Windows.Forms.Label();
            this.txttricpes = new System.Windows.Forms.TextBox();
            this.lbltriceps = new System.Windows.Forms.Label();
            this.lblbiceps = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customer_InfoTableAdapter = new FITZONE.FITZONEDataSet9TableAdapters.Customer_InfoTableAdapter();
            this.lblShoulder = new System.Windows.Forms.Label();
            this.txtShoulder = new System.Windows.Forms.TextBox();
            this.txtlegs = new System.Windows.Forms.TextBox();
            this.lbllegs = new System.Windows.Forms.Label();
            this.lblLreportDate = new System.Windows.Forms.Label();
            this.txtlastreport = new System.Windows.Forms.TextBox();
            this.btngnbmi = new System.Windows.Forms.Button();
            this.txtnwbmi = new System.Windows.Forms.TextBox();
            this.txtsearchrecord = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.monthly_Report_InfoTableAdapter = new FITZONE.FITZONEDataSet10TableAdapters.Monthly_Report_InfoTableAdapter();
            this.txtbiceps = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lblcustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagvrecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyReportInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcustomer
            // 
            this.lblcustomer.Image = global::FITZONE.Properties.Resources.FitZone_Label2;
            this.lblcustomer.Location = new System.Drawing.Point(499, 12);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(160, 77);
            this.lblcustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lblcustomer.TabIndex = 1;
            this.lblcustomer.TabStop = false;
            this.lblcustomer.Click += new System.EventHandler(this.lblcustomer_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(361, 158);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(30, 13);
            this.lbldate.TabIndex = 257;
            this.lbldate.Text = "Date";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Location = new System.Drawing.Point(28, 158);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(26, 13);
            this.lblday.TabIndex = 256;
            this.lblday.Text = "Day";
            // 
            // tbday
            // 
            this.tbday.Location = new System.Drawing.Point(143, 155);
            this.tbday.Name = "tbday";
            this.tbday.ReadOnly = true;
            this.tbday.Size = new System.Drawing.Size(156, 20);
            this.tbday.TabIndex = 255;
            // 
            // txtBMI
            // 
            this.txtBMI.AutoSize = true;
            this.txtBMI.Location = new System.Drawing.Point(140, 103);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(0, 13);
            this.txtBMI.TabIndex = 254;
            // 
            // lblbmi
            // 
            this.lblbmi.AutoSize = true;
            this.lblbmi.Location = new System.Drawing.Point(28, 103);
            this.lblbmi.Name = "lblbmi";
            this.lblbmi.Size = new System.Drawing.Size(29, 13);
            this.lblbmi.TabIndex = 253;
            this.lblbmi.Text = "BMI:";
            // 
            // cbsearchcust
            // 
            this.cbsearchcust.DataSource = this.customerInfoBindingSource;
            this.cbsearchcust.DisplayMember = "Customer_Name";
            this.cbsearchcust.FormattingEnabled = true;
            this.cbsearchcust.Location = new System.Drawing.Point(143, 49);
            this.cbsearchcust.Name = "cbsearchcust";
            this.cbsearchcust.Size = new System.Drawing.Size(230, 21);
            this.cbsearchcust.TabIndex = 252;
            this.cbsearchcust.ValueMember = "Customer_Name";
            this.cbsearchcust.SelectedIndexChanged += new System.EventHandler(this.cbsearchcust_SelectedIndexChanged);
            // 
            // customerInfoBindingSource
            // 
            this.customerInfoBindingSource.DataMember = "Customer_Info";
            this.customerInfoBindingSource.DataSource = this.fITZONEDataSet9;
            // 
            // fITZONEDataSet9
            // 
            this.fITZONEDataSet9.DataSetName = "FITZONEDataSet9";
            this.fITZONEDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblsearchcust
            // 
            this.lblsearchcust.AutoSize = true;
            this.lblsearchcust.Location = new System.Drawing.Point(28, 57);
            this.lblsearchcust.Name = "lblsearchcust";
            this.lblsearchcust.Size = new System.Drawing.Size(85, 13);
            this.lblsearchcust.TabIndex = 251;
            this.lblsearchcust.Text = "Customer Name:";
            // 
            // tbdate
            // 
            this.tbdate.Location = new System.Drawing.Point(424, 155);
            this.tbdate.Name = "tbdate";
            this.tbdate.ReadOnly = true;
            this.tbdate.Size = new System.Drawing.Size(156, 20);
            this.tbdate.TabIndex = 258;
            // 
            // datagvrecord
            // 
            this.datagvrecord.AutoGenerateColumns = false;
            this.datagvrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvrecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.reportDateDataGridViewTextBoxColumn,
            this.bMIDataGridViewTextBoxColumn,
            this.bicepsSizeDataGridViewTextBoxColumn,
            this.tricepsSizeDataGridViewTextBoxColumn,
            this.chestSizeDataGridViewTextBoxColumn,
            this.backSizeDataGridViewTextBoxColumn,
            this.shoulderSizeDataGridViewTextBoxColumn,
            this.legsSizeDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.fatPercentDataGridViewTextBoxColumn});
            this.datagvrecord.DataSource = this.monthlyReportInfoBindingSource;
            this.datagvrecord.Location = new System.Drawing.Point(704, 103);
            this.datagvrecord.Name = "datagvrecord";
            this.datagvrecord.Size = new System.Drawing.Size(475, 412);
            this.datagvrecord.TabIndex = 259;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // reportDateDataGridViewTextBoxColumn
            // 
            this.reportDateDataGridViewTextBoxColumn.DataPropertyName = "Report_Date";
            this.reportDateDataGridViewTextBoxColumn.HeaderText = "Report_Date";
            this.reportDateDataGridViewTextBoxColumn.Name = "reportDateDataGridViewTextBoxColumn";
            // 
            // bMIDataGridViewTextBoxColumn
            // 
            this.bMIDataGridViewTextBoxColumn.DataPropertyName = "BMI";
            this.bMIDataGridViewTextBoxColumn.HeaderText = "BMI";
            this.bMIDataGridViewTextBoxColumn.Name = "bMIDataGridViewTextBoxColumn";
            // 
            // bicepsSizeDataGridViewTextBoxColumn
            // 
            this.bicepsSizeDataGridViewTextBoxColumn.DataPropertyName = "Biceps_Size";
            this.bicepsSizeDataGridViewTextBoxColumn.HeaderText = "Biceps_Size";
            this.bicepsSizeDataGridViewTextBoxColumn.Name = "bicepsSizeDataGridViewTextBoxColumn";
            // 
            // tricepsSizeDataGridViewTextBoxColumn
            // 
            this.tricepsSizeDataGridViewTextBoxColumn.DataPropertyName = "Triceps_Size";
            this.tricepsSizeDataGridViewTextBoxColumn.HeaderText = "Triceps_Size";
            this.tricepsSizeDataGridViewTextBoxColumn.Name = "tricepsSizeDataGridViewTextBoxColumn";
            // 
            // chestSizeDataGridViewTextBoxColumn
            // 
            this.chestSizeDataGridViewTextBoxColumn.DataPropertyName = "Chest_Size";
            this.chestSizeDataGridViewTextBoxColumn.HeaderText = "Chest_Size";
            this.chestSizeDataGridViewTextBoxColumn.Name = "chestSizeDataGridViewTextBoxColumn";
            // 
            // backSizeDataGridViewTextBoxColumn
            // 
            this.backSizeDataGridViewTextBoxColumn.DataPropertyName = "Back_Size";
            this.backSizeDataGridViewTextBoxColumn.HeaderText = "Back_Size";
            this.backSizeDataGridViewTextBoxColumn.Name = "backSizeDataGridViewTextBoxColumn";
            // 
            // shoulderSizeDataGridViewTextBoxColumn
            // 
            this.shoulderSizeDataGridViewTextBoxColumn.DataPropertyName = "Shoulder_Size";
            this.shoulderSizeDataGridViewTextBoxColumn.HeaderText = "Shoulder_Size";
            this.shoulderSizeDataGridViewTextBoxColumn.Name = "shoulderSizeDataGridViewTextBoxColumn";
            // 
            // legsSizeDataGridViewTextBoxColumn
            // 
            this.legsSizeDataGridViewTextBoxColumn.DataPropertyName = "Legs_Size";
            this.legsSizeDataGridViewTextBoxColumn.HeaderText = "Legs_Size";
            this.legsSizeDataGridViewTextBoxColumn.Name = "legsSizeDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // fatPercentDataGridViewTextBoxColumn
            // 
            this.fatPercentDataGridViewTextBoxColumn.DataPropertyName = "Fat_Percent";
            this.fatPercentDataGridViewTextBoxColumn.HeaderText = "Fat_Percent";
            this.fatPercentDataGridViewTextBoxColumn.Name = "fatPercentDataGridViewTextBoxColumn";
            // 
            // monthlyReportInfoBindingSource
            // 
            this.monthlyReportInfoBindingSource.DataMember = "Monthly_Report_Info";
            this.monthlyReportInfoBindingSource.DataSource = this.fITZONEDataSet10;
            // 
            // fITZONEDataSet10
            // 
            this.fITZONEDataSet10.DataSetName = "FITZONEDataSet10";
            this.fITZONEDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblfat
            // 
            this.lblfat.AutoSize = true;
            this.lblfat.Location = new System.Drawing.Point(28, 530);
            this.lblfat.Name = "lblfat";
            this.lblfat.Size = new System.Drawing.Size(62, 13);
            this.lblfat.TabIndex = 274;
            this.lblfat.Text = "FatPercent:";
            // 
            // txtfat
            // 
            this.txtfat.Location = new System.Drawing.Point(94, 530);
            this.txtfat.Name = "txtfat";
            this.txtfat.Size = new System.Drawing.Size(150, 20);
            this.txtfat.TabIndex = 273;
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(94, 478);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(150, 20);
            this.txtheight.TabIndex = 272;
            // 
            // lblheight
            // 
            this.lblheight.AutoSize = true;
            this.lblheight.Location = new System.Drawing.Point(19, 478);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(71, 13);
            this.lblheight.TabIndex = 271;
            this.lblheight.Text = "Height(Meter)";
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(94, 430);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(150, 20);
            this.txtweight.TabIndex = 270;
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Location = new System.Drawing.Point(28, 433);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(65, 13);
            this.lblweight.TabIndex = 269;
            this.lblweight.Text = "Weight (KG)";
            // 
            // txtback
            // 
            this.txtback.Location = new System.Drawing.Point(94, 380);
            this.txtback.Name = "txtback";
            this.txtback.Size = new System.Drawing.Size(150, 20);
            this.txtback.TabIndex = 268;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(28, 380);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(58, 13);
            this.lblBack.TabIndex = 267;
            this.lblBack.Text = "Back Size:";
            // 
            // txtchest
            // 
            this.txtchest.Location = new System.Drawing.Point(94, 325);
            this.txtchest.Name = "txtchest";
            this.txtchest.Size = new System.Drawing.Size(150, 20);
            this.txtchest.TabIndex = 266;
            // 
            // lblchest
            // 
            this.lblchest.AutoSize = true;
            this.lblchest.Location = new System.Drawing.Point(28, 325);
            this.lblchest.Name = "lblchest";
            this.lblchest.Size = new System.Drawing.Size(60, 13);
            this.lblchest.TabIndex = 265;
            this.lblchest.Text = "Chest Size:";
            // 
            // txttricpes
            // 
            this.txttricpes.Location = new System.Drawing.Point(94, 277);
            this.txttricpes.Name = "txttricpes";
            this.txttricpes.Size = new System.Drawing.Size(150, 20);
            this.txttricpes.TabIndex = 264;
            // 
            // lbltriceps
            // 
            this.lbltriceps.AutoSize = true;
            this.lbltriceps.Location = new System.Drawing.Point(28, 277);
            this.lbltriceps.Name = "lbltriceps";
            this.lbltriceps.Size = new System.Drawing.Size(65, 13);
            this.lbltriceps.TabIndex = 263;
            this.lbltriceps.Text = "Triceps Size";
            // 
            // lblbiceps
            // 
            this.lblbiceps.AutoSize = true;
            this.lblbiceps.Location = new System.Drawing.Point(28, 235);
            this.lblbiceps.Name = "lblbiceps";
            this.lblbiceps.Size = new System.Drawing.Size(65, 13);
            this.lblbiceps.TabIndex = 261;
            this.lblbiceps.Text = "Biceps Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 275;
            this.label2.Text = "New Monthly Report:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 276;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 40);
            this.button2.TabIndex = 277;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // customer_InfoTableAdapter
            // 
            this.customer_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // lblShoulder
            // 
            this.lblShoulder.AutoSize = true;
            this.lblShoulder.Location = new System.Drawing.Point(315, 235);
            this.lblShoulder.Name = "lblShoulder";
            this.lblShoulder.Size = new System.Drawing.Size(75, 13);
            this.lblShoulder.TabIndex = 278;
            this.lblShoulder.Text = "Shoulder Size:";
            // 
            // txtShoulder
            // 
            this.txtShoulder.Location = new System.Drawing.Point(401, 232);
            this.txtShoulder.Name = "txtShoulder";
            this.txtShoulder.Size = new System.Drawing.Size(150, 20);
            this.txtShoulder.TabIndex = 279;
            // 
            // txtlegs
            // 
            this.txtlegs.Location = new System.Drawing.Point(401, 277);
            this.txtlegs.Name = "txtlegs";
            this.txtlegs.Size = new System.Drawing.Size(150, 20);
            this.txtlegs.TabIndex = 280;
            // 
            // lbllegs
            // 
            this.lbllegs.AutoSize = true;
            this.lbllegs.Location = new System.Drawing.Point(315, 280);
            this.lbllegs.Name = "lbllegs";
            this.lbllegs.Size = new System.Drawing.Size(56, 13);
            this.lbllegs.TabIndex = 283;
            this.lbllegs.Text = "Legs Size:";
            // 
            // lblLreportDate
            // 
            this.lblLreportDate.AutoSize = true;
            this.lblLreportDate.Location = new System.Drawing.Point(246, 103);
            this.lblLreportDate.Name = "lblLreportDate";
            this.lblLreportDate.Size = new System.Drawing.Size(88, 13);
            this.lblLreportDate.TabIndex = 284;
            this.lblLreportDate.Text = "Last Report Date";
            // 
            // txtlastreport
            // 
            this.txtlastreport.Location = new System.Drawing.Point(364, 100);
            this.txtlastreport.Name = "txtlastreport";
            this.txtlastreport.ReadOnly = true;
            this.txtlastreport.Size = new System.Drawing.Size(132, 20);
            this.txtlastreport.TabIndex = 285;
            // 
            // btngnbmi
            // 
            this.btngnbmi.Location = new System.Drawing.Point(318, 325);
            this.btngnbmi.Name = "btngnbmi";
            this.btngnbmi.Size = new System.Drawing.Size(73, 40);
            this.btngnbmi.TabIndex = 286;
            this.btngnbmi.Text = "Generate BMI";
            this.btngnbmi.UseVisualStyleBackColor = true;
            this.btngnbmi.Click += new System.EventHandler(this.btngnbmi_Click);
            // 
            // txtnwbmi
            // 
            this.txtnwbmi.Location = new System.Drawing.Point(401, 336);
            this.txtnwbmi.Name = "txtnwbmi";
            this.txtnwbmi.Size = new System.Drawing.Size(150, 20);
            this.txtnwbmi.TabIndex = 287;
            // 
            // txtsearchrecord
            // 
            this.txtsearchrecord.Location = new System.Drawing.Point(866, 69);
            this.txtsearchrecord.Name = "txtsearchrecord";
            this.txtsearchrecord.Size = new System.Drawing.Size(166, 20);
            this.txtsearchrecord.TabIndex = 288;
            this.txtsearchrecord.TextChanged += new System.EventHandler(this.txtsearchrecord_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(746, 72);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(87, 13);
            this.lblSearch.TabIndex = 289;
            this.lblSearch.Text = "Search By Name";
            // 
            // monthly_Report_InfoTableAdapter
            // 
            this.monthly_Report_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // txtbiceps
            // 
            this.txtbiceps.Location = new System.Drawing.Point(94, 235);
            this.txtbiceps.Name = "txtbiceps";
            this.txtbiceps.Size = new System.Drawing.Size(156, 20);
            this.txtbiceps.TabIndex = 290;
            // 
            // MonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1210, 686);
            this.Controls.Add(this.txtbiceps);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtsearchrecord);
            this.Controls.Add(this.txtnwbmi);
            this.Controls.Add(this.btngnbmi);
            this.Controls.Add(this.txtlastreport);
            this.Controls.Add(this.lblLreportDate);
            this.Controls.Add(this.lbllegs);
            this.Controls.Add(this.txtlegs);
            this.Controls.Add(this.txtShoulder);
            this.Controls.Add(this.lblShoulder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblfat);
            this.Controls.Add(this.txtfat);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.lblheight);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.lblweight);
            this.Controls.Add(this.txtback);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.txtchest);
            this.Controls.Add(this.lblchest);
            this.Controls.Add(this.txttricpes);
            this.Controls.Add(this.lbltriceps);
            this.Controls.Add(this.lblbiceps);
            this.Controls.Add(this.datagvrecord);
            this.Controls.Add(this.tbdate);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.tbday);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.lblbmi);
            this.Controls.Add(this.cbsearchcust);
            this.Controls.Add(this.lblsearchcust);
            this.Controls.Add(this.lblcustomer);
            this.Name = "MonthlyReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonthlyReport";
            this.Load += new System.EventHandler(this.MonthlyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblcustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagvrecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyReportInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lblcustomer;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.TextBox tbday;
        private System.Windows.Forms.Label txtBMI;
        private System.Windows.Forms.Label lblbmi;
        private System.Windows.Forms.ComboBox cbsearchcust;
        private System.Windows.Forms.Label lblsearchcust;
        private System.Windows.Forms.TextBox tbdate;
        private System.Windows.Forms.DataGridView datagvrecord;
        private System.Windows.Forms.Label lblfat;
        private System.Windows.Forms.TextBox txtfat;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.TextBox txtback;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.TextBox txtchest;
        private System.Windows.Forms.Label lblchest;
        private System.Windows.Forms.TextBox txttricpes;
        private System.Windows.Forms.Label lbltriceps;
        private System.Windows.Forms.Label lblbiceps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private FITZONEDataSet9 fITZONEDataSet9;
        private System.Windows.Forms.BindingSource customerInfoBindingSource;
        private FITZONEDataSet9TableAdapters.Customer_InfoTableAdapter customer_InfoTableAdapter;
        private System.Windows.Forms.Label lblShoulder;
        private System.Windows.Forms.TextBox txtShoulder;
        private System.Windows.Forms.TextBox txtlegs;
        private System.Windows.Forms.Label lbllegs;
        private System.Windows.Forms.Label lblLreportDate;
        private System.Windows.Forms.TextBox txtlastreport;
        private System.Windows.Forms.Button btngnbmi;
        private System.Windows.Forms.TextBox txtnwbmi;
        private System.Windows.Forms.TextBox txtsearchrecord;
        private System.Windows.Forms.Label lblSearch;
        private FITZONEDataSet10 fITZONEDataSet10;
        private System.Windows.Forms.BindingSource monthlyReportInfoBindingSource;
        private FITZONEDataSet10TableAdapters.Monthly_Report_InfoTableAdapter monthly_Report_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bicepsSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tricepsSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chestSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoulderSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn legsSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtbiceps;
    }
}