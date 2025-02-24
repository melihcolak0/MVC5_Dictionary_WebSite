# :gem:MVC5 ile Admin Panelli Dinamik Sözlük Sitesi
Bu repository, Murat Yücedağ'ın Mvc Proje Kampı kursunu içermektedir. Bu eğitimde bana yol gösteren Murat Yücedağ'a çok teşekkür ederim.

MVC5 ve ASP.NET Web Application (.NET Framework) kullanarak dinamik bir Sözlük sitesi oluşturdum Bu projede, tamamen N-Tier Architecture (N Katmanlı Mimari) tabanlı bir tasarım kullandım. Aynı şekilde SOLID prensiplerine ve dosya yapısına uygun bir şekilde projeyi tamamlamaya çalıştım. Bu şekilde kod tekrarını azaltmaya çalıştım. Entity Framework - CodeFirst yaklaşımı ile veri tabanı bağlantılarını oluşturdum.

N-Tier Architecture (N Katmanlı Mimari), yazılım uygulamalarını birden fazla bağımsız katmana (layer) bölerek geliştirmeye olanak tanıyan bir yazılım mimari modelidir.
Bu mimari, uygulamanın farklı katmanlarını belirleyerek modülerlik, ölçeklenebilirlik ve bakım kolaylığı sağlar.

Genel anlamda 4 katman üzerinde projeyi oluşturdum. Presentation Layer (Sunum Katmanı), kullanıcının doğrudan etkileşimde bulunduğu katmandır. Burada HTML5, CSS3, Bootstrap ve JavaScript kullanarak web sayfaları oluşturdum. Business Logic Layer (İş Mantığı Katmanı), uygulamanın kurallarını ve iş mantığını barındırır. Service ve Manager olarak tüm entity'lerin metotlarını oluşturup kontrollerini yaptım. Data Access Layer (Veri Erişim Katmanı), veritabanı ile etkileşimi sağlar. Burada veri tabanındaki verileri gereken şekilde kullandım. Entity Layer (Varlık Katmanı), verileri saklayan katmandır. Burası CodeFirst yaklaşımının başlangıcıdır. Veri tabanındaki tablolar ve sütunlar yerine bu katmanda sınıflar ve property'ler kullandım.

Bu projede değiştirilmesi gereken bazı noktalar olabilir fakat burada asıl amaç Back-end Development anlamında MVC5 ile admin panelli bir sistem kurmaktır. Front-end anlamında düzeltmeler yapılabilir.

Projede genel anlamda 4 farklı bölüm bulunmaktadır;

1- Admin Paneli: Adminler'in giriş yapıp kategoriler, başlıklar, yazılar, yazarlar, mesajlar, yetkilendirmeler gibi alanlar ile ilgili CRUD (Create, Read, Update, Delete) işlemlerinin yaptığı bölümdür.  
2- Yazar Paneli: Yazarlar'ın sisteme girip yeni başlık açma, başlık altına yazı yazma, mesajlaşma ve kendi profilleri için düzenleme yapma gibi işlemlerini yaptığı bölümdür.  
3- Sözlük Sayfası: Bu sayfa her kullanıcının hiçbir Login işlemi yapmadan görebildiği kısımdır. Bu bölümde başlıklara göre ayrılmış, siteye yazılan tüm içerikler görülebilir.  
4- Ana Sayfa: Burada da Melih Çolak ve bu proje ile ilgili bilgiler yer alıyor. Yine tüm kullanıcılar herhangi bir Login işlemi yapmdan bu sayfayı görüntüleyebilir.

## :arrow_forward: Admin Paneli
Bu eğitimde ilk olarak admin panelini oluşturdum. Admin tüm tablolar ile ilgili CRUD işlemlerini yapabildiği için temeli bu bölüm ile atmak istedim. Bu sayfa LogIn, Kategoriler, Başlıklar, Yazılar, Yazarlar, Grafikler, Hakkımızda, Raporlar, İletişim ve Mesajlar, Yetkilendirmeler, Hata Sayfaları, Yetenek Kartım, Siteye Git ve Çıkış Yap bölümlerinden oluşmaktadır.

