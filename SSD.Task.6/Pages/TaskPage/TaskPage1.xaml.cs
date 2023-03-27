using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
    /// Логика взаимодействия для TaskPage1.xaml
    /// </summary>
    public partial class TaskPage1 : Page
    {
        public TaskPage1()
        {
            InitializeComponent();
        }
        int variable;
        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            int A = Convert.ToInt32(TbA.Text);
            A = A * 4 / 3 * 2;
            MessageBox.Show($"R = {A}", "Системное сообщение",
                       MessageBoxButton.OK,
                       MessageBoxImage.Information);
        }
    }
}
