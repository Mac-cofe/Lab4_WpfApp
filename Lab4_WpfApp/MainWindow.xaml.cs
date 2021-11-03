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

namespace Lab4_WpfApp
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

        private void calc1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (kurs1.Text.Length != 0 && kurs1.Text.Length != 0)
                {
                    double rateDollar = Convert.ToDouble(rate1.Text);
                    double kursDollar = Convert.ToDouble(kurs1.Text);
                    double rezult = rateDollar * kursDollar;
                    rezult1.Text = rezult.ToString();
                }
                else
                    MessageBox.Show("Вы не ввели данные");
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные");
            }
        }

        private void calc2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (kurs2.Text.Length != 0 && kurs2.Text.Length != 0)
            {
                double rateEvro = Convert.ToDouble(rate2.Text);
            double kursEvro = Convert.ToDouble(kurs2.Text);
            double rezult = rateEvro * kursEvro;
            rezult2.Text = rezult.ToString();
            }
            else
                MessageBox.Show("Вы не ввели данные");
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные");
            }
        }

        private void calc3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (kurs3.Text.Length != 0 && kurs3.Text.Length != 0)
            {
                double rateGrivn = Convert.ToDouble(rate3.Text);
            double kursGrivn = Convert.ToDouble(kurs3.Text);
            double rezult = rateGrivn * kursGrivn;
            rezult3.Text = rezult.ToString();
            }
            else
                MessageBox.Show("Вы не ввели данные");
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные");
            }
        }

        private void calc4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (kurs3.Text.Length != 0 && kurs3.Text.Length != 0)
            {
                double rateDrams = Convert.ToDouble(rate4.Text);
            double kursDrams = Convert.ToDouble(kurs4.Text);
            double rezult = rateDrams * kursDrams;
            rezult4.Text = rezult.ToString();
            }
            else
                MessageBox.Show("Вы не ввели данные");
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные");
            }
        }

        private void calc_m1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (km.Text.Length != 0)
            {
                double km_m = Convert.ToDouble(km.Text);
                double rezult = km_m*1000;
                rezult_m1.Text = rezult.ToString();
            }
            else
                MessageBox.Show("Вы не ввели данные");
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные");
            }
        }

        private void calc_m2_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
            if (versta.Text.Length != 0)
            {
                double versta_m = Convert.ToDouble(versta.Text);
                double rezult = versta_m * 1066.8;
                rezult_m2.Text = rezult.ToString();
            }
            else
                MessageBox.Show("Вы не ввели данные");
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные");
            }
        }

        private void calc_m3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (mili.Text.Length != 0)
            {
                double mili_m = Convert.ToDouble(mili.Text);
                double rezult = mili_m * 1609.34;
                rezult_m3.Text = rezult.ToString();
            }
            else
                MessageBox.Show("Вы не ввели данные");
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные");
            }
        }

        private void calc_m4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (futs.Text.Length != 0)
            {
                double futs_m = Convert.ToDouble(futs.Text);
                double rezult = futs_m * 30.48/100;
                rezult_m4.Text = rezult.ToString();
            }
            else
                MessageBox.Show("Вы не ввели данные");
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные");
            }
        }
    }
}
