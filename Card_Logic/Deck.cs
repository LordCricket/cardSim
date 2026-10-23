public class Deck
{
    private List<Card> cards = new List<Card>();
    public int Count => cards.Count;

    public Deck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                cards.Add(new Card(rank, suit));
            }
        }
        cards.Add(new Card(null, null, true));
        cards.Add(new Card(null, null, true));
    }

    public Card? Draw()
    {
        if (cards.Count < 1)
        {
            return null;
        }


        Card drawnCard = cards[0];
        cards.RemoveAt(0);
        return drawnCard;
    }

    public void Shuffle()
    {
        Random rand = new Random();

        for (int i = 0; i < cards.Count; i++)
        {
            int index = rand.Next(i, cards.Count);

            Card temp = cards[i];
            cards[i] = cards[index];
            cards[index] = temp;
        }
    }
}