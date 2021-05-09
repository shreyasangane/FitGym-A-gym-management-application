namespace FITZONE
{
    partial class Home
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsearchempcust = new System.Windows.Forms.LinkLabel();
            this.lblviewreport = new System.Windows.Forms.Label();
            this.lblprogress = new System.Windows.Forms.LinkLabel();
            this.lbladdprogress = new System.Windows.Forms.LinkLabel();
            this.linkExercise = new System.Windows.Forms.LinkLabel();
            this.lblcustomer = new System.Windows.Forms.PictureBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lblcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(48, 195);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 18);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Customer ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(48, 284);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(74, 18);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Employee";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "FILL DATA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "VIEW DATA";
            // 
            // lblsearchempcust
            // 
            this.lblsearchempcust.AutoSize = true;
            this.lblsearchempcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchempcust.Location = new System.Drawing.Point(300, 182);
            this.lblsearchempcust.Name = "lblsearchempcust";
            this.lblsearchempcust.Size = new System.Drawing.Size(144, 18);
            this.lblsearchempcust.TabIndex = 6;
            this.lblsearchempcust.TabStop = true;
            this.lblsearchempcust.Text = "Customer/Employee";
            this.lblsearchempcust.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblsearchempcust_LinkClicked);
            // 
            // lblviewreport
            // 
            this.lblviewreport.AutoSize = true;
            this.lblviewreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblviewreport.Location = new System.Drawing.Point(583, 122);
            this.lblviewreport.Name = "lblviewreport";
            this.lblviewreport.Size = new System.Drawing.Size(287, 31);
            this.lblviewreport.TabIndex = 9;
            this.lblviewreport.Text = "View Customer Report";
            // 
            // lblprogress
            // 
            this.lblprogress.AutoSize = true;
            this.lblprogress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprogress.Location = new System.Drawing.Point(586, 284);
            this.lblprogress.Name = "lblprogress";
            this.lblprogress.Size = new System.Drawing.Size(104, 18);
            this.lblprogress.TabIndex = 10;
            this.lblprogress.TabStop = true;
            this.lblprogress.Text = "View Progress";
            this.lblprogress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblprogress_LinkClicked);
            // 
            // lbladdprogress
            // 
            this.lbladdprogress.AutoSize = true;
            this.lbladdprogress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdprogress.Location = new System.Drawing.Point(586, 182);
            this.lbladdprogress.Name = "lbladdprogress";
            this.lbladdprogress.Size = new System.Drawing.Size(149, 18);
            this.lbladdprogress.TabIndex = 11;
            this.lbladdprogress.TabStop = true;
            this.lbladdprogress.Text = "Update/Add Progress";
            this.lbladdprogress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbladdprogress_LinkClicked);
            // 
            // linkExercise
            // 
            this.linkExercise.AutoSize = true;
            this.linkExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkExercise.Location = new System.Drawing.Point(300, 264);
            this.linkExercise.Name = "linkExercise";
            this.linkExercise.Size = new System.Drawing.Size(73, 18);
            this.linkExercise.TabIndex = 12;
            this.linkExercise.TabStop = true;
            this.linkExercise.Text = "Exercises";
            this.linkExercise.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExercise_LinkClicked);
            // 
            // lblcustomer
            // 
            this.lblcustomer.Image = global::FITZONE.Properties.Resources.FitZone_Label2;
            this.lblcustomer.Location = new System.Drawing.Point(380, 12);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(160, 77);
            this.lblcustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lblcustomer.TabIndex = 1;
            this.lblcustomer.TabStop = false;
            this.lblcustomer.Click += new System.EventHandler(this.lblcustomer_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(48, 363);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(120, 18);
            this.linkLabel3.TabIndex = 13;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Exercise Change";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkExercise);
            this.Controls.Add(this.lbladdprogress);
            this.Controls.Add(this.lblprogress);
            this.Controls.Add(this.lblviewreport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblsearchempcust);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblcustomer);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lblcustomer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblsearchempcust;
        private System.Windows.Forms.Label lblviewreport;
        private System.Windows.Forms.LinkLabel lblprogress;
        private System.Windows.Forms.LinkLabel lbladdprogress;
        private System.Windows.Forms.LinkLabel linkExercise;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}