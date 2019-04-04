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

namespace baithuchanh_04._04_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TxtGt_Click(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(txtSoN.Text);
            int gt = 1;
            for (int i = 2; i <= n; i++)
            {
                gt = gt * i;
            }
           txtKQ.Text = gt.ToString();
        }

        private void BtTong_Click(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(txtSoN.Text);
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s = s + Math.Sqrt(i);
            }
            txtKQ.Text = s.ToString();
        }

        private void BtBP_Click(object sender, RoutedEventArgs e)
        {
            int x = Int32.Parse(txtSox.Text);
            int n = Int32.Parse(txtSoN.Text);
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s = s + Math.Pow(x, i);
            }
            txtKQ.Text = s.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
