namespace For_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*             
                1. 1'den 10'a kadar olan sayıları ekrana yazdıran bir for döngüsü yazın.
                2. Kullanıcıdan bir sayı alarak, 1'den bu sayıya kadar olan çift sayıları ekrana yazdıran bir for döngüsü yazın.
                3. 1'den 100'e kadar olan sayıların toplamını hesaplayan bir for döngüsü yazın.
                4. Kullanıcıdan bir sayı alarak, bu sayının faktöriyelini hesaplayan bir for döngüsü yazın.
                5. Kullanıcıdan bir metin alıp, bu metni for döngüsü kullanarak tersten yazdırın.
                6. 1 ile 50 arasındaki tek sayıların toplamını hesaplayan bir for döngüsü yazın.
                7. Girilen bir sayının asal olup olmadığını kontrol eden bir for döngüsü yazın.
                8. 1'den 5'e kadar çarpım tablosunu ekrana yazdıran bir for döngüsü oluşturun. (Örneğin, 1x1=1, 1x2=2 ...)
                9. Bir dizi içerisindeki en büyük elemanı bulan bir for döngüsü yazın.
               10. Kullanıcının belirttiği satır sayısına göre yıldızlardan oluşan bir üçgen şekli çizen bir for döngüsü yazın. (Örnek: 5 satır için)
                         
                    *
                    **
                    ***
                    ****
                    *****                    
            */


            // 1. SORU:
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }


            // 2. SORU:
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= sayi; i += 2)
            {
                Console.WriteLine(i);
            }


            // 3. SORU:
            int toplam = 0;
            for (int i = 1; i <= 100; i++)
            {
                toplam += i;
            }
            Console.WriteLine($"1'den 100'e kadar olan sayıların toplamı: {toplam}");


            // 4. SORU:
            Console.Write("Faktöriyelini almak istediğiniz sayıyı girin: ");
            int faktoriyelSayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;

            for (int i = 1; i <= faktoriyelSayi; i++)
            {
                faktoriyel *= i;
            }
            Console.WriteLine($"Girilen sayınının faktöriyeli: {faktoriyel}");


            // 5. SORU:
            Console.WriteLine("Bir metin giriniz: ");
            string metin = Console.ReadLine();

            for (int i = metin.Length - 1; i >= 0; i--)
            {
                Console.Write(metin[i]);
            }
            Console.WriteLine();


            // 6. SORU:
            int tekToplam = 0;
            for (int i = 1; i <= 50; i += 2)
            {
                tekToplam += i;
            }
            Console.WriteLine($"1 ile 50 arasındaki tek sayıların toplamı: {tekToplam}");



            // 7. SORU:
            Console.WriteLine("Bir sayı giriniz: ");
            int asalSayi = Convert.ToInt32(Console.ReadLine());
            bool asalMi = true;
            for (int i = 2; i <= asalSayi; i++)
            {
                if (asalSayi % i == 0)
                {
                    asalMi = false;
                    break;
                }
            }
            Console.WriteLine(asalMi ? $"{asalSayi} sayısı asaldır." : $"{asalSayi} sayısı asal sayı değildir.");



            // 8. SORU:
            int carpim = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i + " x " + j + " = " + (i * j) + "\t");
                }
                Console.WriteLine();
            }



            // 9. SORU:
            int[] dizi = { 3, 7, 15, 2, 9, 12 };
            int enBuyuk = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > enBuyuk)
                {
                    enBuyuk = dizi[i];
                }
            }
            Console.WriteLine($"En büyük sayı: {enBuyuk}");



            // 10. SORU
            Console.WriteLine("Yıldızların kaç satır olmasını istersiniz?: ");
            int satir = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= satir; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
