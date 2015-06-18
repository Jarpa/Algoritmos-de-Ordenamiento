using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalisisDeAlgoritmos
{
    public class Mezcla
    {
        public int[] Mezclar(int[] a, int[] b, int prim, int ult)
        {
            if (prim < ult)
            {
                int mitad = (prim + ult) / 2;
                Mezclar(a, b, prim, mitad);
                Mezclar(a, b, mitad + 1, ult);
                Combinar(a, b, prim, mitad, mitad + 1, ult);
            }
            return a;
        }
        public void Combinar(int[] a, int[] b, int p1, int u1, int p2, int u2)
        {
            if (p1 > u1 || p2 > u2)
            {

            }
            else
            {
                for (int k = p1; k <= u2; k++)
                {
                    b[k] = a[k];
                }
                int i1 = p1;
                int i2 = p2;
                for (int k = p1; k <= u2; k++)
                {
                    if (b[i1] <= b[i2])
                    {
                        a[k] = b[i1];
                        if (i1 < u1)
                            i1++;
                        else
                            b[i1] = 1000000000 + 1;
                    }
                    else
                    {
                        a[k] = b[i2];
                        if (i2 < u2)
                            i2++;
                        else
                            b[i2] = 1000000000 + 1;
                    }
                }
            }
        }

    }
}
