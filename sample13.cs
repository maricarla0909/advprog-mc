using System;
					
public class Program
{
	public static void Main()
	{
		
		Console.WriteLine("*All Card in Deck**");
		
		for (int suit = 0; suit < 4; suit++){
			Console.WriteLine("************************");
			for (int cards = 1; cards <= 13; cards++)
			{
				string suitName = "";
				switch (suit){
					case 0:
						suitName = "HEARTS";
						break;
					case 1:
						suitName = "DIAMONDS";
						break;
					case 2:
						suitName = "CLUB";
						break;
					case 3:
						suitName = "SPADES";
						break;
					default:
						break;
				}
				string cardName = cards.ToString();
				switch (cards){
					case 1:
						cardName = "Ace";
						break;
					case 11:
						cardName = "Jack";
						break;
					case 12:
						cardName = "Queen";
						break;
					case 13:
						cardName = "King";
						break;
					default:
						break;
				}
				Console.WriteLine("=====================");
				Console.WriteLine(cardName + " of " + suitName);
			}
	
		}
	
	}

}
