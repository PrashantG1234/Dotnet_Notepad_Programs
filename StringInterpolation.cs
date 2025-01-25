using System;
class StringInterpolation{
	static void Main(){
		string name = "John"; 
		int age = 30;
		string greeting = $"Hello, my name is {name} and I am {age} years old.";
		Console.WriteLine(greeting); // Output: Hello, my name is John and I am 30 years old.
	 }
}