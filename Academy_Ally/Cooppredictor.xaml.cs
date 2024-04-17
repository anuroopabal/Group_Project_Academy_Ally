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

            //Register register = new Register();
            //CoopFrame.NavigationService.Navigate(new Home());
        }

        private void TabSelection(object sender, SelectionChangedEventArgs e) 
        {
            string selectedTabItem = ((TabItem)e.AddedItems[0]).Header.ToString();
            // Navigate using NavigationManager
            Navigation.NavigateToPage(selectedTabItem, CoopFrame);
        }
    }
}
