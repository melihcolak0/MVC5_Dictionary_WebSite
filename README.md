# :gem:MVC5 ile Admin Panelli Dinamik Sözlük Sitesi
Bu repository, Murat Yücedağ'ın Mvc Proje Kampı kursunu içermektedir. Bu eğitimde bana yol gösteren Murat Yücedağ'a çok teşekkür ederim.

MVC5 ve ASP.NET Web Application (.NET Framework) kullanarak dinamik bir Sözlük sitesi oluşturdum Bu projede, tamamen N-Tier Architecture (N Katmanlı Mimari) tabanlı bir tasarım kullandım. Aynı şekilde SOLID prensiplerine ve dosya yapısına uygun bir şekilde projeyi tamamlamaya çalıştım. Bu şekilde kod tekrarını azaltmaya çalıştım. Entity Framework - CodeFirst yaklaşımı ile veri tabanı bağlantılarını oluşturdum.

N-Tier Architecture (N Katmanlı Mimari), yazılım uygulamalarını birden fazla bağımsız katmana (layer) bölerek geliştirmeye olanak tanıyan bir yazılım mimari modelidir.
Bu mimari, uygulamanın farklı katmanlarını belirleyerek modülerlik, ölçeklenebilirlik ve bakım kolaylığı sağlar.

Genel anlamda 4 katman üzerinde proejyi oluşturdum. Presentation Layer (Sunum Katmanı), kullanıcının doğrudan etkileşimde bulunduğu katmandır. Burada HTML5, CSS3, Bootstrap ve JavaScript kullanarak web sayfaları oluşturdum. Business Logic Layer (İş Mantığı Katmanı), uygulamanın kurallarını ve iş mantığını barındırır. Service ve Manager olarak tüm entity'lerin metotlarını oluşturup kontrollerini yaptım. Data Access Layer (Veri Erişim Katmanı), veritabanı ile etkileşimi sağlar. Burada veri tabanındaki verileri gereken şekilde kulandım. Entity Layer (Varlık Katmanı), verileri saklayan katmandır. Burası CodeFirst yaklaşımının başlangıcıdır. Veri tabanındaki tablolar ve sütunlar yerine bu katmanda sınıflar ve property'ler kullandım.

Projede genel anlamda 4 farklı bölüm bulunmaktadır;

1- Admin Paneli: Adminler'in giriş yapıp kategoriler, başlıklar, yazılar, yazarlar, mesajlar, yetkilendirmeler gibi alanlar ile ilgili CRUD (Create, Read, Update, Delete) işlemlerinin yapıldığı bölümdür.
2- Yazar Paneli: Yazarlar'ın sisteme girip yeni başlık açma, başlık altına yazı yazma, mesajlaşma ve kendi profilleri için düzenleme yapma gibi işlemlerin yapıldığı bölümdür.
3- Sözlük Sayfası: Burada her kullanıcının hiçbir Login işlemi yapmadan görebildiği kısımdır. Bu bölümde başlıklara göre ayrılmış, siteye yazılan tüm içerikler görülebilir.
4- Ana Sayfa: Burada da benim ve bu proje ile ilgili bilgiler yer alıyor. Yine tüm kullanıcılar herhangi bir Login işlem iyapmdan bu sayfayı görüntüleyebilir.

## :arrow_forward: Admin Paneli
Bu eğitimde ilk olarak admin panelini oluşturdum. Admin tüm tablolar ile ilgili CRUD işlemlerini yapabildiği için temeli bu bölüm ile atmak istedim. Bu sayfa Kategoriler, Başlıklar, Yazılar, Yazarlar, Grafikler, Hakkımızda, Raporlar, İletişim ve Mesajlar, Yetkilendirmeler, Hata Sayfaları, Yetenek Kartım, Siteye Git ve Çıkış Yap bölümlerinden oluşmaktadır.

