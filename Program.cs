Deck deck = new Deck();
deck.Shuffle();



while (true)
{
    Console.Clear();
    Renderer.RenderMenu(deck.Count);
    string? choice = Console.ReadLine();
    
    switch (choice)
    {
        case "1":
        Card? card = deck.Draw();
        if (card == null)
        {
            Console.WriteLine("The deck is empty!");
        }
        else
        {
            Renderer.RenderCard(card);
            Console.WriteLine();
            Console.WriteLine("Press [Any Key] to continue");
            Console.ReadKey();
        }
        break;

        case "2":
        deck.Shuffle();
        break;

        case "3":
        return;

        default:
        Console.WriteLine("Invalid option!");
        break;
    }
}

