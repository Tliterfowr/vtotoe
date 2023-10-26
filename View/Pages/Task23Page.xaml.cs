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
    /// Логика взаимодействия для Task23Page.xaml
    /// </summary>
    public partial class Task23Page : Page
    {
        public Task23Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"R = {(Math.Pow(Math.Sin(Convert.ToDouble(TbY.Text)), 2) + 0.3 * Convert.ToDouble(TbD.Text)) / (Math.Exp(Convert.ToDouble(TbY.Text)) + Math.Log(Convert.ToDouble(TbD.Text)))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}