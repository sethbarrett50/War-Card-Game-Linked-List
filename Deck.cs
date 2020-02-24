using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Card_Game
{
    class Deck
    {
        private LinkedList _cards = new LinkedList();
        public Deck(bool fill)
        {
            if (fill)
            {
                for (int rank = 1; rank <= 13; rank++)
                    for (int suitIdx = 0; suitIdx < Card._Suits.Length; suitIdx++)
                        this.AddCard(new Card(rank, Card._Suits[suitIdx]));
            }
        }
        public void AddCard(Card card)
        {
            //this.ShiftRight();
            _cards.AddFirst(card);
        }
        public Card DealCard()
        {
            return _cards.RemoveLast();
        }
        public int GetSize()
        {
            return _cards._numNodes;
        }
        public void Shuffle()
        {
            _cards.Shuffle();
        }
        public void Show()
        {
            _cards.Show();
        }
        public int GetValue()
        {
            return _cards.GetValue();
        }
    }
}
