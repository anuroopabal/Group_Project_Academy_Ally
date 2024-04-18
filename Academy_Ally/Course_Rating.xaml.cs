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
    /// Interaction logic for Course_Rating.xaml
    /// </summary>
    public partial class Course_Rating : Page
    {
        int check = 0;
        public Course_Rating()
        {
            InitializeComponent();
        }

        //private void StarRadioButton_Click(object sender, RoutedEventArgs e)
        //{
        //    // Handle star rating click
        //    RadioButton radioButton = sender as RadioButton;
        //    int rating = int.Parse(radioButton.Content.ToString().Split()[0]); // Extract rating from button content
        //                                                                       // MessageBox.Show($"Selected Rating: {rating}");
        //}

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle submit button click
            bool radioButtonSelected = StarRadioButtons.Children.OfType<RadioButton>().Any(radioButton => radioButton.IsChecked == true);

            if (!radioButtonSelected)
            {
                // Display error message if no radio button is selected
                MessageBox.Show("Please select a rating.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                // Handle submit button click when a radio button is selected
                MessageBox.Show("Rating submitted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                CourseComboBox.SelectedIndex = 0;
                StarRadioButtons.Children.OfType<RadioButton>().ToList().ForEach(radioButton => radioButton.IsChecked = false);
            }
        }
        private void TabFocus(object sender, RoutedEventArgs e)
        {
            TabItem tabItem = sender as TabItem;
            string selectedTabItem = tabItem.Header.ToString();
            // Perform actions based on the selected tab item
            if (tabItem.IsSelected && check != 1)
            {
                switch (selectedTabItem)
                {
                    case "Home":
                        RatingFrame.NavigationService.Navigate(new Home());
                        break;
                    case "My Profile":
                        RatingFrame.NavigationService.Navigate(new profile());
                        break;
                    case "Log Out":
                        check = 1;
                        MessageBox.Show("Logged out successfully!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                        MainWindow mainWindow = new MainWindow();
                        Application.Current.Windows.OfType<Window>().SingleOrDefault(w => w.IsActive).Close();
                        mainWindow.Show();
                        break;
                }
            }
        }
    }
}
