using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _153301021_bm
{
    public class Mat
    {

        //<--------------------DataGrid------------------->>

        public DataTable dt = new DataTable();
        
        public Mat()
        {
            dt.Columns.Add("No");
            dt.Columns.Add("Hassaslik");
            dt.Columns.Add("Miktar");
            dt.Columns.Add("Kirlilik");
            dt.Columns.Add("Dönüş Hızı");
            dt.Columns.Add("Süre");
            dt.Columns.Add("Deterjan");

            string[] row1 = new string[] { "1", "Hassas", "Kucuk", "Kucuk", "hassas", "kısa", "çok az" };
            string[] row2 = new string[] { "2", "Hassas", "Kucuk", "Orta", "normal hassas", "kısa", "az" };
            string[] row3 = new string[] { "3", "Hassas", "Kucuk", "Buyuk", "orta", "normal kısa", "orta" };
            string[] row4 = new string[] { "4", "Hassas", "Orta", "Kucuk", "hassas", "kısa", "orta" };
            string[] row5 = new string[] { "5", "Hassas", "Orta", "Orta", "normal hassas", "normal kısa", "orta" };
            string[] row6 = new string[] { "6", "Hassas", "Orta", "Buyuk", "orta", "orta", "fazla" };
            string[] row7 = new string[] { "7", "Hassas", "Buyuk", "Kucuk", "normal hassas", "normal kısa", "orta" };
            string[] row8 = new string[] { "8", "Hassas", "Buyuk", "Orta", "normal hassas", "orta", "fazla" };
            string[] row9 = new string[] { "9", "Hassas", "Buyuk", "Buyuk", "orta", "normal uzun", "fazla" };
            string[] row10 = new string[] { "10", "Orta", "Kucuk", "Kucuk", "normal hassas", "normal kısa", "az" };
            string[] row11 = new string[] { "11", "Orta", "Kucuk", "Orta", "orta", "kısa", "orta" };
            string[] row12 = new string[] { "12", "Orta", "Kucuk", "Buyuk", "normal güçlü", "orta", "fazla" };
            string[] row13 = new string[] { "13", "Orta", "Orta", "Kucuk", "normal hassas ", "normal kısa", "orta" };
            string[] row14 = new string[] { "14", "Orta", "Orta", "Orta", "orta", "orta", "orta" };
            string[] row15 = new string[] { "15", "Orta", "Orta", "Buyuk", "hassas", "uzun", "fazla" };
            string[] row16 = new string[] { "16", "Orta", "Buyuk", "Kucuk", "hassas", "orta", "orta" };
            string[] row17 = new string[] { "17", "Orta", "Buyuk", "Orta", "hassas", "normal uzun", "fazla" };
            string[] row18 = new string[] { "18", "Orta", "Buyuk", "Buyuk", "hassas", "uzun", "çok fazla" };
            string[] row19 = new string[] { "19", "Saglam", "Kucuk", "Kucuk", "orta", "orta", "az" };
            string[] row20 = new string[] { "20", "Saglam", "Kucuk", "Orta", "normal güçlü", "orta", "orta" };
            string[] row21 = new string[] { "21", "Saglam", "Kucuk", "Buyuk", "güçlu", "normal uzun", "fazla" };
            string[] row22 = new string[] { "22", "Saglam", "Orta", "Kucuk", "orta", "orta", "orta" };
            string[] row23 = new string[] { "23", "Saglam", "Orta", "Orta", "normal güçlü", "normal uzun", "orta" };
            string[] row24 = new string[] { "24", "Saglam", "Orta", "Buyuk", "güçlü", "orta", "çok fazla" };
            string[] row25 = new string[] { "25", "Saglam", "Buyuk", "Kucuk", "normal güçlü", "normal uzun", "fazla" };
            string[] row26 = new string[] { "26", "Saglam", "Buyuk", "Orta", "normal güçlü", "uzun", "fazla" };
            string[] row27 = new string[] { "27", "Saglam", "Buyuk", "Buyuk", "güçlü", "uzun", "çok fazla" };
            dt.Rows.Add(row1); dt.Rows.Add(row2); dt.Rows.Add(row3); dt.Rows.Add(row4); dt.Rows.Add(row5);
            dt.Rows.Add(row6); dt.Rows.Add(row7); dt.Rows.Add(row8); dt.Rows.Add(row9); dt.Rows.Add(row10);
            dt.Rows.Add(row11); dt.Rows.Add(row12); dt.Rows.Add(row13); dt.Rows.Add(row14); dt.Rows.Add(row15);
            dt.Rows.Add(row16); dt.Rows.Add(row17); dt.Rows.Add(row18); dt.Rows.Add(row19); dt.Rows.Add(row20);
            dt.Rows.Add(row21); dt.Rows.Add(row22); dt.Rows.Add(row23); dt.Rows.Add(row24); dt.Rows.Add(row25);
            dt.Rows.Add(row26); dt.Rows.Add(row27); 

        }


        //<------------------ Hesaplama ----------------------->>
        public static double ucgen(double a, double b, double c, double sayi)
        {
            if (sayi >= a && sayi <= b)
                return (sayi - a) / (b - a);
            else if (sayi >= b && sayi <= c)
                return (sayi - b) / (b - c) + 1;
            else
                return -1;
        }
        public static double yamuk(double a, double b, double c, double d, double sayi)
        {
            if (sayi >= a && sayi <= b)
                return (sayi - a) / (b - a);
            else if (sayi >= b && sayi <= c)
                return 1;
            else if (sayi >= c && sayi <= d)
                return (sayi - c) / (c - d) + 1;
            else
                return -1;
        }
        //<------------------ Hesaplama ----------------------->>
    }
}
