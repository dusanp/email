namespace email
{
    partial class SettingsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SMTPPage = new System.Windows.Forms.TabPage();
            this.SMTPHostLabel = new System.Windows.Forms.Label();
            this.SMTPNameLabel = new System.Windows.Forms.Label();
            this.SMTPPassLabel = new System.Windows.Forms.Label();
            this.SMTPPortLabel = new System.Windows.Forms.Label();
            this.SMTPPortBox = new System.Windows.Forms.TextBox();
            this.SMTPPassBox = new System.Windows.Forms.TextBox();
            this.SMTPNameBox = new System.Windows.Forms.TextBox();
            this.SMTPHostBox = new System.Windows.Forms.TextBox();
            this.POPPage = new System.Windows.Forms.TabPage();
            this.POPPortLabel = new System.Windows.Forms.Label();
            this.POPPassLabel = new System.Windows.Forms.Label();
            this.POPNameLabel = new System.Windows.Forms.Label();
            this.POPHostLabel = new System.Windows.Forms.Label();
            this.POPPortBox = new System.Windows.Forms.TextBox();
            this.POPPassBox = new System.Windows.Forms.TextBox();
            this.POPNameBox = new System.Windows.Forms.TextBox();
            this.POPHostBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SMTPPage.SuspendLayout();
            this.POPPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.SMTPPage);
            this.tabControl1.Controls.Add(this.POPPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(287, 157);
            this.tabControl1.TabIndex = 0;
            // 
            // SMTPPage
            // 
            this.SMTPPage.Controls.Add(this.SMTPHostLabel);
            this.SMTPPage.Controls.Add(this.SMTPNameLabel);
            this.SMTPPage.Controls.Add(this.SMTPPassLabel);
            this.SMTPPage.Controls.Add(this.SMTPPortLabel);
            this.SMTPPage.Controls.Add(this.SMTPPortBox);
            this.SMTPPage.Controls.Add(this.SMTPPassBox);
            this.SMTPPage.Controls.Add(this.SMTPNameBox);
            this.SMTPPage.Controls.Add(this.SMTPHostBox);
            this.SMTPPage.Location = new System.Drawing.Point(4, 22);
            this.SMTPPage.Name = "SMTPPage";
            this.SMTPPage.Padding = new System.Windows.Forms.Padding(3);
            this.SMTPPage.Size = new System.Drawing.Size(279, 131);
            this.SMTPPage.TabIndex = 0;
            this.SMTPPage.Text = "SMTP";
            this.SMTPPage.UseVisualStyleBackColor = true;
            // 
            // SMTPHostLabel
            // 
            this.SMTPHostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SMTPHostLabel.AutoSize = true;
            this.SMTPHostLabel.Location = new System.Drawing.Point(189, 17);
            this.SMTPHostLabel.Name = "SMTPHostLabel";
            this.SMTPHostLabel.Size = new System.Drawing.Size(79, 13);
            this.SMTPHostLabel.TabIndex = 4;
            this.SMTPHostLabel.Text = "Server Address";
            // 
            // SMTPNameLabel
            // 
            this.SMTPNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SMTPNameLabel.AutoSize = true;
            this.SMTPNameLabel.Location = new System.Drawing.Point(189, 43);
            this.SMTPNameLabel.Name = "SMTPNameLabel";
            this.SMTPNameLabel.Size = new System.Drawing.Size(55, 13);
            this.SMTPNameLabel.TabIndex = 4;
            this.SMTPNameLabel.Text = "Username";
            // 
            // SMTPPassLabel
            // 
            this.SMTPPassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SMTPPassLabel.AutoSize = true;
            this.SMTPPassLabel.Location = new System.Drawing.Point(189, 69);
            this.SMTPPassLabel.Name = "SMTPPassLabel";
            this.SMTPPassLabel.Size = new System.Drawing.Size(53, 13);
            this.SMTPPassLabel.TabIndex = 4;
            this.SMTPPassLabel.Text = "Password";
            // 
            // SMTPPortLabel
            // 
            this.SMTPPortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SMTPPortLabel.AutoSize = true;
            this.SMTPPortLabel.Location = new System.Drawing.Point(189, 95);
            this.SMTPPortLabel.Name = "SMTPPortLabel";
            this.SMTPPortLabel.Size = new System.Drawing.Size(26, 13);
            this.SMTPPortLabel.TabIndex = 4;
            this.SMTPPortLabel.Text = "Port";
            // 
            // SMTPPortBox
            // 
            this.SMTPPortBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SMTPPortBox.Location = new System.Drawing.Point(19, 95);
            this.SMTPPortBox.Name = "SMTPPortBox";
            this.SMTPPortBox.Size = new System.Drawing.Size(164, 20);
            this.SMTPPortBox.TabIndex = 1;
            // 
            // SMTPPassBox
            // 
            this.SMTPPassBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SMTPPassBox.Location = new System.Drawing.Point(19, 69);
            this.SMTPPassBox.Name = "SMTPPassBox";
            this.SMTPPassBox.Size = new System.Drawing.Size(164, 20);
            this.SMTPPassBox.TabIndex = 1;
            this.SMTPPassBox.UseSystemPasswordChar = true;
            // 
            // SMTPNameBox
            // 
            this.SMTPNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SMTPNameBox.Location = new System.Drawing.Point(19, 43);
            this.SMTPNameBox.Name = "SMTPNameBox";
            this.SMTPNameBox.Size = new System.Drawing.Size(164, 20);
            this.SMTPNameBox.TabIndex = 1;
            // 
            // SMTPHostBox
            // 
            this.SMTPHostBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SMTPHostBox.Location = new System.Drawing.Point(19, 17);
            this.SMTPHostBox.Name = "SMTPHostBox";
            this.SMTPHostBox.Size = new System.Drawing.Size(164, 20);
            this.SMTPHostBox.TabIndex = 1;
            // 
            // POPPage
            // 
            this.POPPage.Controls.Add(this.POPPortLabel);
            this.POPPage.Controls.Add(this.POPPassLabel);
            this.POPPage.Controls.Add(this.POPNameLabel);
            this.POPPage.Controls.Add(this.POPHostLabel);
            this.POPPage.Controls.Add(this.POPPortBox);
            this.POPPage.Controls.Add(this.POPPassBox);
            this.POPPage.Controls.Add(this.POPNameBox);
            this.POPPage.Controls.Add(this.POPHostBox);
            this.POPPage.Location = new System.Drawing.Point(4, 22);
            this.POPPage.Name = "POPPage";
            this.POPPage.Padding = new System.Windows.Forms.Padding(3);
            this.POPPage.Size = new System.Drawing.Size(279, 131);
            this.POPPage.TabIndex = 1;
            this.POPPage.Text = "POP3";
            this.POPPage.UseVisualStyleBackColor = true;
            // 
            // POPPortLabel
            // 
            this.POPPortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.POPPortLabel.AutoSize = true;
            this.POPPortLabel.Location = new System.Drawing.Point(189, 95);
            this.POPPortLabel.Name = "POPPortLabel";
            this.POPPortLabel.Size = new System.Drawing.Size(26, 13);
            this.POPPortLabel.TabIndex = 3;
            this.POPPortLabel.Text = "Port";
            // 
            // POPPassLabel
            // 
            this.POPPassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.POPPassLabel.AutoSize = true;
            this.POPPassLabel.Location = new System.Drawing.Point(189, 69);
            this.POPPassLabel.Name = "POPPassLabel";
            this.POPPassLabel.Size = new System.Drawing.Size(53, 13);
            this.POPPassLabel.TabIndex = 3;
            this.POPPassLabel.Text = "Password";
            // 
            // POPNameLabel
            // 
            this.POPNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.POPNameLabel.AutoSize = true;
            this.POPNameLabel.Location = new System.Drawing.Point(189, 43);
            this.POPNameLabel.Name = "POPNameLabel";
            this.POPNameLabel.Size = new System.Drawing.Size(55, 13);
            this.POPNameLabel.TabIndex = 3;
            this.POPNameLabel.Text = "Username";
            // 
            // POPHostLabel
            // 
            this.POPHostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.POPHostLabel.AutoSize = true;
            this.POPHostLabel.Location = new System.Drawing.Point(189, 17);
            this.POPHostLabel.Name = "POPHostLabel";
            this.POPHostLabel.Size = new System.Drawing.Size(79, 13);
            this.POPHostLabel.TabIndex = 3;
            this.POPHostLabel.Text = "Server Address";
            // 
            // POPPortBox
            // 
            this.POPPortBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.POPPortBox.Location = new System.Drawing.Point(19, 95);
            this.POPPortBox.Name = "POPPortBox";
            this.POPPortBox.Size = new System.Drawing.Size(164, 20);
            this.POPPortBox.TabIndex = 2;
            // 
            // POPPassBox
            // 
            this.POPPassBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.POPPassBox.Location = new System.Drawing.Point(19, 69);
            this.POPPassBox.Name = "POPPassBox";
            this.POPPassBox.Size = new System.Drawing.Size(164, 20);
            this.POPPassBox.TabIndex = 2;
            this.POPPassBox.UseSystemPasswordChar = true;
            // 
            // POPNameBox
            // 
            this.POPNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.POPNameBox.Location = new System.Drawing.Point(19, 43);
            this.POPNameBox.Name = "POPNameBox";
            this.POPNameBox.Size = new System.Drawing.Size(164, 20);
            this.POPNameBox.TabIndex = 2;
            // 
            // POPHostBox
            // 
            this.POPHostBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.POPHostBox.Location = new System.Drawing.Point(19, 17);
            this.POPHostBox.Name = "POPHostBox";
            this.POPHostBox.Size = new System.Drawing.Size(164, 20);
            this.POPHostBox.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(197, 159);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OKButton.Location = new System.Drawing.Point(12, 159);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 187);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.tabControl1.ResumeLayout(false);
            this.SMTPPage.ResumeLayout(false);
            this.SMTPPage.PerformLayout();
            this.POPPage.ResumeLayout(false);
            this.POPPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SMTPPage;
        private System.Windows.Forms.TabPage POPPage;
        private System.Windows.Forms.TextBox SMTPPassBox;
        private System.Windows.Forms.TextBox SMTPNameBox;
        private System.Windows.Forms.TextBox SMTPHostBox;
        private System.Windows.Forms.TextBox SMTPPortBox;
        private System.Windows.Forms.TextBox POPPortBox;
        private System.Windows.Forms.TextBox POPPassBox;
        private System.Windows.Forms.TextBox POPNameBox;
        private System.Windows.Forms.TextBox POPHostBox;
        private System.Windows.Forms.Label SMTPHostLabel;
        private System.Windows.Forms.Label SMTPNameLabel;
        private System.Windows.Forms.Label SMTPPassLabel;
        private System.Windows.Forms.Label SMTPPortLabel;
        private System.Windows.Forms.Label POPPortLabel;
        private System.Windows.Forms.Label POPPassLabel;
        private System.Windows.Forms.Label POPNameLabel;
        private System.Windows.Forms.Label POPHostLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OKButton;
    }
}