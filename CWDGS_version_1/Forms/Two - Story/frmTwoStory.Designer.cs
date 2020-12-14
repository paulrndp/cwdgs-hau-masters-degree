namespace CWDGS_version_1.Forms.Bungalow
{
    partial class frmTwoStory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTwoStory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imgs = new System.Windows.Forms.ImageList(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.doorBox = new System.Windows.Forms.ListBox();
            this.painterBox = new System.Windows.Forms.ListBox();
            this.tileManBox = new System.Windows.Forms.ListBox();
            this.masonBox = new System.Windows.Forms.ListBox();
            this.carpenterBox = new System.Windows.Forms.ListBox();
            this.steelManBox = new System.Windows.Forms.ListBox();
            this.laborBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 41);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Two - Story Residential Construction\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 223);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rate of Workers Per Day (PHP)";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 17);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(561, 203);
            this.dgv.TabIndex = 0;
            // 
            // col1
            // 
            this.col1.HeaderText = "Workers";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            // 
            // col2
            // 
            this.col2.HeaderText = "Rate";
            this.col2.Name = "col2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(33, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Note : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(81, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input value on the yellow cells";
            // 
            // imgs
            // 
            this.imgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs.ImageStream")));
            this.imgs.TransparentColor = System.Drawing.Color.Transparent;
            this.imgs.Images.SetKeyName(0, "start.png");
            this.imgs.Images.SetKeyName(1, "bungalow.png");
            this.imgs.Images.SetKeyName(2, "2-story.png");
            this.imgs.Images.SetKeyName(3, "test.png");
            this.imgs.Images.SetKeyName(4, "cement.png");
            this.imgs.Images.SetKeyName(5, "door.png");
            this.imgs.Images.SetKeyName(6, "excavator.png");
            this.imgs.Images.SetKeyName(7, "floor.png");
            this.imgs.Images.SetKeyName(8, "mansory.png");
            this.imgs.Images.SetKeyName(9, "painting.png");
            this.imgs.Images.SetKeyName(10, "plastering.png");
            this.imgs.Images.SetKeyName(11, "steel_frame.png");
            this.imgs.Images.SetKeyName(12, "steel.png");
            this.imgs.Images.SetKeyName(13, "hammering.png");
            this.imgs.Images.SetKeyName(14, "excavator-2.png");
            this.imgs.Images.SetKeyName(15, "paint-bucket.png");
            this.imgs.Images.SetKeyName(16, "cement-truck.png");
            this.imgs.Images.SetKeyName(17, "summary.png");
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ImageKey = "steel_frame.png";
            this.button10.ImageList = this.imgs;
            this.button10.Location = new System.Drawing.Point(584, 128);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(135, 82);
            this.button10.TabIndex = 10;
            this.button10.Text = "Ceiling";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ImageKey = "door.png";
            this.button9.ImageList = this.imgs;
            this.button9.Location = new System.Drawing.Point(422, 128);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(156, 82);
            this.button9.TabIndex = 9;
            this.button9.Text = "Doors";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ImageKey = "paint-bucket.png";
            this.button8.ImageList = this.imgs;
            this.button8.Location = new System.Drawing.Point(291, 128);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 82);
            this.button8.TabIndex = 8;
            this.button8.Text = "Painting Works";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ImageKey = "plastering.png";
            this.button7.ImageList = this.imgs;
            this.button7.Location = new System.Drawing.Point(152, 128);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 82);
            this.button7.TabIndex = 7;
            this.button7.Text = "Plastering Works";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ImageKey = "floor.png";
            this.button6.ImageList = this.imgs;
            this.button6.Location = new System.Drawing.Point(33, 128);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 82);
            this.button6.TabIndex = 6;
            this.button6.Text = "Flooring Works";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ImageKey = "mansory.png";
            this.button5.ImageList = this.imgs;
            this.button5.Location = new System.Drawing.Point(606, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 75);
            this.button5.TabIndex = 5;
            this.button5.Text = "Masonry Walls";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageKey = "cement-truck.png";
            this.button4.ImageList = this.imgs;
            this.button4.Location = new System.Drawing.Point(458, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 75);
            this.button4.TabIndex = 4;
            this.button4.Text = "Reinforced Cement Concrete";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageKey = "hammering.png";
            this.button3.ImageList = this.imgs;
            this.button3.Location = new System.Drawing.Point(334, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 75);
            this.button3.TabIndex = 3;
            this.button3.Text = "Formworks";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageKey = "steel.png";
            this.button2.ImageList = this.imgs;
            this.button2.Location = new System.Drawing.Point(152, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "Steel Reinforcement Work";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageKey = "excavator-2.png";
            this.button1.ImageList = this.imgs;
            this.button1.Location = new System.Drawing.Point(33, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "Earthworks";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ImageKey = "summary.png";
            this.button11.ImageList = this.imgs;
            this.button11.Location = new System.Drawing.Point(606, 348);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(113, 88);
            this.button11.TabIndex = 12;
            this.button11.Text = "See Summary";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // doorBox
            // 
            this.doorBox.FormattingEnabled = true;
            this.doorBox.Location = new System.Drawing.Point(777, 357);
            this.doorBox.Name = "doorBox";
            this.doorBox.Size = new System.Drawing.Size(60, 95);
            this.doorBox.TabIndex = 25;
            // 
            // painterBox
            // 
            this.painterBox.FormattingEnabled = true;
            this.painterBox.Location = new System.Drawing.Point(909, 200);
            this.painterBox.Name = "painterBox";
            this.painterBox.Size = new System.Drawing.Size(60, 147);
            this.painterBox.TabIndex = 24;
            // 
            // tileManBox
            // 
            this.tileManBox.FormattingEnabled = true;
            this.tileManBox.Location = new System.Drawing.Point(843, 200);
            this.tileManBox.Name = "tileManBox";
            this.tileManBox.Size = new System.Drawing.Size(60, 147);
            this.tileManBox.TabIndex = 23;
            // 
            // masonBox
            // 
            this.masonBox.FormattingEnabled = true;
            this.masonBox.Location = new System.Drawing.Point(777, 200);
            this.masonBox.Name = "masonBox";
            this.masonBox.Size = new System.Drawing.Size(60, 147);
            this.masonBox.TabIndex = 22;
            // 
            // carpenterBox
            // 
            this.carpenterBox.FormattingEnabled = true;
            this.carpenterBox.Location = new System.Drawing.Point(909, 47);
            this.carpenterBox.Name = "carpenterBox";
            this.carpenterBox.Size = new System.Drawing.Size(60, 147);
            this.carpenterBox.TabIndex = 21;
            // 
            // steelManBox
            // 
            this.steelManBox.FormattingEnabled = true;
            this.steelManBox.Location = new System.Drawing.Point(843, 47);
            this.steelManBox.Name = "steelManBox";
            this.steelManBox.Size = new System.Drawing.Size(60, 147);
            this.steelManBox.TabIndex = 20;
            // 
            // laborBox
            // 
            this.laborBox.FormattingEnabled = true;
            this.laborBox.Location = new System.Drawing.Point(777, 47);
            this.laborBox.Name = "laborBox";
            this.laborBox.Size = new System.Drawing.Size(60, 147);
            this.laborBox.TabIndex = 19;
            // 
            // frmTwoStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 466);
            this.Controls.Add(this.doorBox);
            this.Controls.Add(this.painterBox);
            this.Controls.Add(this.tileManBox);
            this.Controls.Add(this.masonBox);
            this.Controls.Add(this.carpenterBox);
            this.Controls.Add(this.steelManBox);
            this.Controls.Add(this.laborBox);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTwoStory";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Two - Story";
            this.Load += new System.EventHandler(this.frmTwoStory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imgs;
        private System.Windows.Forms.Button button11;
        public System.Windows.Forms.ListBox doorBox;
        public System.Windows.Forms.ListBox painterBox;
        public System.Windows.Forms.ListBox tileManBox;
        public System.Windows.Forms.ListBox masonBox;
        public System.Windows.Forms.ListBox carpenterBox;
        public System.Windows.Forms.ListBox steelManBox;
        public System.Windows.Forms.ListBox laborBox;
    }
}