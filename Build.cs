using System;
using System.Collections.Generic;

public class Deck
{
	public List<Card> Cards = new List<Card>();
    public Deck()
    {
        Reset();
    }
	public void Reset ()
	{
		for(var i = 0; i < 4; i++) 
		{
			for(var j = 1; j <14; j++) 
			{
		        Card eCard = new Card();
				if (i == 0) {
					eCard.suit = "Spades";
				} else if (i == 1) {
					eCard.suit = "Diamonds";
				} else if (i == 2) {
					eCard.suit = "Clubs";
				} else {
					eCard.suit = "Hearts";
				}
				if (j == 1) {
					eCard.stringVal = "Ace";
				} else if (j == 11) {
					eCard.stringVal = "Jack";
				} else if (j == 12) {
					eCard.stringVal = "Queen";
				} else if (j == 13) {
					eCard.stringVal = "King";
				} else {
					eCard.stringVal = j.ToString();
				}
				eCard.val = j;
                System.Console.WriteLine(eCard.val);
			    Cards.Add(eCard);
			}
		}
    }

    public Card deal() {
        if (Cards.Count > 0) {
            Card temp = new Card();
            temp = Cards[0];
            Cards.RemoveAt(0);
            return(temp);
        } else {
            return(null);
        }
    }

    public void Shuffle()
    {
        Random rnd = new Random();
        for (int i = 0; i < 220; i++) {
            int x = rnd.Next(52);
            Cards.Add(Cards[x]);
            Cards.RemoveAt(x);
        }
    }
}
