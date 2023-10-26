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
    /// Логика взаимодействия для Task27Page.xaml
    /// </summary>
    public partial class Task27Page : Page
    {
        public Task27Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"Z = {(Math.Pow(Math.Sin(Convert.ToDouble(TbP.Text) + 0.4), 2)) / (Math.Pow(Convert.ToDouble(TbY.Text), 2) + 7.325  * Convert.ToDouble(TbP.Text))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}