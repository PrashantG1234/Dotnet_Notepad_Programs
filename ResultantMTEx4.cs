using System;
using System.Threading;
//Since we know that we can't return any return value from a thread function 
//but if we want to get the answer what we can do is use a callback method to
//to get the answer below is the demonstration
public class MainClass{
	public static void Main(){
        //create the resultcallback delegate instance and pass callback the method
        // to get the resultant answer
        ResultCallback resultCallback = new ResultCallback(ResultCallbackMethod);

        //instance of  numberhelper with two parameter
        NumberHelper numberHelper = new NumberHelper(10,resultCallback);
        ThreadStart threadStart = new ThreadStart(numberHelper.SumOfN);
        // type safe manner
        Thread t1 = new Thread(threadStart){
            Name = "Thread1"
        };
        t1.Start();  
        t1.Join();
    }
    //this method will used to print the result
    static void ResultCallbackMethod(int result){
        Console.WriteLine("Result is "+result);
    }
    
}
public delegate void ResultCallback(int result); 
class NumberHelper{
    int _Number;
    ResultCallback _ResultCallback;
    public NumberHelper(int Number, ResultCallback resultCallback){
        _Number = Number;
        _ResultCallback = resultCallback;
    }
    public  void SumOfN(){
       int result = 0;
       for (int i = 1; i <= this._Number; i++)
        {
            result += i;
        }
        this._ResultCallback.Invoke(result);
    }
}
		
