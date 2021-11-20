using System;
					
public class Program
{
	public static void Main()
	{

		int numberOne = 2, numberTwo = 9, numberThree = 1;
		int temp;
		
		if (numberTwo < numberOne && numberTwo < numberThree){
			temp = numberTwo;
			numberTwo = numberOne;
			numberOne = temp;
			if (numberThree < numberTwo){
				temp = numberThree;
				numberThree = numberTwo;
				numberTwo = temp;
			}
		}
		else if (numberThree < numberOne && numberThree < numberTwo){
			temp = numberThree;
			numberThree = numberOne;
			numberOne = temp;
			
			if (numberThree < numberTwo){
				temp = numberThree;
				numberThree = numberTwo;
				numberTwo = temp;
			}
		}
		Console.WriteLine("The numbers in descending order: ");
		Console.WriteLine(numberOne + ", " + numberTwo + ", " + numberThree);

}
}
