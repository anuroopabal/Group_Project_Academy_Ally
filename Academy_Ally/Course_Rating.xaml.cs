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
        public Course_Rating()
        {
            InitializeComponent();
        }

        //private void CourseRatingButton_Click(object sender, RoutedEventArgs e) 
        //{ 
        //    // Handle Course Rating button click
        //    CourseRatingGrid.Visibility = Visibility.Visible;
        //}

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
            MessageBox.Show("Rating submitted successfully!");
        }
        private void TabSelection(object sender, SelectionChangedEventArgs e)
        {
            string selectedTabItem = ((TabItem)e.AddedItems[0]).Header.ToString();
            // Navigate using NavigationManager
            Navigation.NavigateToPage(selectedTabItem, CourseRatingFrame);
        }
    }
}
