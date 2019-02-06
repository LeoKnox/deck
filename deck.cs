using System;

public class Card
{
	public string suit;
	public string stringVal;
	public int val;
}

public class Deck
{
	public Deck ()
	{
		for(var i = 0; i < 4; i++) 
		{
			for(var j = 1; j <14; j++) 
			{
				if (i == 0) {
					Card.suit = "Spades";
				} else if (i == 1) {
					Card.suit = "Diamonds";
				} else if (i == 2) {
					Card.suit = "Clubs";
				} else {
					Card.suit = "Hearts";
				}
				if (j == 1) {
					Card.stringVal = "Ace";
				} else if (j == 11) {
					Card.stringVal = "Jack";
				} else if (j == 12) {
					Card.stringVal = "Queen";
				} else if (j == 13) {
					Card.stringVal = "King";
				} else {
					Card.stringVal = j;
				}
				Card.val = j;
			}
			Deck.Add(Card);
		}
	}
}

public class Player
{
	public string Name;
	
				
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}
}