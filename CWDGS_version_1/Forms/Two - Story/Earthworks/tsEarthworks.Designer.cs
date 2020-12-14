namespace CWDGS_version_1.Forms.Bungalow.Earthworks
{
    partial class tsEarthworks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tsEarthworks));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtCum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExcavation = new System.Windows.Forms.TextBox();
            this.txtPreffered = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtWorkers = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCostOfLabor = new System.Windows.Forms.TextBox();
            this.imgs = new System.Windows.Forms.ImageList(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.soft = new System.Windows.Forms.TextBox();
            this.hard = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soil Type : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Soft",
            "Hard"});
            this.comboBox1.Location = new System.Drawing.Point(125, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 22);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCum
            // 
            this.txtCum.Location = new System.Drawing.Point(207, 8);
            this.txtCum.Name = "txtCum";
            this.txtCum.ReadOnly = true;
            this.txtCum.Size = new System.Drawing.Size(44, 22);
            this.txtCum.TabIndex = 2;
            this.txtCum.TabStop = false;
            this.txtCum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "cum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Excavation :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Preffered Time :\r\n";
            // 
            // txtExcavation
            // 
            this.txtExcavation.BackColor = System.Drawing.Color.Yellow;
            this.txtExcavation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcavation.Location = new System.Drawing.Point(125, 36);
            this.txtExcavation.Name = "txtExcavation";
            this.txtExcavation.Size = new System.Drawing.Size(76, 22);
            this.txtExcavation.TabIndex = 1;
            this.txtExcavation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExcavation.Click += new System.EventHandler(this.txtExcavation_Click);
            this.txtExcavation.TextChanged += new System.EventHandler(this.txtExcavation_TextChanged);
            this.txtExcavation.Enter += new System.EventHandler(this.txtExcavation_Enter);
            // 
            // txtPreffered
            // 
            this.txtPreffered.BackColor = System.Drawing.Color.Yellow;
            this.txtPreffered.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreffered.Location = new System.Drawing.Point(125, 64);
            this.txtPreffered.Name = "txtPreffered";
            this.txtPreffered.Size = new System.Drawing.Size(76, 22);
            this.txtPreffered.TabIndex = 2;
            this.txtPreffered.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPreffered.Click += new System.EventHandler(this.txtPreffered_Click);
            this.txtPreffered.TextChanged += new System.EventHandler(this.txtPreffered_TextChanged);
            this.txtPreffered.Enter += new System.EventHandler(this.txtPreffered_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "# of days : ";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(125, 117);
            this.txtDays.Name = "txtDays";
            this.txtDays.ReadOnly = true;
            this.txtDays.Size = new System.Drawing.Size(76, 22);
            this.txtDays.TabIndex = 14;
            this.txtDays.TabStop = false;
            this.txtDays.Text = "0";
            this.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWorkers
            // 
            this.txtWorkers.Location = new System.Drawing.Point(125, 145);
            this.txtWorkers.Name = "txtWorkers";
            this.txtWorkers.ReadOnly = true;
            this.txtWorkers.Size = new System.Drawing.Size(76, 22);
            this.txtWorkers.TabIndex = 16;
            this.txtWorkers.TabStop = false;
            this.txtWorkers.Text = "0";
            this.txtWorkers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWorkers.TextChanged += new System.EventHandler(this.txtWorkers_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "# of workers : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 14);
            this.label9.TabIndex = 17;
            this.label9.Text = "day/s";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 14);
            this.label10.TabIndex = 18;
            this.label10.Text = "worker/s";
            // 
            // txtLabor
            // 
            this.txtLabor.Location = new System.Drawing.Point(125, 210);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.ReadOnly = true;
            this.txtLabor.Size = new System.Drawing.Size(76, 22);
            this.txtLabor.TabIndex = 20;
            this.txtLabor.TabStop = false;
            this.txtLabor.Text = "0";
            this.txtLabor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLabor.TextChanged += new System.EventHandler(this.txtLabor_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 14);
            this.label11.TabIndex = 19;
            this.label11.Text = "LABORER";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(125, 238);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(76, 22);
            this.txtCost.TabIndex = 22;
            this.txtCost.TabStop = false;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 14);
            this.label12.TabIndex = 21;
            this.label12.Text = "Cost of Labor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(207, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 14);
            this.label13.TabIndex = 23;
            this.label13.Text = "worker/s";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(207, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 14);
            this.label14.TabIndex = 24;
            this.label14.Text = "Php";
            // 
            // txtCostOfLabor
            // 
            this.txtCostOfLabor.Location = new System.Drawing.Point(331, 11);
            this.txtCostOfLabor.Name = "txtCostOfLabor";
            this.txtCostOfLabor.ReadOnly = true;
            this.txtCostOfLabor.Size = new System.Drawing.Size(42, 22);
            this.txtCostOfLabor.TabIndex = 25;
            this.txtCostOfLabor.TabStop = false;
            this.txtCostOfLabor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imgs
            // 
            this.imgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs.ImageStream")));
            this.imgs.TransparentColor = System.Drawing.Color.Transparent;
            this.imgs.Images.SetKeyName(0, "check.png");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(254, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 14);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "cum/day";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.ImageKey = "check.png";
            this.btnSave.ImageList = this.imgs;
            this.btnSave.Location = new System.Drawing.Point(0, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(425, 38);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // soft
            // 
            this.soft.Location = new System.Drawing.Point(331, 39);
            this.soft.Name = "soft";
            this.soft.ReadOnly = true;
            this.soft.Size = new System.Drawing.Size(42, 22);
            this.soft.TabIndex = 25;
            this.soft.TabStop = false;
            this.soft.Text = "3";
            this.soft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hard
            // 
            this.hard.Location = new System.Drawing.Point(331, 69);
            this.hard.Name = "hard";
            this.hard.ReadOnly = true;
            this.hard.Size = new System.Drawing.Size(42, 22);
            this.hard.TabIndex = 25;
            this.hard.TabStop = false;
            this.hard.Text = "2";
            this.hard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tsEarthworks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 315);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.soft);
            this.Controls.Add(this.txtCostOfLabor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLabor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWorkers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPreffered);
            this.Controls.Add(this.txtExcavation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCum);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tsEarthworks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eartworks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExcavation;
        private System.Windows.Forms.TextBox txtPreffered;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtWorkers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtCostOfLabor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ImageList imgs;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.TextBox txtCum;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox soft;
        public System.Windows.Forms.TextBox hard;
        public System.Windows.Forms.TextBox txtCost;
        public System.Windows.Forms.TextBox txtLabor;
    }
}