using System;

class Program
{
    static void Main()
    {

	Console.WriteLine("Modyfikacja 1: Cześć, World! :) ");
	Console.WriteLine("Modyfikacja 2: Co tam słychać?");
	Console.WriteLine("Modyfikacja 3: What's up?");

        double a = 2, b = 4, c = 6;
        double average = (a + b + c) / 3;
        Console.WriteLine($"Średnia: {average}");
    
	// New method -> feature-max
	int[] numbers = { 5, 10, 20, 100, 15, 25};
	int maxValue = FindMaxValue(numbers);
	Console.WriteLine($"Maksymalna wartość: {maxValue});
	}

	static int FindMaxValue(int[] numbers)
	{
		int max = numbers[0]; // indeks 0 jako pocz. wartość
		foreach (int num in numbers)
		{
			if (num > max)
			{
				max = num; // jeśli istnieje większa, nadpisz
			}
		}
	return max;
	}
}
}
