using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Hafta4_Kapanış
{
    public abstract class BaseMakine
    {
        // Üretim tarihi özelliği, nesne oluşturulduğunda otomatik olarak atanacak.
        public DateTime UretimTarihi { get; set; }

        // Seri numarası, ad, açıklama ve işletim sistemi gibi özellikler tanımlanıyor.
        public string SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        // Urunadigetir isimli soyut (abstract) bir metot tanımlanıyor.
        public abstract void Urunadigetir();

        // BaseMakine constructor'ı, ÜretimTarihi'ni nesne oluşturulduğunda şimdiki zaman olarak atıyor.
        public BaseMakine()
        {
            UretimTarihi = DateTime.Now;
        }

        // BilgileriYazdir metodu, üretim tarihi ve diğer özellikleri konsola yazdırıyor.
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
            Console.WriteLine($"Seri Numarası: {SeriNumarasi}");
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Açıklama: {Aciklama}");
            Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
        }
    }
}
