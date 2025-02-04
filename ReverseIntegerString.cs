using System;
public class ReverseIntegerString{
    public static void Main(){
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(ReverseIntegerToString(n));
    }
    public static string ReverseIntegerToString(int n){
        int x = n;
        string ans = "";
        while(n!=0){
            ans+=n%10;
            n /= 10;
        }
        return ans+x.ToString();
    }
}