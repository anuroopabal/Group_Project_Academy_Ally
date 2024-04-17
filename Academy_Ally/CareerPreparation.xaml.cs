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
    /// Interaction logic for CareerPreparation.xaml
    /// </summary>
    public partial class CareerPreparation : Page
    {
        public CareerPreparation()
        {
            InitializeComponent();
        }
        private void RadioButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (CoopPrep.IsChecked == true)
            {
                PredictorFrame.NavigationService.Navigate(new CoOpPreparation());
            }
            else
            {
                PredictorFrame.NavigationService.Navigate(new CoursePreparation());
            }
        }

        private void TabSelection(object sender, SelectionChangedEventArgs e)
        {
            string selectedTabItem = ((TabItem)e.AddedItems[0]).Header.ToString();
            // Navigate using NavigationManager
            Navigation.NavigateToPage(selectedTabItem, PredictorFrame);



        }
    }
}
