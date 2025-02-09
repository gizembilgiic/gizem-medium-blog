namespace _03_KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if-else
            // 1. Pozitif Negatif Kontrolü
            // Kullanıcıdan bir sayı alın ve sayının pozitif mi, negatif mi yoksa sıfır mı olduğunu ekrana yazdırın.

            Console.WriteLine("Bir sayı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 < 0)
                Console.WriteLine("Negatif");
            else if (sayi1 > 0)
                Console.WriteLine("Pozitif");
            else
                Console.WriteLine("Sayı sıfır.");



            // 2. Yaş Kontrolü
            // Bir kişinin yaşını kullanıcıdan alın. Eğer yaş 18'den küçükse "Reşit değilsiniz", 18 veya daha büyükse "Reşitsiniz" mesajını yazdırın.

            Console.WriteLine("Yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            if (yas < 18)
                Console.WriteLine("Reşit değilsiniz");
            else
                Console.WriteLine("Reşitsiniz");



            // 3. Tek mi Çift mi?
            // Kullanıcıdan bir sayı alın ve bu sayının tek mi, çift mi olduğunu ekrana yazdırın.

            Console.WriteLine("Bir sayı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi2 % 2 == 0)
                Console.WriteLine("Sayı çifttir.");
            else
                Console.WriteLine("Sayı tektir.");



            // 4. Not Aralığına Göre Derecelendirme
            // Kullanıcıdan bir not girilmesini isteyin ve şu koşullara göre not derecesini yazdırın:
            // 90 - 100: AA
            // 80 - 89: BA
            // 70 - 79: BB
            // 60 - 69: CB
            //  0 - 59: FF

            Console.WriteLine("Notunuzu giriniz: ");
            int not = Convert.ToInt32(Console.ReadLine());

            if (not >= 90 && not <= 100)
                Console.WriteLine("AA");
            else if (not >= 80 && not < 90)
                Console.WriteLine("BA");
            else if (not >= 70 && not < 80)
                Console.WriteLine("BB");
            else if (not >= 60 && not < 70)
                Console.WriteLine("CB");
            else
                Console.WriteLine("FF");



            // 5. Üç Sayıyı Karşılaştırma
            // Kullanıcıdan üç farklı sayı alın ve en büyük sayıyı ekrana yazdırın.

            Console.WriteLine("1. Sayıyı Giriniz: ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz: ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. Sayıyı Giriniz: ");
            int s3 = Convert.ToInt32(Console.ReadLine());

            int enBuyuk = s1;

            if (s2 > enBuyuk)
                enBuyuk = s2;
            if (s3 > enBuyuk)
                enBuyuk = s3;

            Console.WriteLine($"En büyük sayı: {enBuyuk}");



            // 6. Harf Kontrolü (Sesli veya Sessiz)
            // Kullanıcıdan bir harf girilmesini isteyin. Harfin sesli mi yoksa sessiz mi olduğunu kontrol edin ve sonucu ekrana yazdırın.
            // (Sesli harfler: a, e, i, o, u)

            Console.WriteLine("Bir harf giriniz: ");
            string harf = Console.ReadLine();

            if (harf == "a" || harf == "e" || harf == "ı" || harf == "i" || harf == "o" || harf == "ö" || harf == "u" || harf == "ü")
                Console.WriteLine("Sesli harf");
            else
                Console.WriteLine("Sessiz harf");



            // 7. Login Sistemi
            // Bir kullanıcı adı ve şifre belirleyin. Kullanıcıdan bu bilgileri girmesini isteyin.
            // Eğer doğruysa "Giriş başarılı", yanlışsa "Giriş başarısız" mesajını yazdırın.

            string dogruKullaniciAdi = "admin";
            string dogruSifre = "Admin123";

            Console.WriteLine("Kullanıcı adını giriniz: ");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreyi giriniz: ");
            string sifre = Console.ReadLine();

            if (kullaniciAdi == dogruKullaniciAdi && sifre == dogruSifre)
                Console.WriteLine("Giriş başarılı");
            else
                Console.WriteLine("Giriş başarısız");



            // 8. İndirim Hesaplama
            // Bir mağaza için şu kurallara göre indirim hesaplayan bir program yazın:
            // * Eğer alışveriş tutarı 100 TL'den azsa indirim uygulanmaz.
            // * 100-500 TL arasında %10 indirim uygulanır.
            // * 500 TL ve üzerinde %20 indirim uygulanır.

            Console.WriteLine("Alışveriş tutarını giriniz: ");
            double tutar = Convert.ToDouble(Console.ReadLine());
            double indirim = 0;

            if (tutar < 100)
                Console.WriteLine($"İndirim yok. Toplam tutar: {tutar}");
            else if (tutar <= 500)
                indirim = tutar * 0.1;
            else
                indirim = tutar * 0.2;
            Console.WriteLine($"İndirim: {indirim}, Ödenecek tutar: {tutar - indirim}");



            // 9. Basit Hesap Makinesi
            // Kullanıcıdan iki sayı ve bir işlem türü (+, -, *, /) alın. İşlem türüne göre sonucu hesaplayıp ekrana yazdırın. Eğer kullanıcı geçersiz bir işlem türü girerse "Geçersiz işlem" mesajını gösterin.

            Console.WriteLine("1. Sayıyı Giriniz: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapılacak işlemi seçin (+,-,*,/): ");
            char islem = char.Parse(Console.ReadLine());

            if (islem == '+')
                Console.WriteLine($"Sonuç: {num1 + num2}");
            else if (islem == '-')
                Console.WriteLine($"Sonuç: {num1 - num2}");
            else if (islem == '*')
                Console.WriteLine($"Sonuç: {num1 * num2}");
            else if (islem == '/')
            {
                if (num2 != 0)
                    Console.WriteLine($"Sonuç: {num1 / num2}");
                else
                    Console.WriteLine("Sıfıra bölünme hatası");
            }
            else
                Console.WriteLine("Geçersiz işlem");



            // 10. Üçgen Tipini Belirleme
            // Kullanıcıdan bir üçgenin üç kenar uzunluğunu alın.
            // * Eğer üç kenar eşitse "Eşkenar üçgen",
            // * İki kenar eşitse "İkizkenar üçgen",
            // * Hiçbiri eşit değilse "Çeşitkenar üçgen" olduğunu ekrana yazdırın.

            Console.WriteLine("Üçgenin 1. kenarını giriniz: ");
            int kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçgenin 2. kenarını giriniz: ");
            int kenar2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçgenin 3. kenarını giriniz: ");
            int kenar3 = Convert.ToInt32(Console.ReadLine());

            if (kenar1 == kenar2 && kenar2 == kenar3)
                Console.WriteLine("Eşkenar üçgen");
            else if (kenar1 == kenar2 || kenar1 == kenar3 || kenar2 == kenar3)
                Console.WriteLine("İkizkenar üçgen");
            else
                Console.WriteLine("Çeşitkenar üçgen");
            #endregion

            #region switch-case
            // 1. Gün Adı Belirleme
            // Kullanıcıdan bir sayı alın (1-7 arasında) ve bu sayıya göre haftanın gününü yazdırın.

            Console.WriteLine("1 ile 7 arasında bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("Geçersiz giriş!");
                    break;
            }

            // 2. Ay Adı Belirleme 
            // Kullanıcıdan 1 ile 12 arasında bir sayı alın ve bu sayıya göre ay adını yazdırın.

            Console.WriteLine("1 ile 12 arasında bir sayı giriniz: ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            switch (s1)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Ağustos");
                    break;
                case 9:
                    Console.WriteLine("Eylül");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                case 12:
                    Console.WriteLine("Aralık");
                    break;
                default:
                    Console.WriteLine("Geçersiz giriş!");
                    break;
            }

            // 3. Basit Hesap Makinesi
            // Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) alın. İşleme göre sonucu yazdırın.

            Console.WriteLine("Birinci sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bir işlem seçiniz (+, -, *, /): ");
            char islem = char.Parse(Console.ReadLine());

            switch (islem)
            {
                case '+':
                    Console.WriteLine($"Sonuç: {sayi1 + sayi2}");
                    break;
                case '-':
                    Console.WriteLine($"Sonuç: {sayi1 - sayi2}");
                    break;
                case '*':
                    Console.WriteLine($"Sonuç: {sayi1 * sayi2}");
                    break;
                case '/':
                    Console.WriteLine(sayi2 != 0 ? $"Sonuç: {sayi1 / sayi2} : " : "Bir sayı sıfıra bölünemez");
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem");
                    break;
            }

            // 4. Sınıf Geçme Durumu
            // Kullanıcının not ortalamasını alıp, 50'nin altında kalırsa sınıfta kaldığını, aksi halde geçtiğini gösterin.

            Console.WriteLine("Not ortalamasını giriniz: ");
            int not = Convert.ToInt32(Console.ReadLine());

            switch (not)
            {
                case < 50:
                    Console.WriteLine("Sınıfta kaldınız.");
                    break;
                case >= 50:
                    Console.WriteLine("Sınıfı geçtiniz.");
                    break;
            }

            // 5. Harf Notu Belirleme
            // Kullanıcının girdiği puana göre harf notu belirleyin (0-100 arası).

            // 90 - 100: AA
            // 80 - 89 : BA
            // 70 - 79 : BB
            // 60 - 69 : CB
            // 50 - 59 : CC
            // Altı    : FF

            Console.WriteLine("Notunuzu giriniz (0-100):");
            int harfNotu = Convert.ToInt32(Console.ReadLine());

            switch (harfNotu)
            {
                case >= 90 and <= 100:
                    Console.WriteLine("Harf Notu: AA");
                    break;
                case >= 80 and < 90:
                    Console.WriteLine("Harf Notu: BA");
                    break;
                case >= 70 and < 80:
                    Console.WriteLine("Harf Notu: BB");
                    break;
                case >= 60 and < 70:
                    Console.WriteLine("Harf Notu: CB");
                    break;
                case >= 50 and < 60:
                    Console.WriteLine("Harf Notu: CC");
                    break;
                case < 50 and >= 0:
                    Console.WriteLine("Harf Notu: FF");
                    break;
                default:
                    Console.WriteLine("Geçersiz not girdiniz!");
                    break;
            }

            // 6. Sayının Tek veya Çift Olması
            // Kullanıcıdan bir sayı alıp tek mi çift mi olduğunu switch-case ile kontrol edin.

            Console.WriteLine("Bir sayı giriniz: ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num % 2)
            {
                case 0:
                    Console.WriteLine("Çift sayı");
                    break;
                case 1:
                    Console.WriteLine("Tek sayı");
                    break;
                default:
                    Console.WriteLine("Geçersiz giriş");
                    break;
            }

            // 7. Yılın Mevsimini Bulma
            // Kullanıcıdan bir ay numarası alıp, hangi mevsimde olduğunu yazdırın.

            // İlkbahar: Mart, Nisan, Mayıs
            // Yaz: Haziran, Temmuz, Ağustos
            // Sonbahar: Eylül, Ekim, Kasım
            // Kış: Aralık, Ocak, Şubat

            Console.WriteLine("Bir ay numarası giriniz (1-12): ");
            int ay = Convert.ToInt32(Console.ReadLine());

            switch (ay)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Mevsim: İlkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Mevsim: Yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Mevsim: Sonbahar");
                    break;
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Mevsim: Kış");
                    break;
                default:
                    Console.WriteLine("Geçersiz ay numarası!");
                    break;
            }

            // 8. Haftalık Mesai Ücreti Hesaplama
            // Çalışanın haftalık çalışma saatine göre mesai ücreti hesaplayın.

            // İlk 40 saati normal ücret
            // Fazladan her saat için normal ücretin 1.5 katı uygulanır.

            Console.WriteLine("Haftalık çalışma saatini giriniz: ");
            int saat = Convert.ToInt32(Console.ReadLine());
            const int saatlikUcret = 20;
            int toplamUcret;

            switch (saat)
            {
                case <= 40:
                    toplamUcret = saat * saatlikUcret;
                    Console.WriteLine($"Toplam ücret: {toplamUcret} TL");
                    break;
                case > 40:
                    toplamUcret = (40 * saatlikUcret) + ((saat - 40) * (int)(saatlikUcret * 1.5));
                    Console.WriteLine($"Toplam ücret: {toplamUcret} TL");
                    break;
                default:
                    Console.WriteLine("Geçersiz saat!");
                    break;
            }

            // 9. Tarihe Göre Zodyak Burcu
            // Kullanıcının doğum ayı ve gününü alarak Zodyak burcunu bulun.

            Console.WriteLine("Doğduğunuz ayı giriniz (1-12): ");
            int ayGir = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Doğdunuz günü giriniz: ");
            int gun = Convert.ToInt32(Console.ReadLine());

            switch (ayGir)
            {
                case 1:
                    Console.WriteLine(gun <= 19 ? "Oğlak" : "Kova");
                    break;
                case 2:
                    Console.WriteLine(gun <= 18 ? "Kova" : "Balık");
                    break;
                case 3:
                    Console.WriteLine(gun <= 20 ? "Balık" : "Koç");
                    break;
                case 4:
                    Console.WriteLine(gun <= 19 ? "Koç" : "Boğa");
                    break;
                case 5:
                    Console.WriteLine(gun <= 20 ? "Boğa" : "İkizler");
                    break;
                case 6:
                    Console.WriteLine(gun <= 20 ? "İkizler" : "Yengeç");
                    break;
                case 7:
                    Console.WriteLine(gun <= 22 ? "Yengeç" : "Aslan");
                    break;
                case 8:
                    Console.WriteLine(gun <= 22 ? "Aslan" : "Başak");
                    break;
                case 9:
                    Console.WriteLine(gun <= 22 ? "Başak" : "Terazi");
                    break;
                case 10:
                    Console.WriteLine(gun <= 22 ? "Terazi" : "Akrep");
                    break;
                case 11:
                    Console.WriteLine(gun <= 21 ? "Akrep" : "Yay");
                    break;
                case 12:
                    Console.WriteLine(gun <= 21 ? "Yay" : "Oğlak");
                    break;
                default:
                    Console.WriteLine("Geçersiz ay!");
                    break;
            }

            #endregion
        }
    }
}
