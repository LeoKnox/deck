using System;
using System.Collections.Generic;

public class Player
{
    public string Name;
    public List<Card> Hand = new List<Card>();
    //Build eDeck = new Build();
	public Player(string eName)
    {
        Name = eName;
    }

    public void DrawHand (Deck eDeck) 
    {
        for (int i = 0; i <  5; i++) {
            Hand.Add(eDeck.deal());
        }
    }

    public void Show(){
        for (int z = 0; z < Hand.Count; z++) {
            System.Console.WriteLine(Hand[z]);
        }
    }

    public Card Discard(){
        Card temp = new Card();
        temp = Hand[Hand.Count-1];
        Hand.RemoveAt(Hand.Count-1);
        return(temp);
    }
}
