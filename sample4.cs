using System;
					
public class Program
{
	public static void Main()
	{
		int x = 7;
		int y = 27;
		int temp = x;
		
		x = y;
		y = temp;
		
		Console.WriteLine("The value of x is " +  x);
		Console.WriteLine("The value of y is " + y);
		
		
		
	}
}
