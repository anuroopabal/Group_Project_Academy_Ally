using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
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
    /// Interaction logic for CoursePredictor.xaml
    /// </summary>
    public partial class CoursePredictor : Page
    {
        public CoursePredictor()
        {
            InitializeComponent();
            
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Course Prediction successfull");
            Output.Text = "";
            CoursePredictorLogic();
        }
        private void TabSelection(object sender, SelectionChangedEventArgs e)
        {
            string selectedTabItem = ((TabItem)e.AddedItems[0]).Header.ToString();
            // Navigate using NavigationManager
            Navigation.NavigateToPage(selectedTabItem, CourseFrame);
        }
        private void CoursePredictorLogic()
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
                    MessageBox.Show("Oops, you are not eligible for next course. Check your grades.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    Output.Background = Brushes.Yellow;
                    if (subject1Mark > 70)
                    {
                        Output.Text = "Computer Applications Development(0066)";
                    }
                    else if (subject2Mark > 70)
                    {
                        Output.Text = "Technical Systems Analysis (1601)";
                    }
                    else if (subject3Mark > 70)
                    {
                        Output.Text = "Information Technology Project Management (1566)";
                    }
                    else if (subject4Mark > 70)
                    {
                        Output.Text = "Information Technology Network Security (1475)";
                    }
                    else if (subject5Mark > 70)
                    {
                        Output.Text = "Virtualization and Cloud Computing (1523)";
                    }
                    else
                    {
                        Output.Text = "Project Management (1298)";
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Invalid input. Please enter valid marks for all subjects.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
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
