namespace _04_TryParse_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TryParse metodu ile ilgili örnek sorular 

            /*
             1. Kullanıcıdan alınan bir string değerin int türüne çevrilebilir olup olmadığını kontrol edin.

             2. Kullanıcıdan alınan string değerin double türüne çevrilebilir olup olmadığını kontrol edin.

             3. Kullanıcıdan alınan string bir tarihi DateTime türüne çevirmeye çalışın. Başarılı olup olmadığını ekrana yazdırın.

             4. Kullanıcının girdiği string değeri bool türüne çevirmeye çalışın ve başarılıysa sonucu ekrana yazdırın.

             5. Kullanıcının girdiği string değeri decimal türüne çevirmeye çalışın. Eğer çevirme başarısız olursa 0 değeri döndürün.

             6. Kullanıcının girdiği iki sayıyı TryParse kullanarak int türüne çevirin ve sadece çevirme başarılı olduğunda toplamlarını ekrana yazdırın.

             7. Kullanıcının girdiği string ifadenin TimeSpan türüne çevrilebilir olup olmadığını kontrol edin ve sonucu ekrana yazdırın.

             8. Kullanıcının girdiği string ifadenin byte türüne çevrilebilir olup olmadığını kontrol edin. Eğer çevirme başarılıysa sayıyı 2 ile çarpıp ekrana yazdırın.

             9. Kullanıcının girdiği string ifadenin hangi veri tipine TryParse yöntemi ile çevrilebileceğini bulan bir metot yazın. (int, double, bool, DateTime, byte gibi birkaç veri türünü destekleyin)

            10. Kullanıcıdan birden fazla sayı içeren bir string alın (örneğin: "45, 67, 89, abc, 12"). TryParse metodunu kullanarak yalnızca sayıları bir List<int> koleksiyonuna ekleyin ve en büyük ile en küçük sayıyı ekrana yazdırın.      
             
             */
            #endregion

            #region TryParse metodu cevapları
            Console.WriteLine("TryParse Örnek Sorular");
            // 1.
            Console.Write("1. Soru: Bir sayı girin: ");
            string giris1 = Console.ReadLine();

            if (int.TryParse(giris1, out int sayi))
            {
                Console.WriteLine($"Girilen sayı: {sayi}");
            }
            else
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz.");
            }
            Console.WriteLine("-------------------------------------------------");

            // 2.
            Console.Write("2. Soru: Bir ondalıklı sayı girin: ");
            string giris2 = Console.ReadLine();

            if (double.TryParse(giris2, out double sonuc))
            {
                Console.WriteLine($"Girilen ondalıklı sayı: {sonuc}");
            }
            else
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz.");
            }
            Console.WriteLine("-------------------------------------------------");

            // 3.
            Console.Write("3. Soru: Bir tarih girin (GG.AA.YYYY): ");
            string giris3 = Console.ReadLine();

            if (DateTime.TryParse(giris3, out DateTime tarih))
            {
                Console.WriteLine($"Girilen tarih: {tarih}");
            }
            else
            {
                Console.WriteLine("Geçersiz bir tarih girdiniz.");
            }
            Console.WriteLine("-------------------------------------------------");

            // 4.
            Console.Write("4. Soru: True veya False girin: ");
            string giris4 = Console.ReadLine();

            if (bool.TryParse(giris4, out bool sonuc4))
            {
                Console.WriteLine($"Girilen değer: {sonuc4}");
            }
            else
            {
                Console.WriteLine("Geçersiz bir boolean değeri girdiniz.");
            }
            Console.WriteLine("-------------------------------------------------");

            // 5. 
            Console.Write("5. Soru: Bir ondalıklı sayı girin: ");
            string giris5 = Console.ReadLine();

            if (!decimal.TryParse(giris5, out decimal sonuc5))
            {
                sonuc = 0;
            }
            Console.WriteLine($"Girilen değer: {sonuc5}");
            Console.WriteLine("-------------------------------------------------");

            // 6.
            Console.Write("6. Soru: Birinci sayıyı girin: ");
            string s1 = Console.ReadLine();

            Console.Write("İkinci sayıyı girin: ");
            string s2 = Console.ReadLine();

            if (int.TryParse(s1, out int sayi1) && int.TryParse(s2, out int sayi2))
            {
                Console.WriteLine($"Toplam: {sayi1 + sayi2}");
            }
            else
            {
                Console.WriteLine("Geçersiz girişlerden biri veya her ikisi de sayı değil.");
            }
            Console.WriteLine("-------------------------------------------------");

            // 7. 
            Console.Write("7. Soru: Saat ve dakika girin (HH:MM formatında): ");
            string giris7 = Console.ReadLine();

            if (TimeSpan.TryParse(giris7, out TimeSpan sure))
            {
                Console.WriteLine($"Girilen süre: {sure}");
            }
            else
            {
                Console.WriteLine("Geçersiz bir zaman dilimi girdiniz.");
            }
            Console.WriteLine("-------------------------------------------------");

            // 8.
            Console.Write("8. Soru: 0 ile 255 arasında bir sayı girin: ");
            string giris8 = Console.ReadLine();

            if (byte.TryParse(giris8, out byte sayi8))
            {
                Console.WriteLine($"Girilen sayının iki katı: {sayi8 * 2}");
            }
            else
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz.");
            }
            Console.WriteLine("-------------------------------------------------");

            // 9. 
            Console.Write("9. Soru: Bir giriş yapın: ");
            string giris9 = Console.ReadLine();

            if (int.TryParse(giris9, out _))
                Console.WriteLine("Girdiğiniz değer bir INTEGER.");
            else if (double.TryParse(giris9, out _))
                Console.WriteLine("Girdiğiniz değer bir DOUBLE.");
            else if (bool.TryParse(giris9, out _))
                Console.WriteLine("Girdiğiniz değer bir BOOLEAN.");
            else if (DateTime.TryParse(giris9, out _))
                Console.WriteLine("Girdiğiniz değer bir DATETIME.");
            else
                Console.WriteLine("Girdiğiniz değer hiçbir bilinen türle eşleşmiyor.");
            Console.WriteLine("-------------------------------------------------");

            // 10.
            Console.Write("10. Soru: Sayıları virgülle ayırarak girin: ");
            string giris10 = Console.ReadLine();

            string[] parcala = giris10.Split(',');

            List<int> sayilar = new List<int>();

            foreach (string eleman in parcala)
            {
                if (int.TryParse(eleman.Trim(), out int sayi10))
                {
                    sayilar.Add(sayi10);
                }
            }

            if (sayilar.Count > 0)
            {
                Console.WriteLine($"En küçük sayı: {sayilar.Min()}");
                Console.WriteLine($"En büyük sayı: {sayilar.Max()}");
            }
            else
            {
                Console.WriteLine("Hiç geçerli bir sayı girilmedi.");
            }
            #endregion

            #region TryCatch Hata Yönetimi ile ilgili örnek sorular
            /*
             1. Sıfıra Bölme Hatası: Kullanıcıdan iki sayı alıp, birinci sayıyı ikinciye bölerek sonucu ekrana yazdıran bir program yazın. Ancak ikinci sayı sıfır girildiğinde hata yakalayarak uygun bir mesaj gösterin.

             2. Dizi Taşma Hatası: 5 elemanlı bir dizi tanımlayın ve kullanıcıdan bir indeks değeri isteyerek o indeksteki elemanı ekrana yazdırın. Kullanıcı geçersiz bir indeks girerse hatayı yakalayarak uygun bir mesaj gösterin.

             3. Format Hatası: Kullanıcıdan bir sayı girmesini isteyen bir program yazın. Kullanıcı sayı yerine harf veya geçersiz bir karakter girerse, hatayı yakalayıp mesaj gösterin.

             4. Dosya Okuma Hatası: Kullanıcıdan bir dosya adı isteyerek o dosyanın içeriğini okumaya çalışan bir program yazın. Eğer dosya bulunamazsa hatayı yakalayıp mesaj gösterin.

             5. Çoklu Catch Kullanımı: Kullanıcının girdiği bir sayıyı bir listeye ekleyen bir program yazın. FormatException, ArgumentOutOfRangeException ve genel Exception türlerini yakalayarak uygun mesajlar gösterin.

             6. Finally Kullanımı: Kullanıcının girdiği iki sayıyı bölüp sonucu ekrana yazdıran bir program yazın. Hata oluşsa da oluşmasa da "İşlem tamamlandı." mesajını ekrana yazdıran bir finally bloğu ekleyin.

             7. Özel Hata Fırlatma: Kullanıcının girdiği bir yaş değerini kontrol eden bir program yazın. Eğer yaş 0 veya negatifse, throw kullanarak özel bir hata fırlatın ve bunu catch bloğunda yakalayın.

             8. Birden Fazla Catch Kullanarak Farklı Hata Türlerini Ayırma: Bir int dizi oluşturun ve kullanıcıdan bir indeks isteyin. Kullanıcı geçersiz bir indeks girerse IndexOutOfRangeException, harf girerse FormatException yakalayan bir try-catch bloğu oluşturun.

             9. Try-Catch ile Loglama ve Yeniden Deneme Mekanizması: Kullanıcıdan bir dosya adı alarak dosyanın içeriğini okumaya çalışan bir program yazın. Dosya okunamazsa, hatayı yakalayıp bir log dosyasına kaydedin ve kullanıcıya 3 kez tekrar deneme hakkı verin.        
             
             */
            #endregion

            #region TryCatch Hata Yönetimi cevapları

            Console.WriteLine("*** TryCatch Hata Yönetimi Soru Cevapları ***");
            Console.WriteLine("1.SORU");
            try
            {
                Console.Write("Birinci sayıyı girin: ");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.Write("İkinci sayıyı girin: ");
                int sayi2 = int.Parse(Console.ReadLine());
                int sonuc = sayi1 / sayi2;
                Console.WriteLine($"Sonuç: {sonuc}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Bir sayı sıfıra bölünemez!");
            }
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("2. SORU");
            try
            {
                int[] dizi = { 10, 20, 30, 40, 50 };
                Console.WriteLine("Bir indeks girin: ");
                int indeks = int.Parse(Console.ReadLine());
                Console.WriteLine($"Seçilen eleman: {dizi[indeks]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Hatalı indeks girdiniz!");
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("3. SORU");
            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                Console.WriteLine($"Girdiğiniz sayı: {sayi}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz format! Lütfen bir sayı girin!");
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("4. SORU");
            try
            {
                Console.WriteLine("Dosya adını girin: ");
                string dosyaAdi = Console.ReadLine();
                string icerik = File.ReadAllText(dosyaAdi);
                Console.WriteLine("Dosya içeriği: ");
                Console.WriteLine(icerik);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Belirtilen dosya bulunamadı!");
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("5. SORU");
            try
            {
                Console.WriteLine("Bir tam sayı girin: ");
                int sayi = int.Parse(Console.ReadLine());
                List<int> sayilar = new List<int>();
                sayilar.Add(sayi);
                Console.WriteLine("Sayı listeye  eklendi.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz format! Sayı girilmelidir.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Girilen değer çok büyük ya da çok küçük!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Beklenmeyen hata: {ex.Message}");
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("6. SORU");
            try
            {
                Console.Write("Birinci sayıyı girin: ");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.Write("İkinci sayıyı girin: ");
                int sayi2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Bölme Sonucu: {sayi1 / sayi2}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Sıfıra bölme hatası!");
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("7. SORU");
            try
            {
                Console.Write("Yaşınızı girin: ");
                int yas = int.Parse(Console.ReadLine());
                if (yas <= 0)
                    throw new Exception("Yaş negatif veya sıfır olamaz!");
                Console.WriteLine($"Girdiğiniz yaş: {yas}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("8. SORU");
            try
            {
                int[] sayilar = { 5, 10, 15 };
                Console.Write("Bir indeks girin: ");
                int indeks = int.Parse(Console.ReadLine());
                Console.WriteLine($"Seçilen eleman: {sayilar[indeks]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Hatalı indeks girdiniz!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Sayı formatında giriş yapmalısınız!");
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("9. SORU");
            int denemeHakki = 3;
            while (denemeHakki > 0)
            {
                try
                {
                    Console.Write("Dosya adını girin: ");
                    string dosyaAdi = Console.ReadLine();
                    string icerik = File.ReadAllText(dosyaAdi);
                    Console.WriteLine("Dosya içeriği:");
                    Console.WriteLine(icerik);
                    break;
                }
                catch (FileNotFoundException ex)
                {
                    File.AppendAllText("log.txt", $"Hata: {ex.Message}\n");
                    Console.WriteLine("Dosya bulunamadı, tekrar deneyin.");
                    denemeHakki--;
                }
            }
            if (denemeHakki == 0)
            {
                Console.WriteLine("Tüm deneme haklarınız tükendi!");
            }
            #endregion
        }
    }
}
