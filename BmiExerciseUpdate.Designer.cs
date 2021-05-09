namespace FITZONE
{
    partial class BmiExerciseUpdate
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
            this.lblbmiup = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bMIExerciseInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fITZONEDataSet2 = new FITZONE.FITZONEDataSet2();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bMIExerciseInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fITZONEDataSet3 = new FITZONE.FITZONEDataSet3();
            this.lblday = new System.Windows.Forms.Label();
            this.lblchange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblupex = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bMIClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyPart1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMIExerciseInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fITZONEDataSet6 = new FITZONE.FITZONEDataSet6();
            this.bMI_Exercise_InfoTableAdapter = new FITZONE.FITZONEDataSet2TableAdapters.BMI_Exercise_InfoTableAdapter();
            this.bMI_Exercise_InfoTableAdapter1 = new FITZONE.FITZONEDataSet3TableAdapters.BMI_Exercise_InfoTableAdapter();
            this.lbbodyparts = new System.Windows.Forms.ListBox();
            this.bodypartsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fITZONEDataSet7 = new FITZONE.FITZONEDataSet7();
            this.bodyparts_InfoTableAdapter = new FITZONE.FITZONEDataSet7TableAdapters.Bodyparts_InfoTableAdapter();
            this.fITZONEDataSet5 = new FITZONE.FITZONEDataSet5();
            this.bodypartsInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bodyparts_InfoTableAdapter1 = new FITZONE.FITZONEDataSet5TableAdapters.Bodyparts_InfoTableAdapter();
            this.bMI_Exercise_InfoTableAdapter2 = new FITZONE.FITZONEDataSet6TableAdapters.BMI_Exercise_InfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lblcustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMIExerciseInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMIExerciseInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMIExerciseInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodypartsInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodypartsInfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcustomer
            // 
            this.lblcustomer.Image = global::FITZONE.Properties.Resources.FitZone_Label2;
            this.lblcustomer.Location = new System.Drawing.Point(478, 12);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(160, 77);
            this.lblcustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lblcustomer.TabIndex = 3;
            this.lblcustomer.TabStop = false;
            this.lblcustomer.Click += new System.EventHandler(this.lblcustomer_Click);
            // 
            // lblbmiup
            // 
            this.lblbmiup.AutoSize = true;
            this.lblbmiup.Location = new System.Drawing.Point(64, 160);
            this.lblbmiup.Name = "lblbmiup";
            this.lblbmiup.Size = new System.Drawing.Size(26, 13);
            this.lblbmiup.TabIndex = 4;
            this.lblbmiup.Text = "BMI";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bMIExerciseInfoBindingSource
            // 
            this.bMIExerciseInfoBindingSource.DataMember = "BMI_Exercise_Info";
            this.bMIExerciseInfoBindingSource.DataSource = this.fITZONEDataSet2;
            // 
            // fITZONEDataSet2
            // 
            this.fITZONEDataSet2.DataSetName = "FITZONEDataSet2";
            this.fITZONEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(134, 229);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(211, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // bMIExerciseInfoBindingSource1
            // 
            this.bMIExerciseInfoBindingSource1.DataMember = "BMI_Exercise_Info";
            this.bMIExerciseInfoBindingSource1.DataSource = this.fITZONEDataSet3;
            // 
            // fITZONEDataSet3
            // 
            this.fITZONEDataSet3.DataSetName = "FITZONEDataSet3";
            this.fITZONEDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Location = new System.Drawing.Point(64, 237);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(26, 13);
            this.lblday.TabIndex = 6;
            this.lblday.Text = "Day";
            // 
            // lblchange
            // 
            this.lblchange.Location = new System.Drawing.Point(144, 484);
            this.lblchange.Name = "lblchange";
            this.lblchange.Size = new System.Drawing.Size(75, 23);
            this.lblchange.TabIndex = 8;
            this.lblchange.Text = "Change";
            this.lblchange.UseVisualStyleBackColor = true;
            this.lblchange.Click += new System.EventHandler(this.lblchange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // lblupex
            // 
            this.lblupex.AutoSize = true;
            this.lblupex.Location = new System.Drawing.Point(64, 333);
            this.lblupex.Name = "lblupex";
            this.lblupex.Size = new System.Drawing.Size(80, 13);
            this.lblupex.TabIndex = 11;
            this.lblupex.Text = "Select Exercise";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bMIClassDataGridViewTextBoxColumn,
            this.dayNameDataGridViewTextBoxColumn,
            this.bodyPart1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bMIExerciseInfoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(478, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 303);
            this.dataGridView1.TabIndex = 12;
            // 
            // bMIClassDataGridViewTextBoxColumn
            // 
            this.bMIClassDataGridViewTextBoxColumn.DataPropertyName = "BMIClass";
            this.bMIClassDataGridViewTextBoxColumn.HeaderText = "BMIClass";
            this.bMIClassDataGridViewTextBoxColumn.Name = "bMIClassDataGridViewTextBoxColumn";
            // 
            // dayNameDataGridViewTextBoxColumn
            // 
            this.dayNameDataGridViewTextBoxColumn.DataPropertyName = "Day_Name";
            this.dayNameDataGridViewTextBoxColumn.HeaderText = "Day_Name";
            this.dayNameDataGridViewTextBoxColumn.Name = "dayNameDataGridViewTextBoxColumn";
            // 
            // bodyPart1DataGridViewTextBoxColumn
            // 
            this.bodyPart1DataGridViewTextBoxColumn.DataPropertyName = "Body_Part1";
            this.bodyPart1DataGridViewTextBoxColumn.HeaderText = "Body_Part1";
            this.bodyPart1DataGridViewTextBoxColumn.Name = "bodyPart1DataGridViewTextBoxColumn";
            // 
            // bMIExerciseInfoBindingSource2
            // 
            this.bMIExerciseInfoBindingSource2.DataMember = "BMI_Exercise_Info";
            this.bMIExerciseInfoBindingSource2.DataSource = this.fITZONEDataSet6;
            // 
            // fITZONEDataSet6
            // 
            this.fITZONEDataSet6.DataSetName = "FITZONEDataSet6";
            this.fITZONEDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bMI_Exercise_InfoTableAdapter
            // 
            this.bMI_Exercise_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // bMI_Exercise_InfoTableAdapter1
            // 
            this.bMI_Exercise_InfoTableAdapter1.ClearBeforeFill = true;
            // 
            // lbbodyparts
            // 
            this.lbbodyparts.DataSource = this.bodypartsInfoBindingSource;
            this.lbbodyparts.DisplayMember = "Body_Parts";
            this.lbbodyparts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbodyparts.FormattingEnabled = true;
            this.lbbodyparts.ItemHeight = 16;
            this.lbbodyparts.Location = new System.Drawing.Point(225, 287);
            this.lbbodyparts.Name = "lbbodyparts";
            this.lbbodyparts.Size = new System.Drawing.Size(120, 148);
            this.lbbodyparts.TabIndex = 13;
            this.lbbodyparts.ValueMember = "Body_Parts";
            this.lbbodyparts.SelectedIndexChanged += new System.EventHandler(this.lbbodyparts_SelectedIndexChanged);
            // 
            // bodypartsInfoBindingSource
            // 
            this.bodypartsInfoBindingSource.DataMember = "Bodyparts_Info";
            this.bodypartsInfoBindingSource.DataSource = this.fITZONEDataSet7;
            // 
            // fITZONEDataSet7
            // 
            this.fITZONEDataSet7.DataSetName = "FITZONEDataSet7";
            this.fITZONEDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bodyparts_InfoTableAdapter
            // 
            this.bodyparts_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // fITZONEDataSet5
            // 
            this.fITZONEDataSet5.DataSetName = "FITZONEDataSet5";
            this.fITZONEDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bodypartsInfoBindingSource1
            // 
            this.bodypartsInfoBindingSource1.DataMember = "Bodyparts_Info";
            this.bodypartsInfoBindingSource1.DataSource = this.fITZONEDataSet5;
            // 
            // bodyparts_InfoTableAdapter1
            // 
            this.bodyparts_InfoTableAdapter1.ClearBeforeFill = true;
            // 
            // bMI_Exercise_InfoTableAdapter2
            // 
            this.bMI_Exercise_InfoTableAdapter2.ClearBeforeFill = true;
            // 
            // BmiExerciseUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 529);
            this.Controls.Add(this.lbbodyparts);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblupex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblchange);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblbmiup);
            this.Controls.Add(this.lblcustomer);
            this.Name = "BmiExerciseUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BmiExerciseUpdate";
            this.Load += new System.EventHandler(this.BmiExerciseUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblcustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMIExerciseInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMIExerciseInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMIExerciseInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodypartsInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodypartsInfoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lblcustomer;
        private System.Windows.Forms.Label lblbmiup;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Button lblchange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblupex;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FITZONEDataSet2 fITZONEDataSet2;
        private System.Windows.Forms.BindingSource bMIExerciseInfoBindingSource;
        private FITZONEDataSet2TableAdapters.BMI_Exercise_InfoTableAdapter bMI_Exercise_InfoTableAdapter;
        private FITZONEDataSet3 fITZONEDataSet3;
        private System.Windows.Forms.BindingSource bMIExerciseInfoBindingSource1;
        private FITZONEDataSet3TableAdapters.BMI_Exercise_InfoTableAdapter bMI_Exercise_InfoTableAdapter1;
        private System.Windows.Forms.ListBox lbbodyparts;
        private FITZONEDataSet7 fITZONEDataSet7;
        private System.Windows.Forms.BindingSource bodypartsInfoBindingSource;
        private FITZONEDataSet7TableAdapters.Bodyparts_InfoTableAdapter bodyparts_InfoTableAdapter;
        private FITZONEDataSet5 fITZONEDataSet5;
        private System.Windows.Forms.BindingSource bodypartsInfoBindingSource1;
        private FITZONEDataSet5TableAdapters.Bodyparts_InfoTableAdapter bodyparts_InfoTableAdapter1;
        private FITZONEDataSet6 fITZONEDataSet6;
        private System.Windows.Forms.BindingSource bMIExerciseInfoBindingSource2;
        private FITZONEDataSet6TableAdapters.BMI_Exercise_InfoTableAdapter bMI_Exercise_InfoTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMIClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyPart1DataGridViewTextBoxColumn;
    }
}