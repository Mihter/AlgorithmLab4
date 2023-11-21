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
            if(Checker() == true)
            {
                MessageBox.Show("Выполняется");//запуск
                frame.Navigate(new InternalSortMain());
            }
            else 
            {
                MessageBox.Show("Пример: \n1) 1 или 87\n2) 3 или 0,3");
            }
        }
        private void SelectSort_Click(object sender, RoutedEventArgs e)
        {
            if (Checker() == true)
            {
                MessageBox.Show("Выполняется");//запуск
            }
            else
            {
                MessageBox.Show("Пример: \n1) 10 или 23\n2) 4 или 0,4");
            }
        }
        private void QuickSort_Click(object sender, RoutedEventArgs e)
        {
            if (Checker() == true)
            {
                MessageBox.Show("Выполняется");//запуск
            }
            else
            {
                MessageBox.Show("Пример: \n1) 6 или 107\n2) 5 или 0,5");
            }
        }
        private void IntroSort_Click(object sender, RoutedEventArgs e)
        {
            if (Checker() == true)
            {
                MessageBox.Show("Выполняется");//запуск
            }
            else
            {
                MessageBox.Show("Пример: \n1) 5 или 287\n2) 3 или 1,3");
            }
        }

        private bool Checker()
        {
            int size;
            double delay;
            if (int.TryParse(countTextBox.Text, out size) && double.TryParse(delayTextBox.Text, out delay))
            {
                if (size >= 0 && delay >= 0)
                {
                    return true; 
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите целое не отрицательное число элементов.\n" +
                        "Пожалуйста, введите дробное(через запятую) или целое, не отрицательное время задержки.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное значение кол-ва элементов или задержки.\n" +
                    "Введенно неверное значение кол-ва элементов или задержки или вовсе отсутствует.");
                return false;
            }
        }
    }
}
