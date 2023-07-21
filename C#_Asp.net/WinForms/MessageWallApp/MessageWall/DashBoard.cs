using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageWall
{
    public partial class DashBoard : Form
    {
        BindingList<string> messages = new BindingList<string>();

        public DashBoard()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            messageTextListBox.DataSource = messages;
            //messageTextListBox.DisplayMember = nameof(DashBoard.Text);   use PersonModel insted of Dashboard               
        }
        private void MessageLabel_Click(object sender, EventArgs e)
        {

        }

        private void addMessageButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(messageText.Text))
            {
                // Do something Diffrent
                MessageBox.Show("Enter the message before click on Add","Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                messages.Add(messageText.Text);
                messageText.Text = "";                
            }
            //messageText.Focus();

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
