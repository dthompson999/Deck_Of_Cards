using System;
using System.Collections.Generic;

namespace deck_of_cards.Models
{
    public class Deck
    {
        public List<Card> Cards = new List<Card>();

        public void Reset()
        {
            Cards.Clear();
            string[] Suits = new string[]{"Clubs", "Spades", "Hearts", "Diamonds"};
            string[] StringValues = new string[]{"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};

            foreach(string Suit in Suits)
            {
                for(int i=0; i<StringValues.Length; i++)
                {
                    Cards.Add(new Card(Suit, StringValues[i], i+1));
                }
            }
            // Console.WriteLine("The deck is being Reset");
        }

        public Deck()
        {
            Reset();
        }

        public Card Deal()
        {
            Card DealCard = Cards[0];
            Cards.RemoveAt(0);
            // Console.WriteLine("Dealing:");
            // DealCard.Display();
            return DealCard;
        }

        public void Shuffle()
        {
            Random shuffle = new Random();
            for (int i=0; i<Cards.Count; i++)
            {
                int shuffleIndex = shuffle.Next(Cards.Count);
                Card temp = Cards[i];
                Cards[i] = Cards[shuffleIndex];
                Cards[shuffleIndex] = temp;
            }
            Console.WriteLine("The deck is being Shuffled.");
        }
    }
}