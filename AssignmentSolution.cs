using System;
using System.Collections.Generic;
class DemoExample1{
	public static void Main(){
		Console.WriteLine("Enter Size of first array");
		int[] arr1 = new int[int.Parse(Console.ReadLine())];
		Console.WriteLine("Enter array values of given size");
		for(int i=0;i<arr1.Length;i++){
			arr1[i]=int.Parse(Console.ReadLine());
		}
		Console.WriteLine("Enter Size of second array");
		int[] arr2 = new int[int.Parse(Console.ReadLine())];
		Console.WriteLine("Enter array values of given size");
		for(int i=0;i<arr2.Length;i++){
			arr2[i]=int.Parse(Console.ReadLine());
		}
		Console.WriteLine("Common Array elements are: ");
		foreach(int x in FindCommonElements(arr1, arr2)){
			Console.Write(x+" ");
		}
		//ReverseArray(arr);
		//MoveZerosToEnd(arr);
		/*Console.WriteLine("After moving zero to end");
		for(int i=0;i<arr.Length;i++){
			Console.Write(arr[i]+" ");		
		}
		Console.WriteLine("Enter Range");
		int range = int.Parse(Console.ReadLine());
		Console.WriteLine("Missing Number :"+FindMissingNumber(arr,range));
		*/

		
	}
	public static int FindLargest(int[] arr){
		int largest = arr[0];
		foreach(int temp in arr){
			if(temp>largest){
				largest = temp;
			}
		}
		return largest;
	}
	public static int SecondLargest(int[] arr){
		int largest = arr[0],secLar = int.MinValue;
		foreach(int temp in arr){
			if(temp>=largest){
				largest = temp;
			}else if(temp<largest && temp>secLar){
				secLar=temp;
			}
		}
		return secLar;
	}
	public static bool IsArraySorted(int[] arr){
		bool ans = true;
		int temp = arr[0];
		foreach(int val in arr){
			if(val>=temp){
				temp=val;
			}else{
				ans = false;
			}	
		}
		return ans;
	}
	public static void ReverseArray(int[] arr){
		for(int i=0;i<arr.Length/2;i++){
			int temp = arr[arr.Length-1-i];
			arr[arr.Length-1-i]=arr[i];
			arr[i]=temp;
		}
		Console.WriteLine("Reversed Array with length "+arr.Length);
		for(int i=0;i<arr.Length;i++){
			Console.Write(arr[i]+" ");		
		}

	}
	public static void MoveZerosToEnd(int[] arr){
		int i=0,j=arr.Length-1;
		while(i<j){
			if(arr[i]==0 && arr[j]!=0){
				arr[i]=arr[j];
				arr[j]=0;
				i++;
				j--;
			}else if(arr[j]==0){
				j--;		
			}else{
				i++;
			}
		}	
	}
	public static int FindMissingNumber(int[] arr, int n)
	{	
		int sum=0;
		for(int i=0;i<arr.Length;i++){
			sum+=arr[i];		
		}
	 	return (n*(n+1)/2)-sum;	 
	}
	public  static List<int> FindCommonElements(int[] arr1, int[] arr2){
		List<int> ansList = new List<int>();
		int i=0,j=0;
		while(i<arr1.Length && j<arr2.Length){
			if(arr1[i]==arr2[j]){
				ansList.Add(arr1[i]);
				i++;
				j++;
			}else if(arr1[i]>arr2[j]){
				j++;
			}else{
				i++;
			}
		}
		return ansList;
				
	}


	
}