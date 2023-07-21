using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniproject
{
    public partial class AddressForm : Form
    {
        ISavedAddress _parent;
        public AddressForm(ISavedAddress parent)
        {
            InitializeComponent();

            _parent = parent;
            
        }

        private void saveAddressButton_Click(object sender, EventArgs e)
        {
            AddressModel address = new AddressModel
            {
                StreetAddress = streetData.Text,
                City = cityData.Text,
                State = stateData.Text,
                ZipCode = zipData.Text
            };
            _parent.SaveAddress(address);

            this.Close();
        }

















        //-----------------------------------------------
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void streetAddressLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
