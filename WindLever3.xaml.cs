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
using System.Windows.Threading;
using System.Threading;
namespace BlackGrayBolls
{
    /// <summary>
    /// Логика взаимодействия для WinLever2.xaml
    /// </summary>

    public partial class WinLever3 : Window
    {
        List<Button> buttons;
        GamePlay ourGame;
        public WinLever3()
        {
            InitializeComponent();
            buttons = new List<Button>();
            ourGame = new GamePlay(3);

            buttons.Add(b10);
            buttons.Add(b1);
            buttons.Add(b2);
            buttons.Add(b3);
            buttons.Add(b5);
            buttons.Add(b6);
            buttons.Add(b7);
            buttons.Add(b8);
            buttons.Add(b9);
            buttons.Add(b11);
            for (int i = 0; i < buttons.Count; i++)
            {
                // MessageBox.Show(ourGame.bolls[i].ToString());
                buttons[i].Content = ourGame.bolls[i].ToString();
            }
            toBlock();
            InitializeComponent();
        }
        private void toBlock()
        {
            if (buttons.Count == 0) return;
            if (b1 == buttons[0]) b1.IsEnabled = true;
            if (b2 == buttons[0]) b2.IsEnabled = true;
            if (b3 == buttons[0]) b3.IsEnabled = true;
            if (b5 == buttons[0]) b5.IsEnabled = true;
            if (b6 == buttons[0]) b6.IsEnabled = true;
            if (b7 == buttons[0]) b7.IsEnabled = true;
            if (b8 == buttons[0]) b8.IsEnabled = true;
            if (b9 == buttons[0]) b9.IsEnabled = true;
            if (b10 == buttons[0]) b10.IsEnabled = true;
            if (b11 == buttons[0]) b11.IsEnabled = true;

            if (b1 == buttons[buttons.Count - 1]) b1.IsEnabled = true;
            if (b2 == buttons[buttons.Count - 1]) b2.IsEnabled = true;
            if (b3 == buttons[buttons.Count - 1]) b3.IsEnabled = true;
            if (b5 == buttons[buttons.Count - 1]) b5.IsEnabled = true;
            if (b6 == buttons[buttons.Count - 1]) b6.IsEnabled = true;
            if (b7 == buttons[buttons.Count - 1]) b7.IsEnabled = true;
            if (b8 == buttons[buttons.Count - 1]) b8.IsEnabled = true;
            if (b9 == buttons[buttons.Count - 1]) b9.IsEnabled = true;
            if (b10 == buttons[buttons.Count - 1]) b10.IsEnabled = true;
            if (b11 == buttons[buttons.Count - 1]) b11.IsEnabled = true;


            for (int i = 1; i < buttons.Count - 1; i++)
            {

                if (b1 == buttons[i]) b1.IsEnabled = false;
                if (b2 == buttons[i]) b2.IsEnabled = false;
                if (b3 == buttons[i]) b3.IsEnabled = false;
                if (b5 == buttons[i]) b5.IsEnabled = false;
                if (b6 == buttons[i]) b6.IsEnabled = false;
                if (b7 == buttons[i]) b7.IsEnabled = false;
                if (b8 == buttons[i]) b8.IsEnabled = false;
                if (b9 == buttons[i]) b9.IsEnabled = false;
                if (b10 == buttons[i]) b10.IsEnabled = false;
                if (b11 == buttons[i]) b11.IsEnabled = false;
            }
        }

        private void Play(object sender, RoutedEventArgs e)
        {
            Thread.Sleep(200);
            int cnt = buttons.Count;
            pl.Text = ourGame.player.ToString();
            cm.Text = ourGame.comp.ToString();
            if (cnt == 0)
            {
                string result = "";
                string result2 = "";
                if (ourGame.player > ourGame.comp) { result = "Вы выиграли :)"; result2 = "Выигрыш"; }
                if (ourGame.player < ourGame.comp) { result = "Вы проиграли :("; result2 = "Проигрыш"; }
                if (ourGame.comp == ourGame.player) { result = "Ничья!"; result2 = "Ничья"; }
                MessageBox.Show(result); Properties.Settings.Default.count1 = Properties.Settings.Default.count2;
                Properties.Settings.Default.count2 = Properties.Settings.Default.count3;
                Properties.Settings.Default.count3 = Properties.Settings.Default.count4;
                Properties.Settings.Default.count4 = Properties.Settings.Default.count5;
                Properties.Settings.Default.count5 = Properties.Settings.Default.count6;
                Properties.Settings.Default.count6 = Properties.Settings.Default.count7;
                Properties.Settings.Default.count7 = Properties.Settings.Default.count8;
                Properties.Settings.Default.count8 = Properties.Settings.Default.count9;
                Properties.Settings.Default.count9 = Properties.Settings.Default.count10;

                Properties.Settings.Default.count10 = result2 + " " + ourGame.player.ToString() + ":" + ourGame.comp.ToString() + " (Уровень 3)";
                Properties.Settings.Default.Save();
                this.Close();
                return;
            }
            if (cnt % 2 == 1)
            {
                toBlock();
                string com = ourGame.GetStep();
                if (com == "left") do_UnVisible(0);
                else do_UnVisible(buttons.Count - 1);
                cnt++;
                Play(sender, e);
            }
            toBlock();
        }

