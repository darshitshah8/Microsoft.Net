namespace Miniproject
{
    partial class PersonForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameData = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameData = new System.Windows.Forms.TextBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.addNewAddress = new System.Windows.Forms.Button();
            this.addressesBox = new System.Windows.Forms.ListBox();
            this.isAciveLabel = new System.Windows.Forms.Label();
            this.addressesLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(123, 25);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstNameData
            // 
            this.firstNameData.Location = new System.Drawing.Point(186, 22);
            this.firstNameData.Name = "firstNameData";
            this.firstNameData.Size = new System.Drawing.Size(100, 20);
            this.firstNameData.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(123, 65);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameData
            // 
            this.lastNameData.Location = new System.Drawing.Point(186, 62);
            this.lastNameData.Name = "lastNameData";
            this.lastNameData.Size = new System.Drawing.Size(100, 20);
            this.lastNameData.TabIndex = 2;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(186, 98);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isActiveCheckBox.TabIndex = 3;
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // addNewAddress
            // 
            this.addNewAddress.Location = new System.Drawing.Point(223, 98);
            this.addNewAddress.Name = "addNewAddress";
            this.addNewAddress.Size = new System.Drawing.Size(75, 23);
            this.addNewAddress.TabIndex = 4;
            this.addNewAddress.Text = "Add";
            this.addNewAddress.UseVisualStyleBackColor = true;
            this.addNewAddress.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // addressesBox
            // 
            this.addressesBox.FormattingEnabled = true;
            this.addressesBox.Location = new System.Drawing.Point(126, 147);
            this.addressesBox.Name = "addressesBox";
            this.addressesBox.Size = new System.Drawing.Size(172, 199);
            this.addressesBox.TabIndex = 4;
            this.addressesBox.TabStop = false;
            this.addressesBox.SelectedIndexChanged += new System.EventHandler(this.userDataBox_SelectedIndexChanged);
            // 
            // isAciveLabel
            // 
            this.isAciveLabel.AutoSize = true;
            this.isAciveLabel.Location = new System.Drawing.Point(123, 98);
            this.isAciveLabel.Name = "isAciveLabel";
            this.isAciveLabel.Size = new System.Drawing.Size(48, 13);
            this.isAciveLabel.TabIndex = 2;
            this.isAciveLabel.Text = "Is Active";
            // 
            // addressesLabel
            // 
            this.addressesLabel.AutoSize = true;
            this.addressesLabel.Location = new System.Drawing.Point(123, 131);
            this.addressesLabel.Name = "addressesLabel";
            this.addressesLabel.Size = new System.Drawing.Size(56, 13);
            this.addressesLabel.TabIndex = 2;
            this.addressesLabel.Text = "Addresses";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(173, 352);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.TabStop = false;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 381);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addressesBox);
            this.Controls.Add(this.addNewAddress);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(this.lastNameData);
            this.Controls.Add(this.isAciveLabel);
            this.Controls.Add(this.addressesLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameData);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "PersonForm";
            this.Text = "Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameData;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameData;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.Button addNewAddress;
        private System.Windows.Forms.ListBox addressesBox;
        private System.Windows.Forms.Label isAciveLabel;
        private System.Windows.Forms.Label addressesLabel;
        private System.Windows.Forms.Button saveButton;
    }
}

