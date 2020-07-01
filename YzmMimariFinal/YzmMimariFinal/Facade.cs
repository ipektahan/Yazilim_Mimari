using System;
using System.Collections.Generic;
using System.Text;

namespace YzmMimariFinal
{
        public class Facade
    {
        private HastamizinAdiSoyadi _hastamizinadisoyadi;
        private Yatan_Hastane _yatanhastane;
        private Hastanin_Durumu _hastanindurum;
        private Yatis_Ned _yatisned;
        public Facade()
        {
            _hastamizinadisoyadi = new HastamizinAdiSoyadi();
            _yatanhastane = new Yatan_Hastane();
            _hastanindurum = new Hastanin_Durumu();
            _yatisned = new Yatis_Ned(); 
        }
        public void hasta_adi_Soyadi (Hasta TCNO, string Giris)
        {
            _hastamizinadisoyadi.HastaAdiSoyadi_Bilgisi(TCNO, Giris);
        }
        public void yatann_hastane(Hasta Hastaneadi, string Giris)
        {
            _yatanhastane.HastaneAdi_Bilgisi(Hastaneadi, Giris);
        }
        public void hasta_dur(Hasta Durum_Bil, string Giris)
        {
            _hastanindurum.HastaninDurumBilgisi(Durum_Bil, Giris);
        }
        public void yatis_nedeni(Hasta Yts_Bil, string giris)
        {
            _yatisned.YatisNedeni_Bilgisi(Yts_Bil,giris);
        }
    }
    
}
