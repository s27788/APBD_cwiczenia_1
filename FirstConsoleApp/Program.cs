using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Modyfikacja 1: Cześć, World! :) ");
        Console.WriteLine("Modyfikacja 2: Co tam słychać?");
        Console.WriteLine("Modyfikacja 3: What's up?");

        double a = 5, b = 10, c = 15;
        double average = (a + b + c) / 3;
        Console.WriteLine($"Średnia: {average}");
    
        // New method -> feature-max
        int[] values = { 5, 10, 20, 100, 15, 25 };
        int maxValue = FindMaxValue(values);
        Console.WriteLine($"Maksymalna wartość: {maxValue}");
    }

    static int FindMaxValue(int[] values)
    {
        int max = values[0]; // indeks 0 jako początkowa wartość
        foreach (int num in values)
        {
            if (num > max)
            {
                max = num; // jeśli istnieje większa wartość, nadpisz
            }
        }
        return max;
    }
}
