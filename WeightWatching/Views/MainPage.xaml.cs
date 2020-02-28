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
using WeightAPI.UserManagement;

namespace WeightWatching.Views {
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page {
        public MainPage() {
            InitializeComponent();

            try {
                WeightTracker.Content = new Tabs.WeightTracker();
                FoodIntake.Content = new Tabs.DailyFood();
                //ExercisePlanner.Content = new Tabs.ExercisePlanner();
                //MealPlanner.Content = new Tabs.MealPlanner();
                About.Content = new Tabs.About();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }


        }

        private void MainPage_OnLoaded(object sender, RoutedEventArgs e) {
            
        }
    }
}