### :triangular_flag_on_post: LogIn Bölümü
LogIn bölümünde Tbl_Admins tablosundaki adminler mail ve şifreleri ile birlikte giriş yapabilirler. Paneldeki veriler admin değişkliğine göre uyum sağlamaktadır. Bunun için Session Yönetimi kullandım. 
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/adminLogin.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Kategoriler Bölümü
Kategoriler bölümünde Tbl_Categories tablosundaki verileri listeledim. Listeleme yanında Yeni Kategori Ekleme, Silme, Güncelleme ve Başlıkları Görüntüleme işlemlerini de bu bölümden yapabiliriz. Silme kısmı çoğu projede pasif yapma olarak kullanılır. İlişkili tablolar kullanıldığından dolayı tablolalarda silme işlemi yerine durum sütunu eklenebilir. Sil butonuna tıklandığında kategori durumu pasif hale getirilir ve listede görünmez. Güncelle butonuna tıklandğında kategori güncelleme sayfası açılır ve buraya hangi veri için Güncelle butonuna tıklandıysa o verinin bilgileri taşınır. Admin gerekli değişikliği yaptıktan sonra Güncelle butonuna basar ve veri veri tabanı üzerinde güncellenmiş olur. Ekleme işleminde ise Yeni Kategori Ekle butonuna basıldığında kategori ekleme sayfası açılır. Buradaki istenen bilgiler girilerek yeni bir kategori oluşturulabilir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/adminCategories.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/adminAddCategory.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/adminUpdateCategory.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Başlıklar Bölümü
Başlıklar bölümünde Tbl_Headings tablosundaki verileri listeledim. Listeleme yanında Yeni Başlık Ekleme, Silme, Düzenleme ve Yazıları Görüntüleme işlemlerini bu bölümden yapabiliriz. Sil butonuna tıklandığında başlık durumu pasif hale getirilir ve listede görünmez. Güncelle butonuna tıklandğında başlık güncelleme sayfası açılır ve buraya hangi veri için Güncelle butonuna tıklandıysa o verinin bilgileri taşınır. Admin gerekli değişikliği yaptıktan sonra Güncelle butonuna basar ve veri veri tabanı üzerinde güncellenmiş olur. Ekleme işleminde ise Yeni Başlık Ekle butonuna basıldığında başlık ekleme sayfası açılır. Buradaki istenen bilgiler girilerek yeni bir başlık oluşturulabilir. Yazılar butonuna tıklandığında da tıklanan başlık altında oluşturulmuş yazılar listelenmektedir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/adminHeadings.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Yazılar Bölümü
Yazılar bölümünde Tbl_Contents tablosundaki verileri listeledim. Listeleme yanında Arama işlemini de bu bölümden yapabiliriz. Ara butonuna basılığında arama kutucuğuna girilen değerin içinde geçtiği tüm yazılar listelenir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/adminContents.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Yazarlar Bölümü
Yazarlar bölümünde Tbl_Writers tablosundaki verileri listeledim. Listeleme yanında Yazar Bilgilerini Güncelleme ve Yazarın Oluşturmuş Olduğu Başlıkları Görüntüleme işlemlerini bu bölümden yapabiliriz. Profili Düzenle butonuna basıldığında yazar güncelleme sayfası açılır ve buraya hangi veri için Profili Düzenle butonuna tıklandıysa o verinin bilgileri taşınır. Admin gerekli değişikliği yaptıktan sonra Güncelle butonuna basar ve veri veri tabanı üzerinde güncellenmiş olur. Yazarın Başlıkları butonuna basıldığında ise butonuna tıklanan yazarın oluşturmuş olduğu başlıklar listelenmiş bir şekilde görüntülenir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/adminWriters.jpg" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/adminUpdateWriter.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Grafikler Bölümü
Grafikler bölümünde statik olarak kategorilere göre başlık sayılarının raporlandığı bir PieChart oluşturdum. Chart olşutururken GoogleChart'dan faydalandım.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/adminChart.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Hakkımızda Bölümü
Hakkımızda bölümünde Tbl_Abouts tablosundaki verileri listeledim. Listeleme yanında Silme ve Güncelleme işlemlerini de bu bölümden yapabiliriz. Sil butonuna tıklandığında hakkımızda detay durumu pasif hale getirilir ve listede görünmez. Güncelle butonuna tıklandığında hakkımızda detay güncelleme sayfası açılır ve buraya hangi veri için Güncelle butonuna tıklandıysa o verinin bilgileri taşınır. Admin gerekli değişikliği yaptıktan sonra Güncelle butonuna basar ve veri veri tabanı üzerinde güncellenmiş olur. Ekleme işleminde ise Yeni Hakkımızda Bölümü Ekle butonuna basıldığında hakkımızda bölümü ekleme sayfası açılır. Buradaki istenen bilgiler girilerek yeni bir hakkımızda bölümü oluşturulabilir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/adminAbout.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Raporlar Bölümü
Raporlar bölümü proje bittiğinde oluşturulmuş tabloların verilerinin raporlarının alınacağı ve listeleneceği bölümdür. Bu bölümü yalnızca başlıklar bölümü için yani Tbl_Headings tablosundaki veriler için oluşturdum. Bu işlem tüm tablolar için gerçekleştirilebilir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/adminReports.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: İletişim ve Mesajlar Bölümü
İletişim ve Mesajlar bölümünde Tbl_Contacts ve Tbl_Messages tablolarındaki verileri listeledim. İletişim, Gelen Mesajlar, Gönderilen Mesajlar, Taslaklar, Çöp Kutusu ve Yeni Mesaj Oluşturma işlemlerini bu bölümden yapabiliriz. İletişim bölümü Ana Sayfa'daki iletişim bölümünden gönderilen mesajların listelendiği yerdir. Bu mesajları tüm adminler görebilir. Gelen ve Gönderilen Mesajlar bölümleri diğer yazarlar ve adminler arasındaki iletişimin sağlandığı bölümlerdir. Gelen Mesajlar bölümünde yazarlardan adminlere gönderilen mesajlar listelenirken, Gönderilen Mesajlar bölümünde ise adminlerin yazarlara göndermiş olduğu mesajlar listelenmektedir. Taslaklar bölümünde, oluşturulmuş fakat henüz gönderilmek istenmeyen mesajlar listelenir. Yeni Mesaj Oluşturma sayfasındaki Taslaklara Ekle butonuna basılırsa o an oluşturulan mesaj gönderilmez taslaklar listesine aktarılır. Çöp Kutusu, Gelen Mesajlar listesinde çöp kutusu ikonuna basılan verilerin listelendiği bölümdür. Yeni Mesaj Oluşturma bölümünde ise bir admin bir yazara mesaj gönderebilir. Ayrıca listelenen mesajların üzerine tıklandığı takdirde mesaj içeriği görüntülenmektedir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/adminMessages.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Yetkilendirmeler Bölümü
Yetkilendirmeler bölümünde Tbl_Admins tablosundaki verileri listeledim. Listeleme yanında Silme ve Güncelleme ve Ekleme işlemlerini de bu bölümden yapabiliriz. Sil butonuna tıklandığında adminin durumu pasif hale getirilir ve listede görünmez. Güncelle butonuna tıklandığında admin güncelleme sayfası açılır ve buraya hangi veri için Güncelle butonuna tıklandıysa o verinin bilgileri taşınır. Admin gerekli değişikliği yaptıktan sonra Güncelle butonuna basar ve veri veri tabanı üzerinde güncellenmiş olur. Ekleme işleminde ise Yeni Admin Tanımla butonuna basıldığında admin ekleme sayfası açılır. Buradaki istenen bilgiler girilerek yeni bir admin oluşturulabilir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/adminAuthentication.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Hata Sayfaları Bölümü
Hata Sayfaları bölümünde web sayfalarında alınabilecek hataları listeleyebiliriz. Ben burada yalnızca 404 hatası için bir tasarım oluşturdum. Bu işlem tüm hatalar için oluşturulabilir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/adminErrorPage.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Yetenk Kartım Bölümü
Yetenk Kartım bölümünde benimle ilgili bir yetenek kartı bulunmaktadır. Burada bazı yeteneklerim ve dereceleri bulunmaktadır.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/adminAbilityCard.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Siteye Git Bölümü
Siteye Git bölümü Ana Sayfa'ya yönlendirme yapar.

