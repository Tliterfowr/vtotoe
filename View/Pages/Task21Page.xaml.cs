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
    /// Логика взаимодействия для Task21Page.xaml
    /// </summary>
    public partial class Task21Page : Page
    {
        public Task21Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"Q = {(Math.Sqrt(Convert.ToDouble(TbK.Text) + 2.6 * Convert.ToDouble(TbP.Text) * Math.Sin(Convert.ToDouble(TbK.Text)))) / (Convert.ToDouble(TbX.Text) - Math.Pow(Convert.ToDouble(TbX.Text), 3))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}