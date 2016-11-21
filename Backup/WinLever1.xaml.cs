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

namespace BlackGrayBolls
{
    /// <summary>
    /// Логика взаимодействия для WinLever1.xaml
    /// </summary>
    public partial class WinLever1 : Window
    {
        List<Button> buttons;
        GamePlay ourGame;
        public WinLever1()
        {
            InitializeComponent();
            buttons = new List<Button>();
            ourGame = new GamePlay(1);
            buttons.Add(b1);
            buttons.Add(b2);
            buttons.Add(b3);
            buttons.Add(b5);
            for (int i = 0; i < buttons.Count; i++)
            {
                // MessageBox.Show(ourGame.bolls[i].ToString());
                buttons[i].Content = ourGame.bolls[i].ToString();
            }
            toBlock();
        }

        private void Play(object sender, RoutedEventArgs e)
        {
            int cnt = buttons.Count;
            pl.Text = ourGame.player.ToString();
            cm.Text = ourGame.comp.ToString();
            if (cnt == 0)
            {
                string result = "";
                if (ourGame.player > ourGame.comp) result = "Вы выиграли :)";
                if (ourGame.player < ourGame.comp) result = "Вы проиграли :(";
                if (ourGame.comp == ourGame.player) result = "Ничья!";
                MessageBox.Show(result);
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

        private void toBlock()
        {
            if (buttons.Count == 0) return;
            if (b1 == buttons[0]) b1.IsEnabled = true;
            if (b2 == buttons[0]) b2.IsEnabled = true;
            if (b3 == buttons[0]) b3.IsEnabled = true;
            if (b5 == buttons[0]) b5.IsEnabled = true;

            if (b1 == buttons[buttons.Count - 1]) b1.IsEnabled = true;
            if (b2 == buttons[buttons.Count - 1]) b2.IsEnabled = true;
            if (b3 == buttons[buttons.Count - 1]) b3.IsEnabled = true;
            if (b5 == buttons[buttons.Count - 1]) b5.IsEnabled = true;
            for (int i = 1; i < buttons.Count - 1; i++)
            {
                if (b1 == buttons[i]) b1.IsEnabled = false;
                if (b2 == buttons[i]) b2.IsEnabled = false;
                if (b3 == buttons[i]) b3.IsEnabled = false;
                if (b5 == buttons[i]) b5.IsEnabled = false;
            }
        }
        private void do_UnVisible(int idx)
        {
            if (b1 == buttons[idx]) b1.Visibility =  Visibility.Collapsed;
            if (b2 == buttons[idx]) b2.Visibility =  Visibility.Collapsed;
            if (b3 == buttons[idx]) b3.Visibility =  Visibility.Collapsed;
            if (b5 == buttons[idx]) b5.Visibility =  Visibility.Collapsed;
            buttons.RemoveAt(idx);
        }
        private void b1_Click(object sender, RoutedEventArgs e)
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
            Play(sender, e);
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
            Play(sender, e);
        }
    }
}
