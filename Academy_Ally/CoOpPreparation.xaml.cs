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
    /// Interaction logic for CoOpPreparation.xaml
    /// </summary>
    public partial class CoOpPreparation : Page
    {
        public CoOpPreparation()
        {
            InitializeComponent();
        }

      

        private void Resume_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Guide to Build your resume with ATS");
        }

        private void Interview_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Interview preparation links");
        }

        private void Job_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Job search assistancee through LinkedIn");
        }
    }
}
