using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Academy_Ally
{
    /// <summary>
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : Page
    {
        public profile()
        {
            InitializeComponent();

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString; ;
                SqlConnection connection = new SqlConnection(connectionString);
                string selectQuery = $"SELECT * FROM AcademyAlly.dbo.UserDetails where Email = '{CurrentUser.Username}'";
                SqlCommand cmd = new SqlCommand(selectQuery, connection);
                DataTable dt = new DataTable();
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Email.Text = sdr["Email"].ToString();
                    UserName.Text = sdr["Name"].ToString();
                    PhoneNo.Text = sdr["Contact"].ToString();
                    Address.Text = sdr["Address"].ToString();
                    Password.Password = sdr["Password"].ToString();
                }
                dt.Load(sdr);
                connection.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile details: " + ex.Message);
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Profile updates are saved.");
            string name = UserName.Text;
            string phoneNumber = PhoneNo.Text;
            string address = Address.Text;
            string password = Password.Password;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                string updateQuery = $"UPDATE AcademyAlly.dbo.UserDetails set Name = '{name}', Password = '{password}', Contact = '{phoneNumber}', Address = '{address}' WHERE Email = '{CurrentUser.Username}'";
                SqlCommand cmd = new SqlCommand(updateQuery, connection);
                DataTable dt = new DataTable();
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                connection.Close();
                MessageBox.Show("Successfully updated!.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                MessageBox.Show("Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void HomeNav(object sender, MouseButtonEventArgs e)
        {
            ProFrame.NavigationService.Navigate(new Home());
        }
    }
}
