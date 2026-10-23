public static class Renderer
{
    public static void RenderCard(Card card)
    {
        string rankSymbol = GetRankSymbol(card.Rank);
        string suitSymbol = GetSuitSymbol(card.Suit);
        string centerSymbol = card.IsJoker ? "★" : suitSymbol;
        string cardName = card.IsJoker ? "Joker" : $"{card.Rank} of {card.Suit}";
        ConsoleColor cardColor = ConsoleColor.White;

        if (card.Suit == Suit.Hearts || card.Suit == Suit.Diamonds)
        {
            cardColor = ConsoleColor.Red;
        }

        else if (card.IsJoker)
        {
            cardColor = ConsoleColor.Yellow;
        }


        Console.ForegroundColor = cardColor;
        
        Console.WriteLine("     ┌─────────────┐");
        Console.WriteLine($"     │{rankSymbol.PadRight(13)}│");
        Console.WriteLine($"     │{suitSymbol.PadRight(13)}│");
        Console.WriteLine("     │             │");
        Console.WriteLine($"     │{centerSymbol.PadLeft(7).PadRight(13)}│");
        Console.WriteLine("     │             │");
        Console.WriteLine($"     │{suitSymbol.PadLeft(13)}│");
        Console.WriteLine($"     │{rankSymbol.PadLeft(13)}│");
        Console.WriteLine("     └─────────────┘");
        Console.WriteLine($"     {cardName}".PadLeft(12).PadRight(20));

        Console.ResetColor();
        return;
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