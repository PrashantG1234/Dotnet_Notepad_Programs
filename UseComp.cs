using System;
public class UseComp{
    static void Main(){
        Company comp = new Company(4000,"EPAM","Hyderabad",1000000.0m);
        Console.WriteLine(comp[0]);
        Console.WriteLine(comp[1]);
        Console.WriteLine(comp[2]);
        Console.WriteLine(comp[3]);
    }
}