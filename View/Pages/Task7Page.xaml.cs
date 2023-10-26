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
    /// Логика взаимодействия для Task7Page.xaml
    /// </summary>
    public partial class Task7Page : Page
    {
        public Task7Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"N = {(Math.Pow(Convert.ToDouble(TbM.Text), 2) + 2.8 * Convert.ToDouble(TbM.Text) + 0.355) / (Math.Cos(2 * Convert.ToDouble(TbY.Text)) + 3.6)}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}
