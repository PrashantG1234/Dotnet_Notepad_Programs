using System;
using System.Collections.Generic;

class Yield
{
    static IEnumerable<int> Fibonacci(int count)
    {
        int a = 0, b = 1;
        for (int i = 0; i < count; i++)
        {
            yield return a; // Return current value and pause
            int temp = a;
            a = b;
            b = temp + b;
        }
    }
    public static IEnumerable<int> GetNumbers()
    {
        yield return 1;
        Console.WriteLine("Returned 1");
         yield return 2;
        Console.WriteLine("Returned 2");
         yield return 3;
        Console.WriteLine("Returned 3");
         yield return 4;
        Console.WriteLine("Returned 4"); 
        yield return 5;
        Console.WriteLine("Returned 5");
    }


static void Main()
{
    foreach (var num in Fibonacci(10))
    {
        Console.WriteLine(num);
    }
    foreach (int number in GetNumbers())
    {
        Console.WriteLine(number);
    }
}
}