using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalisisDeAlgoritmos
{
    public class QuickSort
    {
        public int[] Quicksort(int[] a, int prim, int ult)
        {

            if (prim < ult)
            {
                int l = Pivote(a, a[prim], prim, ult);
                Quicksort(a, prim, l - 1);
                Quicksort(a, l + 1, ult);
            }
            return a;
        }

        public int Pivote(int[] a, int p, int prim, int ult)
        {
            int temp;
            int i = prim;
            int l = ult + 1;
            do
            {
                i++;
            } while (a[i] <= p && i < ult);
            do
            {
                l--;
            } while (a[l] > p);

            while (i < l)
            {
                temp = a[i];
                a[i] = a[l];
                a[l] = temp;
                do
                {
                    i++;
                } while (a[i] <= p);
                do
                {
                    l--;
                } while (a[l] > p);
            }
            temp = a[prim];
            a[prim] = a[l];
            a[l] = temp;
            return l;
        }


    }
}
