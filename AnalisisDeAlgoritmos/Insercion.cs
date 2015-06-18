using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalisisDeAlgoritmos
{
    public class Insercion
    {
        public int[] Insercionn(int[] a, int prim, int ult)
        {

            for (int i = prim + 1; i <= ult; i++)
            {
                
                int x = a[i];
                int j = i - 1;
                while (j >= prim && x < a[j])
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = x;
            }
            return a;
        }

        public int[] InsercionnAlReves(int[] a, int prim, int ult)
        {

            for (int i = ult; i > prim; i--)
            {
                int x = a[i]; 
                int j = i - 1;
                while (j < ult && x >= a[j])
                {
                    a[j - 1] = a[j];
                    j--;
                }
                a[j - 1] = x;
            }
            return a;
        }
    }
}
