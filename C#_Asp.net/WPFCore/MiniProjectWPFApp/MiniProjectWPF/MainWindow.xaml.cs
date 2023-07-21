using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiniProjectWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , ISavedAddress
    {

         BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        public MainWindow()
        {
            InitializeComponent();
            addressesList.ItemsSource = addresses;
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address); 

        }

        private void addAddressButton_Click(object sender, RoutedEventArgs e)
        {
            addressEntry entry = new addressEntry(this);
            entry.Show();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                IsActive = (isActiveCheckBox.IsChecked ?? false ),
                Addresses = addresses.ToList()
            };
        }
    }
}
