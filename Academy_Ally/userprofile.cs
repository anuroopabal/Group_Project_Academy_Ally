namespace UserProfileApp.Pages
{
    public class UserProfileModel : PageModel
    {
        string Email { get; set; }
        string Name { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }
        string CourseName { get; set; }
        string Password { get; set; }

        public void OnGet()
        {
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            // Load user profile details
            Email = "john@graph.com";
            Name = "Jon Doe";
            PhoneNumber = "+1 xxx-xxx-xxxx";
            Address = "123, ABC, Kitchener, ON";
            CourseName = "[Course Name]";
            Password = "*********";
        }
    }
}

