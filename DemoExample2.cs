using System;
class DemoExample2{
	public static void Main(){
		int[] arr = new int[5];
		Console.WriteLine("Enter array values of size 5");
		for(int i=0;i<5;i++){
			arr[i]=int.Parse(Console.ReadLine());
		}
		Console.Write("Some of those elements is:");
		int sum=0;
		foreach(int x in arr){
			sum+=x;
		}
		Console.WriteLine(sum);
		Console.WriteLine(arr.GetLength());
	}
}