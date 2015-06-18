using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalisisDeAlgoritmos
{
    public class Burbuja_2
    {
        public int[] Burbuja2(int[] a, int prim, int ult)
        {
            for (int i = prim; i <= ult - 1; i++)
            {
                for (int j = ult; j >= i + 1; j--)
                {
                    if (a[j - 1] > a[j])
                    {
                        int aux = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = aux;
                    }
                }
            }
            return a;
        }
        public int[] Burbuja2AlReves(int[] a, int prim, int ult)
        {
            for (int i = ult-1; i >= prim; i--)
            {
                for (int j = prim; j < i + 1; j++)
                {
                    if (a[j + 1] > a[j])
                    {
                        int aux = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = aux;
                    }
                }
            }
            return a;
        }
    }
}
