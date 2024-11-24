# 🌎 Tur Projesi

#### Bu proje C# Eğitim Kampı kapsamında gerçekleştirdiğimiz bir uygulamadır. Proje, Entity Framework metotları kullanarak veritabanı işlemleri gerçekleştiren bir uygulama sunmaktadır. Uygulama, seyahat acentası ile ilgili verilere dair istatistikleri kullanıcıya sunmayı amaçlayan bir Windows Forms uygulamasıdır. Veritabanındaki mevcut veriler üzerinde çeşitli hesaplamalar ve istatistiksel sorgular yapılmıştır. Proje görseli aşağıda yer almaktadır.

## 📍 Temel Özellikler:
+ **Konum Sayısı:** Veritabanındaki tüm konumların sayısını gösterir.
+ **Toplam Kapasite:** Tüm konumların kapasite toplamını hesaplar.
+ **Rehber Sayısı:** Seyahat acentasında yer alan rehber sayısını gösterir.
+ **Ortalama Kapasite:** Tüm konumların ortalama kapasitesini hesaplar.
+ **Ortalama Tur Fiyatı:** Tüm konumların ortalama tur fiyatını hesaplar.
+ **Son Eklenen Ülke Adı:** Veritabanındaki en son eklenen ülkenin adını görüntüler.
+ **Edinburgh Kapasitesi:** Edinburgh şehrindeki konumların kapasitesini gösterir.
+ **İtalya Ortalaması:** İtalya'daki konumların kapasite ortalamasını gösterir.
+ **Salerno Rehber Adı:** Salerno şehrindeki rehberin adını ve soyadını gösterir.
+ **Maksimum Kapasite:** En yüksek kapasiteye sahip olan şehri gösterir.
+ **Maksimum Fiyat:** En yüksek tura sahip şehri gösterir.
+ **Betül Avcı'nın Yerel Konum Sayısı:** "Betül Avcı" adlı rehberin sorumlu olduğu konum sayısını gösterir.

## 📍 Projede Kullanılan Entity Framework Metotları

Projede, Entity Framework'ün sağladığı güçlü LINQ sorguları kullanılarak veritabanından veri çekilmiştir. Aşağıda kullanılan başlıca EF metotları ve açıklamaları yer almaktadır:

+ **db.Location.Count():** Veritabanındaki Location tablosundaki kayıtların sayısını alır.
+ **db.Location.Sum(x => x.Capacity):** Tüm konumların Capacity (kapasite) değerlerinin toplamını alır.
+ **db.Location.Average(x => x.Capacity):** Tüm konumların Capacity (kapasite) değerlerinin ortalamasını hesaplar.
+ **db.Location.Average(x => x.Price).Value:** Tüm konumların Price (fiyat) ortalamasını hesaplar.
+ **db.Location.Max(x => x.LocationId):** LocationId değerinin en yüksek olduğu konumu bulur.
+ **db.Location.Where(x => x.City == "Edinburgh"):** Belirli bir şehirdeki konumları filtreler.
+ **db.Guide.Where(x => x.GuideName == "Betül" && x.GuideSurname == "Avcı"):** Belirli bir rehberin bilgilerini alır.

**Bu metotlar, veritabanındaki Location ve Guide tablolarındaki mevcut verilere dayalı çeşitli istatistiksel hesaplamalar yapmaktadır.**



![Ekran görüntüsü 2024-11-24 164027](https://github.com/user-attachments/assets/9a223969-1fa1-4b5c-be36-a7790a4e2208)
