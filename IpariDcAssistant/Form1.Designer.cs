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
            this.panelServers = new System.Windows.Forms.Panel();
            this.lbRooms = new System.Windows.Forms.ListBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.lblServerName = new System.Windows.Forms.Label();
            this.circleIpari = new IpariDcAssistant.Circle();
            this.circleCsáki = new IpariDcAssistant.Circle();
            this.panelServers.SuspendLayout();
            this.panelRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelServers
            // 
            this.panelServers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panelServers.Controls.Add(this.circleIpari);
            this.panelServers.Controls.Add(this.circleCsáki);
            this.panelServers.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelServers.Location = new System.Drawing.Point(0, 0);
            this.panelServers.Name = "panelServers";
            this.panelServers.Size = new System.Drawing.Size(76, 461);
            this.panelServers.TabIndex = 6;
            // 
            // lbRooms
            // 
            this.lbRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.lbRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbRooms.ForeColor = System.Drawing.Color.Silver;
            this.lbRooms.FormattingEnabled = true;
            this.lbRooms.ItemHeight = 20;
            this.lbRooms.Location = new System.Drawing.Point(16, 54);
            this.lbRooms.Margin = new System.Windows.Forms.Padding(16);
            this.lbRooms.Name = "lbRooms";
            this.lbRooms.Size = new System.Drawing.Size(168, 400);
            this.lbRooms.TabIndex = 7;
            this.lbRooms.SelectedIndexChanged += new System.EventHandler(this.lbRooms_SelectedIndexChanged);
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.tbInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInput.ForeColor = System.Drawing.Color.White;
            this.tbInput.Location = new System.Drawing.Point(282, 409);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(490, 40);
            this.tbInput.TabIndex = 8;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.tbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOutput.ForeColor = System.Drawing.Color.Silver;
            this.tbOutput.Location = new System.Drawing.Point(295, 25);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(16, 16, 0, 0);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(477, 381);
            this.tbOutput.TabIndex = 9;
            // 
            // panelRooms
            // 
            this.panelRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.panelRooms.Controls.Add(this.lblServerName);
            this.panelRooms.Controls.Add(this.lbRooms);
            this.panelRooms.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRooms.Location = new System.Drawing.Point(76, 0);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(200, 461);
            this.panelRooms.TabIndex = 10;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblServerName.Location = new System.Drawing.Point(6, 18);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(192, 20);
            this.lblServerName.TabIndex = 8;
            this.lblServerName.Text = "Kattints az egyik körre!";
            // 
            // circleIpari
            // 
            this.circleIpari.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.circleIpari.ForeColor = System.Drawing.Color.Chocolate;
            this.circleIpari.Location = new System.Drawing.Point(8, 84);
            this.circleIpari.Margin = new System.Windows.Forms.Padding(8);
            this.circleIpari.Name = "circleIpari";
            this.circleIpari.Size = new System.Drawing.Size(60, 60);
            this.circleIpari.TabIndex = 1;
            this.circleIpari.Text = " I";
            this.circleIpari.Click += new System.EventHandler(this.circleIpari_Click);
            // 
            // circleCsáki
            // 
            this.circleCsáki.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.circleCsáki.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.circleCsáki.Location = new System.Drawing.Point(8, 8);
            this.circleCsáki.Margin = new System.Windows.Forms.Padding(8);
            this.circleCsáki.Name = "circleCsáki";
            this.circleCsáki.Size = new System.Drawing.Size(60, 60);
            this.circleCsáki.TabIndex = 0;
            this.circleCsáki.Text = "C";
            this.circleCsáki.Click += new System.EventHandler(this.circleCsáki_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelRooms);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.panelServers);
            this.Controls.Add(this.tbOutput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Ipari Dc Assistant";
            this.panelServers.ResumeLayout(false);
            this.panelRooms.ResumeLayout(false);
            this.panelRooms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelServers;
        private Circle circleCsáki;
        private Circle circleIpari;
        private System.Windows.Forms.ListBox lbRooms;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Panel panelRooms;
        private System.Windows.Forms.Label lblServerName;
    }
}

