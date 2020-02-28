using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using ExtraTools;
using WeightAPI.UserManagement;

namespace WeightWatching.Views {
    /// <summary>
    /// Interaction logic for CreateUser.xaml
    /// </summary>
    public partial class CreateUser : UserControl {
        
        public CreateUser() {
            InitializeComponent();
        }

        private void CreateUser_OnLoaded(object sender, RoutedEventArgs e) {
            double size = (ActualWidth - 40) / 2;

            WeightTextBox.Width = size;
            AgeTextBox.Width = size;
            //BMITextBox.Width

            TargetWeightTextBox.Width = size;
            //TargetBMITextBox.Width = size;

            LoginButton.Width = size;
            CreateButton.Width = size;
        }

        private void LoginButton_OnClick(object sender, RoutedEventArgs e) {
            Utilities.LoginContentView.Header = "login";
            Utilities.LoginContentView.Content = new LoginContent();
        }


        private void CreateButton_OnClick(object sender, RoutedEventArgs e) {
            double weight = double.Parse(WeightTextBox.Text);
            double age = double.Parse(AgeTextBox.Text);
            if (!AccountCreator.CreateAccount(NameTextBox.Text, UserNameTextBox.Text, "123456", weight, age)) {
                DialogBox.Show("User Exists", "The user already exists", "Okay");
            }

            Utilities.LoginContentView.Header = "login";
            Utilities.LoginContentView.Content = new LoginContent();
        }

        private void IsANumber(object sender, TextCompositionEventArgs e) {
            Regex numbers = new Regex("[^0-9]+");
            e.Handled = numbers.IsMatch(e.Text);
        }
    }
}
