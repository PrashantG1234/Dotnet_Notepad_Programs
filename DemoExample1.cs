using System;
class DemoExample1{
	public static void Main(){
		Console.WriteLine("Provide Credentials i.e name and age");
		string username = Console.ReadLine();
		int age = int.Parse(Console.ReadLine());
		string result = GetUserInfo(username,age);
		Console.WriteLine(result);
	}
	public static string GetUserInfo(string username,int age){
		return "User's name is "+username+" and age is "+age;
	}
}