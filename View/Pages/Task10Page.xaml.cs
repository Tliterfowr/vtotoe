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
    /// Логика взаимодействия для Task10Page.xaml
    /// </summary>
    public partial class Task10Page : Page
    {
        public Task10Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"Z = {(2 * Convert.ToDouble(TbT.Text) + Convert.ToDouble(TbY.Text) * Math.Cos(Convert.ToDouble(TbT.Text))) / (Math.Sqrt(Convert.ToDouble(TbY.Text) + 4.831))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}
