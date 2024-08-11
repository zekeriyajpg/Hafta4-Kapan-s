using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Hafta4_Kapanış
{
    public class Bilgisayar : BaseMakine
    {
        // USB giriş sayısı için private bir alan tanımlanır.
        private int _usbSayisi;

        // usbSayisi özelliği, encapsulation kullanılarak kontrol edilir.
        public int usbSayisi
        {
            get { return _usbSayisi; }
            set
            {
                // USB giriş sayısı 2 veya 4 olabilir; aksi durumda -1 atanır.
                if (value == 2 || value == 4)
                    _usbSayisi = value;
                else
                {
                    Console.WriteLine("Geçersiz USB giriş sayısı, otomatik olarak -1 olarak atandı.");
                    _usbSayisi = -1;
                }
            }
        }

        // Bilgisayarın Bluetooth özelliğini belirten bir özellik.
        public bool Bluetooth { get; set; }

        // Urunadigetir metodu, Bilgisayar sınıfına özel olarak ezilir (override edilir).
        public override void Urunadigetir()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
        }

        // BilgileriYazdir metodu, BaseMakine'deki metodu ezerek (override ederek)
        // hem temel bilgileri hem de USB sayısı ve Bluetooth bilgilerini yazdırır.
        public override void BilgileriYazdir()
        {
            // BaseMakine'deki BilgileriYazdir metodunu çağırarak temel bilgileri yazdırır.
            base.BilgileriYazdir();

            // USB giriş sayısını yazdırır.
            Console.WriteLine($"USB Giriş Sayısı: {_usbSayisi}");

            // Bluetooth var olup olmadığını yazdırır.
            Console.WriteLine($"Bluetooth Var mı: {(Bluetooth ? "Evet" : "Hayır")}");
        }
    }
}
