using System;
					
public class Program
{
	public static void Main()
	{

		int nOne, nTwo, gNumber;
		
		Console.WriteLine("Please enter two numbers.");
		Console.WriteLine("Enter your first number:");
		nOne = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter your second number:");
		nTwo = int.Parse(Console.ReadLine());
		
		if (nOne > nTwo){
			gNumber = nOne;
		}
		else{
			gNumber = nTwo;
		}
		Console.WriteLine("The greater number of the two is " + gNumber);
		
		
		
	}
}
