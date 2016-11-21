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
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace BlackGrayBolls
{
    /// <summary>
    /// Логика взаимодействия для WinCount.xaml
    /// </summary>
    public partial class WinCount : Window
    {
        public WinCount()
        {

            InitializeComponent();
            if (Properties.Settings.Default.count1[Properties.Settings.Default.count1.Length - 1] != '0') LB.Items.Add(Properties.Settings.Default.count1);
            if (Properties.Settings.Default.count2[Properties.Settings.Default.count2.Length - 1] != '0') LB.Items.Add(Properties.Settings.Default.count2);
            if (Properties.Settings.Default.count3[Properties.Settings.Default.count3.Length - 1] != '0') LB.Items.Add(Properties.Settings.Default.count3);
            if (Properties.Settings.Default.count4[Properties.Settings.Default.count4.Length - 1] != '0') LB.Items.Add(Properties.Settings.Default.count4);
            if (Properties.Settings.Default.count5[Properties.Settings.Default.count5.Length - 1] != '0') LB.Items.Add(Properties.Settings.Default.count5);
            if (Properties.Settings.Default.count6[Properties.Settings.Default.count6.Length - 1] != '0') LB.Items.Add(Properties.Settings.Default.count6);
            if (Properties.Settings.Default.count7[Properties.Settings.Default.count7.Length - 1] != '0') LB.Items.Add(Properties.Settings.Default.count7);
            if (Properties.Settings.Default.count8[Properties.Settings.Default.count8.Length - 1] != '0') LB.Items.Add(Properties.Settings.Default.count8);
            if (Properties.Settings.Default.count9[Properties.Settings.Default.count9.Length - 1] != '0') LB.Items.Add(Properties.Settings.Default.count9);
            if (Properties.Settings.Default.count10[Properties.Settings.Default.count10.Length - 1] != '0') LB.Items.Add(Properties.Settings.Default.count10);
            if (LB.Items.Count == 0) LB.Items.Add("У Вас еще не было игр. Попробуйте сыграть :)");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;
            da.To = 360;
            da.Duration = new Duration(TimeSpan.FromSeconds(2));
            RotateTransform rt = new RotateTransform();
            ballik.RenderTransform = rt;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.count1 = "0:0:0";
            Properties.Settings.Default.count2 = "0:0:0";
            Properties.Settings.Default.count3 = "0:0:0";
            Properties.Settings.Default.count4 = "0:0:0";
            Properties.Settings.Default.count5 = "0:0:0";
            Properties.Settings.Default.count6 = "0:0:0";
            Properties.Settings.Default.count7 = "0:0:0";
            Properties.Settings.Default.count8 = "0:0:0";
            Properties.Settings.Default.count9 = "0:0:0";
            Properties.Settings.Default.count10 = "0:0:0";
            Properties.Settings.Default.Save();
            LB.Items.Clear(); 
            if (LB.Items.Count == 0) LB.Items.Add("У Вас еще не было игр. Попробуйте сыграть :)");
        }
    }
}
