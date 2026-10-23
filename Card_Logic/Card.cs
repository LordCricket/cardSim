public class Card
{
    public Rank? Rank {get;}
    public Suit? Suit {get;}
    public bool IsJoker {get;}

    public Card(Rank? rank, Suit? suit, bool isJoker = false)
    {
        Rank = rank;
        Suit = suit;
        IsJoker = isJoker;
    }
}