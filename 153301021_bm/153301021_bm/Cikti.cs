using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _153301021_bm
{
    class Cikti : Girdi
    {
        
        public Cikti(double a, double b, double c)
        {
            hassas = a;
            kirli = b;
            miktar = c;
        }
        public enum Cikti_DonusHizienum
        {
            Hassas,
            NormalHassas,
            Orta,
            NormalGuclu,
            Guclu
        }
        public enum Cikti_Sureenum
        {
            Kisa,
            NormalKisa,
            Orta,
            NormalUzun,
            Uzun
        }
        public enum Cikti_Deterjanenum
        {
            CokAz,
            Az,
            Orta,
            Fazla,
            CokFazla
        }

        public double DonusHizi, Sure, Deterjan;

        public double OrtaNoktasiniBul(Enum key)
        {
            if (key.Equals(Cikti_DonusHizienum.Hassas))
                return 0.5;
            if (key.Equals(Cikti_DonusHizienum.NormalHassas))
                return 2.75;
            if (key.Equals(Cikti_DonusHizienum.Orta))
                return 5;
            if (key.Equals(Cikti_DonusHizienum.NormalGuclu))
                return 7.25;
            if (key.Equals(Cikti_DonusHizienum.Guclu))
                return 9.5;

            if (key.Equals(Cikti_Sureenum.Kisa))
                return 22.3;
            if (key.Equals(Cikti_Sureenum.NormalKisa))
                return 39.9;
            if (key.Equals(Cikti_Sureenum.Orta))
                return 57.5;
            if (key.Equals(Cikti_Sureenum.NormalUzun))
                return 75.1;
            if (key.Equals(Cikti_Sureenum.Uzun))
                return 92.7;

            if (key.Equals(Cikti_Deterjanenum.CokAz))
                return 20;
            if (key.Equals(Cikti_Deterjanenum.Az))
                return 85;
            if (key.Equals(Cikti_Deterjanenum.Orta))
                return 150;
            if (key.Equals(Cikti_Deterjanenum.Fazla))
                return 215;
            if (key.Equals(Cikti_Deterjanenum.CokFazla))
                return 280;

            return 0;
        }

        public List<List<Enum>> TumciktiDurum;
        public List<Enum> ciktiDurum;
        public List<double> mumdai;


        public Dictionary<Enum, List<double>> donusHizi;
        public Dictionary<Enum, List<double>> sure;
        public Dictionary<Enum, List<double>> deterjan;

        public List<double> bucket;
        //<------------------ Kurallar ----------------------->>
        public void KuralHesapla()
        {
            
            TumciktiDurum = new List<List<Enum>>();
            mumdai = new List<double>();
            //1
            if (hassasList.Contains(Hassasenum.Hassas) && miktarList.Contains(Miktarenum.Kucuk) && kirliList.Contains(Kirlienum.Kucuk))
            {
                
                double enKucukEleman = Kucuk(Hassasenum.Hassas, Miktarenum.Kucuk, Kirlienum.Kucuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();
                
                ciktiDurum.Add(Cikti_DonusHizienum.Hassas);
                ciktiDurum.Add(Cikti_Sureenum.Kisa);
                ciktiDurum.Add(Cikti_Deterjanenum.CokAz);
                TumciktiDurum.Add(ciktiDurum);
            }
            //2
            if (hassasList.Contains(Hassasenum.Hassas) && miktarList.Contains(Miktarenum.Kucuk) && kirliList.Contains(Kirlienum.Orta))
            {
                double enKucukEleman = Kucuk(Hassasenum.Hassas, Miktarenum.Kucuk, Kirlienum.Orta);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.NormalHassas);
                ciktiDurum.Add(Cikti_Sureenum.Kisa);
                ciktiDurum.Add(Cikti_Deterjanenum.Az);
                TumciktiDurum.Add(ciktiDurum);
            }
            //3
            if (hassasList.Contains(Hassasenum.Hassas) && miktarList.Contains(Miktarenum.Kucuk) && kirliList.Contains(Kirlienum.Buyuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Hassas, Miktarenum.Kucuk, Kirlienum.Buyuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.Orta);
                ciktiDurum.Add(Cikti_Sureenum.NormalKisa);
                ciktiDurum.Add(Cikti_Deterjanenum.Orta);
                TumciktiDurum.Add(ciktiDurum);
            }

            //4
            if (hassasList.Contains(Hassasenum.Hassas) && miktarList.Contains(Miktarenum.Orta) && kirliList.Contains(Kirlienum.Kucuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Hassas, Miktarenum.Orta, Kirlienum.Kucuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.Hassas);
                ciktiDurum.Add(Cikti_Sureenum.Kisa);
                ciktiDurum.Add(Cikti_Deterjanenum.Orta);
                TumciktiDurum.Add(ciktiDurum);
            }
            //5
            if (hassasList.Contains(Hassasenum.Hassas) && miktarList.Contains(Miktarenum.Orta) && kirliList.Contains(Kirlienum.Orta))
            {
                double enKucukEleman = Kucuk(Hassasenum.Hassas, Miktarenum.Orta, Kirlienum.Orta);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.NormalHassas);
                ciktiDurum.Add(Cikti_Sureenum.NormalKisa);
                ciktiDurum.Add(Cikti_Deterjanenum.Orta);
                TumciktiDurum.Add(ciktiDurum);
            }
            //6
            if (hassasList.Contains(Hassasenum.Hassas) && miktarList.Contains(Miktarenum.Orta) && kirliList.Contains(Kirlienum.Buyuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Hassas, Miktarenum.Orta, Kirlienum.Buyuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.Orta);
                ciktiDurum.Add(Cikti_Sureenum.Orta);
                ciktiDurum.Add(Cikti_Deterjanenum.Fazla);
                TumciktiDurum.Add(ciktiDurum);
            }


            //7
            if (hassasList.Contains(Hassasenum.Hassas) && miktarList.Contains(Miktarenum.Buyuk) && kirliList.Contains(Kirlienum.Kucuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Hassas, Miktarenum.Buyuk, Kirlienum.Kucuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.NormalHassas);
                ciktiDurum.Add(Cikti_Sureenum.NormalKisa);
                ciktiDurum.Add(Cikti_Deterjanenum.Orta);
                TumciktiDurum.Add(ciktiDurum);
            }
            //8
            if (hassasList.Contains(Hassasenum.Hassas) && miktarList.Contains(Miktarenum.Buyuk) && kirliList.Contains(Kirlienum.Orta))
            {
                double enKucukEleman = Kucuk(Hassasenum.Hassas, Miktarenum.Buyuk, Kirlienum.Orta);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.NormalHassas);
                ciktiDurum.Add(Cikti_Sureenum.Orta);
                ciktiDurum.Add(Cikti_Deterjanenum.Fazla);
                TumciktiDurum.Add(ciktiDurum);
            }
            //9
            if (hassasList.Contains(Hassasenum.Hassas) && miktarList.Contains(Miktarenum.Buyuk) && kirliList.Contains(Kirlienum.Buyuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Hassas, Miktarenum.Buyuk, Kirlienum.Buyuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.Orta);
                ciktiDurum.Add(Cikti_Sureenum.NormalUzun);
                ciktiDurum.Add(Cikti_Deterjanenum.Fazla);
                TumciktiDurum.Add(ciktiDurum);
            }

            // 10
            if (hassasList.Contains(Hassasenum.Orta) && miktarList.Contains(Miktarenum.Kucuk) && kirliList.Contains(Kirlienum.Kucuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Orta, Miktarenum.Kucuk, Kirlienum.Kucuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.NormalHassas);
                ciktiDurum.Add(Cikti_Sureenum.NormalKisa);
                ciktiDurum.Add(Cikti_Deterjanenum.Az);
                TumciktiDurum.Add(ciktiDurum);
            }


            //11
            if (hassasList.Contains(Hassasenum.Orta) && miktarList.Contains(Miktarenum.Kucuk) && kirliList.Contains(Kirlienum.Orta))
            {
                double enKucukEleman = Kucuk(Hassasenum.Orta, Miktarenum.Kucuk, Kirlienum.Orta);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.Orta);
                ciktiDurum.Add(Cikti_Sureenum.Kisa);
                ciktiDurum.Add(Cikti_Deterjanenum.Orta);
                TumciktiDurum.Add(ciktiDurum);
            }
            //12
            if (hassasList.Contains(Hassasenum.Orta) && miktarList.Contains(Miktarenum.Kucuk) && kirliList.Contains(Kirlienum.Buyuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Orta, Miktarenum.Kucuk, Kirlienum.Buyuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.NormalGuclu);
                ciktiDurum.Add(Cikti_Sureenum.Orta);
                ciktiDurum.Add(Cikti_Deterjanenum.Fazla);
                TumciktiDurum.Add(ciktiDurum);
            }
            //13
            if (hassasList.Contains(Hassasenum.Orta) && miktarList.Contains(Miktarenum.Orta) && kirliList.Contains(Kirlienum.Kucuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Orta, Miktarenum.Orta, Kirlienum.Kucuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.NormalHassas);
                ciktiDurum.Add(Cikti_Sureenum.NormalKisa);
                ciktiDurum.Add(Cikti_Deterjanenum.Orta);
                TumciktiDurum.Add(ciktiDurum);
            }



            // 14
            if (hassasList.Contains(Hassasenum.Orta) && miktarList.Contains(Miktarenum.Orta) && kirliList.Contains(Kirlienum.Orta))
            {
                double enKucukEleman = Kucuk(Hassasenum.Orta, Miktarenum.Orta, Kirlienum.Orta);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.Orta);
                ciktiDurum.Add(Cikti_Sureenum.Orta);
                ciktiDurum.Add(Cikti_Deterjanenum.Orta);
                TumciktiDurum.Add(ciktiDurum);
            }
            //15
            if (hassasList.Contains(Hassasenum.Orta) && miktarList.Contains(Miktarenum.Orta) && kirliList.Contains(Kirlienum.Buyuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Orta, Miktarenum.Orta, Kirlienum.Buyuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.Hassas);
                ciktiDurum.Add(Cikti_Sureenum.Uzun);
                ciktiDurum.Add(Cikti_Deterjanenum.Fazla);
                TumciktiDurum.Add(ciktiDurum);
            }

            //16
            if (hassasList.Contains(Hassasenum.Orta) && miktarList.Contains(Miktarenum.Buyuk) && kirliList.Contains(Kirlienum.Kucuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Orta, Miktarenum.Buyuk, Kirlienum.Kucuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.Hassas);
                ciktiDurum.Add(Cikti_Sureenum.Orta);
                ciktiDurum.Add(Cikti_Deterjanenum.Orta);
                TumciktiDurum.Add(ciktiDurum);
            }
            //17
            if (hassasList.Contains(Hassasenum.Orta) && miktarList.Contains(Miktarenum.Buyuk) && kirliList.Contains(Kirlienum.Orta))
            {
                double enKucukEleman = Kucuk(Hassasenum.Orta, Miktarenum.Buyuk, Kirlienum.Orta);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.Hassas);
                ciktiDurum.Add(Cikti_Sureenum.NormalUzun);
                ciktiDurum.Add(Cikti_Deterjanenum.Fazla);
                TumciktiDurum.Add(ciktiDurum);
            }
            //18
            if (hassasList.Contains(Hassasenum.Orta) && miktarList.Contains(Miktarenum.Buyuk) && kirliList.Contains(Kirlienum.Buyuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Orta, Miktarenum.Buyuk, Kirlienum.Buyuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.Hassas);
                ciktiDurum.Add(Cikti_Sureenum.Uzun);
                ciktiDurum.Add(Cikti_Deterjanenum.CokFazla);
                TumciktiDurum.Add(ciktiDurum);
            }

            //19
            if (hassasList.Contains(Hassasenum.Saglam) && miktarList.Contains(Miktarenum.Kucuk) && kirliList.Contains(Kirlienum.Kucuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Saglam, Miktarenum.Kucuk, Kirlienum.Kucuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.Orta);
                ciktiDurum.Add(Cikti_Sureenum.Orta);
                ciktiDurum.Add(Cikti_Deterjanenum.Az);
                TumciktiDurum.Add(ciktiDurum);
            }
            //20
            if (hassasList.Contains(Hassasenum.Saglam) && miktarList.Contains(Miktarenum.Kucuk) && kirliList.Contains(Kirlienum.Orta))
            {
                double enKucukEleman = Kucuk(Hassasenum.Saglam, Miktarenum.Kucuk, Kirlienum.Orta);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.NormalGuclu);
                ciktiDurum.Add(Cikti_Sureenum.Orta);
                ciktiDurum.Add(Cikti_Deterjanenum.Orta);
                TumciktiDurum.Add(ciktiDurum);
            }
            //21
            if (hassasList.Contains(Hassasenum.Saglam) && miktarList.Contains(Miktarenum.Kucuk) && kirliList.Contains(Kirlienum.Buyuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Saglam, Miktarenum.Kucuk, Kirlienum.Buyuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.Guclu);
                ciktiDurum.Add(Cikti_Sureenum.NormalUzun);
                ciktiDurum.Add(Cikti_Deterjanenum.Fazla);
                TumciktiDurum.Add(ciktiDurum);
            }

            //22
            if (hassasList.Contains(Hassasenum.Saglam) && miktarList.Contains(Miktarenum.Orta) && kirliList.Contains(Kirlienum.Kucuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Saglam, Miktarenum.Orta, Kirlienum.Kucuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.Orta);
                ciktiDurum.Add(Cikti_Sureenum.Orta);
                ciktiDurum.Add(Cikti_Deterjanenum.Orta);
                TumciktiDurum.Add(ciktiDurum);
            }
            //23
            if (hassasList.Contains(Hassasenum.Saglam) && miktarList.Contains(Miktarenum.Orta) && kirliList.Contains(Kirlienum.Orta))
            {
                double enKucukEleman = Kucuk(Hassasenum.Saglam, Miktarenum.Orta, Kirlienum.Orta);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.NormalGuclu);
                ciktiDurum.Add(Cikti_Sureenum.NormalUzun);
                ciktiDurum.Add(Cikti_Deterjanenum.Orta);
                TumciktiDurum.Add(ciktiDurum);
            }
            //24
            if (hassasList.Contains(Hassasenum.Saglam) && miktarList.Contains(Miktarenum.Orta) && kirliList.Contains(Kirlienum.Buyuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Saglam, Miktarenum.Orta, Kirlienum.Buyuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.Guclu);
                ciktiDurum.Add(Cikti_Sureenum.Orta);
                ciktiDurum.Add(Cikti_Deterjanenum.CokFazla);
                TumciktiDurum.Add(ciktiDurum);
            }

            //25
            if (hassasList.Contains(Hassasenum.Saglam) && miktarList.Contains(Miktarenum.Buyuk) && kirliList.Contains(Kirlienum.Kucuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Saglam, Miktarenum.Buyuk, Kirlienum.Kucuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.NormalGuclu);
                ciktiDurum.Add(Cikti_Sureenum.NormalUzun);
                ciktiDurum.Add(Cikti_Deterjanenum.Fazla);
                TumciktiDurum.Add(ciktiDurum);
            }
            //26
            if (hassasList.Contains(Hassasenum.Saglam) && miktarList.Contains(Miktarenum.Buyuk) && kirliList.Contains(Kirlienum.Orta))
            {
                double enKucukEleman = Kucuk(Hassasenum.Saglam, Miktarenum.Buyuk, Kirlienum.Orta);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.NormalGuclu);
                ciktiDurum.Add(Cikti_Sureenum.Uzun);
                ciktiDurum.Add(Cikti_Deterjanenum.Fazla);
                TumciktiDurum.Add(ciktiDurum);
            }
            //27
            if (hassasList.Contains(Hassasenum.Saglam) && miktarList.Contains(Miktarenum.Buyuk) && kirliList.Contains(Kirlienum.Buyuk))
            {
                double enKucukEleman = Kucuk(Hassasenum.Saglam, Miktarenum.Buyuk, Kirlienum.Buyuk);
                mumdai.Add(enKucukEleman);
                ciktiDurum = new List<Enum>();

                ciktiDurum.Add(Cikti_DonusHizienum.Guclu);
                ciktiDurum.Add(Cikti_Sureenum.Uzun);
                ciktiDurum.Add(Cikti_Deterjanenum.CokFazla);
                TumciktiDurum.Add(ciktiDurum);
            }


        }

       

        public void Sonuc()
        {
            List<double> son = new List<double>();
            donusHizi = new Dictionary<Enum, List<double>>();
            sure = new Dictionary<Enum, List<double>>();
            deterjan = new Dictionary<Enum, List<double>>();
            //<<<----- Durulaştırma------->>>
            // Cıktılardan ayni kurallar birleştirilir
            for (int i = 0; i < TumciktiDurum.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        if (donusHizi.ContainsKey(TumciktiDurum[i][j]))
                            donusHizi[TumciktiDurum[i][j]].Add(mumdai[i]);
                        else
                        {
                            bucket = new List<double>();
                            bucket.Add(mumdai[i]);
                            donusHizi.Add(TumciktiDurum[i][j], bucket);
                        }
                    }
                    if (j == 1)
                    {
                        // varsa
                        if (sure.ContainsKey(TumciktiDurum[i][j]))
                            sure[TumciktiDurum[i][j]].Add(mumdai[i]);
                        else
                        {
                            bucket = new List<double>();
                            bucket.Add(mumdai[i]);
                            sure.Add(TumciktiDurum[i][j], bucket);
                        }
                    }
                    if (j == 2)
                    {
                        if (deterjan.ContainsKey(TumciktiDurum[i][j]))
                            deterjan[TumciktiDurum[i][j]].Add(mumdai[i]);
                        else
                        {
                            bucket = new List<double>();
                            bucket.Add(mumdai[i]);
                            deterjan.Add(TumciktiDurum[i][j], bucket);
                        }
                    }
                }
            }
            
           //kural mandaniden en büyüğü hayatta kalır
            donusHizi = DictionaryMax(donusHizi);
            sure = DictionaryMax(sure);
            deterjan = DictionaryMax(deterjan);
            
            // ağırlıklı ortalama yöntemi
            DonusHizi = Ortalama(donusHizi);
            Sure = Ortalama(sure);
            Deterjan = Ortalama(deterjan);
           
        }


        //<------------------ Kurallar ----------------------->>

        //Hazır kod en büyügünü bulmak için
        Dictionary<Enum, List<double>> swapDict;
        private Dictionary<Enum, List<double>> DictionaryMax(Dictionary<Enum, List<double>> x)
        {
            swapDict = new Dictionary<Enum, List<double>>();
            // maxı bul
            foreach (var item in x)
            {
                if (item.Value.Count > 1)
                {
                    double min = item.Value[0];
                    foreach (var item2 in item.Value)
                    {
                        if (min < item2)
                            min = item2;
                    }
                    bucket = new List<double>();
                    bucket.Add(min);
                    swapDict.Add(item.Key, bucket);
                }
                else
                    swapDict.Add(item.Key, item.Value);
            }
            return swapDict;
        }

        private double Ortalama(Dictionary<Enum, List<double>> girisDegerleri)
        {
            double sonucPay = 0;
            double sonucPayda = 0;
            double ortaNokta;
            // kural sayısı kadar dön
            foreach (var item in girisDegerleri)
            {
                ortaNokta = OrtaNoktasiniBul(item.Key);
                sonucPay += Convert.ToDouble(item.Value[0]) * ortaNokta;
            }
            foreach (var item in girisDegerleri)
            {
                sonucPayda += Convert.ToDouble(item.Value[0]);
            }

            return sonucPay / sonucPayda;
        }

        public double Kucuk(Enum e1, Enum e2, Enum e3)
        {
            // üyelik dereceleri y değerleri
            double uyelikHassas = FyHesapla(e1);
            double uyelikMiktar = FyHesapla(e2);
            double uyelikKirli = FyHesapla(e3);


            double enKucuk = uyelikHassas;
            if (enKucuk > uyelikKirli)
                enKucuk = uyelikKirli;

            if (enKucuk > uyelikMiktar)
                enKucuk = uyelikMiktar;

            return enKucuk;

        }
    }
}
