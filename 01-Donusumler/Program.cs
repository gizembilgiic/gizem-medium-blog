namespace _01_Donusumler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Implicit Cast (Kapalı Dönüşüm)
            int kucukSayi = 42;
            double buyukSayi = kucukSayi;   // int -> double dönüşümü
            Console.WriteLine(buyukSayi);   // Çıktı : 42
            Console.WriteLine(buyukSayi.ToString("F1")); // Çıktı : 42.0
            Console.WriteLine(buyukSayi.ToString("F3")); // Çıktı : 42.000 
            #endregion

            #region 2. Explicit Cast (Açık Dönüşüm)
            double ondalikliSayi = 42.58;
            int tamSayi = (int)ondalikliSayi;   // double -> int dönüşümü 
            Console.WriteLine(tamSayi);         // Çıktı: 42 
            #endregion

            #region 3. Type Conversion Methods
            // Convert ile Dönüşüm
            string metin1 = "123";
            int sayi1 = Convert.ToInt32(metin1);
            Console.WriteLine(sayi1);    // Çıktı: 123

            // Parse ve TryParse
            string metin2 = "456";
            bool basarili = int.TryParse(metin2, out int sayi2);

            if (basarili)
                Console.WriteLine($"Başarılı dönüşüm: {sayi2}");
            else
                Console.WriteLine("Dönüşüm başarısız!");
            #endregion
        }
    }
}
