﻿using System;
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

namespace SSD.Task._6.Pages.TaskPage
{
    /// <summary>
    /// Логика взаимодействия для TaskPage2.xaml
    /// </summary>
    public partial class TaskPage3 : Page
    {
        public TaskPage3()
        {
            InitializeComponent();
        }

        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            double A = rnd.Next(0,999);
            MessageBox.Show($"{A}", "Системное сообщение",
                       MessageBoxButton.OK,
                       MessageBoxImage.Information);
        }
    }
}
