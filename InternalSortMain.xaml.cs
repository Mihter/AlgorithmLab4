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

namespace AlgorithmLab4
{
    /// <summary>
    /// Логика взаимодействия для InternalSortMain.xaml
    /// </summary>
    public partial class InternalSortMain : Page
    {
        public InternalSortMain()
        {
            InitializeComponent();
        }

        private void BubbleSort_Click(object sender, RoutedEventArgs e)
        {
            //реализуется
            int depth;
            if (int.TryParse(depthTextBox.Text, out depth))
            {
                Console.WriteLine("Aboba");
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное значение задержки.\nВведенно неверное значение задержки или вовсе отсутствует.");
            }
        }
        private void SelectSort_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Aboba");
        }
        private void QuickSort_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Aboba");
        }
        private void IntroSort_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Aboba");
        }
    }
}
