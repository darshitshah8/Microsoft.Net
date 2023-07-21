namespace Miniproject
{
    partial class AddressForm
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
            this.streetAddressLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.streetData = new System.Windows.Forms.TextBox();
            this.cityData = new System.Windows.Forms.TextBox();
            this.stateData = new System.Windows.Forms.TextBox();
            this.zipData = new System.Windows.Forms.TextBox();
            this.saveAddressButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // streetAddressLabel
            // 
            this.streetAddressLabel.AutoSize = true;
            this.streetAddressLabel.Location = new System.Drawing.Point(285, 91);
            this.streetAddressLabel.Name = "streetAddressLabel";
            this.streetAddressLabel.Size = new System.Drawing.Size(76, 13);
            this.streetAddressLabel.TabIndex = 0;
            this.streetAddressLabel.Text = "Street Address";
            this.streetAddressLabel.Click += new System.EventHandler(this.streetAddressLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "City";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(311, 169);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(50, 13);
            this.zipCodeLabel.TabIndex = 3;
            this.zipCodeLabel.Text = "Zip Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "State";
            // 
            // streetData
            // 
            this.streetData.Location = new System.Drawing.Point(367, 88);
            this.streetData.Name = "streetData";
            this.streetData.Size = new System.Drawing.Size(100, 20);
            this.streetData.TabIndex = 4;
            // 
            // cityData
            // 
            this.cityData.Location = new System.Drawing.Point(367, 114);
            this.cityData.Name = "cityData";
            this.cityData.Size = new System.Drawing.Size(100, 20);
            this.cityData.TabIndex = 5;
            // 
            // stateData
            // 
            this.stateData.Location = new System.Drawing.Point(367, 140);
            this.stateData.Name = "stateData";
            this.stateData.Size = new System.Drawing.Size(100, 20);
            this.stateData.TabIndex = 6;
            // 
            // zipData
            // 
            this.zipData.Location = new System.Drawing.Point(367, 166);
            this.zipData.Name = "zipData";
            this.zipData.Size = new System.Drawing.Size(100, 20);
            this.zipData.TabIndex = 7;
            // 
            // saveAddressButton
            // 
            this.saveAddressButton.Location = new System.Drawing.Point(340, 204);
            this.saveAddressButton.Name = "saveAddressButton";
            this.saveAddressButton.Size = new System.Drawing.Size(75, 23);
            this.saveAddressButton.TabIndex = 8;
            this.saveAddressButton.TabStop = false;
            this.saveAddressButton.Text = "Save";
            this.saveAddressButton.UseVisualStyleBackColor = true;
            this.saveAddressButton.Click += new System.EventHandler(this.saveAddressButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Address Entry";
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveAddressButton);
            this.Controls.Add(this.zipData);
            this.Controls.Add(this.stateData);
            this.Controls.Add(this.cityData);
            this.Controls.Add(this.streetData);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.streetAddressLabel);
            this.Name = "AddressForm";
            this.Text = "Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label streetAddressLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox streetData;
        private System.Windows.Forms.TextBox cityData;
        private System.Windows.Forms.TextBox stateData;
        private System.Windows.Forms.TextBox zipData;
        private System.Windows.Forms.Button saveAddressButton;
        private System.Windows.Forms.Label label1;
    }
}