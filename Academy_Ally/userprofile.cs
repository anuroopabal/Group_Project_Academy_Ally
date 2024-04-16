﻿namespace UserProfileApp.Pages
{
    public class UserProfileModel : PageModel
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string CourseName { get; set; }
        public string Password { get; set; }

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

