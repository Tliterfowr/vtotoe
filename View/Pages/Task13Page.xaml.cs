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
    /// Логика взаимодействия для Task13Page.xaml
    /// </summary>
    public partial class Task13Page : Page
    {
        public Task13Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"A = {(Math.Sin(2 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(TbH.Text)) + Math.Pow(Convert.ToDouble(TbH.Text), 2)) / (Math.Exp(Convert.ToDouble(TbH.Text)) + Convert.ToDouble(TbY.Text))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}
