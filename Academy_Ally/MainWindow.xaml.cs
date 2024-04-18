using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            int count = 0;

            // Check if username or password is empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }



            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                string selectQuery = $"SELECT COUNT(*) from  AcademyAlly.dbo.UserDetails WHERE Email = '{username}'and Password = '{password}'";
                SqlCommand cmd = new SqlCommand(selectQuery, connection);
                DataTable dt = new DataTable();
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                count = (int)cmd.ExecuteScalar();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            // Validate user credentials (example: for demonstration purposes)
            if (count>0)
            {
                // Navigate to the next page or perform any other action
                MessageBox.Show("Login successful.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                CurrentUser.Username = username;
                Content = new Home();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                // Clear password field
                txtPassword.Clear();
                // Set focus to username field
                txtUsername.Focus();
            }
            
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            Content = new Register();
        }

        private void CoursePredictor_Subject(object sender, RoutedEventArgs e)
        {
            CoursePredictor coursePredictor = new CoursePredictor();
            Content =  coursePredictor;
        }
        private void Enter(object sender, RoutedEventArgs e)
        {
            TextBox sub = sender as TextBox;
            if (sub.Text == "Email ID"|| sub.Text == "Password")
            {
                sub.Text = "";
                sub.Foreground = Brushes.Black;
                sub.FontStyle = FontStyles.Normal;
            }
        }

        private void Leave(object sender, RoutedEventArgs e)
        {
            TextBox sub = sender as TextBox;
            if (sub.Text == "")
            {
                sub.Text = "Email ID";
                sub.Foreground = Brushes.Gray;
                sub.FontStyle = FontStyles.Italic;
            }
        }

    }
}