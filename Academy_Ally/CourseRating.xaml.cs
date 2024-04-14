using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle Home button click
        }

        private void CourseRatingButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle Course Rating button click
            CourseRatingGrid.Visibility = Visibility.Visible;
        }

        private void StarRadioButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle star rating click
            RadioButton radioButton = sender as RadioButton;
            int rating = int.Parse(radioButton.Content.ToString().Split()[0]); // Extract rating from button content
                                                                               // MessageBox.Show($"Selected Rating: {rating}");
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle submit button click
            MessageBox.Show("Rating submitted successfully!");
        }
    }
}
