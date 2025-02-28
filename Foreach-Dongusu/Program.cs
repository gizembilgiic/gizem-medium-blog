namespace Foreach_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                1. Bir dizide bulunan tüm elemanları ekrana yazdıran bir foreach döngüsü yazın.
                2. Bir liste içinde bulunan şehir isimlerini foreach döngüsü kullanarak ekrana yazdıran bir program yazın.
                3. Bir dizide bulunan sayıların toplamını foreach döngüsü kullanarak hesaplayan bir program yazın.
                4. Bir string dizisinde yer alan kelimeleri büyük harfe çevirip ekrana yazdıran bir foreach döngüsü yazın.
                5. Bir dizideki sayıların karesini alıp ekrana yazdıran bir foreach döngüsü yazın.
                6. Bir kelimenin karakterlerini foreach döngüsü ile ekrana yazdıran bir program yazın.
                7. Bir listede bulunan çift sayıları ekrana yazdıran bir foreach döngüsü yazın.
                8. Bir dizideki en büyük ve en küçük sayıyı bulan bir foreach döngüsü yazın.
                9. Bir öğrencinin aldığı notları içeren bir listeyi foreach döngüsü ile dolaşıp, eğer not 50'den düşükse "Başarısız" diğer durumlarda "Başarılı" yazdıran bir program yazın.
               10. Bir dictionary (sözlük) yapısı kullanarak, öğrencilerin isimleri ve notlarını saklayan ve bu bilgileri foreach döngüsü ile ekrana yazdıran bir program yazın.
             */


            // 1.SORU
            Console.WriteLine("1. SORU: ");
            string[] isimler = { "Ayşe", "Fatma", "Ali", "Veli" };

            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine();


            // 2.SORU
            Console.WriteLine("2. SORU: ");
            List<string> sehirler = new List<string> { "Ankara", "İstanbul", "İzmir", "Bursa", "Antalya" };
            Console.WriteLine("Şehirler Listesi: ");

            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
            Console.WriteLine();


            // 3.SORU
            Console.WriteLine("3. SORU: ");
            int[] sayilar = { 3, 1, 5, 8, 2, 6, 4, 7 };

            int toplam = 0;

            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }
            Console.WriteLine($"Sayılar dizisindeki elemanların toplamı: {toplam}");
            Console.WriteLine();


            // 4.SORU
            Console.WriteLine("4. SORU ");
            string[] kelimeler = { "kalem", "defter", "kitap", "bilgisayar", "programlama", "algoritma" };

            Console.WriteLine("Kelimelerin büyük harfe çevrilmiş hali: ");

            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime.ToUpper());
            }
            Console.WriteLine();


            // 5.SORU
            Console.WriteLine("5. SORU: ");
            int[] sayilarinKaresi = { 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("Sayıların karesinin alınmış hali: ");

            foreach (int sayi in sayilarinKaresi)
            {
                Console.WriteLine(sayi * sayi);
            }
            Console.WriteLine();


            // 6.SORU
            Console.WriteLine("6. SORU: ");
            string kelimeninKarakterleri = "Programlama";

            Console.WriteLine("Programlama kelimesinin karakterleri: ");

            foreach (char karakter in kelimeninKarakterleri)
            {
                Console.WriteLine(karakter);
            }
            Console.WriteLine();


            // 7.SORU
            Console.WriteLine("7. SORU: ");
            int[] ciftSayilar = { 3, 6, 9, 5, 7, 1, 4, 18 };

            foreach (int ciftSayi in ciftSayilar)
            {
                if (ciftSayi % 2 == 0)
                {
                    Console.WriteLine(ciftSayi);
                }
            }
            Console.WriteLine();


            // 8.SORU
            Console.WriteLine("8. SORU: ");
            int[] numbers = { 2, 98, 23, 7, 17, 5, 82, 6 };

            // Başlangıç değerlerini dizinin ilk elemanına atıyoruz.
            int enKucuk = numbers[0];
            int enBuyuk = numbers[0];

            foreach (int number in numbers)
            {
                if (number > enBuyuk)
                    enBuyuk = number; // Eğer daha büyük bir sayı bulursak güncellenir.
                if (number < enKucuk)
                    enKucuk = number; // Eğer daha küçük bir sayı bulursak güncellenir.
            }

            Console.WriteLine($"Dizideki en büyük sayı: {enBuyuk}");
            Console.WriteLine($"Dizideki en küçük sayı: {enKucuk}");
            Console.WriteLine();


            // 9.SORU
            Console.WriteLine("9. SORU: ");
            // Öğrencinin aldığı notlar
            List<int> notlar = new List<int> { 45, 70, 55, 39, 80, 62, 48 };

            // Notları tek tek kontrol ediyoruz.
            foreach (int not in notlar)
            {
                if (not < 50)
                    Console.WriteLine($" {not} - Başarısız");
                else
                    Console.WriteLine($" {not} -Başarılı");
            }
            Console.WriteLine();


            // 10.SORU
            // Öğrencilerin isimleri ve notlarını saklayan Dictionary
            Dictionary<string, int> ogrencilerNotlar = new Dictionary<string, int>()
            {
                { "Ahmet", 85 },
                { "Mehmet", 92 },
                { "Ayşe", 48 },
                { "Fatma", 75 },
                { "Ali", 63 }
            };

            // Sözlükteki her öğeyi dolaşıyoruz
            foreach (var ogrenci in ogrencilerNotlar)
            {
                Console.WriteLine($"{ogrenci.Key} - Notu: {ogrenci.Value}");
            }

        }
    }
}
