namespace ApacheHelper
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
            this.apacheDirButton = new System.Windows.Forms.Button();
            this.apacheDirLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vhostListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hostsListBox = new System.Windows.Forms.ListBox();
            this.createVHost = new System.Windows.Forms.Button();
            this.changeDocumentRootButton = new System.Windows.Forms.Button();
            this.documentRootLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // apacheDirButton
            // 
            this.apacheDirButton.AutoSize = true;
            this.apacheDirButton.Location = new System.Drawing.Point(18, 23);
            this.apacheDirButton.Name = "apacheDirButton";
            this.apacheDirButton.Size = new System.Drawing.Size(99, 23);
            this.apacheDirButton.TabIndex = 0;
            this.apacheDirButton.Text = "Apache Directory";
            this.apacheDirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.apacheDirButton.UseVisualStyleBackColor = true;
            this.apacheDirButton.Click += new System.EventHandler(this.apacheDirButton_Click);
            // 
            // apacheDirLabel
            // 
            this.apacheDirLabel.AutoSize = true;
            this.apacheDirLabel.Location = new System.Drawing.Point(124, 28);
            this.apacheDirLabel.Name = "apacheDirLabel";
            this.apacheDirLabel.Size = new System.Drawing.Size(89, 13);
            this.apacheDirLabel.TabIndex = 1;
            this.apacheDirLabel.Text = "Apache Directory";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vhostListBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 299);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apache VHosts";
            // 
            // vhostListBox
            // 
            this.vhostListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vhostListBox.FormattingEnabled = true;
            this.vhostListBox.Location = new System.Drawing.Point(3, 16);
            this.vhostListBox.Name = "vhostListBox";
            this.vhostListBox.Size = new System.Drawing.Size(331, 280);
            this.vhostListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hostsListBox);
            this.groupBox2.Location = new System.Drawing.Point(368, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 299);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hosts";
            // 
            // hostsListBox
            // 
            this.hostsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostsListBox.FormattingEnabled = true;
            this.hostsListBox.Location = new System.Drawing.Point(3, 16);
            this.hostsListBox.Name = "hostsListBox";
            this.hostsListBox.Size = new System.Drawing.Size(331, 280);
            this.hostsListBox.TabIndex = 0;
            // 
            // createVHost
            // 
            this.createVHost.AutoSize = true;
            this.createVHost.Location = new System.Drawing.Point(18, 101);
            this.createVHost.Name = "createVHost";
            this.createVHost.Size = new System.Drawing.Size(99, 23);
            this.createVHost.TabIndex = 4;
            this.createVHost.Text = "New VHOST";
            this.createVHost.UseVisualStyleBackColor = true;
            this.createVHost.Click += new System.EventHandler(this.createVHost_Click);
            // 
            // changeDocumentRootButton
            // 
            this.changeDocumentRootButton.AutoSize = true;
            this.changeDocumentRootButton.Location = new System.Drawing.Point(18, 61);
            this.changeDocumentRootButton.Name = "changeDocumentRootButton";
            this.changeDocumentRootButton.Size = new System.Drawing.Size(99, 23);
            this.changeDocumentRootButton.TabIndex = 5;
            this.changeDocumentRootButton.Text = "Document Root";
            this.changeDocumentRootButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.changeDocumentRootButton.UseVisualStyleBackColor = true;
            this.changeDocumentRootButton.Click += new System.EventHandler(this.changeDocumentRootButton_Click);
            // 
            // documentRootLabel
            // 
            this.documentRootLabel.AutoSize = true;
            this.documentRootLabel.Location = new System.Drawing.Point(124, 66);
            this.documentRootLabel.Name = "documentRootLabel";
            this.documentRootLabel.Size = new System.Drawing.Size(82, 13);
            this.documentRootLabel.TabIndex = 6;
            this.documentRootLabel.Text = "Document Root";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Browse to the folder that represents your public root";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.documentRootLabel);
            this.Controls.Add(this.changeDocumentRootButton);
            this.Controls.Add(this.createVHost);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.apacheDirLabel);
            this.Controls.Add(this.apacheDirButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Apace Helper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apacheDirButton;
        private System.Windows.Forms.Label apacheDirLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button createVHost;
        private System.Windows.Forms.ListBox vhostListBox;
        private System.Windows.Forms.ListBox hostsListBox;
        private System.Windows.Forms.Button changeDocumentRootButton;
        private System.Windows.Forms.Label documentRootLabel;
        private System.Windows.Forms.Label label1;
    }
}

