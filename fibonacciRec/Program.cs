using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciRec
{
    class Program
    {
        
        static double fibonacciRecursive(int sayi) 
        {
            sayi--;
            if (sayi == 1 || sayi == 0) 
            {
                return 1;
            }
            return fibonacciRecursive(sayi) + fibonacciRecursive(sayi-1);
        }
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();//Sonucu bulana kadar geçen zamanı öğrenebilmek için bir stopwatch nesnesi yaratıldı. 
            int kacinciFib;
            Console.Write("Kacinci fibonacci sayisi hesaplansin : ");
            kacinciFib = Int32.Parse(Console.ReadLine());
            watch.Start(); // süre başlatıldı.
            Console.WriteLine(""+fibonacciRecursive(kacinciFib)); // işlemler başlatıldı.
            watch.Stop();// işlem bittiği anda süre durduruldu.
            TimeSpan ts = watch.Elapsed; // süreyi ekrana yazdırabilmek için zaman dilimi (TimeSpan) nesnesi watch nesnesi ile ilişkilendirildi.
            Console.WriteLine("Saat : " + ts.Hours + "       Dakika : "+ts.Minutes+"        Saniye : "+ts.Seconds+"      Milisaniye : "+ts.Milliseconds);
            Console.WriteLine("Toplam milisaniye : "+ts.TotalMilliseconds); // Sonucu bir de toplam milisaniye şeklinde gösteriliyor.
            Console.ReadKey();// Ekrana basılan sonucun görülebilmesi için kullandım. Kullanıcı bir tuşa basınca program otomatik kapanır.
        }
    }
}
