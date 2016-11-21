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
        }

        private void lever1_Click(object sender, RoutedEventArgs e)
        {
            WinLever1 lev1 = new WinLever1();
            bool f = lev1.Activate();
        }

        private void lever2_Click(object sender, RoutedEventArgs e)
        {
            WinLever2 lev2 = new WinLever2();
            bool f = lev2.Activate();
        }
    }
}
