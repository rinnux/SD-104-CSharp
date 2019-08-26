using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab10
{
    class DeckOfCards
    {

        public List<Card> Deck { get; set; }
        private const int NUMBER_OF_CARD = 52;

        public DeckOfCards()
        {
            string[] faces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] suits = { "♣", "♥", "♦", "♠" };
            int[] value = { 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            //new deck
            Deck = new List<Card>();

            for (int count =0;count< NUMBER_OF_CARD; count++)
            {
                Deck.Add(new Card (faces[count % 13], suits[count / 13], value[count % 13]));
            }

        }
        public void Shuffle()
        {
            Random randNum = new Random();
            int nRand;
            Card temp;
            for (int n = 0; n < Deck.Count;n++)
            {
                nRand = randNum.Next(1, Deck.Count);
                temp = Deck[n];
                Deck[n] = Deck[nRand];
                Deck[nRand] = temp;
            }

        }
        public Card Deal()
        {
            Card temp = Deck[0];
            Deck.RemoveAt(0);
            return temp;
        }

    }

    
}
