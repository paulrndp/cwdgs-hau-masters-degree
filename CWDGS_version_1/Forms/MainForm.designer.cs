using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.MaterialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.styleError = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton9 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.twostoryRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.bungalowRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = new System.Windows.Forms.Label();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton10 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.menuIconList = new System.Windows.Forms.ImageList(this.components);
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.disabledItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item3ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMansory = new MaterialSkin.Controls.MaterialButton();
            this.btnSteel = new MaterialSkin.Controls.MaterialButton();
            this.btnReinforce = new MaterialSkin.Controls.MaterialButton();
            this.btnPlastering = new MaterialSkin.Controls.MaterialButton();
            this.btnPaint = new MaterialSkin.Controls.MaterialButton();
            this.btnForm = new MaterialSkin.Controls.MaterialButton();
            this.btnFloor = new MaterialSkin.Controls.MaterialButton();
            this.btnEarth = new MaterialSkin.Controls.MaterialButton();
            this.btnDoors = new MaterialSkin.Controls.MaterialButton();
            this.btnCeiling = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage7);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.menuIconList;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(995, 574);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialButton2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.materialLabel24);
            this.tabPage1.Controls.Add(this.materialLabel9);
            this.tabPage1.Controls.Add(this.materialButton7);
            this.tabPage1.Controls.Add(this.MaterialButton4);
            this.tabPage1.ImageKey = "home.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(987, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // materialLabel24
            // 
            this.materialLabel24.AutoSize = true;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel24.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel24.Location = new System.Drawing.Point(173, 19);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Size = new System.Drawing.Size(129, 58);
            this.materialLabel24.TabIndex = 32;
            this.materialLabel24.Text = "Home";
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(173, 81);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(751, 69);
            this.materialLabel9.TabIndex = 0;
            this.materialLabel9.Text = resources.GetString("materialLabel9.Text");
            // 
            // materialButton7
            // 
            this.materialButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton7.Depth = 0;
            this.materialButton7.DrawShadows = true;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = null;
            this.materialButton7.Location = new System.Drawing.Point(808, 484);
            this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.Size = new System.Drawing.Size(133, 36);
            this.materialButton7.TabIndex = 0;
            this.materialButton7.Text = "Change Theme";
            this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton7.UseAccentColor = false;
            this.materialButton7.UseVisualStyleBackColor = true;
            this.materialButton7.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // MaterialButton4
            // 
            this.MaterialButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaterialButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaterialButton4.Depth = 0;
            this.MaterialButton4.DrawShadows = true;
            this.MaterialButton4.HighEmphasis = true;
            this.MaterialButton4.Icon = null;
            this.MaterialButton4.Location = new System.Drawing.Point(650, 484);
            this.MaterialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaterialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialButton4.Name = "MaterialButton4";
            this.MaterialButton4.Size = new System.Drawing.Size(140, 36);
            this.MaterialButton4.TabIndex = 22;
            this.MaterialButton4.Text = "Change Colors";
            this.MaterialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MaterialButton4.UseAccentColor = false;
            this.MaterialButton4.UseVisualStyleBackColor = true;
            this.MaterialButton4.Click += new System.EventHandler(this.MaterialButton1_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.White;
            this.tabPage7.Controls.Add(this.styleError);
            this.tabPage7.Controls.Add(this.materialLabel4);
            this.tabPage7.Controls.Add(this.materialLabel3);
            this.tabPage7.Controls.Add(this.materialButton9);
            this.tabPage7.Controls.Add(this.materialLabel2);
            this.tabPage7.Controls.Add(this.twostoryRadio);
            this.tabPage7.Controls.Add(this.bungalowRadio);
            this.tabPage7.Controls.Add(this.materialTextBox6);
            this.tabPage7.Controls.Add(this.materialLabel25);
            this.tabPage7.Controls.Add(this.materialLabel8);
            this.tabPage7.ImageKey = "plus.png";
            this.tabPage7.Location = new System.Drawing.Point(4, 31);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(987, 539);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "New Project";
            // 
            // styleError
            // 
            this.styleError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.styleError.AutoSize = true;
            this.styleError.Depth = 0;
            this.styleError.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.styleError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.styleError.HighEmphasis = true;
            this.styleError.Location = new System.Drawing.Point(413, 237);
            this.styleError.MouseState = MaterialSkin.MouseState.HOVER;
            this.styleError.Name = "styleError";
            this.styleError.Size = new System.Drawing.Size(141, 19);
            this.styleError.TabIndex = 72;
            this.styleError.Text = "Please select style *";
            this.styleError.UseAccent = true;
            this.styleError.Visible = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 499);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(981, 37);
            this.materialLabel4.TabIndex = 71;
            this.materialLabel4.Text = resources.GetString("materialLabel4.Text");
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.Location = new System.Drawing.Point(594, 274);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(353, 19);
            this.materialLabel3.TabIndex = 70;
            this.materialLabel3.Text = "Empty or Input string was not in a correct format *";
            this.materialLabel3.UseAccent = true;
            this.materialLabel3.Visible = false;
            // 
            // materialButton9
            // 
            this.materialButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton9.AutoSize = false;
            this.materialButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton9.Depth = 0;
            this.materialButton9.DrawShadows = true;
            this.materialButton9.HighEmphasis = true;
            this.materialButton9.Icon = null;
            this.materialButton9.Location = new System.Drawing.Point(779, 221);
            this.materialButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton9.Name = "materialButton9";
            this.materialButton9.Size = new System.Drawing.Size(168, 36);
            this.materialButton9.TabIndex = 68;
            this.materialButton9.Text = "NEXT";
            this.materialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton9.UseAccentColor = false;
            this.materialButton9.UseVisualStyleBackColor = true;
            this.materialButton9.Click += new System.EventHandler(this.materialButton9_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(24, 233);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(61, 24);
            this.materialLabel2.TabIndex = 67;
            this.materialLabel2.Text = "Style : ";
            // 
            // twostoryRadio
            // 
            this.twostoryRadio.AutoSize = true;
            this.twostoryRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twostoryRadio.Depth = 0;
            this.twostoryRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.twostoryRadio.Location = new System.Drawing.Point(224, 228);
            this.twostoryRadio.Margin = new System.Windows.Forms.Padding(0);
            this.twostoryRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.twostoryRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.twostoryRadio.Name = "twostoryRadio";
            this.twostoryRadio.Ripple = true;
            this.twostoryRadio.Size = new System.Drawing.Size(123, 37);
            this.twostoryRadio.TabIndex = 66;
            this.twostoryRadio.TabStop = true;
            this.twostoryRadio.Text = "Two - Storey";
            this.twostoryRadio.UseVisualStyleBackColor = true;
            this.twostoryRadio.CheckedChanged += new System.EventHandler(this.twostoryRadio_CheckedChanged);
            // 
            // bungalowRadio
            // 
            this.bungalowRadio.AutoSize = true;
            this.bungalowRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bungalowRadio.Depth = 0;
            this.bungalowRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bungalowRadio.Location = new System.Drawing.Point(98, 228);
            this.bungalowRadio.Margin = new System.Windows.Forms.Padding(0);
            this.bungalowRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.bungalowRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.bungalowRadio.Name = "bungalowRadio";
            this.bungalowRadio.Ripple = true;
            this.bungalowRadio.Size = new System.Drawing.Size(106, 37);
            this.bungalowRadio.TabIndex = 64;
            this.bungalowRadio.TabStop = true;
            this.bungalowRadio.Text = "Bungalow";
            this.bungalowRadio.UseVisualStyleBackColor = true;
            this.bungalowRadio.CheckedChanged += new System.EventHandler(this.bungalowRadio_CheckedChanged);
            // 
            // materialTextBox6
            // 
            this.materialTextBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialTextBox6.Depth = 0;
            this.materialTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialTextBox6.Hint = "Type here";
            this.materialTextBox6.Location = new System.Drawing.Point(28, 159);
            this.materialTextBox6.MaxLength = 50;
            this.materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox6.Multiline = false;
            this.materialTextBox6.Name = "materialTextBox6";
            this.materialTextBox6.Size = new System.Drawing.Size(919, 50);
            this.materialTextBox6.TabIndex = 62;
            this.materialTextBox6.Text = "";
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel25.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel25.Location = new System.Drawing.Point(22, 13);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(258, 58);
            this.materialLabel25.TabIndex = 58;
            this.materialLabel25.Text = "New Project";
            // 
            // materialLabel8
            // 
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(25, 76);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(442, 37);
            this.materialLabel8.TabIndex = 57;
            this.materialLabel8.Text = "Enter the name of the new project and select the project style. ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Controls.Add(this.materialListView1);
            this.tabPage2.Controls.Add(this.id);
            this.tabPage2.Controls.Add(this.materialLabel5);
            this.tabPage2.Controls.Add(this.materialButton1);
            this.tabPage2.Controls.Add(this.materialButton10);
            this.tabPage2.Controls.Add(this.materialLabel26);
            this.tabPage2.ImageKey = "data.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(987, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Project List";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(274, 44);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(200, 19);
            this.materialLabel1.TabIndex = 76;
            this.materialLabel1.Text = "Please select project name *";
            this.materialLabel1.UseAccent = true;
            this.materialLabel1.Visible = false;
            // 
            // materialListView1
            // 
            this.materialListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(20, 73);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(603, 410);
            this.materialListView1.TabIndex = 73;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Project Name";
            this.columnHeader2.Width = 450;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(494, 49);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(13, 13);
            this.id.TabIndex = 75;
            this.id.Text = "0";
            this.id.Visible = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(3, 499);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(981, 37);
            this.materialLabel5.TabIndex = 72;
            this.materialLabel5.Text = resources.GetString("materialLabel5.Text");
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(713, 122);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(199, 36);
            this.materialButton1.TabIndex = 61;
            this.materialButton1.Text = "DELETE";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton10
            // 
            this.materialButton10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton10.AutoSize = false;
            this.materialButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton10.Depth = 0;
            this.materialButton10.DrawShadows = true;
            this.materialButton10.HighEmphasis = true;
            this.materialButton10.Icon = null;
            this.materialButton10.Location = new System.Drawing.Point(713, 74);
            this.materialButton10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton10.Name = "materialButton10";
            this.materialButton10.Size = new System.Drawing.Size(199, 36);
            this.materialButton10.TabIndex = 62;
            this.materialButton10.Text = "LOAD";
            this.materialButton10.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton10.UseAccentColor = true;
            this.materialButton10.UseVisualStyleBackColor = true;
            this.materialButton10.Click += new System.EventHandler(this.materialButton10_Click);
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel26.Location = new System.Drawing.Point(21, 12);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(242, 58);
            this.materialLabel26.TabIndex = 59;
            this.materialLabel26.Text = "Project List";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.btnMansory);
            this.tabPage3.Controls.Add(this.btnSteel);
            this.tabPage3.Controls.Add(this.btnReinforce);
            this.tabPage3.Controls.Add(this.btnPlastering);
            this.tabPage3.Controls.Add(this.btnPaint);
            this.tabPage3.Controls.Add(this.btnForm);
            this.tabPage3.Controls.Add(this.btnFloor);
            this.tabPage3.Controls.Add(this.btnEarth);
            this.tabPage3.Controls.Add(this.btnDoors);
            this.tabPage3.Controls.Add(this.btnCeiling);
            this.tabPage3.Controls.Add(this.materialLabel7);
            this.tabPage3.Controls.Add(this.materialLabel6);
            this.tabPage3.ImageKey = "kilo.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(987, 539);
            this.tabPage3.TabIndex = 7;
            this.tabPage3.Text = "Units";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(0, 502);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(987, 37);
            this.materialLabel7.TabIndex = 72;
            this.materialLabel7.Text = resources.GetString("materialLabel7.Text");
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel6.Location = new System.Drawing.Point(21, 12);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(111, 58);
            this.materialLabel6.TabIndex = 32;
            this.materialLabel6.Text = "Units";
            // 
            // menuIconList
            // 
            this.menuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIconList.ImageStream")));
            this.menuIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIconList.Images.SetKeyName(0, "round_assessment_white_24dp.png");
            this.menuIconList.Images.SetKeyName(1, "round_backup_white_24dp.png");
            this.menuIconList.Images.SetKeyName(2, "round_bluetooth_white_24dp.png");
            this.menuIconList.Images.SetKeyName(3, "round_bookmark_white_24dp.png");
            this.menuIconList.Images.SetKeyName(4, "round_build_white_24dp.png");
            this.menuIconList.Images.SetKeyName(5, "round_gps_fixed_white_24dp.png");
            this.menuIconList.Images.SetKeyName(6, "round_http_white_24dp.png");
            this.menuIconList.Images.SetKeyName(7, "round_report_problem_white_24dp.png");
            this.menuIconList.Images.SetKeyName(8, "round_swap_vert_white_24dp.png");
            this.menuIconList.Images.SetKeyName(9, "home.png");
            this.menuIconList.Images.SetKeyName(10, "plus.png");
            this.menuIconList.Images.SetKeyName(11, "data.png");
            this.menuIconList.Images.SetKeyName(12, "chart.png");
            this.menuIconList.Images.SetKeyName(13, "kilo.png");
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.disabledItemToolStripMenuItem,
            this.item2ToolStripMenuItem,
            this.toolStripSeparator1,
            this.item3ToolStripMenuItem});
            this.materialContextMenuStrip1.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(166, 130);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.AutoSize = false;
            this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subItem1ToolStripMenuItem,
            this.subItem2ToolStripMenuItem});
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item1ToolStripMenuItem.Text = "Item 1";
            // 
            // subItem1ToolStripMenuItem
            // 
            this.subItem1ToolStripMenuItem.AutoSize = false;
            this.subItem1ToolStripMenuItem.Name = "subItem1ToolStripMenuItem";
            this.subItem1ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem1ToolStripMenuItem.Text = "SubItem 1";
            // 
            // subItem2ToolStripMenuItem
            // 
            this.subItem2ToolStripMenuItem.AutoSize = false;
            this.subItem2ToolStripMenuItem.Name = "subItem2ToolStripMenuItem";
            this.subItem2ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem2ToolStripMenuItem.Text = "SubItem 2";
            // 
            // disabledItemToolStripMenuItem
            // 
            this.disabledItemToolStripMenuItem.AutoSize = false;
            this.disabledItemToolStripMenuItem.Enabled = false;
            this.disabledItemToolStripMenuItem.Name = "disabledItemToolStripMenuItem";
            this.disabledItemToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.disabledItemToolStripMenuItem.Text = "Disabled item";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.AutoSize = false;
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item2ToolStripMenuItem.Text = "Item 2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // item3ToolStripMenuItem
            // 
            this.item3ToolStripMenuItem.AutoSize = false;
            this.item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
            this.item3ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item3ToolStripMenuItem.Text = "Item 3";
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(650, 436);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(140, 36);
            this.materialButton2.TabIndex = 34;
            this.materialButton2.Text = "Change Colors";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CWDGS.Properties.Resources.builder;
            this.pictureBox1.Location = new System.Drawing.Point(23, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnMansory
            // 
            this.btnMansory.AutoSize = false;
            this.btnMansory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMansory.Depth = 0;
            this.btnMansory.DrawShadows = true;
            this.btnMansory.HighEmphasis = false;
            this.btnMansory.Icon = global::CWDGS.Properties.Resources.mansory;
            this.btnMansory.Location = new System.Drawing.Point(450, 270);
            this.btnMansory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMansory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMansory.Name = "btnMansory";
            this.btnMansory.Size = new System.Drawing.Size(168, 36);
            this.btnMansory.TabIndex = 128;
            this.btnMansory.Text = "Mansory Walls";
            this.btnMansory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMansory.UseAccentColor = false;
            this.btnMansory.UseVisualStyleBackColor = true;
            this.btnMansory.Click += new System.EventHandler(this.btnMansory_Click);
            // 
            // btnSteel
            // 
            this.btnSteel.AutoSize = false;
            this.btnSteel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSteel.Depth = 0;
            this.btnSteel.DrawShadows = true;
            this.btnSteel.HighEmphasis = false;
            this.btnSteel.Icon = global::CWDGS.Properties.Resources.bracket;
            this.btnSteel.Location = new System.Drawing.Point(274, 318);
            this.btnSteel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSteel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSteel.Name = "btnSteel";
            this.btnSteel.Size = new System.Drawing.Size(344, 36);
            this.btnSteel.TabIndex = 127;
            this.btnSteel.Text = "Steel Reinforcement works";
            this.btnSteel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSteel.UseAccentColor = false;
            this.btnSteel.UseVisualStyleBackColor = true;
            this.btnSteel.Click += new System.EventHandler(this.btnSteel_Click);
            // 
            // btnReinforce
            // 
            this.btnReinforce.AutoSize = false;
            this.btnReinforce.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReinforce.Depth = 0;
            this.btnReinforce.DrawShadows = true;
            this.btnReinforce.HighEmphasis = false;
            this.btnReinforce.Icon = global::CWDGS.Properties.Resources.concrete_mixer1;
            this.btnReinforce.Location = new System.Drawing.Point(274, 366);
            this.btnReinforce.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReinforce.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReinforce.Name = "btnReinforce";
            this.btnReinforce.Size = new System.Drawing.Size(344, 36);
            this.btnReinforce.TabIndex = 126;
            this.btnReinforce.Text = "reinforced cement concrete";
            this.btnReinforce.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReinforce.UseAccentColor = false;
            this.btnReinforce.UseVisualStyleBackColor = true;
            this.btnReinforce.Click += new System.EventHandler(this.btnReinforce_Click);
            // 
            // btnPlastering
            // 
            this.btnPlastering.AutoSize = false;
            this.btnPlastering.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlastering.Depth = 0;
            this.btnPlastering.DrawShadows = true;
            this.btnPlastering.HighEmphasis = false;
            this.btnPlastering.Icon = global::CWDGS.Properties.Resources.trowel;
            this.btnPlastering.Location = new System.Drawing.Point(450, 222);
            this.btnPlastering.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPlastering.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlastering.Name = "btnPlastering";
            this.btnPlastering.Size = new System.Drawing.Size(168, 36);
            this.btnPlastering.TabIndex = 125;
            this.btnPlastering.Text = "plastering";
            this.btnPlastering.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPlastering.UseAccentColor = false;
            this.btnPlastering.UseVisualStyleBackColor = true;
            this.btnPlastering.Click += new System.EventHandler(this.btnPlastering_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.AutoSize = false;
            this.btnPaint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPaint.Depth = 0;
            this.btnPaint.DrawShadows = true;
            this.btnPaint.HighEmphasis = false;
            this.btnPaint.Icon = global::CWDGS.Properties.Resources.paint_roller;
            this.btnPaint.Location = new System.Drawing.Point(450, 174);
            this.btnPaint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPaint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(168, 36);
            this.btnPaint.TabIndex = 124;
            this.btnPaint.Text = "painting";
            this.btnPaint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPaint.UseAccentColor = false;
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnForm
            // 
            this.btnForm.AutoSize = false;
            this.btnForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnForm.Depth = 0;
            this.btnForm.DrawShadows = true;
            this.btnForm.HighEmphasis = false;
            this.btnForm.Icon = global::CWDGS.Properties.Resources.beam1;
            this.btnForm.Location = new System.Drawing.Point(450, 126);
            this.btnForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(168, 36);
            this.btnForm.TabIndex = 123;
            this.btnForm.Text = "formworks";
            this.btnForm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnForm.UseAccentColor = false;
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnFloor
            // 
            this.btnFloor.AutoSize = false;
            this.btnFloor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFloor.Depth = 0;
            this.btnFloor.DrawShadows = true;
            this.btnFloor.HighEmphasis = false;
            this.btnFloor.Icon = global::CWDGS.Properties.Resources.floor;
            this.btnFloor.Location = new System.Drawing.Point(274, 270);
            this.btnFloor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFloor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFloor.Name = "btnFloor";
            this.btnFloor.Size = new System.Drawing.Size(168, 36);
            this.btnFloor.TabIndex = 122;
            this.btnFloor.Text = "flooring";
            this.btnFloor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFloor.UseAccentColor = false;
            this.btnFloor.UseVisualStyleBackColor = true;
            this.btnFloor.Click += new System.EventHandler(this.btnFloor_Click);
            // 
            // btnEarth
            // 
            this.btnEarth.AutoSize = false;
            this.btnEarth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEarth.Depth = 0;
            this.btnEarth.DrawShadows = true;
            this.btnEarth.HighEmphasis = false;
            this.btnEarth.Icon = global::CWDGS.Properties.Resources.concrete_mixer1;
            this.btnEarth.Location = new System.Drawing.Point(274, 222);
            this.btnEarth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEarth.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEarth.Name = "btnEarth";
            this.btnEarth.Size = new System.Drawing.Size(168, 36);
            this.btnEarth.TabIndex = 121;
            this.btnEarth.Text = "earthworks";
            this.btnEarth.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEarth.UseAccentColor = false;
            this.btnEarth.UseVisualStyleBackColor = true;
            this.btnEarth.Click += new System.EventHandler(this.btnEarth_Click);
            // 
            // btnDoors
            // 
            this.btnDoors.AutoSize = false;
            this.btnDoors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDoors.Depth = 0;
            this.btnDoors.DrawShadows = true;
            this.btnDoors.HighEmphasis = false;
            this.btnDoors.Icon = global::CWDGS.Properties.Resources.door1;
            this.btnDoors.Location = new System.Drawing.Point(274, 174);
            this.btnDoors.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDoors.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDoors.Name = "btnDoors";
            this.btnDoors.Size = new System.Drawing.Size(168, 36);
            this.btnDoors.TabIndex = 120;
            this.btnDoors.Text = "doors";
            this.btnDoors.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDoors.UseAccentColor = false;
            this.btnDoors.UseVisualStyleBackColor = true;
            this.btnDoors.Click += new System.EventHandler(this.btnDoors_Click);
            // 
            // btnCeiling
            // 
            this.btnCeiling.AutoSize = false;
            this.btnCeiling.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCeiling.Depth = 0;
            this.btnCeiling.DrawShadows = true;
            this.btnCeiling.HighEmphasis = false;
            this.btnCeiling.Icon = global::CWDGS.Properties.Resources.man_silhouette_touching_ceiling;
            this.btnCeiling.Location = new System.Drawing.Point(274, 126);
            this.btnCeiling.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCeiling.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCeiling.Name = "btnCeiling";
            this.btnCeiling.Size = new System.Drawing.Size(168, 36);
            this.btnCeiling.TabIndex = 119;
            this.btnCeiling.Text = "ceiling";
            this.btnCeiling.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCeiling.UseAccentColor = false;
            this.btnCeiling.UseVisualStyleBackColor = true;
            this.btnCeiling.Click += new System.EventHandler(this.btnCeiling_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 641);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Construction Worker Distribution Guide System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem disabledItemToolStripMenuItem;
        private ImageList menuIconList;
        private TabPage tabPage7;
        private MaterialLabel materialLabel8;
        private MaterialLabel materialLabel9;
        private MaterialButton MaterialButton4;
        private MaterialButton materialButton7;
        private MaterialLabel materialLabel24;
        private MaterialLabel materialLabel25;
        private MaterialLabel materialLabel26;
        private PictureBox pictureBox1;
        private MaterialLabel materialLabel2;
        private MaterialButton materialButton9;
        private MaterialLabel materialLabel4;
        private MaterialButton materialButton1;
        private MaterialButton materialButton10;
        private MaterialLabel materialLabel5;
        private Label id;
        private MaterialListView materialListView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private MaterialLabel materialLabel1;
        public MaterialTextBox materialTextBox6;
        public MaterialRadioButton bungalowRadio;
        public MaterialRadioButton twostoryRadio;
        public MaterialLabel materialLabel3;
        public MaterialLabel styleError;
        private TabPage tabPage3;
        private MaterialLabel materialLabel7;
        private MaterialLabel materialLabel6;
        private MaterialButton btnMansory;
        private MaterialButton btnSteel;
        private MaterialButton btnReinforce;
        private MaterialButton btnPlastering;
        private MaterialButton btnPaint;
        private MaterialButton btnForm;
        private MaterialButton btnFloor;
        private MaterialButton btnEarth;
        private MaterialButton btnDoors;
        private MaterialButton btnCeiling;
        private MaterialButton materialButton2;
    }
}