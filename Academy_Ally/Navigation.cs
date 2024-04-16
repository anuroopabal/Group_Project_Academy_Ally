using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Academy_Ally
{
        public static class Navigation
        {
            public static void NavigateToPage(string pageName, Frame frame)
            {
                switch (pageName)
                {
                    case "Home":
                        frame.NavigationService.Navigate(new Home());
                        break;
                    case "My Profile":
                        frame.NavigationService.Navigate(new Home());
                        break;
                    case "Log Out":
                        MessageBox.Show("Log out successful!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        //Close the current window
                        //Window.GetWindow(this)?.Close();
                        break;
                }
            }
        }
    }
