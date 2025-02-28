namespace While_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                1. 1'den 10'a kadar olan sayıları ekrana yazdıran bir while döngüsü yazın.
                2. Kullanıcıdan bir sayı alarak, 1'den bu sayıya kadar olan çift sayıları ekrana yazdıran bir while döngüsü yazın.
                3. 1'den 100'e kadar olan sayıların toplamını hesaplayan bir while döngüsü yazın.
                4. Kullanıcıdan bir sayı alarak, bu sayının faktöriyelini hesaplayan bir while döngüsü yazın.
                5. Kullanıcıdan bir metin alıp, bu metni while döngüsü kullanarak tersten yazdırın.
                6. 1 ile 50 arasındaki tek sayıların toplamını hesaplayan bir while döngüsü yazın.
                7. Girilen bir sayının asal olup olmadığını kontrol eden bir while döngüsü yazın.
                8. Kullanıcıdan sürekli olarak sayı alıp, toplamları 100’ü geçene kadar devam eden bir while döngüsü yazın.
                9. Bir dizi içerisindeki en büyük elemanı bulan bir while döngüsü yazın.
               10. Kullanıcının belirttiği satır sayısına göre yıldızlardan oluşan bir üçgen şekli çizen bir while döngüsü yazın. (Örnek: 5 satır için)
                    *
                    **
                    ***
                    ****
                    *****            
             */

            // 1.SORU
            int sayi1 = 1;
            while (sayi1 <= 10)
            {
                Console.WriteLine(sayi1);
                sayi1++;
            }


            // 2.SORU
            Console.Write("Bir sayı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= sayi2)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }


            // 3.SORU
            int toplam = 0;
            int sayi3 = 1;
            while (sayi3 <= 100)
            {
                toplam += sayi3;
                sayi3++;
            }
            Console.Write($"1'den 100'e kadar olan sayıların toplamı: {toplam}");


            // 4.SORU
            Console.Write("Faktöriyeli alınacak sayıyı giriniz: ");
            int sayi4 = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            int i = sayi4;
            while (i > 1)
            {
                faktoriyel *= i;
                i--;
            }
            Console.WriteLine($"{sayi4}! = {faktoriyel}");


            // 5.SORU
            Console.WriteLine("Bir metin giriniz: ");
            string metin = Console.ReadLine();
            int i = metin.Length - 1;
            Console.Write("Tersten: ");

            while (i >= 0)
            {
                Console.Write(metin[i]);
                i--;
            }


            // 6.SORU
            int toplam = 0;
            int i = 1;
            while (i <= 50)
            {
                if (i % 2 != 0)
                {
                    toplam += i;
                }
                i++;
            }
            Console.WriteLine("1 ile 50 arasındaki tek sayıların toplamı: " + toplam);


            // 7.SORU
            Console.Write("Bir sayı giriniz: ");
            int sayi7 = Convert.ToInt32(Console.ReadLine());

            if (sayi7 < 2)
            {
                Console.WriteLine("Asal sayı değil.");
                return;
            }

            int bolen = 2;
            bool asal = true;

            while (bolen <= sayi7 / 2)
            {
                if (sayi7 % bolen == 0)
                {
                    asal = false;
                    break;
                }
                bolen++;
            }

            Console.WriteLine(asal ? $"{sayi7} bir asal sayıdır." : $"{sayi7} asal sayı değildir.");



            // 8.SORU
            int toplam = 0;

            while (toplam <= 100)
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi8 = Convert.ToInt32(Console.ReadLine());

                toplam += sayi8;

                Console.WriteLine($"Güncel toplam: {toplam}");
            }
            Console.WriteLine("Toplam 100 ü geçti. Program sona erdi.   ");



            // 9.SORU
            int[] sayilar = { 40, 50, 10, 20, 30, 5, 1, 15 };
            int index = 1; // İlk eleman zaten max olarak kabul edildiği için 1’den başlıyoruz
            int enBuyuk = sayilar[0]; // İlk elemanı başlangıçta en büyük kabul ediyoruz.

            while (index < sayilar.Length)
            {
                if (sayilar[index] > enBuyuk)
                {
                    enBuyuk = sayilar[index]; // Daha büyük bir sayı bulunursa güncellenir.
                }
                index++; // İndeksi arttırarak sıradaki elemana geçiyoruz.
            }
            Console.WriteLine($"Dizideki en büyük eleman: {enBuyuk}");



            // 10.SORU
            Console.WriteLine("Kaç satır olsun? ");
            int satirSayisi = Convert.ToInt32(Console.ReadLine());

            int satir = 1; // Başlangıç satırı

            while (satir <= satirSayisi)
            {
                // Yıldızları arttır
                int yildiz = 1;
                while (yildiz <= satir)
                {
                    Console.Write("*");
                    yildiz++;
                }
                Console.WriteLine(); // Yeni satıra geç
                satir++;
            }

        }
    }
}
