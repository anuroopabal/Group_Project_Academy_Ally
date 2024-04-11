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

namespace Academy_Ally
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public Register()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sign-up successful!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            //NavigationService?.Navigate(null);

            // Open a new instance of MainWindow
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            // Close the current window
            Window.GetWindow(this)?.Close();
        }
        public static void ChangePage(Page page)
        {
            var mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (mainWindow != null)
                mainWindow.Content = page;
        }
    }
}
