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
    /// Логика взаимодействия для Task19Page.xaml
    /// </summary>
    public partial class Task19Page : Page
    {
        public Task19Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"E = {(Math.Log(0.7 * Convert.ToDouble(TbY.Text) + 2 * Convert.ToDouble(TbQ.Text))) / (Math.Sqrt(3 * Math.Pow(Convert.ToDouble(TbY.Text), 2) + 0.5 * Convert.ToDouble(TbY.Text) + 4))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}
