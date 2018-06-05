using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace istatikselHesapMakinesi
{
    class AritmetikOrtalama : Form1
    {


        public AritmetikOrtalama(float[] sayilar, int n)
        {
            int i;
            float total = 0;
            for (i = 0; i < n; i++)
                total += sayilar[i];
            float sonuc = total / n;
         
        }
        public float Sonuclu(float[] sayilar, int n)
        {
            int i;
            float total = 0;
            for (i = 0; i < n; i++)
                total += sayilar[i];
            float sonuc = total / n;
            return sonuc;
        }
    }
}