using System;

class Program
{
    static void Main()
    {
        double a = 5, b = 10, c = 15;
        double average = (a + b + c) / 3;
        Console.WriteLine($"Średnia: {average}");

        // New method -> feature-max
        int[] numbers = { 5, 10, 20, 100, 15, 25 };
        int maxValue = FindMaxValue(numbers);
        Console.WriteLine($"Maksymalna wartość: {maxValue}");
    }

    static int FindMaxValue(int[] numbers)
    {
        int max = numbers[0]; // indeks 0 jako początkowa wartość
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num; // jeśli istnieje większa wartość, nadpisz
            }
        }
        return max;
    }
}