### :triangular_flag_on_post: Çıkış Yap Bölümü
Çıkış Yap bölümünde giriş yapmış olan adminin doğrulaması kaldırılarak çıkış yapmış hale getirilir.

## :arrow_forward: Yazar Paneli
Yazar panelinde siteye kayıtlı her yazar sisteme giriş yaparak sözlük işlemlerinde bulunabilir. Burada LogIn, Profilim, Başlıklarım, Tüm Başlıklar, Yazılarım, Mesajlar, Siteye Git ve Çıkış Yap bölümleri bulunmaktadır.

### :triangular_flag_on_post: LogIn Bölümü
LogIn bölümünde Tbl_Writers tablosundaki yazarlar mail ve şifreleri ile birlikte giriş yapabilirler. Paneldeki veriler yazar değişkliğine göre uyum sağlamaktadır. Bunun için Session Yönetimi kullandım.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/writerLogin.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Profilim Bölümü
Profilim bölümünde yazar, Tbl_Writers tablosunda kendisi ile ilgili bilgileri görüntüleyebilir ve güncelleme yapıp Değişiklikleri Uygula butonuna basarak verileri güncelleyebilir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/writerProfile.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Başlıklarım Bölümü
Başlıklarım bölümünde yazar, Tbl_Headings tablosunda kendi oluşturduğu başlıkları görüntüler. Aynı şekilde bu sayfada Silme, Düzenleme ve Yazıları Görüntüleme işlemleri yapılabilir. Sil butonuna tıklandığında başlığın durumu pasif hale getirilir ve listede görünmez. Güncelle butonuna tıklandığında başlık güncelleme sayfası açılır ve buraya hangi veri için Güncelle butonuna tıklandıysa o verinin bilgileri taşınır. Admin gerekli değişikliği yaptıktan sonra Güncelle butonuna basar ve veri veri tabanı üzerinde güncellenmiş olur. Ekleme işleminde ise Yeni Başlık Ekle butonuna basıldığında başlık ekleme sayfası açılır. Buradaki istenen bilgiler girilerek yeni bir başlık oluşturulabilir. Yazılar butonuna basıldığında ise yazarın oluşturduğu başlıkların altında yazılan yazılar listelenir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/writerMyHeadings.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Tüm Başlıklar Bölümü
Tüm Başlıklar bölümünde yazar, Tbl_Headings tablosunda oluşturulmuş tüm başlıkları görüntüler. Bu sayfada Başlıkları Sayfalama Kullanarak Listeleme, Yazıları Görüntüle ve Bu Başlığa Yazma işlemleri yapılabilir. Yazılar butonuna basıldığında başlık altına yazılmış yazılar listelenir. Başlığa Yaz butonuna basıldığında ise yeni bir yazı oluşturma sayfası açılır ve gerekli bilgiler girilerek seçilen başlığa yazı eklenir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/writerAllHeadings.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Yazılarım Bölümü
Yazılarım bölümünde yazar, Tbl_Contents tablosunda kendi oluşturduğu verileri görüntüler. Burada yalnızca listeleme işlemi yapılır. Giriş yapan yazara göre değişiklik gösterecektir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/writerMyContents.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Mesajlar Bölümü
Mesajlar bölümünde yazar, diğer yazarlar ve adminler ile mesajlaşabilir. Gelen Mesajlar bölümünde yazara gelen mesajlar, Gönderilen Mesajlar bölümünde yazarın gönderdiği mesajlar listelenir. Taslaklar bölümünde, oluşturulmuş fakat henüz gönderilmek istenmeyen mesajlar listelenir. Yeni Mesaj Oluşturma sayfasındaki Taslaklara Ekle butonuna basılırsa o an oluşturulan mesaj gönderilmez taslaklar listesine aktarılır. Çöp Kutusu, Gelen Mesajlar listesinde çöp kutusu ikonuna basılan verilerin listelendiği bölümdür. Yeni Mesaj Oluşturma bölümünde ise bir yazar bir admine veya yazara mesaj gönderebilir. Ayrıca listelenen mesajların üzerine tıklandığı takdirde mesaj içeriği görüntülenebilmektedir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/writerMessages.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Siteye Git Bölümü
Siteye Git bölümü Sözlük Sayfa'sına yönlendirme yapar.

