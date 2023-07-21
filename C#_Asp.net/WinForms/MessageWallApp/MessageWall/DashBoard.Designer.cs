namespace MessageWall
{
    partial class DashBoard
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.TextBox();
            this.messageTextListBox = new System.Windows.Forms.ListBox();
            this.messageTextBoxLabel = new System.Windows.Forms.Label();
            this.addMessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(45, 53);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(50, 13);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Message";
            this.messageLabel.Click += new System.EventHandler(this.MessageLabel_Click);
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(101, 50);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(222, 20);
            this.messageText.TabIndex = 1;
            // 
            // messageTextListBox
            // 
            this.messageTextListBox.FormattingEnabled = true;
            this.messageTextListBox.Location = new System.Drawing.Point(48, 143);
            this.messageTextListBox.Name = "messageTextListBox";
            this.messageTextListBox.Size = new System.Drawing.Size(275, 160);
            this.messageTextListBox.TabIndex = 3;
            this.messageTextListBox.TabStop = false;
            // 
            // messageTextBoxLabel
            // 
            this.messageTextBoxLabel.AutoSize = true;
            this.messageTextBoxLabel.Location = new System.Drawing.Point(45, 116);
            this.messageTextBoxLabel.Name = "messageTextBoxLabel";
            this.messageTextBoxLabel.Size = new System.Drawing.Size(55, 13);
            this.messageTextBoxLabel.TabIndex = 0;
            this.messageTextBoxLabel.Text = "Messages";
            this.messageTextBoxLabel.Click += new System.EventHandler(this.MessageLabel_Click);
            // 
            // addMessageButton
            // 
            this.addMessageButton.BackColor = System.Drawing.Color.Chartreuse;
            this.addMessageButton.Location = new System.Drawing.Point(330, 50);
            this.addMessageButton.Name = "addMessageButton";
            this.addMessageButton.Size = new System.Drawing.Size(75, 23);
            this.addMessageButton.TabIndex = 2;
            this.addMessageButton.Text = "Add";
            this.addMessageButton.UseVisualStyleBackColor = false;
            this.addMessageButton.Click += new System.EventHandler(this.addMessageButton_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(465, 325);
            this.Controls.Add(this.addMessageButton);
            this.Controls.Add(this.messageTextListBox);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.messageTextBoxLabel);
            this.Controls.Add(this.messageLabel);
            this.Name = "DashBoard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.ListBox messageTextListBox;
        private System.Windows.Forms.Label messageTextBoxLabel;
        private System.Windows.Forms.Button addMessageButton;
    }
}

