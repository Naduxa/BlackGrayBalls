using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackGrayBolls
{
    class DP
    {
        int[, ,] z = new int[20, 20, 2];
        int n;
        int sum;
        string step;
        int[] a = new int[20];
        public DP(List<int> data)
        {
            Update(data);
        }

        public bool IsGoodBolls()
        {
            if (Calc(0, n - 1, 0) * 2 - sum > 0 && Calc(0, n - 1, 0) * 2 - sum < 4) return true;
            return false;
        }
        public bool IsVeryGoodBolls()
        {
            if (Calc(0, n - 1, 0) * 2 - sum < 0) return true;
            return false;
        }
        private int Calc(int l, int r, int p)
        {
            if (z[l, r, p] != -1)
            {
                return z[l, r, p];
            }
            if (l > r)
            {
                return z[l, r, p] = 0;
            }
            if (l == r)
            {
                if (p == 0)
                {
                    return z[l, r, p] = a[l];
                }
                else
                {
                    return z[l, r, p] = 0;
                }
            }
            if (p == 0)
            {
                if (l == 0 && r == n - 1 && p == 0)
                {
                    if (a[l] + Calc(l + 1, r, 1 - p) > a[r] + Calc(l, r - 1, 1 - p))
                    {
                        z[l, r, p] = a[l] + Calc(l + 1, r, 1 - p);
                        step = "left";
                    }
                    else
                    {
                        z[l, r, p] = a[r] + Calc(l, r - 1, 1 - p);
                        step = "right";
                    }
                }
                else z[l, r, p] = Math.Max(a[l] + Calc(l + 1, r, 1 - p), a[r] + Calc(l, r - 1, 1 - p));
            }
            else
            {
                z[l, r, p] = Math.Min(Calc(l + 1, r, 0), Calc(l, r - 1, 0));
            }
            return z[l, r, p];
        }
        public string Step
        {
            get
            {
                return step;
            }
            set
            {
            }
        }

        public void Update(List<int> data)
        {
            n = data.Count;
            sum = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = data[i];
                sum += a[i];
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    z[i, j, 0] = -1;
                    z[i, j, 1] = -1;
                }
            }
            if (n != 0) z[0, n - 1, 0] = Calc(0, n - 1, 0);
        }
    }
}
