using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            /*DeckOfCards myDeck = new DeckOfCards();
            myDeck.Shuffle();
            foreach (Card card in myDeck.Deck)
            {
                Console.WriteLine(card.ToString());
                
            }*/
            FiveCardDraw fiveCardDraw = new FiveCardDraw();
            fiveCardDraw.PlayerRound();
            Console.ReadLine();
        }
    }
}
