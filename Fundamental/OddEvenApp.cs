namespace Fundamental;

using System;
using System.Security.Cryptography;

public class OddEvenApp
{
    /*
    * Menampilkan Menu
    */
    static void Menu()
    {
        Console.WriteLine("===============");
        Console.WriteLine("Menu Ganjil Genap");
        Console.WriteLine("===============");
        Console.WriteLine("1. Cek Ganjil Genap");
        Console.WriteLine("2. Print Ganjil/Genap (dengan limit)");
        Console.WriteLine("3. Exit");
    }

    /*
    * ex: PrintEvenOdd(5, "Genap"') ;
    * output 1, 3, 5
    * x: PrintEvenOdd(5, "Ganjil");
    * output 2, 4
    * @PARAM Limit: Batas akhir. minimal 1, tidak boleh O atau negatif.
    * @PARAM choice: Pilihan, hanya boleh "Even" atau "Odd". Selain itu invalid
    */
    static void PrintEvenOdd(int limit, string choice)
    {

        /* 
        1. Validasi cek limit
        2. Validasi inputan apakah "Ganjil" atau "Genap" 
        3. Loop dari 1 sampai limit (berdasarkan parameter)
        4. Cek setiap angka apakah ganjil/genap sesuai pilihan
        5. Print angka yang sesuai
        */


        if (limit <= 1 && choice == "genap")
        {
            Console.WriteLine("Inputan Invalid ");
            return;
        }

        if (choice != "genap" && choice != "ganjil")
        {
            Console.WriteLine("Choice Invalid");
            return;
        }

        for (int i = 1; i <= limit; i++)
        {
            if (choice == "genap" && i % 2 == 0)
            {
                if (i + 2 > limit)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + ", ");
                }
            }
            else if (choice == "ganjil" && i % 2 != 0)
            {
                if (i + 2 > limit)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + ", ");
                }
            }
        }

    }

    /*
    * ex: EvenOddCheck(5);
    * output "Even"
    * @PARAM input: Angka yang akan dicek. minimal 1, tidak boleh O atau negatif.
    * @RETURN "Genap" jika input genap, "Ganil". jika input ganjil, selain itu Invalid Input!! jika input tidak sesuai pada @PARAM input
    */
    static string CheckEvenOrOdd(int input)
    {

        if (input < 1)
        {
            return "Invalid Input!";
        }

        if (input % 2 == 0)
        {
            return "Genap";
        }
        else if (input % 2 != 0)
        {
            return "Ganjil";
        }

        return "Invalid";
    }

    public static void RunApp()
    {

        bool isRun = true;

        while (isRun)
        {
            Menu();
            Console.Write("Pilih menu: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:

                    try
                    {
                        Console.Write("Masukkan angka: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(CheckEvenOrOdd(input));

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Harus angka");
                    }

                    break;

                case 2:
                    Console.Write("Pilih Ganjil atau Genap: ");
                    string choice = Console.ReadLine() ?? "";
                    string lowerCase = choice.ToLower(); 

                    try
                    {
                        Console.Write("Masukkan limit: ");
                        int limit = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Print bilangan dari 1 - {limit}: ");
                        PrintEvenOdd(limit, lowerCase);
                        Console.WriteLine("");

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Harus angka limitnya");

                    }

                    break;

                case 3:
                    isRun = false;
                    Console.WriteLine("Keluar dari aplikasi");
                    break;

                default:
                    Console.WriteLine("Lu bisa milih yang bener gak sih?");
                    break;
            }
        }
    }
}