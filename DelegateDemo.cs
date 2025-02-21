using System;
public delegate void ArithmeticDelegate(int a,int b);
class ArithOperations{
    public void sum(int a,int b){
        Console.WriteLine("sum is :"+(a+b));
    }
    public void sub(int a,int b){
        Console.WriteLine("subtraction is :"+(a-b));
    }
    
}
class DelegateDemo{
    static void mul(int a,int b){
        Console.WriteLine("mul is :"+(a*b));
    } 
    static void Main(string []args){
        ArithmeticDelegate ad1 = new ArithmeticDelegate(new ArithOperations().sum);
        ad1(2,3);
        //using normal function
        ArithmeticDelegate ad2 = mul;
        ad2(4,5);
        //anonymous function taking parameter as a and b
        ArithmeticDelegate ad4 = delegate(int a,int b){
            Console.WriteLine(a*b);
        };
        ad4(2,3);
        // using lambda operator
        ArithmeticDelegate ad3 = (a,b)=> Console.WriteLine(a+" "+b);
        ad3(2,3);
    }
}