using System;
using System.Threading;
public class MainClass{
	public static void Main(){
        // type safe manner
        Thread t1 = new Thread(new NumberHelper(5).Method1){
            Name = "Thread1"
        };
        t1.Start();  
        t1.Join();
    }
    
}
class NumberHelper{
    int _Number;
    public NumberHelper(int Number){
        _Number = Number;
    }
    public  void Method1(){
        Console.WriteLine($"method1 running on {Thread.CurrentThread.Name}");
       for (int i = 1; i <= this._Number; i++)
        {
            Console.WriteLine("Method1 :" + i);
        }
        Console.WriteLine("method1 ended on " + Thread.CurrentThread.Name);
    }
}
		
