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
                        frame.NavigationService.Navigate(new profile());
                        break;
                    case "Log Out":
                        MessageBox.Show("Logged out successfully!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                        MainWindow mainWindow = new MainWindow();
                        Application.Current.Windows.OfType<Window>().SingleOrDefault(w => w.IsActive).Close();
                        mainWindow.Show();
                        break;
                }
            }

        public static void CloseWindow(Window window)
        {
            window?.Close();
        }

    }
    }
