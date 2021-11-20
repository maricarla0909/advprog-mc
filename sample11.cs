using System;
					
public class Program
{
	public static void Main()
	{

		int nOne, nTwo, nThree;
		int gNumber = 0;
		
		Console.WriteLine("Please enter two numbers.");
		Console.WriteLine("Enter your first number:");
		nOne = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter your second number:");
		nTwo = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter your third number:");
		nThree = int.Parse(Console.ReadLine());
		
		if (nOne > nTwo && nOne > nThree){
			gNumber = nOne;
		}
		else if(nTwo > nOne && nTwo > nThree){
			gNumber = nTwo;
		}
		else if(nThree > nOne && nThree > nTwo){
			gNumber = nThree;
		}
		
		Console.WriteLine("The greater number of the three is " + gNumber + ".");
		
}
}
