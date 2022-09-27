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
using Lib_14;

namespace Один
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Нажатие на кнопку "Рассчитать"
        private void btn_Count_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int sum; // Сумма
                string results; //То, что будет выводиться в TextBox с именем result
                int count; // Количество чисел
                Lib_14.Class1.RandomSum(Convert.ToInt32(k.Text), out sum, out results, out count);
                results += "Сумма: " + sum + "\n" + "Количество сгенерированных чисел: " + count;
                result.Text = results;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Кнопка "О программе"
        private void btn_About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дунаева М.И.\n\nПрактическая работа №1\n\n Вычислить сумму целых случайных чисел, распределенных в диапазоне от 55 до " +
                "70, пока эта сумма не превышает некоторого числа K.Вывести на экран" +
                "сгенерированные числа, значение суммы, и количество сгенерированных чисел.");
        }

        // Кнопка "выход"
        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
