using System;

class Program
{
    static void Main()
    {
        // Define an array
        int[] numbers = {-2,1,-3,4,-1,2,1,-5,4};

        // Call the method and pass the array
        int result = MaxSubarrayFunc(numbers);

        // Print the result
        Console.WriteLine("max value of subarray: " + result);
    }
    public static int MaxSubarrayFunc(int[] arr){
        int max = Int32.MinValue;
        int sum = 0;
        for(int i=0;i<arr.Length;i++){
            sum += arr[i];
            max = Math.Max(sum,max);
            if(sum<0) sum=0;
        }
        return max;
    }
}
