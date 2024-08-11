using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Hafta4_Kapanış
{
    public class Telefon : BaseMakine
    {
        // Telefonun TR lisanslı olup olmadığını belirten bir özellik.
        public bool TrLisansi { get; set; }

        // Urunadigetir metodu, Telefon sınıfına özel olarak ezilir (override edilir).
        public override void Urunadigetir()
        {
            Console.WriteLine("Telefonunuzun adı : " + Ad);
        }

        // BilgileriYazdir metodu, BaseMakine'deki metodu ezerek (override ederek) 
        // hem temel bilgileri hem de TR lisansı bilgilerini yazdırır.
        public override void BilgileriYazdir()
        {
            // BaseMakine'deki BilgileriYazdir metodunu çağırarak temel bilgileri yazdırır.
            base.BilgileriYazdir();

            // Ardından, TR lisansı bilgisi yazdırılır.
            Console.WriteLine($"TR Lisanslı mı: {(TrLisansi ? "Evet" : "Hayır")}");
        }
    }
}