        private void do_UnVisible(int idx)
        {
            if (b1 == buttons[idx]) b1.Visibility = Visibility.Collapsed;
            if (b2 == buttons[idx]) b2.Visibility = Visibility.Collapsed;
            if (b3 == buttons[idx]) b3.Visibility = Visibility.Collapsed;
            if (b5 == buttons[idx]) b5.Visibility = Visibility.Collapsed;
            if (b6 == buttons[idx]) b6.Visibility = Visibility.Collapsed;
            if (b7 == buttons[idx]) b7.Visibility = Visibility.Collapsed;
            if (b8 == buttons[idx]) b8.Visibility = Visibility.Collapsed;
            if (b9 == buttons[idx]) b9.Visibility = Visibility.Collapsed;
            if (b10 == buttons[idx]) b10.Visibility = Visibility.Collapsed;
            if (b11 == buttons[idx]) b11.Visibility = Visibility.Collapsed;
            buttons.RemoveAt(idx);
        }
        private void b2_Click(object sender, RoutedEventArgs e)
        {
            if (b2 == buttons[0])
            {
                buttons.RemoveAt(0);
                b2.Visibility = Visibility.Collapsed;
                ourGame.SetStep("left");
            }
            else
            {
                buttons.RemoveAt(buttons.Count - 1);
                b2.Visibility = Visibility.Collapsed;
                ourGame.SetStep("right");
            }
            b2.Refresh();
            Play(sender, e);
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if (b3 == buttons[0])
            {
                buttons.RemoveAt(0);
                b3.Visibility = Visibility.Collapsed;
                ourGame.SetStep("left");
            }
            else
            {
                buttons.RemoveAt(buttons.Count - 1);
                b3.Visibility = Visibility.Collapsed;
                ourGame.SetStep("right");
            }

            b3.Refresh();
            Play(sender, e);
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            if (b5 == buttons[0])
            {
                buttons.RemoveAt(0);
                b5.Visibility = Visibility.Collapsed;
                ourGame.SetStep("left");
            }
            else
            {
                buttons.RemoveAt(buttons.Count - 1);
                b5.Visibility = Visibility.Collapsed;
                ourGame.SetStep("right");
            }

            b5.Refresh();
            Play(sender, e);
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            if (b6 == buttons[0])
            {
                buttons.RemoveAt(0);
                b6.Visibility = Visibility.Collapsed;
                ourGame.SetStep("left");
            }
            else
            {
                buttons.RemoveAt(buttons.Count - 1);
                b6.Visibility = Visibility.Collapsed;
                ourGame.SetStep("right");
            }

            b6.Refresh();
            Play(sender, e);
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            if (b7 == buttons[0])
            {
                buttons.RemoveAt(0);
                b7.Visibility = Visibility.Collapsed;
                ourGame.SetStep("left");
            }
            else
            {
                buttons.RemoveAt(buttons.Count - 1);
                b7.Visibility = Visibility.Collapsed;
                ourGame.SetStep("right");
            }
            b7.Refresh();
            Play(sender, e);
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            if (b8 == buttons[0])
            {
                buttons.RemoveAt(0);
                b8.Visibility = Visibility.Collapsed;
                ourGame.SetStep("left");
            }
            else
            {
                buttons.RemoveAt(buttons.Count - 1);
                b8.Visibility = Visibility.Collapsed;
                ourGame.SetStep("right");
            }
            b8.Refresh();
            Play(sender, e);
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            if (b9 == buttons[0])
            {
                buttons.RemoveAt(0);
                b9.Visibility = Visibility.Collapsed;
                ourGame.SetStep("left");
            }
            else
            {
                buttons.RemoveAt(buttons.Count - 1);
                b9.Visibility = Visibility.Collapsed;
                ourGame.SetStep("right");
            }
            b9.Refresh();
            Play(sender, e);
        }

        private void b1_Click_1(object sender, RoutedEventArgs e)
        {
            if (b1 == buttons[0])
            {
                buttons.RemoveAt(0);
                b1.Visibility = Visibility.Collapsed;
                ourGame.SetStep("left");
            }
            else
            {
                buttons.RemoveAt(buttons.Count - 1);
                b1.Visibility = Visibility.Collapsed;
                ourGame.SetStep("right");
            }
            b1.Refresh();
            Play(sender, e);
        }

        private void b10_Click(object sender, RoutedEventArgs e)
        {

            if (b10 == buttons[0])
            {
                buttons.RemoveAt(0);
                b10.Visibility = Visibility.Collapsed;
                ourGame.SetStep("left");
            }
            else
            {
                buttons.RemoveAt(buttons.Count - 1);
                b10.Visibility = Visibility.Collapsed;
                ourGame.SetStep("right");
            }
            b10.Refresh();
            Play(sender, e);
        }

        private void b11_Click(object sender, RoutedEventArgs e)
        {

            if (b11 == buttons[0])
            {
                buttons.RemoveAt(0);
                b11.Visibility = Visibility.Collapsed;
                ourGame.SetStep("left");
            }
            else
            {
                buttons.RemoveAt(buttons.Count - 1);
                b11.Visibility = Visibility.Collapsed;
                ourGame.SetStep("right");
            }
            b11.Refresh();
            Play(sender, e);
        }
        
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
        }

      
    }
}
