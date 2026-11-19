using System;

namespace BalatroConsole
{
    public class Card
    {
        public Rank Rank { get; }
        public Suit Suit { get; }

        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public void PrintCard()
        {
            Console.WriteLine($"{Rank} of {Suit}");
        }
    }
}