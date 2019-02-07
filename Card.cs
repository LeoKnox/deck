public class Card
{
	public string suit;
	public string stringVal;
	public int val;
	
	public Card()
	{
	}

    public Card(string eSuit, string eval, int ival)
    {
        suit = eSuit;
        stringVal = eval;
        val = ival;
    }

    public override string ToString()
    {
        return $"{stringVal} of {suit}";
    }
}
