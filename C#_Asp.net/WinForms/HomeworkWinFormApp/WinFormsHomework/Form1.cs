using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void printFullNameButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                MessageBox.Show("First Name Required", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                MessageBox.Show("Last Name Required", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Hello {firstNameTextBox.Text} {lastNameTextBox.Text}","Page Says");
            }

            
        }
    }
}
