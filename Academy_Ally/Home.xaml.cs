using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                string selectQuery = $"SELECT Name from  AcademyAlly.dbo.UserDetails WHERE Email = '{CurrentUser.Username}'";
                SqlCommand cmd = new SqlCommand(selectQuery, connection);
                DataTable dt = new DataTable();
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                string name = dt.Rows[0][0].ToString();
                connection.Close();
                Title.Content = $"Welcome {name} to AcedemyAlly!!";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


        }

        private void DateTime_Loaded(object sender, RoutedEventArgs e)
        {
            dateDisplay.Content = DateTime.Now;
        }

        private void AcademicPredictor_Click(object sender, RoutedEventArgs e)
        {
            HomeFrame.NavigationService.Navigate(new AcademicPredictor());
        }
        private void CareerPreparation_Click(object sender, RoutedEventArgs e)
        {
            HomeFrame.NavigationService.Navigate(new CareerPreparation());
        }
        private void CourseRating_Click(object sender, RoutedEventArgs e)
        {
            HomeFrame.NavigationService.Navigate(new Course_Rating());
        }
        private void GradeCalculator_Click(object sender, RoutedEventArgs e)
        {
            HomeFrame.NavigationService.Navigate(new GradeCalculator());
        }

        private void UserProfileNav(object sender, MouseButtonEventArgs e)
        {
            HomeFrame.NavigationService.Navigate(new profile());
        }
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Logged out successfully!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            MainWindow mainWindow = new MainWindow();
            Application.Current.Windows.OfType<Window>().SingleOrDefault(w => w.IsActive).Close();
            mainWindow.Show();
        }
    }
}
