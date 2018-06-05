using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace istatikselHesapMakinesi
{
    class StandartSapma:Form1
    {
        int i;
        public StandartSapma(int n,float []sayilar)
        {
            AritmetikOrtalama aO = new AritmetikOrtalama(sayilar, n);
            float ust = 0,xbar= aO.Sonuclu(sayilar, n);
            for (i = 0; i < n; i++)
            {
                ust +=Convert.ToSingle (Math.Pow((sayilar[i] - xbar), 2));
            }
            float sonuc = Convert.ToSingle(Math.Sqrt(ust / n));
            
        }
        public float Sonuclu(int n, float[] sayilar)
        {
            AritmetikOrtalama aO = new AritmetikOrtalama(sayilar, n);
            float ust = 0, xbar = aO.Sonuclu(sayilar, n);
            for (i = 0; i < n; i++)
            {
                ust += Convert.ToSingle(Math.Pow((sayilar[i] - xbar), 2));
            }
            float sonuc = Convert.ToSingle(Math.Sqrt(ust / n));
            return sonuc;
        }
    }
}
