using System;

class Program
{
    static void Main()
    {
        Bai1();
        Bai2();
        Bai3();
        Bai4();
        Bai5();
        Bai6();
        Bai7();
        Bai8();
        Bai9();
        Bai10();
    }

    // 1. Sum Two Numbers
    static void Bai1()
    {
        int a = 5, b = 10;
        Console.WriteLine("Bai 1 - Sum = " + (a + b));
    }

    // 2. Swap Values
    static void Bai2()
    {
        int a = 5, b = 10;
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("Bai 2 - a = " + a + ", b = " + b);
    }

    // 3. Multiply Floating Numbers
    static void Bai3()
    {
        float x = 2.5f, y = 4.2f;
        Console.WriteLine("Bai 3 - Result = " + (x * y));
    }

    // 4. Feet to Meter
    static void Bai4()
    {
        double feet = 10;
        double meters = feet * 0.3048;
        Console.WriteLine("Bai 4 - Meters = " + meters);
    }

    // 5. Celsius ↔ Fahrenheit
    static void Bai5()
    {
        double c = 25;
        double f = (c * 9 / 5) + 32;
        Console.WriteLine("Bai 5 - Fahrenheit = " + f);

        double f2 = 77;
        double c2 = (f2 - 32) * 5 / 9;
        Console.WriteLine("Bai 5 - Celsius = " + c2);
    }

    // 6. Size of Data Types
    static void Bai6()
    {
        Console.WriteLine("Bai 6 - int: " + sizeof(int));
        Console.WriteLine("Bai 6 - float: " + sizeof(float));
        Console.WriteLine("Bai 6 - double: " + sizeof(double));
        Console.WriteLine("Bai 6 - char: " + sizeof(char));
        Console.WriteLine("Bai 6 - bool: " + sizeof(bool));
    }

    // 7. ASCII Value
    static void Bai7()
    {
        Console.Write("Bai 7 - Enter a character: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine("\nASCII = " + (int)ch);
    }

    // 8. Area of Circle
    static void Bai8()
    {
        double r = 5;
        double area = Math.PI * r * r;
        Console.WriteLine("Bai 8 - Area of Circle = " + area);
    }

    // 9. Area of Square
    static void Bai9()
    {
        double side = 4;
        Console.WriteLine("Bai 9 - Area of Square = " + (side * side));
    }

    // 10. Days to Years, Weeks, Days
    static void Bai10()
    {
        int totalDays = 800;
        int years = totalDays / 365;
        int remaining = totalDays % 365;
        int weeks = remaining / 7;
        int days = remaining % 7;

        Console.WriteLine("Bai 10 - Years: " + years);
        Console.WriteLine("Bai 10 - Weeks: " + weeks);
        Console.WriteLine("Bai 10 - Days: " + days);
    }
}