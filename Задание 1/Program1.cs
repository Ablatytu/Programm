using System;

class Program1
{
    static void Main()
    {
        // Пример 
        int N = 5;
        Console.Write($"N = {N} -> ");
        PrintNaturalNumbers(N);

        N = 8;
        Console.Write($"\nN = {N} -> ");
        PrintNaturalNumbers(N);
    }

    static void PrintNaturalNumbers(int n)
    {
        if (n <= 0)
            return;
        
        Console.Write($"{n}, ");
        PrintNaturalNumbers(n - 1);
    }
}
