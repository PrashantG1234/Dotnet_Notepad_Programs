using System;
class StringFormatting{
	public static void Main(string[] args){
		 
		try{
			int i1 = int.Parse(args[0]);
			int i2 = int.Parse(args[1]);
			Console.WriteLine("Sum of {0} and {1} is {2}",i1,i2,(i1+i2));
		}catch(IndexOutOfRangeException ex){
			Console.WriteLine(ex.Message);
		}catch(FormatException ex){
			Console.WriteLine(ex.Message);
		}finally{ 
			Console.WriteLine("in finally"); 
		}
		 Console.WriteLine("response from API"); 
	}
}