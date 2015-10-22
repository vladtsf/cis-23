using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Deck
{
    class Card
    {
        private static string[] ranks = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private static string[] suits = new string[] { "S", "H", "D", "C" };

        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public Card(int rank, int suit) : this(ranks[rank], suits[suit]) { }

        public Card(int id)
        {
            if (id > 51)
            {
                throw new ArgumentOutOfRangeException("The requested card doesn't exist");
            }

            for (int k = 0, i = 0; i < ranks.Length; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    if (k == id)
                    {
                        Rank = ranks[i];
                        Suit = suits[j];

                        return;
                    }

                    k++;
                }
            }
        }

        public string Rank
        {
            get;
            set;
        }

        public string Suit
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Rank + Suit;
        }

        public bool Equals(Card other)
        {
            return Rank == other.Rank && Suit == other.Suit;
        }
    }
}
