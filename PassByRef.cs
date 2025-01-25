using System;
class PassByRef{
	public static void Main(){
		int value = 10;
		Increment(ref value);
		Console.WriteLine(value);
	}
	public static void Increment(ref int value){
		value+=1;
		Console.WriteLine(value);
	}
}