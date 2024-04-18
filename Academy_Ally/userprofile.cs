namespace UserProfileApp.Pages
{
    public class UserProfileModel : PageModel
    {
        public required string Email { get; set; }
        public required string Name { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }
        public required string CourseName { get; set; }
        public required string Password { get; set; }

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

