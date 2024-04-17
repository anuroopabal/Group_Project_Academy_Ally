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
        private void CoursePredictor_Subject(object sender, RoutedEventArgs e)
        {
            string subject1 = sub1.Text;
            string subject2 = sub2.Text;
            string subject3 = sub3.Text;
            string subject4 = sub4.Text;    
            string subject5 = sub5.Text;

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
            int subject1Mark = int.Parse(sub1.Text);
            int subject2Mark = int.Parse(sub2.Text);
            int subject3Mark = int.Parse(sub3.Text);
            int subject4Mark = int.Parse(sub4.Text);
            int subject5Mark = int.Parse(sub5.Text);
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
}
