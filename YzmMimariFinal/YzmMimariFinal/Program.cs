using System;

namespace YzmMimariFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            Hasta hasta1 = new Hasta() { Hasta_AdSoyad = "İpek Tahan", HastaTCN = "123456789", Yattigi_Hastane = "Turgutlu Devlet Hastanesi", Yatis_nedeni = "COVİD19", Hasta_Durumu = "Kritik" };

            facade.hasta_adi_Soyadi(hasta1, hasta1.Hasta_AdSoyad);
            facade.yatann_hastane(hasta1, hasta1.Yattigi_Hastane);
            facade.yatis_nedeni(hasta1, hasta1.Yatis_nedeni);
            facade.hasta_dur(hasta1, hasta1.Hasta_Durumu);

            Console.ReadLine();
        }
    }
}
