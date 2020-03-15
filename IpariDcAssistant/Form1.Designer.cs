namespace IpariDcAssistant
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbSearch = new System.Windows.Forms.ListBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.numSearch = new System.Windows.Forms.NumericUpDown();
            this.lblSearch1 = new System.Windows.Forms.Label();
            this.lblSearch2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAll = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbStudent = new System.Windows.Forms.TextBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSearch)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSearch
            // 
            this.lbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbSearch.FormattingEnabled = true;
            this.lbSearch.ItemHeight = 20;
            this.lbSearch.Location = new System.Drawing.Point(9, 71);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(454, 140);
            this.lbSearch.TabIndex = 0;
            // 
            // cbSearch
            // 
            this.cbSearch.BackColor = System.Drawing.Color.Black;
            this.cbSearch.ForeColor = System.Drawing.Color.White;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "Ny"});
            this.cbSearch.Location = new System.Drawing.Point(108, 29);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(80, 28);
            this.cbSearch.TabIndex = 1;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.Search);
            // 
            // numSearch
            // 
            this.numSearch.BackColor = System.Drawing.Color.Black;
            this.numSearch.ForeColor = System.Drawing.Color.White;
            this.numSearch.Location = new System.Drawing.Point(9, 31);
            this.numSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSearch.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numSearch.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numSearch.Name = "numSearch";
            this.numSearch.Size = new System.Drawing.Size(90, 26);
            this.numSearch.TabIndex = 2;
            this.numSearch.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numSearch.ValueChanged += new System.EventHandler(this.Search);
            // 
            // lblSearch1
            // 
            this.lblSearch1.AutoSize = true;
            this.lblSearch1.Location = new System.Drawing.Point(8, 5);
            this.lblSearch1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch1.Name = "lblSearch1";
            this.lblSearch1.Size = new System.Drawing.Size(73, 20);
            this.lblSearch1.TabIndex = 3;
            this.lblSearch1.Text = "Évfolyam";
            // 
            // lblSearch2
            // 
            this.lblSearch2.AutoSize = true;
            this.lblSearch2.Location = new System.Drawing.Point(104, 5);
            this.lblSearch2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch2.Name = "lblSearch2";
            this.lblSearch2.Size = new System.Drawing.Size(45, 20);
            this.lblSearch2.TabIndex = 4;
            this.lblSearch2.Text = "Szak";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 461);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage1.Controls.Add(this.btnAll);
            this.tabPage1.Controls.Add(this.lblSearch1);
            this.tabPage1.Controls.Add(this.lbSearch);
            this.tabPage1.Controls.Add(this.lblSearch2);
            this.tabPage1.Controls.Add(this.cbSearch);
            this.tabPage1.Controls.Add(this.numSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(476, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Osztályok";
            // 
            // btnAll
            // 
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Location = new System.Drawing.Point(196, 10);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(112, 47);
            this.btnAll.TabIndex = 5;
            this.btnAll.Text = "Összes diák";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage2.Controls.Add(this.tbStudent);
            this.tabPage2.Controls.Add(this.lblStudent);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(776, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diákok";
            // 
            // tbStudent
            // 
            this.tbStudent.BackColor = System.Drawing.Color.Black;
            this.tbStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStudent.ForeColor = System.Drawing.Color.White;
            this.tbStudent.Location = new System.Drawing.Point(9, 9);
            this.tbStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbStudent.Name = "tbStudent";
            this.tbStudent.Size = new System.Drawing.Size(200, 26);
            this.tbStudent.TabIndex = 0;
            this.tbStudent.TextChanged += new System.EventHandler(this.tbStudent_TextChanged);
            // 
            // lblStudent
            // 
            this.lblStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudent.Location = new System.Drawing.Point(4, 5);
            this.lblStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(768, 418);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "Kezdj el írni egy nevet!";
            this.lblStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Infó";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(770, 422);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.Text = "Ipari Dc Assistant";
            ((System.ComponentModel.ISupportInitialize)(this.numSearch)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.NumericUpDown numSearch;
        private System.Windows.Forms.Label lblSearch1;
        private System.Windows.Forms.Label lblSearch2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbStudent;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

