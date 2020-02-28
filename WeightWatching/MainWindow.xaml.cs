﻿using System;
using System.Collections.Generic;
using System.IO;
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
using WeightWatching.Properties;

namespace WeightWatching {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();

            if (!Directory.Exists("Users")) {
                Directory.CreateDirectory("Users");
            }

            Utilities.MainViewWindow = this;
            Utilities.UserNameText = UserNameTextBlock;

            Content = Settings.Default.Autologin ? (object) new Views.MainPage() : new Views.Login();
        }
    }
}
