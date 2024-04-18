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
using static Academy_Ally.Navigation;

namespace Academy_Ally
{
    /// <summary>
    /// Interaction logic for cooppredictor.xaml
    /// </summary>
    public partial class Cooppredictor : Page
    {
        public Cooppredictor()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {

            Output.Text = "";
            CoopPredictorLogic();
        }

        private void CoopPredictorLogic()
        {
            try
            {
                double subject1Mark = double.Parse(sub1.Text);
                double subject2Mark = double.Parse(sub2.Text);
                double subject3Mark = double.Parse(sub3.Text);
                double subject4Mark = double.Parse(sub4.Text);
                double subject5Mark = double.Parse(sub5.Text);

                if (!ValidateMarks(subject1Mark) || !ValidateMarks(subject2Mark) || !ValidateMarks(subject3Mark) || !ValidateMarks(subject4Mark) || !ValidateMarks(subject5Mark))
                {
                    MessageBox.Show("Invalid input. Marks must be between 0 and 100.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (subject1Mark < 60 || subject2Mark < 60 || subject3Mark < 60 || subject4Mark < 60 || subject5Mark < 60)
                {
                    MessageBox.Show("Oops, you are not eligible for Co-op. Check your grades.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    Output.Background = Brushes.Yellow;
                    double[] marks = { subject1Mark, subject2Mark, subject3Mark, subject4Mark, subject5Mark };
                    double percentage = marks.Average();
                    if (percentage >= 99)
                    {
                        Output.Text = "You are having 100% chances for Co-op.";
                    }
                    else if (percentage >= 95)
                    {
                        Output.Text = "You are having 75% chances for Co-op.";
                    }
                    else if (percentage >= 90)
                    {
                        Output.Text = "You are having 50% chances for Co-op.";
                    }
                    else if (percentage >= 85)
                    {
                        Output.Text = "You are having 25% chances for Co-op.";
                    }
                    else if (percentage >= 80)
                    {
                        Output.Text = "You are eligible but only 5% chances for Co-op.";
                    }
                    else
                    {
                        Output.Text = "You are in-eligible for Co-op!";
                    }
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
            Navigation.NavigateToPage(selectedTabItem, CoopFrame);
        }
        private void Enter(object sender, RoutedEventArgs e)
        {
            TextBox sub = sender as TextBox;
            if (sub.Text == "Enter mark")
            {
                sub.Text = "";
                sub.Foreground = Brushes.Black;
                sub.FontStyle = FontStyles.Normal;
            }
        }

        private void Leave(object sender, RoutedEventArgs e)
        {
            TextBox sub = sender as TextBox;
            if (sub.Text == "")
            {
                sub.Text = "Enter mark";
                sub.Foreground = Brushes.Gray;
                sub.FontStyle = FontStyles.Italic;
            }
        }
        private bool ValidateMarks(double mark)
        {
            // Validate that the mark is within the range of 0 to 100
            return mark >= 0 && mark <= 100;
        }
    }
}
