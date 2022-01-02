namespace E_Trade.DAL.Migrations
{
    using E_Trade.Model.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<E_Trade.DAL.Context.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(E_Trade.DAL.Context.DataContext context)
        {
            context.Categories.AddOrUpdate(x => x.CategoryName, new Category
            {
                CategoryName = "Bilgisayar"
            });

            context.Categories.AddOrUpdate(x => x.CategoryName, new Category
            {
                CategoryName = "Telefon"
            });

            context.Categories.AddOrUpdate(x => x.CategoryName, new Category
            {
                CategoryName = "Tablet"
            });

            context.Categories.AddOrUpdate(x => x.CategoryName, new Category
            {
                CategoryName = "Televizyon"
            });

            context.Brands.AddOrUpdate(x => x.BrandName, new Brand
            {
                BrandName = "ACER"
            });

            context.Brands.AddOrUpdate(x => x.BrandName, new Brand
            {
                BrandName = "Lenovo"
            });

            context.Brands.AddOrUpdate(x => x.BrandName, new Brand
            {
                BrandName = "Samsung"
            });

            context.Brands.AddOrUpdate(x => x.BrandName, new Brand
            {
                BrandName = "Apple"
            });

            context.Brands.AddOrUpdate(x => x.BrandName, new Brand
            {
                BrandName = "Xiaomi"
            });

            context.Brands.AddOrUpdate(x => x.BrandName, new Brand
            {
                BrandName = "Oppo"
            });

            context.Brands.AddOrUpdate(x => x.BrandName, new Brand
            {
                BrandName = "Philips"
            });

            context.Brands.AddOrUpdate(x => x.BrandName, new Brand
            {
                BrandName = "LG"
            });

            context.Brands.AddOrUpdate(x => x.BrandName, new Brand
            {
                BrandName = "Reeder"
            });

            context.Products.AddOrUpdate(x => x.ProuductName, new Product
            {
                ProuductName = "Acer Nitro 5 Intel Core i7 10750H",
                CategoryId = 1,
                BrandId = 1,
                TotalPrice = 14.999,
                TrullyPrice = 12.199,
                Discount = 15,
                Rates = 4.5,
                IsShippingFree = true
            });

            context.Products.AddOrUpdate(x => x.ProuductName, new Product
            {
                ProuductName = "Acer Predator Triton 500 Intel Core i7 10750H",
                CategoryId = 1,
                BrandId = 1,
                TotalPrice = 23.959,
                TrullyPrice = 17.999,
                Discount = 20,
                Rates = 5,
                IsShippingFree = true
            });

            context.Products.AddOrUpdate(x => x.ProuductName, new Product
            {
                ProuductName = "Lenovo IdeaPad Gaming 3 AMD Ryzen 5 4600H",
                CategoryId = 1,
                BrandId = 2,
                TotalPrice = 11.109,
                TrullyPrice = 7.599,
                Discount = 25,
                Rates = 3.5,
                IsShippingFree = false
            });

            context.Products.AddOrUpdate(x => x.ProuductName, new Product
            {
                ProuductName = "Samsung Galaxy Tab S7 SM-T870 128 GB Tablet",
                CategoryId = 3,
                BrandId = 3,
                TotalPrice = 5.799,
                TrullyPrice = 4.899,
                Discount = 16,
                Rates = 4.7,
                IsShippingFree = true
            });

            context.Products.AddOrUpdate(x => x.ProuductName, new Product
            {
                ProuductName = "Lenovo TAB M10 TB-X606F 64GB 10.3 Wi Fi Tablet Gri ZA5T0215TR",
                CategoryId = 3,
                BrandId = 2,
                TotalPrice = 2.999,
                TrullyPrice = 1.829,
                Discount = 39,
                Rates = 4.2,
                IsShippingFree = false
            });

            context.Products.AddOrUpdate(x => x.ProuductName, new Product
            {
                ProuductName = "Reeder M10 Blue Max 64GB 4G LTE",
                CategoryId = 3,
                BrandId = 9,
                TotalPrice = 2.299,
                TrullyPrice = 1.399,
                Discount = 39,
                Rates = 4,
                IsShippingFree = false
            });

            context.Products.AddOrUpdate(x => x.ProuductName, new Product
            {
                ProuductName = "LG 43UN71006LB 43 Inç 108 Ekran Uydu Alıcılı 4K Ultra HD Smart LED TV",
                CategoryId = 4,
                BrandId = 8,
                TotalPrice = 5.999,
                TrullyPrice = 4.399,
                Discount = 27,
                Rates = 4.7,
                IsShippingFree = true

            }); context.Products.AddOrUpdate(x => x.ProuductName, new Product

            {
                ProuductName = "Philips 50PUS7805 50 Inç 126 Ekran Uydu Alıcılı 4K Ultra HD LED Smart TV",
                CategoryId = 4,
                BrandId = 7,
                TotalPrice = 8.199,
                TrullyPrice = 5.199,
                Discount = 37,
                Rates = 4.6,
                IsShippingFree = true
            });

            context.Products.AddOrUpdate(x => x.ProuductName, new Product
            {
                ProuductName = "Reeder P13 Blue Max 64 GB (Reeder Türkiye Garantili)",
                CategoryId = 2,
                BrandId = 9,
                TotalPrice = 2.049,
                TrullyPrice = 1.549,
                Discount = 24,
                Rates = 3.6,
                IsShippingFree = false
            });

            context.Products.AddOrUpdate(x => x.ProuductName, new Product
            {
                ProuductName = "Oppo Reno 4 Lite 128 GB (Oppo Türkiye Garantili)",
                CategoryId = 2,
                BrandId = 6,
                TotalPrice = 3.599,
                TrullyPrice = 3.318,
                Discount = 8,
                Rates = 4.4,
                IsShippingFree = true
            });

            context.Products.AddOrUpdate(x => x.ProuductName, new Product
            {
                ProuductName = "Xiaomi Redmi Note 10 Pro 128 GB 8 GB RAM (Xiaomi Türkiye Garantili)",
                CategoryId = 2,
                BrandId = 5,
                TrullyPrice = 4.299,
                Rates = 4.6,
                IsShippingFree = true
            });

            context.Products.AddOrUpdate(x => x.ProuductName, new Product
            {
                ProuductName = "Samsung Galaxy Note 20 Ultra 256 GB (Samsung Türkiye Garantili)",
                CategoryId = 2,
                BrandId = 3,
                TotalPrice = 12.299,
                TrullyPrice = 11.249,
                Discount = 9,
                Rates = 4.5,
                IsShippingFree = true
            });

            context.Products.AddOrUpdate(x => x.ProuductName, new Product
            {
                ProuductName = "iPhone XS Max 256 GB",
                CategoryId = 2,
                BrandId = 4,
                TrullyPrice = 13.997,
                Rates = 4.7,
                IsShippingFree = false
            });

            context.ProductComments.AddOrUpdate(x => x.Comment, new ProductComment
            {
                ProductId = 2,
                Comment = "cihaz harika ancak 2080 max-q olması desktop versiyonda 2070'e denk geldiği nutulmamalı.Oyunlarda overclocklu hali ile gayet tatmin edici fps'ler sunuyor.tavsiye olunur.",
                Rate = 5,
                UserName = "Ahmet",
                UserSurname = "Sayar",
                UserAvatar = null,
                WritingDate = DateTime.Now,
                ThumbsUp = 6,
                ThumbsDown = 4
            });

            context.ProductComments.AddOrUpdate(x => x.Comment, new ProductComment
            {
                ProductId = 2,
                Comment = "Öncelikle hızlı kargo gönderimi için Hepsi Buradaya teşekkür ederim. Ürün elime hasarsız bir ekilde ulaştı. Kutulama oldukça başarılı. Ürün gerçekten çok kaliteli. Hem iş hem de oyun amaçlı olarak ullanılabiliyor. Performans olarak Harika bir ürün herkese gönül rahatlığıyla tavsiye ederim.",
                Rate = 5,
                UserName = "İrem",
                UserSurname = "Aras",
                UserAvatar = null,
                WritingDate = DateTime.Now,
                ThumbsUp = 3,
                ThumbsDown = 11
            });

            context.ProductComments.AddOrUpdate(x => x.Comment, new ProductComment
            {
                ProductId = 3,
                Comment = "Ürün gayet başarılı, 512 gb ssdli modeli yerine tercih ettim, kurulum sıkıntı oldu, riverleri mutlaka lenovonun kendi sitesinden indirmenizi tavsiye ederim, satıcı güzel, iletişimi iyiydi.",
                Rate = 5,
                UserName = "Beril",
                UserSurname = "Su",
                UserAvatar = null,
                WritingDate = DateTime.Now,
                ThumbsUp = 4,
                ThumbsDown = 10
            });

            context.ProductComments.AddOrUpdate(x => x.Comment, new ProductComment
            {
                ProductId = 3,
                Comment = "Ürün fotoğraflardaki gibi 3 4 saattir kurulum için kullanıyorum gayet hızlı.İstanbul içinde seniz kargo süreci çok hızlı bir şekilde işliyor. Free dos olduğu için format attıktan sonra ilk iş windowsu son sürümegüncelleyin daha sonra kurulum yapın.Lenovo sitesindeki sürücülerin bazıları windows son sürüm olmadığı için kurulmuyorözellikle ekran kartları. Klavye hissiyatı çok iyi. Satıcı ilgili aradığımda direkt çözüm odaklı konuştular. Gerekli azılımları indirmenizi tavsiye ederim. Düşünmeden alabilirsiniz",
                Rate = 5,
                UserName = "Gökçe",
                UserSurname = "Deniz",
                UserAvatar = null,
                WritingDate = DateTime.Now,
                ThumbsUp = 4,
                ThumbsDown = 5
            });

            context.ProductComments.AddOrUpdate(x => x.Comment, new ProductComment
            {
                ProductId = 4,
                Comment = "Ürün iyi hoş güzel de aga bu nasıl bir dolar kuru, adam bunu 400 500 lira sayıp alıyor biz iye 2 asgari ücretten fazla koyuyoz Allah aşkına ya.  Not: Almanya bizi kıskanıyor :'(",
                Rate = 1,
                UserName = "Remzi",
                UserSurname = "Cenk",
                UserAvatar = null,
                WritingDate = DateTime.Now,
                ThumbsUp = 154,
                ThumbsDown = 26
            });

            context.ProductComments.AddOrUpdate(x => x.Comment, new ProductComment
            {
                ProductId = 5,
                Comment = "Öncelikle Ürünü alış sebebim laptopu internette bişeyler bakmak, alışveriş yapmak sosyal edyada takılmak için kullanırken ağır olması şarjının çok gitmemesiydi. Ben öyle oyun oynayan biri değilim o yüzden yun performansı açısından bir değerlendirme yapamayacağım. Ürün beklediğim gibi. Bilgisayardan google chrome'a nasıl idiyorsanız bu cihazla da aynen girebiliyorsunuz. Şarj konusuna gelirsek net 6 saat ekran açık İnternette ezinebiliyorsunuz. Cihazın hoparlörlerinden gelen ses çok başarılı ancak kulaklık konusunda çok iddialı değil. Aşağıda orumda arkadaş usb bellekleri görmüyor demiş ben çatır çutur takıyorum gayette görüyor. Cihazın iki kusuru var bence irincisi yeni olduğundan dolayı kılıf olsun ekran koruyucu olsun bu tarz aksesuarlar açısından sıkıntısı var. İkincisi e batarya biraz daha büyük olabilirdi. Ancak şunu da söyleyeyim bu aralar işe gitmiyor oluşum ve cihazın yeni oluşundanötürü sürekli elimde olması da pilini yeterli bulmamamda etkili bir faktördür. Sonuç olarak benim aldığım amaçla lacaklara tavsiye ederim.Kargo gayet hızlı sitenin tahmini olarak size söylediği tarihten 2 gün önce elinize laşıyor.",
                Rate = 5,
                UserName = "Seyid",
                UserSurname = "Adıgüzel",
                UserAvatar = null,
                WritingDate = DateTime.Now,
                ThumbsUp = 66,
                ThumbsDown = 8
            });

            context.ProductComments.AddOrUpdate(x => x.Comment, new ProductComment
            {
                ProductId = 7,
                Comment = "Televizyonun Artıları: + iPhone ile tam uyumlu olması + Hızlı açılış süresi + Menülerdeki kıcılık + Fiyat performans ürünü Eksileri - Kanal geçişleri bazen can sıkabiliyor - Menünün bazı kısımları yavaş alışıyor - Görüntü ayarlarında istenen rengi yakalamak olması gerekenden zor. Genel olarak ben üründen memnunum.Daha yi olabilirdi ancak o zamanda tabiki fiyatı daha da yüksek olacaktı.Ayrıca satın aldığım satıcının paketlemesi oldukça yi.Sadece kutusu ile göndermeyip dışına birde kabarcıklı poşet sarması teslimat sırasında kontrol etmenizi çok çok olaylaştırıyor.Satıcının ilgiside gayet iyiydi.Çok teşekkürler.",
                Rate = 5,
                UserName = "Recep",
                UserSurname = "yılmaz",
                UserAvatar = null,
                WritingDate = DateTime.Now,
                ThumbsUp = 4,
                ThumbsDown = 2
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 1,
                Image = "1.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 1,
                Image = "2.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 1,
                Image = "3.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 2,
                Image = "4.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 2,
                Image = "5.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 2,
                Image = "6.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 3,
                Image = "7.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 3,
                Image = "8.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 3,
                Image = "9.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 13,
                Image = "10.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 13,
                Image = "11.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 13,
                Image = "12.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 5,
                Image = "13.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 5,
                Image = "14.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 7,
                Image = "15.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 7,
                Image = "16.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 7,
                Image = "17.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 7,
                Image = "18.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 7,
                Image = "19.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 10,
                Image = "20.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 10,
                Image = "21.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 10,
                Image = "22.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 8,
                Image = "23.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 8,
                Image = "24.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 8,
                Image = "25.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 6,
                Image = "26.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 6,
                Image = "27.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 6,
                Image = "28.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 6,
                Image = "29.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 9,
                Image = "30.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 9,
                Image = "31.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 9,
                Image = "32.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 9,
                Image = "33.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 9,
                Image = "34.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 12,
                Image = "35.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 12,
                Image = "36.jpg"
            });


            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 12,
                Image = "37.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 12,
                Image = "38.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 12,
                Image = "39.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 12,
                Image = "40.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 4,
                Image = "41.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 4,
                Image = "42.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 4,
                Image = "43.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 11,
                Image = "44.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 11,
                Image = "45.jpg"
            });

            context.ProductImages.AddOrUpdate(x => x.Image, new ProductImage
            {
                ProductId = 11,
                Image = "46.jpg"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "Ekran Boyutu",
                VarValue = "15,6 inç"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "Ekran Kartı",
                VarValue = "Nvidia GeForce RTX 2060"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "İşletim Sistemi",
                VarValue = "Yok (Free Dos)"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "İşlemci",
                VarValue = "10750H"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "Ram",
                VarValue = "16 GB"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "Harddisk Kapasitesi",
                VarValue = "512 GB SSD"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "Cihaz Ağırlığı",
                VarValue = "1 - 2 kg"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "Dokunmatik Ekran",
                VarValue = "Yok"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "Ekran Özelliği",
                VarValue = "IPS"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "Bellek Hızı",
                VarValue = "2933 MHz"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "Bellek Yuvası",
                VarValue = "2"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "Max Ekran Çözünürlüğü",
                VarValue = "1920 x 1080"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "Şarjlı Kullanım Süresi",
                VarValue = "4 - 6 Saat"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "Temel İşlemci Hızı",
                VarValue = "2,60 GHz"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "Klavye",
                VarValue = "Q Türkçe"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "Usb 2.0",
                VarValue = "Yok"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "USB 3.0",
                VarValue = "Yok"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "USB 3.1",
                VarValue = "3"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "Garanti Süresi (Ay)",
                VarValue = "24"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 1,
                VarKey = "Maksimum İşlemci Hızı",
                VarValue = "5 GHz"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 2,
                VarKey = "Ekran Boyutu",
                VarValue = "15,6 inç"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 2,
                VarKey = "Ekran Kartı",
                VarValue = "Nvidia GeForce RTX 2080 Super"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 2,
                VarKey = "İşletim Sistemi",
                VarValue = "Yok (Free Dos)"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 2,
                VarKey = "İşlemci",
                VarValue = "10750H"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 2,
                VarKey = "Ram",
                VarValue = "8 GB"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 2,
                VarKey = "Harddisk Kapasitesi",
                VarValue = "1TB SSD"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 2,
                VarKey = "Cihaz Ağırlığı",
                VarValue = "2 - 4 kg"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 2,
                VarKey = "Dokunmatik Ekran",
                VarValue = "Yok"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 2,
                VarKey = "Ekran Özelliği",
                VarValue = "IPS"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 2,
                VarKey = "Bellek Hızı",
                VarValue = "2933 MHz"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 3,
                VarKey = "Ekran Boyutu",
                VarValue = "15,6 inç"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 3,
                VarKey = "Ekran Kartı",
                VarValue = "GTX 1650"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 3,
                VarKey = "İşletim Sistemi",
                VarValue = "Yok (Free Dos)"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 3,
                VarKey = "İşlemci",
                VarValue = "AMD Ryzen 5 4600H"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 3,
                VarKey = "Ram",
                VarValue = "16 GB"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 3,
                VarKey = "Harddisk Kapasitesi",
                VarValue = "512 GB SSD"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 4,
                VarKey = "Kamera",
                VarValue = "Çift Kamera"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 4,
                VarKey = "Ekran Boyutu",
                VarValue = "11 inç"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 4,
                VarKey = "Dahili Hafıza",
                VarValue = "128 GB"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 4,
                VarKey = "Max Ekran Çözünürlüğü",
                VarValue = "2560 x 1600"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 5,
                VarKey = "Kamera",
                VarValue = "Çift Kamera"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 5,
                VarKey = "Ekran Boyutu",
                VarValue = "10,3 inç"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 5,
                VarKey = "Dahili Hafıza",
                VarValue = "64 GB"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 5,
                VarKey = "Max Ekran Çözünürlüğü",
                VarValue = "1920 x 1200"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 5,
                VarKey = "Ram Kapasitesi",
                VarValue = "4 GB"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 6,
                VarKey = "Max Ekran Çözünürlüğü",
                VarValue = "1920 x 1200"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 6,
                VarKey = "Ekran Boyutu",
                VarValue = "10,1 inç"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 6,
                VarKey = "Dahili Hafıza",
                VarValue = "64 GB"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 6,
                VarKey = "Kamera",
                VarValue = "Çift Kamera"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 6,
                VarKey = "İşletim Sistemi Tabanı",
                VarValue = "Android"
            });

            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 6,
                VarKey = "Ram Kapasitesi",
                VarValue = "4 GB"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 7,
                VarKey = "Ekran Ebatı",
                VarValue = "43 inç / 108 cm"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 7,
                VarKey = "Smart TV",
                VarValue = "Var"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 7,
                VarKey = "Wi-Fi",
                VarValue = "Var"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 8,
                VarKey = "Ekran Ebatı",
                VarValue = "50 inç / 127 cm"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 8,
                VarKey = "Smart TV",
                VarValue = "Var"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 8,
                VarKey = "Görüntü Teknolojisi",
                VarValue = "LED"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 8,
                VarKey = "Çözünürlük",
                VarValue = "4K Ultra HD"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 8,
                VarKey = "Çözünürlük (Piksel)",
                VarValue = "3840 x 2160"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 9,
                VarKey = "Dahili Hafıza",
                VarValue = "64 GB"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 9,
                VarKey = "RAM Kapasitesi",
                VarValue = "4 GB"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 9,
                VarKey = "Pil Gücü",
                VarValue = "4680 mAh"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 9,
                VarKey = "Ekran Boyutu",
                VarValue = "6,47 inç"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 9,
                VarKey = "Ön (Selfie) Kamera",
                VarValue = "8,0 MP"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 9,
                VarKey = "Kamera Çözünürlüğü",
                VarValue = "13 MP"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 10,
                VarKey = "Dahili Hafıza",
                VarValue = "128 GB"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 10,
                VarKey = "RAM Kapasitesi",
                VarValue = "8 GB"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 10,
                VarKey = "Pil Gücü",
                VarValue = "4310 mAh"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 10,
                VarKey = "Ekran Boyutu",
                VarValue = "6,4 inç"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 10,
                VarKey = "Ön (Selfie) Kamera",
                VarValue = "32 MP"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 10,
                VarKey = "Kamera Çözünürlüğü",
                VarValue = "48 MP + 8 MP + 2 MP + 2 MP"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 11,
                VarKey = "Dahili Hafıza",
                VarValue = "128 GB"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 11,
                VarKey = "RAM Kapasitesi",
                VarValue = "8 GB"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 11,
                VarKey = "Pil Gücü",
                VarValue = "5020 mAh"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 11,
                VarKey = "Ön (Selfie) Kamera",
                VarValue = "16 MP"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 11,
                VarKey = "Kamera Çözünürlüğü",
                VarValue = "108 MP + 8 MP + 5 MP + 2 MP"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 12,
                VarKey = "Ön (Selfie) Kamera",
                VarValue = "10 MP"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 12,
                VarKey = "Pil Gücü",
                VarValue = "4500 mAh"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 12,
                VarKey = "Kamera Çözünürlüğü",
                VarValue = "108 MP + 12 MP + 12 MP"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 12,
                VarKey = "RAM Kapasitesi",
                VarValue = "8 GB"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 12,
                VarKey = "Ekran Boyutu",
                VarValue = "6,9 inç"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 12,
                VarKey = "Dahili Hafıza",
                VarValue = "256 GB"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 13,
                VarKey = "Ön (Selfie) Kamera",
                VarValue = "7,0 MP"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 13,
                VarKey = "Kamera Çözünürlüğü",
                VarValue = "12 MP + 12 MP"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 13,
                VarKey = "Ekran Boyutu",
                VarValue = "6,5 inç"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 13,
                VarKey = "Pil Gücü",
                VarValue = "3174 mAh"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 13,
                VarKey = "Dahili Hafıza",
                VarValue = "256 GB"
            });
            context.ProductProperties.AddOrUpdate(x => x.VarKey, new ProductProperty
            {
                ProductId = 13,
                VarKey = "RAM Kapasitesi",
                VarValue = "4 GB"
            });
        }
    }
}
