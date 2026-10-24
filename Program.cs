Deck deck = new Deck();
deck.Shuffle();

    Card? drawnCard = deck.Draw();

    if (drawnCard == null)
    {
        Console.WriteLine("The deck is empty!");
        return;
    }
    Renderer.RenderCard(drawnCard);

    //verify fedora