### :triangular_flag_on_post: Çıkış Yap Bölümü
Çıkış Yap bölümünde giriş yapmış olan yazarın doğrulaması kaldırılarak çıkış yapmış hale getirilir.

## :arrow_forward: Sözlük Sayfası
Sözlük sayfasında her kullanıcı, herhangi bir sisteme giriş yapmadan sitede yazılan yazıları başlıklara ayrılmış şekilde okumak için bu sayfada gezinebilmektedir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/DictionaryPage.jpg" alt="image alt">
</div>

## :arrow_forward: Ana Sayfa
Ana Sayfa'da Melih Çolak ve bu proje hakkında bilgiler bulunmaktadır. Bu sayfayı da her kullanıcı herhangi bir sisteme giriş yapmadan görüntüleyebilir. Bu sayfada Ana Bölüm, Proje'nin Teknik Detayları, Projede Ne Yaptım?, Proje Görselleri, İstatistikler, Notlar, İletişim ve Footer bölümlerini görüntüleyebiliriz.

### :triangular_flag_on_post: Ana Bölüm
Ana bölümde Melih Çolak bilgileri ve resmi bulunmaktadır. Burada kendi resmimi kullanmadım. Doğru ve uygun bir fotoğraf eklenebilir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/homeMain.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Teknik Detaylar Bölümü
Teknik Detaylar bölümünde projede kullandığım bileşenleri ve oranlarını görüntüledim.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/homeTechnic.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Projede Ne Yaptım Bölümü
Projede Ne Yaptım bölümünde proje esnasındaki işlemleri anlattım.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/homeWhatDidIDo.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Görseller Bölümü
Görseller bölümünde proje ekran görüntülerini listeledim.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/homeImages.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: İstatistikler Bölümü
İstatistikler bölümünde proje istatistikleri görüntülenmektedir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/homeStatistics.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Notlar Bölümü
Notlar bölümünde sayfayı inceleyen kullanıcılara söylemek istediklerim bulunmaktadır.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/homeNotes.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: İletişim Bölümü
İletişim bölümü, sayfayı inceleyen kullanıcıların admin'lere göndermek istediği bir mesaj varsa kullanabilecekleri bölümdür. Buradan gönderilen mesajlar Admin Paneli'nde, İletişim ve Mesajlar sekmesindeki, İletişim bölümüne düşmektedir.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/homeContact.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Alt Başlık Bölümü
Alt Başlık bölümünde çoğu sayfada bulunan seçenekler ve harita bölümü yer almaktadır.
<div align="center">
  <img src="https://github.com/melihcolak0/MVC5_Dictionary_WebSite/blob/f2fac6fdf4598909b3b36dd625bc9ed4ff57efc7/ss/homefooter.jpg" alt="image alt">
</div>

