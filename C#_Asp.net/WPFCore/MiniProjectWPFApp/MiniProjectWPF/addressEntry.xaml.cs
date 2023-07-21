using DemoLibrary;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace MiniProjectWPF
{
    /// <summary>
    /// Interaction logic for addressEntry.xaml
    /// </summary>
    public partial class addressEntry : Window
    {
        ISavedAddress _parent;
        public addressEntry(ISavedAddress parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void saveAddressButton_Click(object sender, RoutedEventArgs e)
        {
            AddressModel address = new AddressModel
                {
                StreetAddress = streetAddressText.Text,
                City = cityText.Text,
                State = stateText.Text,
                ZipCode = zipCodeText.Text,
                };
        _parent.SaveAddress(address);
            this.Close();
        }
        
    }
}
