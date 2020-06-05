using System;
using System.Collections.Generic;

namespace deck_of_cards.Models
{
    public class Player
    {
        public string Name;

        public Deck NewDeck;

        public Player(string Name, Deck NewDeck)
        {
            this.Name = Name;
            this.NewDeck = NewDeck;
        }

        public List<Card> Hand = new List<Card>();

        public void ShowHand()
        {
            Console.WriteLine($"{Name}'s hand is:");
            foreach (Card c in Hand)
            {
                Console.WriteLine($" {c.StringVal} of {c.Suit}");
            }
        }

        public Card Draw()
        {
            
            Card DrawCard = NewDeck.Deal();
            Hand.Add(DrawCard);
            Console.WriteLine($"{Name} draws:");
            DrawCard.Display();
            return DrawCard;
        }
    }
}