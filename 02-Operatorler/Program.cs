namespace _02_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** İlişkisel Operatörler ***");

            int a = 5;
            int b = 10;
            Console.WriteLine(a > b);  // False
            Console.WriteLine(a < b);  // True
            Console.WriteLine(a != b); // True
            Console.WriteLine(a == b); // False
            Console.WriteLine(a <= b); // True
            Console.WriteLine(a >= b); // False


            Console.WriteLine("*** Atama Operatörü ***");
            int x = 5;
            x += 3; // x artık 8 oldu!
            Console.WriteLine(x);


            Console.WriteLine("*** Aritmetik Operatörler ***");
            int sayi = 10;
            Console.WriteLine(sayi + 5);  // 15
            Console.WriteLine(sayi % 3);  // 1 (kalan)
            sayi++;
            Console.WriteLine(sayi);      // 11


            Console.WriteLine("*** Mantıksal Operatörler ***");
            bool durum = (10 > 5) && (5 < 3); // False
            Console.WriteLine(!durum);       // True


            Console.WriteLine("*** Ternary Operatörü ***");
            int number = 15;
            string mesaj = (number < 10) ? "Sayı 10'dan küçük" : "Sayı 10 veya daha büyük";
            Console.WriteLine(mesaj);
        }
    }
}
