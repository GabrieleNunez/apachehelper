namespace ApacheHelper
{
    partial class VhostForm
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
            this.publicRootTextbox = new System.Windows.Forms.TextBox();
            this.serverNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serverAdminTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.publicRootButton = new System.Windows.Forms.Button();
            this.logLocationButton = new System.Windows.Forms.Button();
            this.logLocationTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // publicRootTextbox
            // 
            this.publicRootTextbox.Location = new System.Drawing.Point(111, 22);
            this.publicRootTextbox.Name = "publicRootTextbox";
            this.publicRootTextbox.Size = new System.Drawing.Size(286, 20);
            this.publicRootTextbox.TabIndex = 1;
            this.publicRootTextbox.TextChanged += new System.EventHandler(this.checkFormValues);
            // 
            // serverNameTextbox
            // 
            this.serverNameTextbox.Location = new System.Drawing.Point(111, 53);
            this.serverNameTextbox.Name = "serverNameTextbox";
            this.serverNameTextbox.Size = new System.Drawing.Size(286, 20);
            this.serverNameTextbox.TabIndex = 3;
            this.serverNameTextbox.TextChanged += new System.EventHandler(this.checkFormValues);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Name";
            // 
            // serverAdminTextBox
            // 
            this.serverAdminTextBox.Location = new System.Drawing.Point(111, 84);
            this.serverAdminTextBox.Name = "serverAdminTextBox";
            this.serverAdminTextBox.Size = new System.Drawing.Size(286, 20);
            this.serverAdminTextBox.TabIndex = 5;
            this.serverAdminTextBox.TextChanged += new System.EventHandler(this.checkFormValues);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Server Admin";
            // 
            // publicRootButton
            // 
            this.publicRootButton.AutoSize = true;
            this.publicRootButton.Location = new System.Drawing.Point(12, 22);
            this.publicRootButton.Name = "publicRootButton";
            this.publicRootButton.Size = new System.Drawing.Size(75, 23);
            this.publicRootButton.TabIndex = 6;
            this.publicRootButton.Text = "Public Root";
            this.publicRootButton.UseVisualStyleBackColor = true;
            this.publicRootButton.Click += new System.EventHandler(this.publicRootButton_Click);
            // 
            // logLocationButton
            // 
            this.logLocationButton.AutoSize = true;
            this.logLocationButton.Location = new System.Drawing.Point(12, 119);
            this.logLocationButton.Name = "logLocationButton";
            this.logLocationButton.Size = new System.Drawing.Size(79, 23);
            this.logLocationButton.TabIndex = 8;
            this.logLocationButton.Text = "Log Location";
            this.logLocationButton.UseVisualStyleBackColor = true;
            this.logLocationButton.Click += new System.EventHandler(this.logLocationButton_Click);
            // 
            // logLocationTextBox
            // 
            this.logLocationTextBox.Location = new System.Drawing.Point(111, 119);
            this.logLocationTextBox.Name = "logLocationTextBox";
            this.logLocationTextBox.Size = new System.Drawing.Size(286, 20);
            this.logLocationTextBox.TabIndex = 7;
            this.logLocationTextBox.TextChanged += new System.EventHandler(this.checkFormValues);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(12, 188);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(322, 188);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // VhostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 219);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.logLocationButton);
            this.Controls.Add(this.logLocationTextBox);
            this.Controls.Add(this.publicRootButton);
            this.Controls.Add(this.serverAdminTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serverNameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.publicRootTextbox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VhostForm";
            this.Text = "VHOST";
            this.TextChanged += new System.EventHandler(this.checkFormValues);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox publicRootTextbox;
        private System.Windows.Forms.TextBox serverNameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverAdminTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button publicRootButton;
        private System.Windows.Forms.Button logLocationButton;
        private System.Windows.Forms.TextBox logLocationTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}