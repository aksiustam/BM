using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _153301021_bm
{
    abstract class Girdi 
    {
        public enum Hassasenum
        {
            Saglam,
            Orta,
            Hassas
        }
        public enum Kirlienum
        {
            Kucuk,
            Orta,
            Buyuk
        }
        public enum Miktarenum
        {
            Kucuk,
            Orta,
            Buyuk
        }


        public double hassas, kirli, miktar;
        

        public List<Hassasenum> hassasList;
        public List<Kirlienum> kirliList;
        public List<Miktarenum> miktarList;
        //<------------------ Kurallar ----------------------->>
        public void DurumHesapla()
        {
            hassasList = new List<Hassasenum>();
            kirliList = new List<Kirlienum>();
            miktarList =new List<Miktarenum>();
            
            //<<------------------------------------------>>
            if (hassas >= -4 && hassas <= 4)
                hassasList.Add(Hassasenum.Saglam);

            if (hassas >= 3 && hassas <= 7)
                hassasList.Add(Hassasenum.Orta);

            if (hassas >= 5.5 && hassas <= 14)
                hassasList.Add(Hassasenum.Hassas);
            //<<------------------------------------------>>
            if (miktar >= -4 && miktar <= 4)
                miktarList.Add(Miktarenum.Kucuk);

            if (miktar >= 3 && miktar <= 7)
                miktarList.Add(Miktarenum.Orta);

            if (miktar >= 5.5 && miktar <= 14)
                miktarList.Add(Miktarenum.Buyuk);
            //<<------------------------------------------>> 
            if (kirli >= -4.5 && kirli <= 4.5)
                kirliList.Add(Kirlienum.Kucuk);

            if (kirli >= 3 && kirli <= 7)
                kirliList.Add(Kirlienum.Orta);

            if (kirli >=5.5 && kirli <= 15)
                kirliList.Add(Kirlienum.Buyuk);

            
            
        }
        //<------------------ Kurallar ----------------------->>

        public double FyHesapla(Enum s)
        {

            if (s.Equals(Hassasenum.Saglam))
                return Mat.yamuk(-4, -1.5, 2, 4, hassas);
            if (s.Equals(Hassasenum.Orta))
                return Mat.ucgen(3, 5, 7, hassas);
            if (s.Equals(Hassasenum.Hassas))
                return Mat.yamuk(5.5, 8, 12.5, 14, hassas);

           

            if (s.Equals(Miktarenum.Kucuk))
                return Mat.yamuk(-4, -1.5, 2, 4, miktar);
            if (s.Equals(Miktarenum.Orta))
                return Mat.ucgen(3, 5, 7, miktar);
            if (s.Equals(Miktarenum.Buyuk))
                return Mat.yamuk(5.5, 8, 12.5, 14, miktar);
           

            if (s.Equals(Kirlienum.Kucuk))
                return Mat.yamuk(-4.5, -2.5, 2, 4.5, kirli);
            if (s.Equals(Kirlienum.Orta))
                return Mat.ucgen(3, 5, 7, kirli);
            if (s.Equals(Kirlienum.Buyuk))
                return Mat.yamuk(5.5, 8, 12.5, 15, kirli);

            return -1;
        }



       
    }
}
