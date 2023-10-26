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
    /// Логика взаимодействия для Task17Page.xaml
    /// </summary>
    public partial class Task17Page : Page
    {
        public Task17Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"H = {(Math.Pow(Convert.ToDouble(TbY.Text), 2) - 0.8 * Convert.ToDouble(TbY.Text) + Math.Sqrt(Convert.ToDouble(TbY.Text))) / (23.1 * Math.Pow(Convert.ToDouble(TbN.Text), 2) + Math.Cos(Convert.ToDouble(TbN.Text)))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}