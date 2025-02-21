// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        // double x = 6/4;
        string s = "123.34.45";
        double res;
        Console.WriteLine(double.TryParse(s,out res));
        Console.WriteLine(res);
        
    }
}