using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Galeri galeri = new Galeri();

            while (true)
            {

                IslemSec();
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Write("Plaka: ");
                        string _plaka = Console.ReadLine();
                        Console.Write("Marka: ");
                        string _marka = Console.ReadLine();
                        Console.Write("Model: ");
                        string _model = Console.ReadLine();
                        Console.Write("Yıl: ");
                        int _yil = int.Parse(Console.ReadLine());
                        Console.Write("Fiyat: ");
                        double _fiyat = double.Parse(Console.ReadLine());

                        Araba araba = new Araba(_plaka, _marka, _model, _yil, _fiyat);
                        galeri.ArabaEkle(araba);
                        break;
                    
                    case "2":
                        Console.WriteLine("Silinecek Arabanın Plakasını Giriniz: ");
                        string silinecekAraba = Console.ReadLine();
                        galeri.ArabaSil(silinecekAraba);
                        break;
                    
                    case "3":
                        galeri.Listele();
                        break;
                    
                    case "4":
                        Console.WriteLine("Programdan Çıkılıyor");
                        break;
                    
                    default:
                        Console.WriteLine("Geçersiz seçim... lütfen tekrar deneyin");
                        break;
                }
            }



        }

        static void IslemSec()
        {
            Console.WriteLine("\nGaleri Otomasyonu");
            Console.WriteLine("1. Araba Ekle");
            Console.WriteLine("2. Araba Sil");
            Console.WriteLine("3. Arabaları Listele");
            Console.WriteLine("4. Çıkış");
            Console.Write("Seçiminizi yapın: ");
        }
    }

}
