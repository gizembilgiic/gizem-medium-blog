namespace _00_ConsoleGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string isim = "Gizem";
            //int yas = 88;
            //double s1 = 4.4;
            //float s2;


            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("isim");
            //Console.WriteLine("İsmi giriniz: ");
            //isim = Console.ReadLine();  //input


            //Console.WriteLine("Yaşı giriniz: ");
            //yas = Convert.ToInt32(Console.ReadLine());  //input
            //Console.WriteLine("Merhaba " + isim);       //output
            //Console.WriteLine("Yaşınız: " + yas);
            //Console.WriteLine($"Yaşınız: {yas}");

            //Console.WriteLine("Sayıyı giriniz: ");
            //s1 = Convert.ToInt32(Console.ReadLine());   //input
            //Console.WriteLine("Yaşınız: " + yas + " sayı: " + s1);



            /* 1.SORU
             * 
             * 5 adet sayının klavyeden alınıp aritmetik ortalamalarının hesaplandığı programı yazın.
             */

            Console.WriteLine("Sayı 1: Giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı 2: Giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı 3: Giriniz:");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı 4: Giriniz:");
            int sayi4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı 5: Giriniz:");
            int sayi5 = Convert.ToInt32(Console.ReadLine());

            double ort = (sayi1 + sayi2 + sayi3 + sayi4 + sayi5) / 5.0;
            Console.WriteLine("Deneme: " + ort);
            Console.WriteLine("Ortalama: " + (sayi1 + sayi2 + sayi3 + sayi4 + sayi5) / 5.0);



            Console.WriteLine("--------------------------------");
            /* 2. SORU
             * 
             * Tam bilet fiyatı => 150 TL,
             * Öğrenci bilet fiyatı => 80 TL
             * olan bir sinemada, kişilerin ödemesi gereken toplam miktarı hesaplayan programı yazın.
             * ÖRN:
             * Öğrenci sayısını giriniz: 
             * 5
             * Yetişkin sayısını giriniz: 
             * 5
             * Ödemeniz gereken toplam miktar:
             * 1150 TL
             */

            Console.WriteLine("Öğrenci sayısını giriniz: ");
            int ogrenciBiletSayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yetişkin sayısını giriniz: ");
            int yetiskinBiletSayisi = Convert.ToInt32(Console.ReadLine());

            double ogrenci = 80 * ogrenciBiletSayisi;
            double yetiskin = 150 * yetiskinBiletSayisi;

            double toplamFiyat = ogrenci + yetiskin;

            Console.WriteLine("Ödemeniz gereken toplam miktar: " + toplamFiyat);




            Console.WriteLine("--------------------------------");
            /* 3. SORU
             * 
             * Yarıçapı verilen bir çemberin alanını ve çevresini hesaplayan programı yazınız.
             * ÖRN:
             * Yarıçapı Giriniz: 4
             * Çevre: 25,1428
             * Alan: 50,2857
             */

            Console.WriteLine("Yarıçapı giriniz: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double cevre = 2 * r * (22 / 7.0);

            double alan = (22 / 7.0) * r * r;

            Console.WriteLine("Çevre: " + cevre + " Alan: " + alan);




            Console.WriteLine("--------------------------------");
            /* 4. SORU
             * 
             * Klavyeden girilen 2 sayının karelerinin toplamını hesaplayan programı yazınız.
             * (birincinin karesi + ikincinin karesi)
             */

            Console.WriteLine("Birinci sayıyı giriniz: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int sonuc = (n1 * n1) + (n2 * n2);
            Console.WriteLine("Klavyeden girilen iki sayının kareleri toplamı: " + sonuc);




            Console.WriteLine("--------------------------------");
            /* 5. SORU
             * Doğum yılı girilen yaşını hesaplayan programı yazınız.
             */

            Console.WriteLine("Doğum yılınızı giriniz: ");
            int dogumYili = Convert.ToInt32(Console.ReadLine());
            int yas = 2024 - dogumYili;
            Console.WriteLine("Yaşınız: " + yas);
        }
    }
}
