namespace CWDGS_version_1.Forms
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imgs = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScope = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBungalow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(0, 570);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1076, 49);
            this.textBox1.TabIndex = 999;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imgs
            // 
            this.imgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs.ImageStream")));
            this.imgs.TransparentColor = System.Drawing.Color.Transparent;
            this.imgs.Images.SetKeyName(0, "start.png");
            this.imgs.Images.SetKeyName(1, "bungalow.png");
            this.imgs.Images.SetKeyName(2, "2-story.png");
            this.imgs.Images.SetKeyName(3, "test.png");
            this.imgs.Images.SetKeyName(4, "iconfinder_plus_add_green_61658.png");
            this.imgs.Images.SetKeyName(5, "iconfinder_download_box_blue_61591.png");
            this.imgs.Images.SetKeyName(6, "delete.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(824, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 105);
            this.button1.TabIndex = 1000;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(83, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Construction Worker";
            // 
            // btnScope
            // 
            this.btnScope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScope.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScope.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScope.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnScope.ImageIndex = 5;
            this.btnScope.ImageList = this.imgs;
            this.btnScope.Location = new System.Drawing.Point(892, 10);
            this.btnScope.Name = "btnScope";
            this.btnScope.Size = new System.Drawing.Size(83, 76);
            this.btnScope.TabIndex = 1;
            this.btnScope.Text = "Projects";
            this.btnScope.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnScope.UseVisualStyleBackColor = true;
            this.btnScope.Click += new System.EventHandler(this.btnScope_Click);
            // 
            // pictureBox1
            // 

            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnBungalow
            // 
            this.btnBungalow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBungalow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBungalow.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBungalow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBungalow.ImageIndex = 4;
            this.btnBungalow.ImageList = this.imgs;
            this.btnBungalow.Location = new System.Drawing.Point(803, 10);
            this.btnBungalow.Name = "btnBungalow";
            this.btnBungalow.Size = new System.Drawing.Size(83, 76);
            this.btnBungalow.TabIndex = 2;
            this.btnBungalow.Text = "New";
            this.btnBungalow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBungalow.UseVisualStyleBackColor = true;
            this.btnBungalow.Click += new System.EventHandler(this.btnBungalow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(89, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Distribution Guide System";
            // 
            // btnStory
            // 
            this.btnStory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStory.ImageIndex = 6;
            this.btnStory.ImageList = this.imgs;
            this.btnStory.Location = new System.Drawing.Point(981, 10);
            this.btnStory.Name = "btnStory";
            this.btnStory.Size = new System.Drawing.Size(83, 76);
            this.btnStory.TabIndex = 3;
            this.btnStory.Text = "Exit";
            this.btnStory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStory.UseVisualStyleBackColor = true;
            this.btnStory.Click += new System.EventHandler(this.btnStory_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnStory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBungalow);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnScope);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 95);
            this.panel1.TabIndex = 1;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Construction Worker Distribution Guide System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList imgs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScope;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBungalow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStory;
        private System.Windows.Forms.Panel panel1;
    }
}