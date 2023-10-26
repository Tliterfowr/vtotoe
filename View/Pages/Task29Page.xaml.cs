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

namespace WpfApp3.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task29Page.xaml
    /// </summary>
    public partial class Task29Page : Page
    {
        public Task29Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"T = {(0.355 * Math.Pow(Convert.ToDouble(TbH.Text), 2) - 4.355) / (Math.Exp(Convert.ToDouble(TbY.Text) + Convert.ToDouble(TbH.Text)) + Math.Sqrt(2.7 * Convert.ToDouble(TbY.Text)))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}