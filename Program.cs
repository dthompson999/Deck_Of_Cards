using System;
using deck_of_cards.Models;

namespace deck_of_cards
{
    class Program
    {
        public void ShowAllCards()
        {

        }
        static void Main(string[] args)
        {
            Deck d1 = new Deck();

            Player p1 = new Player("Chris", d1);

            
            Console.WriteLine($"The current deck has {d1.Cards.Count} cards.");

            d1.Shuffle();
            p1.Draw();
            p1.Draw();
            p1.Draw();
            p1.Draw();
            p1.Draw();
            p1.ShowHand();
            Console.WriteLine($"The current deck has {d1.Cards.Count} cards.");
            // foreach (Card c in d1.Cards)
            // {
            //     c.Display();
            // }

            

        }
    }
}
