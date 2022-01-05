using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FinalUygulama.Data;
using System;
using System.Linq;

namespace FinalUygulama.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FinalUygulamaContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FinalUygulamaContext>>()))
            {
                // Look for any movies.
                if (context.Haber.Any())
                {
                    return;   // DB has been seeded
                }


                context.Haber.AddRange(
                                    new Haber
                                    {
                                        HaberBaslik = "Son dakika: Meteoroloji'den flaş uyarı! Aniden yükselecek... Risk artıyor",
                                        HaberAciklama = "Meteoroloji Genel Müdürlüğü son dakika olarak yeni raporunu yayımladı. " +
                                        "Hava sıcaklıklarının hızla yükseleceğine işaret eden yeni raporda flaş uyarılar yer aldı. İşte detaylar...",
                                        HaberDetay = "Meteoroloji'nin son dakika raporuna göre; hava sıcaklıklarının yurt genelinde mevsim normallerinin 4 ila 10 derece üzerinde seyredeceği tahmin ediliyor." +
                                        "Sıcaklıkların hissedilir derecede artarak mevsim normallerinin 4 ila 10 derece üzerinde seyretmesi bekleniyor. Artan sıcaklıklarla birlikte, mevcut kar örtüsünde meydana" +
                                        " gelebilecek hızlı erime sebebiyle sel, su baskını, heyelan ve çığ oluşma riskinin arttığı değerlendirilmektedir" +
                                        "Meteoroloji Genel Müdürlüğü tarafından yapılan son değerlendirmelere göre: Ülkemizin güney ve batı kesimlerinin parçalı ve çok bulutlu," +
                                        "Kıyı Ege,Akdeniz(Burdur dışında) ile Kırklareli ve Manisa çevrelerinin yağmur ve sağanak yağışlı, diğer yerlerin az bulutlu geçeceği tahmin ediliyor.Gece ve sabah saatlerinde " +
                                        "doğu kesimlerde buzlanma ve don olayı, iç ve doğu kesimlerde yer yer pus ve sis görülmesi bekleniyor.",
                                        Kategori = "Gündem",
                                        HaberTarihi = "28.12.2021",
                                        HaberResimYolu = "https://i.hizliresim.com/rxow1r4.jpg"
                                    },
                                    new Haber
                                    {
                                        HaberBaslik = "Türkiye-Ermenistan Özel Temsilcileri arasındaki ilk toplantı 14 Ocak'ta yapılacak",
                                        HaberAciklama = "Dışişleri Bakanlığı'ndan yapılan açıklamaya göre Türkiye ve Ermenistan Özel Temcileri arasındaki ilk toplantı 14 Ocak'ta Moskova'da yapılacak.",
                                        HaberDetay = "Dışişleri Bakanlığı, Türkiye ve Ermenistan'ın özel temsilcilerinin ilk görüşmesinin 14 Ocak'ta Moskova'da yapılacağını bildirdi." +
                                        "Bakanlıktan yapılan yazılı açıklamada 'Türkiye ve Ermenistan Özel Temsilcileri arasındaki ilk toplantı 14 Ocak 2022'de Moskova’da yapılacaktır.' ifadesi kullanıldı." +
                                        "Türkiye'nin eski Washington Büyükelçisi Serdar Kılıç, 15 Aralık'ta Ermenistan Özel Temsilcisi olarak görevlendirilmişti." +
                                        "Ermenistan Parlamentosu Başkan Yardımcısı Ruben Rubinyan da,Ermenistan ve Türkiye arasındaki diyalog süreci kapsamında özel temsilci olarak atanmıştı.",
                                        Kategori = "Türkiye Haberleri",
                                        HaberTarihi = "05.01.2022",
                                        HaberResimYolu = "https://i.hizliresim.com/o1ke3hx.jpg"
                                    },
                                    new Haber
                                    {
                                        HaberBaslik = "ABD Kongresi'nde, 6 Ocak baskınının yıl dönümü için güvenlik önlemleri alındı",
                                        HaberAciklama = "ABD'de geçen yıl yaşanan 6 Ocak Kongre baskınının yıl dönümünde başkent Washington DC'de ve Kongre çevresinde güvenlik önlemleri artırıldı.",
                                        HaberDetay = "ABD'de 3 Kasım 2020 başkanlık seçimlerinin sonuçlarının teyit edildiği oturum esnasında, aşırı sağcı grupların Kongre binasını basmasının yarınki yıl dönümü için kolluk kuvvetleri alarmda bekliyor.\n"+
                                        "Gerek Kongre Polisi gerekse de federal yetkililer, baskının yıl dönümünde yaşanacak herhangi bir şiddet olayını önlemek için gerekli önlemleri alıyor.\n"+
                                        "ABD İç Güvenlik Bakanı Alejandro Mayorkas, yaptığı açıklamada, potansiyel tehditlerin farkında olduklarını ve önlem aldıklarını belirterek, Federal Soruşturma Bürosu (FBI) ile de doğrudan temas halinde olduklarını kaydetti.\n"+
                                        "Kongre Polis Şefi Tom Manger ise yaptığı basın toplantısında, kendilerinin herhangi bir tehdide cevap verecek güçte olduklarını gerekirse diğer birimlerden de yardım isteyeceklerini belirtti.",
                                        Kategori = "Dünya Haberleri",
                                        HaberTarihi = "03.01.2022",
                                        HaberResimYolu = "https://i.hizliresim.com/8jdsoz9.jpg"
                                    },
                                    new Haber
                                    {
                                        HaberBaslik = "Kayseri'de öğrencileri taşıyan midibüs devrildi: 1 ölü, 21 yaralı",
                                        HaberAciklama = "Kayseri'de öğrencileri taşıyan midibüsün devrilmesi sonucu 1 kişi hayatını kaybetti, 21 kişi yaralandı.",
                                        HaberDetay = "Kayseri'de aralarında Erciyes Üniversitesi öğrencilerinin de bulunduğu Özkan Suruç'un kullandığı midibüs, Erciyes Kayak Merkezi'nden dönüşte, Hacılar ilçesi Aşağı Mahalle Erenler Caddesi'nde şarampole devrildi.\n"+
                                        "Kaza yerine çok sayıda ambulans, itfaiye ve polis ekibi sevk edildi. Midibüste bulunan Hilal Sıkar hayatını kaybetti, sürücünün de aralarında bulunduğu 21 kişi yaralandı. Yaralılar, kentteki hastanelere kaldırıldı.\n" +
                                        "Vali Şehmus Günaydın, kaza bölgesine giderek yetkililerden bilgi ald. Günaydın, gazetecilere yaptığı açıklamada, herkesi üzen bir trafik kazası meydana geldiğini söyledi. Bütün arkadaşlarının ilk andan itibaren olaya müdahale ettiklerini belirten Günaydın, şunları kaydetti:\n" +
                                        "'Şimdi arkadaşlarımdan aldığım bilgiye göre maalesef 1 can kaybımız var. Arkadaşlarımız, minibüste 22 kişinin olduğunu ve yaralılarımızdan 4'ünün durumunun ağır olduğunu ifade etti. Hastanelerimizde şu anda yaralılarımıza müdahale ediliyor. Arkadaşlarımızın verdiği bilgiye göre Erciyes Üniversitesi öğrencileri. Buraya saat 12.00 itibarıyla gelmişler. Dönüşte minibüsün yoldan çıkması ve devrilmesi sonucu maalesef bu üzücü kaza meydana geldi. Arkadaşlarımız çalışıyor, teknik olarak kazanın nedeni konusunda daha sonra ayrıntılı bilgi verecekler. Geçmiş olsun, başımız sağ olsun. Yaralılarımıza acil şifalar diliyorum.'",
                                        Kategori = "Türkiye Haberleri",
                                        HaberTarihi = "05.01.2022",
                                        HaberResimYolu = "https://i.hizliresim.com/tl00evs.jpg"
                                    },
                                    new Haber
                                    {
                                        HaberBaslik = "Kosova’da kripto para madenciliği yasaklandı",
                                        HaberAciklama = "Kosova’da enerji krizine çözüm olarak elektrik kesinti uygulamasına gidilmesinin ardından ülkede, kripto para madenciliğinin yasaklandığı bildirildi.",
                                        HaberDetay = "Yüksek küresel fiyatlar ve ülkenin en büyük kömür santralinde arıza meydana gelmesinin ardından enerji krizi yaşanmaya başlamış ve çözüm olarak ülkede elektrik kesinti uygulamasına gidilmişti.\n"+
                                        "Her 8 saatte bir 2 saat elektrik verilen ülkede vatandaşlar kesintileri protesto etti ve Enerji Bakanı'nın istifasını istedi. Ülkede elektrik kesintilerine ek olarak kripto para madenciliği de yasaklandı.",
                                        Kategori = "Ekonomi",
                                        HaberTarihi = "02.01.2022",
                                        HaberResimYolu = "https://i.hizliresim.com/f7vnbm4.jpg"
                                    },
                                    new Haber
                                    {
                                        HaberBaslik = "Damla Sönmez: Popüler olan her şeye tepkiliyim",
                                        HaberAciklama = "Damla Sönmez, Gardırop Magazin dergisinin yeni sayısı için objektif karşısına geçti.",
                                        HaberDetay = "Derin göğüs dekolteli kostümüyle iddialı pozlar veren oyuncu, modada popüler olan şeylere karşı tepkili olduğunu söyledi ve ekledi: 'Genellikle içinde kendimi rahat hissettiğim parçaları tercih ediyorum. Bir anda çok popüler olan her şeye karşı tuhaf bir tepkiselliğim var. O yüzden yeni çıkan ve bir anda herkesin üzerinde gördüğümüz parçalara alışmam uzun zaman alıyor.'",
                                        Kategori = "Magazin",
                                        HaberTarihi = "05.01.2022",
                                        HaberResimYolu = "https://i.hizliresim.com/41ydhes.jpg"
                                    },
                                    new Haber
                                    {
                                        HaberBaslik = "VavaCars Fatih Karagümrük'ten Volkan Demirel Fenerbahçe'de transfer yapacak mı? Meyer gerçeği ortaya çıktı",
                                        HaberAciklama = "Süper Lig ekiplerinden VavaCars Fatih Karagümrük'te teknik direktör Volkan Demirel'in Fenerbahçe'den Max Meyer'i transfer etmek istediği iddia edilmişti. Transfere dair gerçekler ortaya çıktı.",
                                        HaberDetay = "Volkan Demirel'in teknik direktörlüğünü yaptığı VavaCars Fatih Karagümrük ligin ikinci yarısı için transfer çalışmalarını sürdürürken, Max Meyer'in transferine dair gerçekler ortaya çıktı.\n"+
                                        "Lille forması giyen Mustafa Kapı'nın transferi için çalışmalarını sürdüren Fatih Karagümrük'te Max Meyer için herhangi bir girişim yok.\n"+
                                        "Spor Arena'nın edindiği bilgiye göre; Alman orta saha oyuncusu için Fatih Karagümrük'ün Fenerbahçe ile bir görüşme yapmadığı ve Fatih Karagümrük böyle bir transfer hedefinin bulunmadığı öğrenildi.\n"+
                                        "VavaCars Fatih Karagümrük cephesi, çıkan haberleri Spor Arena'ya yalanlarken, transfer çalışmalarının sürdüğü belirtildi.",
                                        Kategori = "Spor",
                                        HaberTarihi = "01.01.2022",
                                        HaberResimYolu = "https://i.hizliresim.com/hfma20t.jpg"
                                    }
                                );
                context.SaveChanges();
            }
        }
    }
}