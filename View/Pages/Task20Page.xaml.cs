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
    /// Логика взаимодействия для Task20Page.xaml
    /// </summary>
    public partial class Task20Page : Page
    {
        public Task20Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"K = {(2 * Math.Pow(Convert.ToDouble(TbT.Text), 2) + 3 * Convert.ToDouble(TbL.Text) + 7.2) / (Math.Log(Convert.ToDouble(TbY.Text) + Math.Exp(2 * Convert.ToDouble(TbT.Text))))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}