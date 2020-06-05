using System;

namespace deck_of_cards.Models
{
    public class Card
    {
        public string Suit;
        public string StringVal;
        public int Value;

        public Card(string Suit, string StringVal, int Value)
        {
            this.Suit = Suit;
            this.StringVal = StringVal;
            this.Value = Value;
        }

        public void Display()
        {
            Console.WriteLine($"The {StringVal} of {Suit}");
        }
    }
}