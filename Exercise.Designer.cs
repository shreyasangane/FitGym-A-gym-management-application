namespace FITZONE
{
    partial class Exercise
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bodypartsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fITZONEDataSet = new FITZONE.FITZONEDataSet();
            this.lblcustomer = new System.Windows.Forms.PictureBox();
            this.lblbdparts = new System.Windows.Forms.Label();
            this.lbladdparts = new System.Windows.Forms.Label();
            this.txtaddparts = new System.Windows.Forms.TextBox();
            this.txtupdtparts = new System.Windows.Forms.TextBox();
            this.lblupdparts = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectBodyPart = new System.Windows.Forms.ComboBox();
            this.listboxexercise = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaddexercise = new System.Windows.Forms.TextBox();
            this.lbladdexercise = new System.Windows.Forms.Label();
            this.txtupdateexerise = new System.Windows.Forms.TextBox();
            this.lblupdtexercise = new System.Windows.Forms.Label();
            this.btndeleteexercise = new System.Windows.Forms.Button();
            this.btnAddparts = new System.Windows.Forms.Button();
            this.btnUpdateparts = new System.Windows.Forms.Button();
            this.btnupdtdecount = new System.Windows.Forms.Button();
            this.lbldec = new System.Windows.Forms.Label();
            this.txtupdatedecount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butaddexec = new System.Windows.Forms.Button();
            this.txtadddec = new System.Windows.Forms.TextBox();
            this.bodyparts_InfoTableAdapter = new FITZONE.FITZONEDataSetTableAdapters.Bodyparts_InfoTableAdapter();
            this.fITZONEDataSet1 = new FITZONE.FITZONEDataSet1();
            this.exerciseInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exercise_InfoTableAdapter = new FITZONE.FITZONEDataSet1TableAdapters.Exercise_InfoTableAdapter();
            this.listboxcount = new System.Windows.Forms.ListBox();
            this.lblexpc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bodypartsInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblcustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.bodypartsInfoBindingSource;
            this.listBox1.DisplayMember = "Body_Parts";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(54, 184);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 166);
            this.listBox1.TabIndex = 3;
            this.listBox1.ValueMember = "Body_Parts";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bodypartsInfoBindingSource
            // 
            this.bodypartsInfoBindingSource.DataMember = "Bodyparts_Info";
            this.bodypartsInfoBindingSource.DataSource = this.fITZONEDataSet;
            // 
            // fITZONEDataSet
            // 
            this.fITZONEDataSet.DataSetName = "FITZONEDataSet";
            this.fITZONEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblcustomer
            // 
            this.lblcustomer.Image = global::FITZONE.Properties.Resources.FitZone_Label2;
            this.lblcustomer.Location = new System.Drawing.Point(461, 12);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(160, 77);
            this.lblcustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lblcustomer.TabIndex = 2;
            this.lblcustomer.TabStop = false;
            this.lblcustomer.Click += new System.EventHandler(this.lblcustomer_Click);
            // 
            // lblbdparts
            // 
            this.lblbdparts.AutoSize = true;
            this.lblbdparts.Location = new System.Drawing.Point(51, 144);
            this.lblbdparts.Name = "lblbdparts";
            this.lblbdparts.Size = new System.Drawing.Size(239, 13);
            this.lblbdparts.TabIndex = 4;
            this.lblbdparts.Text = "Body Parts (Select Below To Delete And Update)";
            this.lblbdparts.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbladdparts
            // 
            this.lbladdparts.AutoSize = true;
            this.lbladdparts.Location = new System.Drawing.Point(205, 185);
            this.lbladdparts.Name = "lbladdparts";
            this.lbladdparts.Size = new System.Drawing.Size(53, 13);
            this.lbladdparts.TabIndex = 5;
            this.lbladdparts.Text = "Add Parts";
            this.lbladdparts.Visible = false;
            // 
            // txtaddparts
            // 
            this.txtaddparts.Location = new System.Drawing.Point(286, 182);
            this.txtaddparts.Name = "txtaddparts";
            this.txtaddparts.Size = new System.Drawing.Size(131, 20);
            this.txtaddparts.TabIndex = 6;
            this.txtaddparts.Visible = false;
            this.txtaddparts.TextChanged += new System.EventHandler(this.txtaddparts_TextChanged);
            // 
            // txtupdtparts
            // 
            this.txtupdtparts.Location = new System.Drawing.Point(286, 227);
            this.txtupdtparts.Name = "txtupdtparts";
            this.txtupdtparts.Size = new System.Drawing.Size(131, 20);
            this.txtupdtparts.TabIndex = 8;
            this.txtupdtparts.Visible = false;
            this.txtupdtparts.TextChanged += new System.EventHandler(this.txtupdtparts_TextChanged);
            // 
            // lblupdparts
            // 
            this.lblupdparts.AutoSize = true;
            this.lblupdparts.Location = new System.Drawing.Point(205, 230);
            this.lblupdparts.Name = "lblupdparts";
            this.lblupdparts.Size = new System.Drawing.Size(69, 13);
            this.lblupdparts.TabIndex = 7;
            this.lblupdparts.Text = "Update Parts";
            this.lblupdparts.Visible = false;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(54, 382);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete Parts";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Visible = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1239, 491);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 534;
            this.lineShape1.X2 = 535;
            this.lineShape1.Y1 = 124;
            this.lineShape1.Y2 = 419;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose Body Part (To display Exercies)";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cbSelectBodyPart
            // 
            this.cbSelectBodyPart.DataSource = this.bodypartsInfoBindingSource;
            this.cbSelectBodyPart.DisplayMember = "Body_Parts";
            this.cbSelectBodyPart.FormattingEnabled = true;
            this.cbSelectBodyPart.Location = new System.Drawing.Point(781, 145);
            this.cbSelectBodyPart.Name = "cbSelectBodyPart";
            this.cbSelectBodyPart.Size = new System.Drawing.Size(121, 21);
            this.cbSelectBodyPart.TabIndex = 12;
            this.cbSelectBodyPart.ValueMember = "Body_Parts";
            this.cbSelectBodyPart.SelectedIndexChanged += new System.EventHandler(this.cbSelectBodyPart_SelectedIndexChanged);
            // 
            // listboxexercise
            // 
            this.listboxexercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxexercise.FormattingEnabled = true;
            this.listboxexercise.HorizontalScrollbar = true;
            this.listboxexercise.ItemHeight = 18;
            this.listboxexercise.Location = new System.Drawing.Point(572, 223);
            this.listboxexercise.Name = "listboxexercise";
            this.listboxexercise.Size = new System.Drawing.Size(155, 148);
            this.listboxexercise.TabIndex = 13;
            this.listboxexercise.SelectedIndexChanged += new System.EventHandler(this.listboxexercise_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Exercises";
            // 
            // txtaddexercise
            // 
            this.txtaddexercise.Location = new System.Drawing.Point(976, 352);
            this.txtaddexercise.Name = "txtaddexercise";
            this.txtaddexercise.Size = new System.Drawing.Size(135, 20);
            this.txtaddexercise.TabIndex = 16;
            this.txtaddexercise.Visible = false;
            // 
            // lbladdexercise
            // 
            this.lbladdexercise.AutoSize = true;
            this.lbladdexercise.Location = new System.Drawing.Point(835, 223);
            this.lbladdexercise.Name = "lbladdexercise";
            this.lbladdexercise.Size = new System.Drawing.Size(78, 13);
            this.lbladdexercise.TabIndex = 15;
            this.lbladdexercise.Text = "Exercise Name";
            // 
            // txtupdateexerise
            // 
            this.txtupdateexerise.Location = new System.Drawing.Point(966, 219);
            this.txtupdateexerise.Name = "txtupdateexerise";
            this.txtupdateexerise.ReadOnly = true;
            this.txtupdateexerise.Size = new System.Drawing.Size(193, 20);
            this.txtupdateexerise.TabIndex = 18;
            // 
            // lblupdtexercise
            // 
            this.lblupdtexercise.AutoSize = true;
            this.lblupdtexercise.Location = new System.Drawing.Point(870, 358);
            this.lblupdtexercise.Name = "lblupdtexercise";
            this.lblupdtexercise.Size = new System.Drawing.Size(85, 13);
            this.lblupdtexercise.TabIndex = 17;
            this.lblupdtexercise.Text = "Update Exercise";
            this.lblupdtexercise.Visible = false;
            // 
            // btndeleteexercise
            // 
            this.btndeleteexercise.Location = new System.Drawing.Point(572, 401);
            this.btndeleteexercise.Name = "btndeleteexercise";
            this.btndeleteexercise.Size = new System.Drawing.Size(120, 23);
            this.btndeleteexercise.TabIndex = 19;
            this.btndeleteexercise.Text = "Delete Exercise";
            this.btndeleteexercise.UseVisualStyleBackColor = true;
            this.btndeleteexercise.Visible = false;
            this.btndeleteexercise.Click += new System.EventHandler(this.btndeleteexercise_Click);
            // 
            // btnAddparts
            // 
            this.btnAddparts.Location = new System.Drawing.Point(439, 180);
            this.btnAddparts.Name = "btnAddparts";
            this.btnAddparts.Size = new System.Drawing.Size(75, 23);
            this.btnAddparts.TabIndex = 20;
            this.btnAddparts.Text = "Add";
            this.btnAddparts.UseVisualStyleBackColor = true;
            this.btnAddparts.Visible = false;
            this.btnAddparts.Click += new System.EventHandler(this.btnAddparts_Click);
            // 
            // btnUpdateparts
            // 
            this.btnUpdateparts.Location = new System.Drawing.Point(439, 227);
            this.btnUpdateparts.Name = "btnUpdateparts";
            this.btnUpdateparts.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateparts.TabIndex = 21;
            this.btnUpdateparts.Text = "Update";
            this.btnUpdateparts.UseVisualStyleBackColor = true;
            this.btnUpdateparts.Visible = false;
            this.btnUpdateparts.Click += new System.EventHandler(this.btnUpdateparts_Click);
            // 
            // btnupdtdecount
            // 
            this.btnupdtdecount.Location = new System.Drawing.Point(1110, 270);
            this.btnupdtdecount.Name = "btnupdtdecount";
            this.btnupdtdecount.Size = new System.Drawing.Size(75, 23);
            this.btnupdtdecount.TabIndex = 22;
            this.btnupdtdecount.Text = "Update";
            this.btnupdtdecount.UseVisualStyleBackColor = true;
            this.btnupdtdecount.Click += new System.EventHandler(this.btnupdtdecount_Click);
            // 
            // lbldec
            // 
            this.lbldec.AutoSize = true;
            this.lbldec.Location = new System.Drawing.Point(835, 270);
            this.lbldec.Name = "lbldec";
            this.lbldec.Size = new System.Drawing.Size(83, 26);
            this.lbldec.TabIndex = 24;
            this.lbldec.Text = "Update Daily \r\nExpected Count";
            // 
            // txtupdatedecount
            // 
            this.txtupdatedecount.Location = new System.Drawing.Point(966, 270);
            this.txtupdatedecount.Name = "txtupdatedecount";
            this.txtupdatedecount.Size = new System.Drawing.Size(100, 20);
            this.txtupdatedecount.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(870, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Daily Expected Count";
            this.label3.Visible = false;
            // 
            // butaddexec
            // 
            this.butaddexec.Location = new System.Drawing.Point(1110, 396);
            this.butaddexec.Name = "butaddexec";
            this.butaddexec.Size = new System.Drawing.Size(75, 23);
            this.butaddexec.TabIndex = 27;
            this.butaddexec.Text = "Add Exercise & Count";
            this.butaddexec.UseVisualStyleBackColor = true;
            this.butaddexec.Visible = false;
            this.butaddexec.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtadddec
            // 
            this.txtadddec.Location = new System.Drawing.Point(985, 399);
            this.txtadddec.Name = "txtadddec";
            this.txtadddec.Size = new System.Drawing.Size(100, 20);
            this.txtadddec.TabIndex = 28;
            this.txtadddec.Visible = false;
            // 
            // bodyparts_InfoTableAdapter
            // 
            this.bodyparts_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // fITZONEDataSet1
            // 
            this.fITZONEDataSet1.DataSetName = "FITZONEDataSet1";
            this.fITZONEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exerciseInfoBindingSource
            // 
            this.exerciseInfoBindingSource.DataMember = "Exercise_Info";
            this.exerciseInfoBindingSource.DataSource = this.fITZONEDataSet1;
            // 
            // exercise_InfoTableAdapter
            // 
            this.exercise_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // listboxcount
            // 
            this.listboxcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxcount.FormattingEnabled = true;
            this.listboxcount.ItemHeight = 18;
            this.listboxcount.Location = new System.Drawing.Point(733, 224);
            this.listboxcount.Name = "listboxcount";
            this.listboxcount.Size = new System.Drawing.Size(50, 148);
            this.listboxcount.TabIndex = 29;
            this.listboxcount.SelectedIndexChanged += new System.EventHandler(this.listboxcount_SelectedIndexChanged);
            // 
            // lblexpc
            // 
            this.lblexpc.AutoSize = true;
            this.lblexpc.Location = new System.Drawing.Point(730, 189);
            this.lblexpc.Name = "lblexpc";
            this.lblexpc.Size = new System.Drawing.Size(35, 13);
            this.lblexpc.TabIndex = 30;
            this.lblexpc.Text = "Count";
            // 
            // Exercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 491);
            this.Controls.Add(this.lblexpc);
            this.Controls.Add(this.listboxcount);
            this.Controls.Add(this.txtadddec);
            this.Controls.Add(this.butaddexec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtupdatedecount);
            this.Controls.Add(this.lbldec);
            this.Controls.Add(this.btnupdtdecount);
            this.Controls.Add(this.btnUpdateparts);
            this.Controls.Add(this.btnAddparts);
            this.Controls.Add(this.btndeleteexercise);
            this.Controls.Add(this.txtupdateexerise);
            this.Controls.Add(this.lblupdtexercise);
            this.Controls.Add(this.txtaddexercise);
            this.Controls.Add(this.lbladdexercise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listboxexercise);
            this.Controls.Add(this.cbSelectBodyPart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtupdtparts);
            this.Controls.Add(this.lblupdparts);
            this.Controls.Add(this.txtaddparts);
            this.Controls.Add(this.lbladdparts);
            this.Controls.Add(this.lblbdparts);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblcustomer);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Exercise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercise";
            this.Load += new System.EventHandler(this.Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bodypartsInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblcustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITZONEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lblcustomer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblbdparts;
        private System.Windows.Forms.Label lbladdparts;
        private System.Windows.Forms.TextBox txtaddparts;
        private System.Windows.Forms.TextBox txtupdtparts;
        private System.Windows.Forms.Label lblupdparts;
        private System.Windows.Forms.Button btndelete;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectBodyPart;
        private System.Windows.Forms.ListBox listboxexercise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaddexercise;
        private System.Windows.Forms.Label lbladdexercise;
        private System.Windows.Forms.TextBox txtupdateexerise;
        private System.Windows.Forms.Label lblupdtexercise;
        private System.Windows.Forms.Button btndeleteexercise;
        private System.Windows.Forms.Button btnAddparts;
        private System.Windows.Forms.Button btnUpdateparts;
        private System.Windows.Forms.Button btnupdtdecount;
        private System.Windows.Forms.Label lbldec;
        private System.Windows.Forms.TextBox txtupdatedecount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butaddexec;
        private System.Windows.Forms.TextBox txtadddec;
        private FITZONEDataSet fITZONEDataSet;
        private System.Windows.Forms.BindingSource bodypartsInfoBindingSource;
        private FITZONEDataSetTableAdapters.Bodyparts_InfoTableAdapter bodyparts_InfoTableAdapter;
        private FITZONEDataSet1 fITZONEDataSet1;
        private System.Windows.Forms.BindingSource exerciseInfoBindingSource;
        private FITZONEDataSet1TableAdapters.Exercise_InfoTableAdapter exercise_InfoTableAdapter;
        private System.Windows.Forms.ListBox listboxcount;
        private System.Windows.Forms.Label lblexpc;
    }
}