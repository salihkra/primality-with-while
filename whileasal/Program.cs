using System;

namespace whileasal
{
    class Program
    {
        static void Main(string[] args)
        {  // x sayısı alın bunun asal olup olmadığını bulun x sayısını al while içine kalansız bölünüyor mu bak sonra i değişkeni ata arttır

            Console.WriteLine("Lütfen sayı giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while (x > i )
            {
                if (x % i == 0 )
                {
                    Console.WriteLine(x + " sayısı asal değildir.");
                    break;
                }
                i++;
                if (x == i )
                {
                    Console.WriteLine(x +  " sayısı asaldır.");
                }
            
            }

        }
    }
}
