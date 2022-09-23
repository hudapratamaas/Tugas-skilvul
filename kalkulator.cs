using System;
namespace kalkulator 
{

    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Masukan action yang diinginkan :");
            Console.WriteLine("Tekan 1 Penambahan");
            Console.WriteLine("Tekan 2 Pengurangan");
            Console.WriteLine("Tekan 3 Perkalian");
            Console.WriteLine("Tekan 4 Pembagian");
            int pilihan = int.Parse(Console.ReadLine());
            
            switch (pilihan) {
                case 1: 
                Console.WriteLine("Masukan angka pertama"); 
                int angka1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Masukan angka kedua"); 
                int angka2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil : {0}", angka1 + angka2);
                break;

                case 2: 
                Console.WriteLine("Masukan angka pertama"); 
                int angka3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Masukan angka kedua"); 
                int angka4 = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil : {0}", angka3 - angka4);
                break;

                case 3: 
                Console.WriteLine("Masukan angka pertama"); 
                int angka5 = int.Parse(Console.ReadLine());
                Console.WriteLine("Masukan angka kedua"); 
                int angka6 = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil : {0}", angka5 * angka6);
                break;

                case 4: 
                Console.WriteLine("Masukan angka pertama"); 
                int angka7 = int.Parse(Console.ReadLine());
                Console.WriteLine("Masukan angka kedua"); 
                int angka8 = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil : {0}", angka7 / angka8);
                break;

            }

            Console.ReadKey();
            
        }
    
    }

}