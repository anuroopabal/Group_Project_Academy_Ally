﻿using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Academy_Ally
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            
        }

        private void DateTime_Loaded(object sender, RoutedEventArgs e)
        {
            dateDisplay.Content = DateTime.Now;
        }

        private void AcademicPredictor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
            CoursePredictor coursePredictor = new CoursePredictor();
            navService.Navigate(coursePredictor);
        }
        private void CareerPreparation_Click(object sender, RoutedEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
            CoursePreparation coursePreparation = new CoursePreparation();
            navService.Navigate(coursePreparation);
        }
        private void CourseRating_Click(object sender, RoutedEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
            CoursePreparation coursePreparation = new CoursePreparation();
            navService.Navigate(coursePreparation);
        }
        private void GradeCalculator_Click(object sender, RoutedEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
            CoursePreparation coursePreparation = new CoursePreparation();
            navService.Navigate(coursePreparation);
        }
    }
}