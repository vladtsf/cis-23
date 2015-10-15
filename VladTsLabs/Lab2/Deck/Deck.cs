using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Deck
{
    class Deck
    {
        private Card[] cards;

        public Deck()
        {
            cards = new Card[52];

            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = new Card(i);
            }

            initialShuffle();
        }

        private void initialShuffle()
        {
            Random rnd = new Random();
            cards = cards.OrderBy(x => rnd.Next()).ToArray();   
        }

        public void shuffle()
        {
            Card[] deck1 = new Card[26];
            Card[] deck2 = new Card[26];

            Array.Copy(cards, 0, deck1, 0, 26);
            Array.Copy(cards, 26, deck2, 0, 26);

            for (int i = 0, j = 0; i < 52; i += 2, j++)
            {
                cards[i] = deck1[j];
                cards[i + 1] = deck2[j];
            }
        }

        new public string ToString()
        {
            string result = "";

            for (int i = 0; i < 52; i++)
            {
                result += cards[i].ToString() + " ";

                if (i != 0 && (i + 1) % 13 == 0)
                {
                    result += Environment.NewLine;
                }
            }

            return result;
        }

        public bool Equals(Deck other)
        {
            for (int i = 0; i < 52; i++)
            {
                if (this[i] != other[i])
                {
                    return false;
                }
            }

            return true;
        }

        public Card this[int i] {
            get { return cards[i]; }
        }

        public Deck Clone()
        {
            Deck original = this;

            return new Deck
            {
                cards = (Card[]) original.cards.Clone()
            };
        }
    }
}
