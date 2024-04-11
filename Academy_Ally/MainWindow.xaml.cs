using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Check if username or password is empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Validate user credentials (example: for demonstration purposes)
            if (username == "admin" && password == "password")
            {
                // Successful sign-in
                MessageBox.Show("Welcome, " + username + "!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                // Proceed with navigation to main content area or perform necessary actions
            }
            else
            {
                // Invalid credentials
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                // Clear password field
                txtPassword.Clear();
                // Set focus to username field
                txtUsername.Focus();
            }
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement sign-up functionality (example: for demonstration purposes)
            MessageBox.Show("Sign-up functionality not implemented yet.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}