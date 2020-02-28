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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExtraTools;
using WeightAPI;
using WeightAPI.UserManagement;

namespace WeightWatching.Views {
    /// <summary>
    /// Interaction logic for LoginContent.xaml
    /// </summary>
    public partial class LoginContent : UserControl {

        public LoginContent() {
            InitializeComponent();
        }

        private void LoginContent_OnLoaded(object sender, RoutedEventArgs e) {
            double size = (ActualWidth - 40) / 2;

            LoginButton.Width = size;
            CreateAccountButton.Width = size;
        }

        private void LoginButton_OnClick(object sender, RoutedEventArgs e) => Login();

        private void Login() {
            if (!AccountGetter.GetAccount(UsernameField.Text)) {
                DialogBox.Show("User Doesn't Exists", "Cannot find user! Please try again!", "Okay");
                return;
            }
            Utilities.MainViewWindow.Content = new MainPage();
            Utilities.UserNameText.Text = UsernameField.Text;
        }

        private void CreateAccountButton_OnClick(object sender, RoutedEventArgs e) {
            Utilities.LoginContentView.Header = "Create Account";
            Utilities.LoginContentView.Content = new CreateUser();
        }

        private void TextField_OnKeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                Login();
            }
        }
    }
}
