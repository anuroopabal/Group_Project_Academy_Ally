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




        MessageBox.Show("Course Prediction successfull");

        }

    }
}
