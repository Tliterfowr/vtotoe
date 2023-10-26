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
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"D = {(7.8 * Math.Pow(Convert.ToDouble(TbA.Text), 2) + 3.52 * Convert.ToDouble(TbT.Text)) / (Math.Log(Convert.ToDouble(TbA.Text) + 2 * Convert.ToDouble(TbY.Text)) + Math.Exp(Convert.ToDouble(TbY.Text)))}");
            }
            
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}
