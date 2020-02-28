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

namespace WeightWatching.Views {
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page {
        public Login() {
            InitializeComponent();

            Utilities.LoginContentView = LoginBox;
        }

        private void Login_OnLoaded(object sender, RoutedEventArgs e) {
            LoginBox.Width = ActualWidth / 2;
            LoginBox.Height = (ActualHeight / 2) + (ActualHeight / 2) / 2;

            LoginBox.Content = new LoginContent();
        }
    }
}
