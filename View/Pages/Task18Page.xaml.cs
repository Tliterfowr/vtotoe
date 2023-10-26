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
    /// Логика взаимодействия для Task18Page.xaml
    /// </summary>
    public partial class Task18Page : Page
    {
        public Task18Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"R = {(Math.Sqrt(Math.Pow(Math.Sin(Convert.ToDouble(TbY.Text)) ,2))) / (Math.Log(Convert.ToDouble(TbY.Text) + Convert.ToDouble(TbK.Text)) + 3 * Math.Pow(Convert.ToDouble(TbY.Text), 2))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}