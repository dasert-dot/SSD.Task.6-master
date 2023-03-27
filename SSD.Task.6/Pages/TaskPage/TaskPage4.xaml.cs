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

namespace SSD.Task._6.Pages.TaskPage
{
    /// <summary>
    /// Логика взаимодействия для TaskPage2.xaml
    /// </summary>
    public partial class TaskPage4 : Page
    {
        public TaskPage4()
        {
            InitializeComponent();
        }

        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            double A = rnd.Next(0, 999);
            int[] G = new int[9];
            MessageBox.Show($"{A}", "Системное сообщение",
                       MessageBoxButton.OK,
                       MessageBoxImage.Information);
        }
    }
}
