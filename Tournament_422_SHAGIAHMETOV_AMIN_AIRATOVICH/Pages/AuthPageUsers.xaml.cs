﻿using System;
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

namespace Tournament_422_SHAGIAHMETOV_AMIN_AIRATOVICH.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPageUsers.xaml
    /// </summary>
    public partial class AuthPageUsers : Page
    {
        public AuthPageUsers()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegUsPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LoginTb.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PassPb.Clear();
        }
    }
}
