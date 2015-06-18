using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalisisDeAlgoritmos
{
    public class Seleccion
    {
        public int[] Seleccionn(int[] a, int prim, int ult)
        {
            for (int i = prim; i <= ult - 1; i++)
            {
                int j = PosMinimos(a, i, ult);
                int temp = (int)a[i];
                a[i] = a[j];
                a[j] = temp;
            }
            return a;
        }
        public int PosMinimos(int[] a, int i, int j)
        {
            int pmin = i;
            for (int k = i + 1; k <= j; k++)
            {
                if (a[k] < a[pmin])
                    pmin = k;
            }
            return pmin;
        }

    }
}
