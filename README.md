# 💣Hafta4-Kapanış
## Teknoloji Mağazası Uygulaması

Bu proje, bir teknoloji mağazasında telefon ve bilgisayar ürünlerinin kaydedilmesi ve bilgilerinin yazdırılmasını sağlayan basit bir konsol uygulamasıdır. Uygulama, OOP (Nesne Yönelimli Programlama) prensiplerine dayanarak `BaseMakine` adında bir temel sınıf ve bu sınıftan türetilen `Telefon` ve `Bilgisayar` sınıflarını kullanır. Uygulama, polymorphism, encapsulation, inheritance ve abstraction gibi OOP kavramlarını barındırmaktadır.

## Uygulamanın Özellikleri

- **Telefon Sınıfı:**
  - Üretim tarihi, seri numarası, ad, açıklama, işletim sistemi, TR lisansı olup olmadığı bilgileri ile birlikte oluşturulur.
  - Ürün adı ve tüm bilgiler konsola yazdırılır.

- **Bilgisayar Sınıfı:**
  - Üretim tarihi, seri numarası, ad, açıklama, işletim sistemi, USB giriş sayısı, Bluetooth olup olmadığı bilgileri ile birlikte oluşturulur.
  - USB giriş sayısı 2 veya 4 olabilir; aksi durumda otomatik olarak -1 atanır.
  - Ürün adı ve tüm bilgiler konsola yazdırılır.

## Program Akışı

1. Kullanıcı, telefon üretmek için `1`, bilgisayar üretmek için `2` tuşuna basar.
2. Kullanıcının seçimine göre ilgili sınıftan bir nesne oluşturulur ve gerekli bilgileri kullanıcıdan alınır.
3. Ürün başarıyla üretildiğinde, tüm bilgileri ve ürün adı konsola yazdırılır.
4. Kullanıcıya başka bir ürün üretmek isteyip istemediği sorulur. 
   - **Evet** derse program başa döner ve yeni bir ürün üretimi yapılır.
   - **Hayır** derse program "İyi günler!" mesajı ile sonlandırılır.
