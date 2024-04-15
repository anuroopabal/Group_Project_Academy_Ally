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
    /// Interaction logic for AcademicPredictor.xaml
    /// </summary>
    public partial class AcademicPredictor : Page
    {
        public AcademicPredictor()
        {
            InitializeComponent();
        }

        private void RadioButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (CoopP.IsChecked == true)
            {
                PredictorFrame.NavigationService.Navigate(new Cooppredictor());
            }
            else
            {
                PredictorFrame.NavigationService.Navigate(new CoursePredictor());
            }
        }
    }
}
