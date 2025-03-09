using System;
using System.Threading;
public class MainClass{
	public static void Main(){
        Thread t1 = new Thread(Method1){
            Name = "Thread1"
        };
        Thread t2 = new Thread(Method2){
            Name = "Thread2"
        };
        Thread t3 = new Thread(Method3){
            Name = "Thread3"
        };
        t1.Start();
        t2.Start();
        t3.Start();

    }
    static void Method1(){
        Console.WriteLine($"method1 running on {Thread.CurrentThread.Name}");
       for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Method1 :" + i);
        }
        Console.WriteLine("method1 ended on " + Thread.CurrentThread.Name);
    }
    static void Method3(){
        Console.WriteLine($"method3 running on {Thread.CurrentThread.Name}");
       for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Method3 :" + i);
        }
        Console.WriteLine("method3 ended on " + Thread.CurrentThread.Name);
    }
    static void Method2(){
        Console.WriteLine($"method2 running on {Thread.CurrentThread.Name}");
       for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Method2 :" + i);
            Console.WriteLine("Performing the Database Operation Started");
            //Sleep for 10 seconds
             Thread.Sleep(1000);
             Console.WriteLine("Performing the Database Operation Completed");
        }
        Console.WriteLine("method2 ended on " + Thread.CurrentThread.Name);
    }

}
		
