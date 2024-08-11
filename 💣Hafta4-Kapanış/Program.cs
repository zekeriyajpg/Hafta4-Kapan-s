using _Hafta4_Kapanış;

bool devam = true;

while (devam)
{
    Console.WriteLine("Telefon üretmek için 1 , bilgisayar üretmek için 2 ye basın");
    int secim = int.Parse(Console.ReadLine());

    if (secim == 1)
    {
        Telefon telefon = new Telefon();
        Console.Write("seri no : ");
        telefon.SeriNumarasi = Console.ReadLine();
        Console.Write("ad : ");
        telefon.Ad = Console.ReadLine();
        Console.Write("açıklama : ");
        telefon.Aciklama = Console.ReadLine();
        Console.Write("İşletim Sistemi: ");
        telefon.IsletimSistemi = Console.ReadLine();
        Console.Write("TR Lisanslı mı? (Evet/Hayır): ");
        telefon.TrLisansi = Console.ReadLine().ToLower() == "evet";
        Console.WriteLine("\nÜrün başarıyla üretildi:");
        telefon.BilgileriYazdir();
        telefon.Urunadigetir();
    }
    else if (secim == 2)
    {
        Bilgisayar bilgisayar = new Bilgisayar();
        Console.Write("Seri Numarası: ");
        bilgisayar.SeriNumarasi = Console.ReadLine();

        Console.Write("Ad: ");
        bilgisayar.Ad = Console.ReadLine();

        Console.Write("Açıklama: ");
        bilgisayar.Aciklama = Console.ReadLine();

        Console.Write("İşletim Sistemi: ");
        bilgisayar.IsletimSistemi = Console.ReadLine();

        Console.Write("USB Giriş Sayısı (2/4): ");
        bilgisayar.usbSayisi = int.Parse(Console.ReadLine());

        Console.Write("Bluetooth Var mı? (Evet/Hayır): ");
        bilgisayar.Bluetooth = Console.ReadLine().ToLower() == "evet";

        Console.WriteLine("\nÜrün başarıyla üretildi:");
        bilgisayar.BilgileriYazdir();
        bilgisayar.Urunadigetir();
    }
    Console.WriteLine("\nBaşka bir ürün üretmek ister misiniz? (Evet/Hayır):");
    devam = Console.ReadLine().ToLower() == "evet";
}
Console.WriteLine("İyi günler!");