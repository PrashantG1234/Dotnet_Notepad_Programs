using System;
public delegate void ArithmeticDelegate(int a,int b);
class ArithOperations{
    public void sum(int a,int b){
        Console.WriteLine("sum is :"+(a+b));
    }
    public void sub(int a,int b){
        Console.WriteLine("subtraction is :"+(a-b));
    }
    public void mul(int a,int b){
        Console.WriteLine("mul is :"+(a*b));
    }
}
class DelegateDemo{
    public static void  Main(){
        ArithOperations ao = new ArithOperations();
        ArithmeticDelegate ad1 = new ArithmeticDelegate(ao.sum);
        ad1(2,3);
        ArithmeticDelegate ad2 = new ArithmeticDelegate(ao.sub);
        ad2(9,3);
        ArithmeticDelegate ad3 = new ArithmeticDelegate(ao.mul);
        ad3(4,5);
        
    }
}