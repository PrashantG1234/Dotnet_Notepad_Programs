using System; //using is a keyword and System is a namespace to include pre-library files;
class DataTypes{
	public static void Main(){
		Console.WriteLine("Enter the First Number");
		int x = Int32.Parse(Console.ReadLine());
		Console.WriteLine("Enter the Second Number");
		int y = Int32.Parse(Console.ReadLine());
		Console.WriteLine("Addition is:"+(x+y));
	}
}