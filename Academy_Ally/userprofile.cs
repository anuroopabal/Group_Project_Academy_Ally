using System.Windows.Forms;

namespace UserProfileApp
{
    public partial class UserProfileForm : Form
    {
        private object txtEmail;
        private object txtName;
        private object txtPhoneNumber;
        private object txtAddress;
        private object txtCourseName;
        private string txtPassword;

        public UserProfileForm()
        {
            InitializeComponent();
            LoadUserProfile();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void LoadUserProfile()
        {
            // Load user profile details
            string email = "john@graph.com";
            string name = "Jon Doe";
            string phoneNumber = "+1 xxx-xxx-xxxx";
            string address = "123, ABC, Kitchener, ON";
            string courseName = "[Course Name]";
            string password = "*********";

            // Display user profile details in the form
            txtEmail = email;
            txtName = name;
            txtPhoneNumber = phoneNumber;
            txtAddress = address;
            txtCourseName = courseName;
            txtPassword = password;
        }
    }
}
