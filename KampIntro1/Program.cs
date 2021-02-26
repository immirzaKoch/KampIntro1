using System;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Urun urun1 = new Urun();
            urun1.urunIsmi = "Cin";
            urun1.urunFiyati = "2 TL";
            urun1.urunMiktari = 5;

            Urun urun2 = new Urun();
            urun2.urunIsmi = "Ac Bitir";
            urun2.urunFiyati = "3.5 TL";
            urun2.urunMiktari = 8;

            Urun urun3 = new Urun();
            urun3.urunIsmi = "Tutuku";
            urun3.urunFiyati = "4 TL";
            urun3.urunMiktari = 25;


           Urun[] urunler = new Urun[] {urun1,urun2,urun3 };

            foreach (var item in urunler)
            {
                Console.WriteLine("Urun Ismi : " + item.urunIsmi + "\nUrun Fiyati : " + item.urunFiyati+ "\nUrun Miktari : " + item.urunMiktari+"\n");
            }
        }
    }
}
class Urun
{
    public string urunIsmi{ get; set; }
    public string urunFiyati { get; set; }
    public int urunMiktari{ get; set; }
}
