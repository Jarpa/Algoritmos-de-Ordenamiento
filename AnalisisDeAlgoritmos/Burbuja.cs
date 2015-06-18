using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AnalisisDeAlgoritmos
{
    public class Burbuja
    {
        

        public int[] Burbuja1(int []a,int prim,int ult)
        {
            for (int i = prim; i <= ult - 1; i++)
            {
                for (int j = ult; j >= prim + 1; j--)
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

        public int[] BurbujaAlreves(int[] a, int prim, int ult)
        {
            for (int i = ult; i >= prim; i--)
            {
                for (int j = prim; j <ult; j++)
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
