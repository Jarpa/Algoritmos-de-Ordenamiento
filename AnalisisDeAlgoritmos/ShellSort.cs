using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalisisDeAlgoritmos
{
    public class ShellSort
    {
        public int[] shellSort(int[] a, int prim, int ult)
        {
            int incremento = 3;
            while (incremento > 0)
            {
                for (int i = 0; i <= ult - prim; i++)
                {
                    int j = i;
                    int temp = a[i];
                    while ((j >= incremento) && (a[j - incremento] > temp))
                    {
                        a[j] = a[j - incremento];
                        j = j - incremento;
                    }
                    a[j] = temp;
                }
                if (incremento / 2 != 0)
                    incremento = incremento / 2;
                else if (incremento == 1)
                    incremento = 0;
                else
                    incremento = 1;
            }
            return a;
        }

    }
}
