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
    public partial class TaskPage2 : Page
    {
        public TaskPage2()
        {
            InitializeComponent();
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            string[] F = { "Крымов", "Юсупова", "Лукашенко", "Кузнецова", "Рыжиков", "Зуйков", "Лукьянчиков", "Зубарев", "Башмачкин", "Реженцов", "Калинин", "Маркони", "Слепаков", "Бебурешвили", "Попова", "Кравец", "Швойц", "Маликова", "Месси" };
            int[] T = new int[19];
            Random ran = new Random();
            int k, t1 = 0;
            int max = 0;
            for (int i = 0; i < 19; i++)
            {
                k = ran.Next(10, 37);
                T[i] = k;
                if (max < k)
                {
                    max = k;
                }
                if (k < max)
                {
                    t1 = k;
                }
            }

            MessageBox.Show($"{F[9]},{F[4]},{F[1]},{F[3]}", "Системное сообщение",
                       MessageBoxButton.OK,
                       MessageBoxImage.Information);
        }
    }
}
