using System;
					
public class Program
{
	public static void Main()
	{
	
		
		Console.WriteLine("Enter a number:");
		int number = int.Parse(Console.ReadLine());
		bool isOdd = number % 2 == 1;
		Console.WriteLine("The number is ODD. True or False?");
		Console.WriteLine("The answer is: " + isOdd);
		
		
	}
}
