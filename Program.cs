Deck deck = new Deck();
deck.Shuffle();

    Card? drawnCard = deck.Draw();

    if (drawnCard == null)
    {
        Console.WriteLine("The deck is empty!");
        return;
    }
    else
    {
        if (drawnCard.IsJoker)
        {
            Console.WriteLine("Joker");
        }
    }
    Renderer.RenderCard(drawnCard);
