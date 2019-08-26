using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab10
{
    class Card
    {
        string rank;
        string suit;
        int val;


        public Card(string rank, string suit, int value)
        {
            this.rank = rank;
            this.suit = suit;
            this.val = value;
        }

        public string Rank { get => rank; set => rank = value; }
        public string Suit { get => suit; set => suit = value; }
        public int Val { get => val; set => val = value; }

        public override string ToString()
        {
           // return rank + " " + suit;
            return string.Format("{0,2} {1}", rank, suit);

        }
    }
}

