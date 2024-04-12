using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {

            // Get user input from text boxes
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Password;
            string contact = txtContact.Text;
            string address = txtAddress.Text;
            string courseId = txtCourse.Text;

            // Check if any required fields are empty
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Insert user data into database
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=Rooz;Initial Catalog = AcademyAlly; Integrated Security = True; Trust Server Certificate=True");
                string insertQuery = $"INSERT INTO AcademyAlly.dbo.UserDetails(Email, Name, Password, Contact, Address, CourseID) VALUES ('{email}', '{name}', '{password}', '{contact}', '{address}', '{courseId}')";
                SqlCommand cmd = new SqlCommand(insertQuery, connection);
                DataTable dt = new DataTable();
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                connection.Close();
                MessageBox.Show("Registration successful.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }



            //MessageBox.Show("Sign-up successful!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            //NavigationService?.Navigate(null);

            // Open a new instance of MainWindow
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            //Close the current window
            Window.GetWindow(this)?.Close();
        }
    }
}