### :triangular_flag_on_post: Kategoriler Bölümü
Kategoriler bölümünde Tbl_Categories tablosundaki verileri listeledim. Listeleme yanında Yeni Kategori Ekleme, Silme, Güncelleme ve Başlıkları Görüntüleme işlemlerini de bu bölümden yapabiliriz. Silme kısmı çoğu projede pasif yapma olarak kullanılır. İlişkili tablolar kullanıldığından dolayı tablolalarda silme işlemi yerine durum sütunu eklenebilir. Sil butonuna tıklandığında kategori durumu pasif hale getirilir ve listede görünmez. Güncelle butonuna tıklandğında kategori güncelleme sayfası açılır ve buraya hangi veri için Güncelle butonuna tıklandıysa o verinin bilgileri taşınır. Admin gerekli değişikliği yaptıktan sonra Güncelle butonuna basar ve veri veri tabanı üzerinde güncellenmiş olur. Ekleme işleminde ise Yeni Kategori Ekle butonuna basıldığında kategori ekleme sayfası açılır. Buradaki istenen bilgiler girilerek yeni bir kategori oluşturulabilir.
<div align="center">
  <img src="" alt="image alt">
</div>

### :triangular_flag_on_post: Deneyimlerim Bölümü
Deneyimlerim bölümünde bugüne kadar yaptığım stajlarımın bilgileri yer almaktadır. Staj yaptığım firma, pozisyonum, staj yaptığım tarih ve staj süresince bulunduğum faaliyetler gibi bilgiler bu sayfada yer almaktadır.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/cvExperiences.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Eğitim Hayatım Bölümü
Eğitim hayatım bölümünde bugüne kadarki aldığım lisans ve ön lisans eğitimlerimin bilgileri yer almaktadır. Üniversitem, fakültem, bölümüm, başlangıç ve bitiş tarihleri ve GANO bilgilerim yer almaktadır.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/cvEducations.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Yeteneklerim Bölümü
Yeteneklerim bölümünde eğitim hayatım boyunca öğrenmiş olduğum ve mezun olduktan sonra almış olduğum eğitimler sonucunda kazandığım yetenekleri sergiledim.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/cvAbilities.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: İlgi Alanlarım Bölümü
İlgi alanlarım bölümünde hayatım boyunca ve özellikle bu zamanlarda ilgi duyduğum konular ve alanlar ile ilgili kısa bir yazı yazdım.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/cvInterests.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Sertifikalarım Bölümü
Sertifikalarım bölümünde eğitim hayatım boyunca ve mezun olduktan sonra almış olduğum eğitimler sonucunda aldığım sertifikalarım yer almaktadır.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/cvCertificates.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: İletişim Bölümü
Sitemi ziyaret eden kişilerin bana iletmek istediği herhangi bir konu varsa iletişim bölümünde bulunan araçlar ile bana ulaşmaları mümkündür. Burada gönderilen mesajlar veri tabanında tutulmaktadır. Ayrıca admin panelinden de görüntülenebilmektedir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/cvContact.jpg" alt="image alt">
</div>

## :arrow_forward: Admin Paneli Sayfası
Admin panelinde CV sayfasında görüntülenen bölümleri düzenleyebiliriz. Yeni bölüm ekleme, bölüm güncelleme ve bölüm silme gibi işlemleri admin panelinden yapabiliriz. Bu sayfada Hakkımda, Deneyimlerim, Eğitim Hayatım, Yeteneklerim, İlgi Alanlarım, Sertifikalarım, İletişim, Sosyal Medya Ayarlar ve Çıkış bölümleri ile ilgili işlemler yer almaktadır.

### :triangular_flag_on_post: LogIn Bölümü
LogIn bölümünde kullanıcı Kullanıcı Adı'nı ve Şifre'sini girerek sisteme giriş yapabilecektir. Kimse giriş yapmadan Admin Paneli sayfasındaki hiçbir alana doğrudan ulaşamaz. Giriş yapmadan yalnızca CV Sitesi ve LogIn sayfalarına ulaşım sağlanabilir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/adminLogin.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Hakkımda Bölümü
Hakkımda bölümünde veri tabanı üzerindeki Tbl_AboutMe tablosundaki verileri görüntülemekteyiz. Burada textBox araçlarında yapılan değişiklikler sonucu "Güncelle" butonuna tıklanırsa veriler veri tabanı üzerinde güncellenecektir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_CV_WebSite/blob/d9a0fc326f649a43b3747e00457fa7827811f216/ss/adminAboutMe.jpg" alt="image alt">
</div>
