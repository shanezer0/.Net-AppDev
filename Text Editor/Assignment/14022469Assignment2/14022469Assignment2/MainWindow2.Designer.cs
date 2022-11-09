using System;
using System.Windows.Forms;

namespace _14022469Assignment2
{
    partial class MainWindow2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.File1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.New1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Open1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Save1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Cut1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.Cut2 = new System.Windows.Forms.ToolStripButton();
            this.Copy2 = new System.Windows.Forms.ToolStripButton();
            this.Paste2 = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.New2 = new System.Windows.Forms.ToolStripButton();
            this.Open2 = new System.Windows.Forms.ToolStripButton();
            this.Save2 = new System.Windows.Forms.ToolStripButton();
            this.SaveAs2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Bold = new System.Windows.Forms.ToolStripButton();
            this.Italic = new System.Windows.Forms.ToolStripButton();
            this.Underline = new System.Windows.Forms.ToolStripButton();
            this.FontBox = new System.Windows.Forms.ToolStripComboBox();
            this.UserLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // File1
            // 
            this.File1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.File1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New1,
            this.Open1,
            this.Save1,
            this.SaveAs1,
            this.LogOut});
            this.File1.Image = ((System.Drawing.Image)(resources.GetObject("File1.Image")));
            this.File1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.File1.Name = "File1";
            this.File1.Size = new System.Drawing.Size(38, 22);
            this.File1.Text = "File";
            this.File1.Click += new System.EventHandler(this.File1_Click);
            // 
            // New1
            // 
            this.New1.Image = ((System.Drawing.Image)(resources.GetObject("New1.Image")));
            this.New1.Name = "New1";
            this.New1.Size = new System.Drawing.Size(173, 22);
            this.New1.Text = " New          Ctrl+N";
            this.New1.Click += new System.EventHandler(this.New1_Click);
            // 
            // Open1
            // 
            this.Open1.Image = ((System.Drawing.Image)(resources.GetObject("Open1.Image")));
            this.Open1.Name = "Open1";
            this.Open1.Size = new System.Drawing.Size(173, 22);
            this.Open1.Text = "Open          Ctrl+O";
            this.Open1.Click += new System.EventHandler(this.Open1_Click);
            // 
            // Save1
            // 
            this.Save1.Image = ((System.Drawing.Image)(resources.GetObject("Save1.Image")));
            this.Save1.Name = "Save1";
            this.Save1.Size = new System.Drawing.Size(173, 22);
            this.Save1.Text = "Save            Ctrl + S";
            this.Save1.Click += new System.EventHandler(this.Save1_Click);
            // 
            // SaveAs1
            // 
            this.SaveAs1.Image = ((System.Drawing.Image)(resources.GetObject("SaveAs1.Image")));
            this.SaveAs1.Name = "SaveAs1";
            this.SaveAs1.Size = new System.Drawing.Size(173, 22);
            this.SaveAs1.Text = "Save As";
            this.SaveAs1.Click += new System.EventHandler(this.SaveAs1_Click);
            // 
            // LogOut
            // 
            this.LogOut.Image = ((System.Drawing.Image)(resources.GetObject("LogOut.Image")));
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(173, 22);
            this.LogOut.Text = "Logout";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cut1,
            this.Copy1,
            this.Paste1});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(40, 22);
            this.toolStripDropDownButton2.Text = "Edit";
            // 
            // Cut1
            // 
            this.Cut1.Image = ((System.Drawing.Image)(resources.GetObject("Cut1.Image")));
            this.Cut1.Name = "Cut1";
            this.Cut1.Size = new System.Drawing.Size(170, 22);
            this.Cut1.Text = "Cut            Ctrl + X";
            this.Cut1.Click += new System.EventHandler(this.Cut1_Click);
            // 
            // Copy1
            // 
            this.Copy1.Image = ((System.Drawing.Image)(resources.GetObject("Copy1.Image")));
            this.Copy1.Name = "Copy1";
            this.Copy1.Size = new System.Drawing.Size(170, 22);
            this.Copy1.Text = "Copy         Ctrl + C";
            this.Copy1.Click += new System.EventHandler(this.Copy1_Click);
            // 
            // Paste1
            // 
            this.Paste1.Image = ((System.Drawing.Image)(resources.GetObject("Paste1.Image")));
            this.Paste1.Name = "Paste1";
            this.Paste1.Size = new System.Drawing.Size(170, 22);
            this.Paste1.Text = "Paste         Ctrl + V";
            this.Paste1.Click += new System.EventHandler(this.Paste1_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton3.Text = "Help";
            // 
            // About
            // 
            this.About.Image = ((System.Drawing.Image)(resources.GetObject("About.Image")));
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(116, 22);
            this.About.Text = "About...";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cut2,
            this.Copy2,
            this.Paste2});
            this.toolStrip3.Location = new System.Drawing.Point(0, 50);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(24, 400);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // Cut2
            // 
            this.Cut2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cut2.Image = ((System.Drawing.Image)(resources.GetObject("Cut2.Image")));
            this.Cut2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cut2.Name = "Cut2";
            this.Cut2.Size = new System.Drawing.Size(21, 20);
            this.Cut2.Text = "Cut";
            this.Cut2.Click += new System.EventHandler(this.Cut1_Click);
            // 
            // Copy2
            // 
            this.Copy2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Copy2.Image = ((System.Drawing.Image)(resources.GetObject("Copy2.Image")));
            this.Copy2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copy2.Name = "Copy2";
            this.Copy2.Size = new System.Drawing.Size(21, 20);
            this.Copy2.Text = "Copy";
            this.Copy2.Click += new System.EventHandler(this.Copy1_Click);
            // 
            // Paste2
            // 
            this.Paste2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Paste2.Image = ((System.Drawing.Image)(resources.GetObject("Paste2.Image")));
            this.Paste2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Paste2.Name = "Paste2";
            this.Paste2.Size = new System.Drawing.Size(21, 20);
            this.Paste2.Text = "Paste";
            this.Paste2.Click += new System.EventHandler(this.Paste1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(24, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 400);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // New2
            // 
            this.New2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.New2.Image = ((System.Drawing.Image)(resources.GetObject("New2.Image")));
            this.New2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New2.Name = "New2";
            this.New2.Size = new System.Drawing.Size(23, 22);
            this.New2.Text = "New";
            this.New2.Click += new System.EventHandler(this.New2_Click);
            // 
            // Open2
            // 
            this.Open2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open2.Image = ((System.Drawing.Image)(resources.GetObject("Open2.Image")));
            this.Open2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open2.Name = "Open2";
            this.Open2.Size = new System.Drawing.Size(23, 22);
            this.Open2.Text = "Open";
            this.Open2.Click += new System.EventHandler(this.Open2_Click);
            // 
            // Save2
            // 
            this.Save2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save2.Image = ((System.Drawing.Image)(resources.GetObject("Save2.Image")));
            this.Save2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save2.Name = "Save2";
            this.Save2.Size = new System.Drawing.Size(23, 22);
            this.Save2.Text = "Save";
            this.Save2.Click += new System.EventHandler(this.Save1_Click);
            // 
            // SaveAs2
            // 
            this.SaveAs2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAs2.Image = ((System.Drawing.Image)(resources.GetObject("SaveAs2.Image")));
            this.SaveAs2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAs2.Name = "SaveAs2";
            this.SaveAs2.Size = new System.Drawing.Size(23, 22);
            this.SaveAs2.Text = "Save As";
            this.SaveAs2.Click += new System.EventHandler(this.SaveAs1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Bold
            // 
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bold.Image = ((System.Drawing.Image)(resources.GetObject("Bold.Image")));
            this.Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(23, 22);
            this.Bold.Text = "Bold";
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italic
            // 
            this.Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italic.Image = ((System.Drawing.Image)(resources.GetObject("Italic.Image")));
            this.Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(23, 22);
            this.Italic.Text = "Invert";
            this.Italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // Underline
            // 
            this.Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Underline.Image = ((System.Drawing.Image)(resources.GetObject("Underline.Image")));
            this.Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(23, 22);
            this.Underline.Text = "Underline";
            this.Underline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // FontBox
            // 
            this.FontBox.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40"});
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(121, 25);
            this.FontBox.Text = "12";
            this.FontBox.Click += new System.EventHandler(this.FontBox_Click_1);
            this.FontBox.TextChanged += new System.EventHandler(this.FontBox_TextChanged);
            // 
            // UserLabel
            // 
            this.UserLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(132, 22);
            this.UserLabel.Text = "Currently logged in as : ";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New2,
            this.Open2,
            this.Save2,
            this.SaveAs2,
            this.toolStripSeparator1,
            this.Bold,
            this.Italic,
            this.Underline,
            this.FontBox,
            this.UserLabel});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // MainWindow2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton File1;
        private System.Windows.Forms.ToolStripMenuItem New1;
        private System.Windows.Forms.ToolStripMenuItem Open1;
        private System.Windows.Forms.ToolStripMenuItem Save1;
        private System.Windows.Forms.ToolStripMenuItem SaveAs1;
        private System.Windows.Forms.ToolStripMenuItem LogOut;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem Cut1;
        private System.Windows.Forms.ToolStripMenuItem Copy1;
        private System.Windows.Forms.ToolStripMenuItem Paste1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem About;
        private LoginWindow loginWindow;
        private string v1;
        private string v2;
        private EventHandler newToolStripMenuItem_Click;

       /* public MainWindow2(LoginWindow loginWindow, string v1, string v2)
        {
            this.loginWindow = loginWindow;
            this.v1 = v1;
            this.v2 = v2;
        }*/

        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton Cut2;
        private System.Windows.Forms.ToolStripButton Copy2;
        private System.Windows.Forms.ToolStripButton Paste2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private ToolStripItemClickedEventHandler toolStrip1_ItemClicked;
        private EventHandler toolStripDropDownButton1_Click;
        private EventHandler openToolStripMenuItem_Click;
        private EventHandler saveToolStripMenuItem_Click;
        private ToolStripItemClickedEventHandler toolStrip2_ItemClicked;
        private EventHandler toolStripButton2_Click;
        private ToolStripButton New2;
        private ToolStripButton Open2;
        private ToolStripButton Save2;
        private ToolStripButton SaveAs2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton Bold;
        private ToolStripButton Italic;
        private ToolStripButton Underline;
        private ToolStripComboBox FontBox;
        private ToolStripLabel UserLabel;
        private ToolStrip toolStrip2;
    }
}