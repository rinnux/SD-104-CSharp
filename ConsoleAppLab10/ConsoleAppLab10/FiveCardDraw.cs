using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab10
{
    class FiveCardDraw
    {
        public List<Card> PlayerHand { get; set; }
        public DeckOfCards deckOfCards { get; set; }
        public FiveCardDraw()
        {
            deckOfCards = new DeckOfCards();
            deckOfCards.Shuffle();
            PlayerHand = new List<Card>();

        }
        private bool[] Discard;
        public void PlayerRound()
        {
            Discard = new bool[5] { false, false, false, false, false };
            string userChoice;
            int DiscardMe = 0;
            for (int n = 0; n < 5; n++)
            {
                PlayerHand.Add(deckOfCards.Deal());
            }
            do
            {
                ShowPlayerHand();
                Console.WriteLine("Type the number of the card in your hand and hit enter to toggle between keep/descard. Type 'D' to finalize Discard.");
                userChoice = Console.ReadLine();
                if (userChoice.ToLower() == "exit")
                { 
                    System.Environment.Exit(0);
                }
            while (userChoice != "D" && !int.TryParse(userChoice, out DiscardMe))
                {
                    Console.WriteLine("Invalid choice. Try Again: ");
                    userChoice = Console.ReadLine();
                }
                if (userChoice!="D" && DiscardMe > 0 && DiscardMe < 6)
                    {
                    Discard[DiscardMe - 1] = Discard[DiscardMe - 1] == true ? false : true;
                }
            } while (userChoice!= "D");
            FinalizeDiscard();
            ShowPlayerHand();
        }

        private void FinalizeDiscard()
        {
            for (int n = 0;n < PlayerHand.Count;n++)
            {
                if (Discard [n])
                {
                    deckOfCards.Deck.Add(PlayerHand[n]);
                    PlayerHand[n] = deckOfCards.Deal();
                }
            }
            Discard = new bool[5] { false, false, false, false, false };
        }
    

        public void ShowPlayerHand()
        {
            for (int n = 0; n < PlayerHand.Count; n++)
            {
                if (!Discard[n])
                    Console.WriteLine("Card #" + (n + 1) + " : " + PlayerHand[n]);
                else
                    Console.WriteLine("Card #" + (n + 1) + " : " + PlayerHand[n] + "<-------Discard");
            }
        }
    }

}

