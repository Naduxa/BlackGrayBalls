using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackGrayBolls
{
    class GamePlay
    {
        public List<int> bolls;
        public DP game;
        public int player;
        public int comp;
        public GamePlay(int lever)
        {
            int cnt = 0;
            if (lever == 1)
            {
                cnt = 4;
            }
            if (lever == 2)
            {
                cnt = 8;
            }
            if (lever == 3)
            {
                cnt = 16;
            }
            do
            {
                bolls = new List<int>();
                Random rnd = new Random();
                for (int i = 0; i < cnt; i++)
                {
                    bolls.Add(rnd.Next(4,15));
                }
                game = new DP(bolls);
            } while (!game.IsGoodBolls());
            comp = 0;
            player = 0;
        }
        public string GetStep()
        {
            string step = game.Step;
            if (step == "right")
            {
                comp += bolls[bolls.Count - 1];
                bolls.RemoveAt(bolls.Count - 1);
            }
            else
            {
                comp += bolls[0];
                bolls.RemoveAt(0);
            }
            game.Update(bolls);
            return step;
        }
        public void SetStep(string step)
        {
            if (step == "right")
            {
                player += bolls[bolls.Count - 1];
                bolls.RemoveAt(bolls.Count - 1);
            }
            else
            {
                player += bolls[0];
                bolls.RemoveAt(0);
            }
            game.Update(bolls);
        }
    }
}
