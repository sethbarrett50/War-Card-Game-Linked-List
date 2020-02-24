using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Card_Game
{
    class Card
    {
        private int _rank;
        private char _suit;
        public static readonly char[] _Suits = {'D', 'H', 'S', 'C' };
        public Card(int rank, char suit)
        {
            this._rank = rank;
            this._suit = suit;
        }
        public void Show()
        {
            Console.Write($"[{_rank},{_suit}]");
        }
        public int Compare(Card other)
        {
            if (this._rank == other._rank)
                return 0;
            if (this._rank == 1)
                return 1;
            if (other._rank == 1)
                return -1;
            if (this._rank > other._rank)
                return 1;
            return -1;
        }
        public int Rank
        {
            get { return _rank; }
        }
    }
}
