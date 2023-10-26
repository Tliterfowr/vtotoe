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
    /// Логика взаимодействия для Task14Page.xaml
    /// </summary>
    public partial class Task14Page : Page
    {
        public Task14Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"P = {(Math.Exp(Convert.ToDouble(TbY.Text) + 2.5) + 7.1 * Math.Pow(Convert.ToDouble(TbH.Text), 3)) / (Math.Log(Math.Sqrt(Convert.ToDouble(TbY.Text) + 0.04 * Convert.ToDouble(TbH.Text))))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}
