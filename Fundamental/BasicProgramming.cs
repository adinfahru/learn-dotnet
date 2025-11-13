namespace Fundamental;

using System;

// VOID vs RETURN
// Return untuk bisnis logic yang mengembalikan nilai
// Void untuk prosedur yang tidak mengembalikan nilai


public class BasicProgramming
{

    
    // static void Main(string[] args) // Entry point of the application

    // static : dapat diakses tanpa membuat instance dari kelas
    // void : tidak mengembalikan nilai apapun
    // string[] args : parameter yang menerima argumen dari command line

    // VOID - Hanya print
    public static void PrintName(string name)
    {
        Console.WriteLine("Name: " + name);
    }

    // VOID - Print dengan parameter multiple
    public static void PrintAge(int age)
    {
        Console.WriteLine($"Age: {age}");
    }

    // RETURN - Return string
    public static string FullName(string firstName, string lastName)
    {
        return firstName + " " + lastName;
    }

    // VOID - Print full name
    public static void PrintFullName(string firstName, string lastName)
    {
        Console.WriteLine(firstName + " " + lastName);
    }

    // VOID - If else demo
    public static void CheckAge(int age)
    {
        if (age > 21)
        {
            Console.WriteLine("You are older than 21.");
        }
        else
        {
            Console.WriteLine("You are 21 or younger.");
        }
    }

    // RETURN - Get category
    public static string GetAgeCategory(int age)
    {
        return age > 21 ? "Older than 21" : "21 or younger";
    }

    // VOID - Print days dengan switch
    public static void PrintDay(int day)
    {
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("Another day");
                break;
        }
    }

    // VOID - Print even numbers dengan for loop
    public static void PrintEvenNumbers()
    {
        for (int i = 1; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    // VOID - While loop demo
    public static void WhileLoopDemo()
    {
        int count = 0;
        while (count < 3)
        {
            Console.WriteLine("Count: " + count);
            count++;
        }
    }

    // Main demo method
    public static void RunDemo()
    {
        Console.WriteLine("========== LATIHAN ==========\n");

        // Variables & Types
        string name = "Fahru";
        PrintName(name);

        int age = 21;
        PrintAge(age);

        age = age + 1;
        PrintAge(age);

        // If Else
        CheckAge(age);

        // Ternary
        string message = GetAgeCategory(age);
        Console.WriteLine("Message: " + message);

        // Switch
        int day = 4;
        PrintDay(day);

        // For Loop
        Console.WriteLine("\nEven numbers:");
        PrintEvenNumbers();

        // While Loop
        Console.WriteLine("\nWhile loop:");
        WhileLoopDemo();

        // Return String
        Console.WriteLine("\nFull Name (Return):");
        Console.WriteLine(FullName("Fahru", "Non"));

        // Void Print
        Console.WriteLine("Full Name (Void):");
        PrintFullName("Fahru", "Void");
    }
}