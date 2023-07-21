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

namespace HomeworkWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameText.Text))
            {
                MessageBox.Show("First Name Required", "Error Occured", MessageBoxButton.OK);
            }
            else if (string.IsNullOrEmpty(lastNameText.Text))
            {
                MessageBox.Show("Last Name Required", "Error Occured", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show($"Hello {firstNameText.Text} {lastNameText.Text}");
            }            
        }
    }
}
