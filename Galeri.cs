using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GaleriOtomasyonu
{
    public class Araba
    {
        public string plaka;
        public string marka;
        public string model;
        public int yil;
        public double fiyat;


        public Araba(string _plaka, string _marka, string _model, int _yil, double _fiyat)
        {
            plaka = _plaka;
            marka = _marka;
            model = _model;
            yil = _yil;
            fiyat = _fiyat;
        }

        public void BilgiYazdir()
        {
            Console.WriteLine("Plaka: " + plaka);
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Yıl: " + yil);
            Console.WriteLine("Fiyat: " + fiyat);
        }
    }

    public class Galeri
    {
        public List<Araba> arabalar = new List<Araba>();

        public void ArabaEkle(Araba araba)
        {
            arabalar.Add(araba);
            Console.WriteLine($"Araba Eklendi: {araba.plaka}");
        }

        public void ArabaSil(string plaka)
        {
            Araba silinecekAraba = arabalar.Find(a => a.plaka == plaka);
            if (silinecekAraba != null)
            {
                arabalar.Remove(silinecekAraba);
                Console.WriteLine($"Araba Silindi: {plaka}");
            }

            else
            {
                Console.WriteLine($"Plaka {plaka} ile eşleşen araba bulunamadı.");
            }
        }

        public void Listele()
        {
            Console.WriteLine("\n Galeri Listesi");
            if (arabalar.Count == 0)
            {
                Console.WriteLine("Galeride Araç Yok.");
                return;
            }

            foreach (var araba in arabalar)
            {
                araba.BilgiYazdir();
            }
        }
    }

}
    
