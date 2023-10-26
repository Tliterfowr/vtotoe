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
    /// Логика взаимодействия для Task8Page.xaml
    /// </summary>
    public partial class Task8Page : Page
    {
        public Task8Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"T = {(2.37 * Math.Sin(Convert.ToDouble(TbT.Text) + 1)) / (Math.Sqrt(4 * Math.Pow(Convert.ToDouble(TbY.Text), 2) - 0.1 * Convert.ToDouble(TbY.Text) + 5))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}
