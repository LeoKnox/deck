using System;
using System.Collections.Generic;


public class Program
{
	public static void Main()
	{
		Deck d = new Deck();
        //System.Console.WriteLine(d.Cards[0]);
        d.Shuffle();
        //System.Console.WriteLine(d.deal());
        Player p = new Player("Ted");
        p.DrawHand(d);
        p.Show();
        System.Console.WriteLine(p.Discard());        
        System.Console.WriteLine(p.Discard());        
	}
}