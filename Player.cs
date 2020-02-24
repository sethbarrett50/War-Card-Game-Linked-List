using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Card_Game
{
    class Player
    {
        private String _name;
        private Deck _playing;
        public Player(String name)
        {
            _name = name;
            _playing = new Deck(false);
        }
        public void TakeCard(Card card)
        {
            _playing.AddCard(card);
        }
        public void Show()
        {
            Console.WriteLine($"({_name}, {this.Score()}:)");
            _playing.Show();
            Console.WriteLine();
        }
        public Card Play()
        {
            if (_playing.GetSize() > 0)
                return _playing.DealCard();
            return null;
        }
        public bool CanPlay()
        {
            return _playing.GetSize() > 0;
        }
        public int Score()
        {
            return _playing.GetValue();
        }
    }
}
