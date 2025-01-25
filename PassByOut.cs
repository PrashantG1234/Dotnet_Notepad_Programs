using System;
class PassByRef{
	public static void Main(){
		int value = 10;
		Increment(out value);
		Console.WriteLine(value);
	}
	public static void Increment(out int value){
		value=1;
		Console.WriteLine(value);
	}
}