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
    /// Логика взаимодействия для Task22Page.xaml
    /// </summary>
    public partial class Task22Page : Page
    {
        public Task22Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"S = {(4.351 * Math.Pow(Convert.ToDouble(TbY.Text), 3) +  2 * Convert.ToDouble(TbT.Text) * Math.Log(Convert.ToDouble(TbT.Text))) / (Math.Sqrt(Math.Cos(2 * Convert.ToDouble(TbY.Text)) + 4.351))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}
