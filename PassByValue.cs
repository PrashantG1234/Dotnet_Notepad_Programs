using System;
class PassByValue{
	public static void Main(){
		int value = 10;
		Increment(value);
		Console.WriteLine(value);
	}
	public static void Increment(int value){
		value+=1;
		Console.WriteLine(value);
	}
}