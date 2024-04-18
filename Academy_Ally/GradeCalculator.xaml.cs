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
    /// Interaction logic for GradeCalculator.xaml
    /// </summary>
    public partial class GradeCalculator : Page
    {
        public GradeCalculator()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            GPA.Text = "";
            try
            {
                double subject1Mark = double.Parse(Mark1.Text);
                double subject2Mark = double.Parse(Mark2.Text);
                double subject3Mark = double.Parse(Mark3.Text);
                double subject4Mark = double.Parse(Mark4.Text);
                double subject5Mark = double.Parse(Mark5.Text);

                if (!ValidateMarks(subject1Mark) || !ValidateMarks(subject2Mark) || !ValidateMarks(subject3Mark) || !ValidateMarks(subject4Mark) || !ValidateMarks(subject5Mark))
                {
                    MessageBox.Show("Invalid input. Marks must be between 0 and 100.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    GPA.Background = Brushes.Yellow;
                    double[] marks = { subject1Mark, subject2Mark, subject3Mark, subject4Mark, subject5Mark };
                    double gp1 = GradeCalculation(Grade1, subject1Mark);
                    double gp2 = GradeCalculation(Grade2, subject2Mark);
                    double gp3 =  GradeCalculation(Grade3, subject3Mark);
                    double gp4 = GradeCalculation(Grade4, subject4Mark);
                    double gp5 = GradeCalculation(Grade5, subject5Mark);
                    double finalGPA = (gp1 * 6 + gp2 * 4 + gp3 * 3 + gp4 * 4 + gp5 * 4) / 21;
                    GPA.Text = finalGPA.ToString("N2");
                }
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter valid marks for all subjects.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void TabSelection(object sender, SelectionChangedEventArgs e)
        {
            string selectedTabItem = ((TabItem)e.AddedItems[0]).Header.ToString();
            // Navigate using NavigationManager
            Navigation.NavigateToPage(selectedTabItem, GradeFrame);
        }
        private bool ValidateMarks(double mark)
        {
            // Validate that the mark is within the range of 0 to 100
            return mark >= 0 && mark <= 100;
        }
        private double GradeCalculation(TextBox textbox, double mark)
        {
            if (mark >= 90)
            {
                textbox.Text = "A+";
                return 4.00;
            }
            else if (mark >= 80)
            {
                textbox.Text = "A";
                return 3.75;
            }
            else if (mark >= 75)
            {
                textbox.Text = "B+";
                return 3.50;
            }
            else if (mark >= 70)
            {
                textbox.Text = "B";
                return 3.00;
            }
            else if (mark >= 65)
            {
                textbox.Text = "C+";
                return 2.50;
            }
            else if (mark >= 60)
            {
                textbox.Text = "C";
                return 2.00;
            }
            else
            {
                textbox.Text = "F";
                return 0.00;
            }
        }
    }
}
