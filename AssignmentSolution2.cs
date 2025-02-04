using System;
public class AssignmentSolution2{
    public static void Main(){
        // string str = Console.ReadLine();
        // Console.WriteLine(ReverseString(str));
        Console.WriteLine("Enter size:");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter elements of given size:");
        int[] arr = new int[s];
        for(int i=0;i<arr.Length;i++){
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("sec smallest ele: "+ (SecondSmallestElement(arr)));
    }
    public static string ReverseString(string str){
        char[] strArr = str.ToCharArray();
        int i=0,j=strArr.Length-1;
        while(i<j){
            char temp = strArr[i];
            strArr[i] =  strArr[j];
            strArr[j] = temp;
            i++;
            j--;
        }
    return new string(strArr);
    }
    public static int SecondSmallestElement(int[] arr){
        int smallest = arr[0],sec = int.MaxValue;
        foreach(int x in arr){
            if(x<smallest){
                sec = smallest;
                smallest = x;
            }else if(x < sec && smallest>x){
                sec = x;
            }
        }
        return sec;
    }
}