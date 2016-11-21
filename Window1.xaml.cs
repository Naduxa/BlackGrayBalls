using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
namespace BlackGrayBolls
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        //WindowRule wind = new WindowRule();
        public Window1()
        {
            InitializeComponent();

        }

        private void rules_Click(object sender, RoutedEventArgs e)
        {
            WindowRule rule = new WindowRule();
            bool f = rule.Activate();
            this.Close();
        }

        private void lever1_Click(object sender, RoutedEventArgs e)
        {
            WinLever1 lev1 = new WinLever1();
            bool f = lev1.Activate();
            this.Close();
        }

        private void lever2_Click(object sender, RoutedEventArgs e)
        {
            WinLever2 lev2 = new WinLever2();
            bool f = lev2.Activate();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;
            da.To = 360;
            da.Duration = new Duration(TimeSpan.FromSeconds(3));
            RotateTransform rt = new RotateTransform();
            ballik.RenderTransform = rt;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);
        }

        private void lever4_Click(object sender, RoutedEventArgs e)
        {
            WinLever4 lev4 = new WinLever4();
            bool f = lev4.Activate();
            this.Close();
        }

        private void lever5_Click(object sender, RoutedEventArgs e)
        {

            WinLever5 lev5 = new WinLever5();
            bool f = lev5.Activate();
            this.Close();
        }

        private void lever3_Click(object sender, RoutedEventArgs e)
        {
            WinLever3 lev3 = new WinLever3();
            bool f = lev3.Activate();
            this.Close();
        }

        private void hishory_Click(object sender, RoutedEventArgs e)
        {
            WinCount wc = new WinCount();
            bool f = wc.Activate();
            this.Close();
        }
    }
}
