public static class Renderer
{
    public static void RenderCard(Card card)
    {

        if (card.IsJoker)
        {
            return;
        }

        string rankSymbol = GetRankSymbol(card.Rank);
        string suitSymbol = GetSuitSymbol(card.Suit);

        Console.WriteLine("     ┌─────────────┐");
        Console.WriteLine($"     │{rankSymbol.PadRight(13)}│");
        Console.WriteLine($"     │{suitSymbol.PadRight(13)}│");
        Console.WriteLine("     │             │");
        Console.WriteLine($"     │{suitSymbol.PadLeft(7).PadRight(13)}│");
        Console.WriteLine("     │             │");
        Console.WriteLine($"     │{suitSymbol.PadLeft(13)}│");
        Console.WriteLine($"     │{rankSymbol.PadLeft(13)}│");
        Console.WriteLine("     └─────────────┘");
        Console.WriteLine($"     {card.Rank} of {card.Suit}".PadLeft(7).PadRight(13));
    }

    private static string GetRankSymbol(Rank? rank)
    {
        return rank switch
        {
            Rank.Ace => "A",
            Rank.Two => "2",
            Rank.Three => "3",
            Rank.Four => "4",
            Rank.Five => "5",
            Rank.Six => "6",
            Rank.Seven => "7",
            Rank.Eight => "8",
            Rank.Nine => "9",
            Rank.Ten => "10",
            Rank.Jack => "J",
            Rank.Queen => "Q",
            Rank.King => "K",
            _ => "?"
        };
    }

    private static string GetSuitSymbol(Suit? suit)
    {
        return suit switch
        {
            Suit.Clubs => "♣",
            Suit.Spades => "♠",
            Suit.Hearts => "♥",
            Suit.Diamonds => "♦",
            _ => "?"
        };
    }
}