using System;
					
public class Program
{
	public static void Main()
	{
	
		int numberOne, numberTwo, numberThree;
		Console.WriteLine("Please enter three numbers:");
		
		Console.WriteLine("Enter your first numbers:");
		numberOne = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter your second numbers:");
		numberTwo = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter your third numbers:");
		numberThree = int.Parse(Console.ReadLine());
		
		int numsum = numberOne + numberTwo + numberThree;
		
		Console.WriteLine("The sum of the three number is: " + numsum);
		
		
	}
}
