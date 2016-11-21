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
    /// Логика взаимодействия для WindowRule.xaml
    /// </summary>
    public partial class WindowRule : Window
    {
        public WindowRule()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
        }
    }
}
