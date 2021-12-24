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

namespace Lab4WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollare = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollare;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rate1Drum = Convert.ToDouble(rate1.Text);
            double sum1Drum = Convert.ToDouble(sum1.Text);
            double res1Drum = rate1Drum * sum1Drum;
            resSum1.Text = res1Drum.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rate2Euro = Convert.ToDouble(rate2.Text);
            double sum2Euro = Convert.ToDouble(sum2.Text);
            double res2Euro = rate2Euro * sum2Euro;
            resSum2.Text = res2Euro.ToString();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rate3Griv = Convert.ToDouble(rate3.Text);
            double sum3Griv = Convert.ToDouble(sum3.Text);
            double res3Griv = rate3Griv * sum3Griv;
            resSum3.Text = res3Griv.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rate4Dollar = 0.0254;
            double sum4Dollare = Convert.ToDouble(sum4.Text);
            double res4Double = rate4Dollar * sum4Dollare;
            resSum4.Text = res4Double.ToString();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rate5Dollar = 0.3048;
            double sum5Dollare = Convert.ToDouble(sum5.Text);
            double res5Double = rate5Dollar * sum5Dollare;
            resSum5.Text = res5Double.ToString();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rate6Dollar = 1609.344;
            double sum6Dollare = Convert.ToDouble(sum6.Text);
            double res6Double = rate6Dollar * sum6Dollare;
            resSum6.Text = res6Double.ToString();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rate7Dollar = 1066.8;
            double sum7Dollare = Convert.ToDouble(sum7.Text);
            double res7Double = rate7Dollar * sum7Dollare;
            resSum7.Text = res7Double.ToString();


        }
    }
}
