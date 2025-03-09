using System;
using System.Threading;
public class MainClass{
	public static void Main(){
        Thread t1 = new Thread(Method1){
            Name = "Thread1"
        };
        t1.Start(5); // not type safe manner 
        //t1.Start("HI"); // this will give runtime error
        t1.Join();
    }
    static void Method1(object n){
        Console.WriteLine($"method1 running on {Thread.CurrentThread.Name}");
        int m = (int) n;
       for (int i = 1; i <= m; i++)
        {
            Console.WriteLine("Method1 :" + i);
        }
        Console.WriteLine("method1 ended on " + Thread.CurrentThread.Name);
    }

}
		
