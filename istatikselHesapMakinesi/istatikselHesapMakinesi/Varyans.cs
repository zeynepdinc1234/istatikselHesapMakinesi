using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace istatikselHesapMakinesi
{
    class Varyans : StandartSapma
    {
        public Varyans(int n, float[] sayilar) : base(n, sayilar)
        {
       
        }
        public float sonuclu(int n,float[]sayilar)
        {
            return Convert.ToSingle(Math.Pow(Sonuclu(n, sayilar), 2));
        }
    }
}
