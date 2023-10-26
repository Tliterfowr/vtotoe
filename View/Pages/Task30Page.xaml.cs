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
    /// Логика взаимодействия для Task30Page.xaml
    /// </summary>
    public partial class Task30Page : Page
    {
        public Task30Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"N = {(3 * Math.Pow(Convert.ToDouble(TbY.Text), 2) + Math.Sqrt(Convert.ToDouble(TbY.Text) + 1)) / (Math.Log(Convert.ToDouble(TbP.Text) + Convert.ToDouble(TbY.Text)) + Math.Exp(Convert.ToDouble(TbP.Text)))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}