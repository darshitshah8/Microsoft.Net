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
    public partial class PersonForm : Form , ISavedAddress
    {

        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        public PersonForm()
        {
            InitializeComponent();
            addressesBox.DataSource = addresses;
            addressesBox.DisplayMember = nameof(AddressModel.FullAddress);
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            AddressForm entry = new AddressForm(this);   
            entry.Show();
        }      
        
        public void SaveAddress(AddressModel address)
        {
             addresses.Add(address);
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel 
            {
                FirstName = firstNameData.Text,
                LastName = lastNameData.Text,
                IsActive = isActiveCheckBox.Checked,
                Addresses = addresses.ToList()
            };
              

        }


        //-----------------------------------------------------------
        //UnusedEventsCreated



        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void userDataBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
