using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay6
{
    class card
    {
        string rank;
        string suit;
        int val;

       public int Value
        {
            get
            {
                return Val;
            }
            
            set
            {
                Val = value;
            }
        }

        public string Rank { get => rank; set => rank = value; }
        public string Suit { get => suit; set => suit = value; }
        public int Val { get => val; set => val = value; }

        public card(string rank, string suit,int val)
        {
            this.Rank = rank;
            this.Suit = suit;
            this.Val = val;
            
        }

        public override bool Equals(object obj)
        {
            return obj is card card &&
                   Value == card.Value;
        }
    }
}
