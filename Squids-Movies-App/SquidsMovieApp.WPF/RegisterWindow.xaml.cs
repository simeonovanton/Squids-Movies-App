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

namespace SquidsMovieApp.WPF
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Page
    {
        public RegisterWindow()
        {
            InitializeComponent();
            EmailRegisterTB.Focus();
        }

        private void GoBackBtnClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LoginWindow());
        }

        private void RegisterBtnClicked(object sender, RoutedEventArgs e)
        {
            ValidateFields();
            this.NavigationService.Navigate(new ProfileWindow());
        }

        private void ValidateFields()
        {
            var email = this.EmailRegisterTB.Text;
            var username = this.UsernameRegisterTB.Text;
            var firstName = this.FirstNamelRegisterTB.Text;
            var lastName = this.LastNameRegisterTB.Text;
            var password = this.PasswordRegisterPB.Password;
            var repeatedPassword = this.PasswordRepeatRegisterPB.Password;

            
        }
    }
}
