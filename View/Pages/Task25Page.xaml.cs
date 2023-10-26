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
    /// Логика взаимодействия для Task25Page.xaml
    /// </summary>
    public partial class Task25Page : Page
    {
        public Task25Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"L = {Math.Pow(Math.Cos(Convert.ToDouble(TbC.Text)), 2) + ((3 * Math.Pow(Convert.ToDouble(TbT.Text),2) + 4) / (Math.Sqrt(Convert.ToDouble(TbC.Text) + Convert.ToDouble(TbT.Text))))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}