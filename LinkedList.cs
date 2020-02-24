using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Card_Game
{
    class LinkedList
    {
        private Node _head;
        public int _numNodes
        {
            get;set;
        }
        public LinkedList()
        {
            _head = null;
        }
        public void AddFirst(Card data)
        {
            _numNodes = _numNodes + 1;
            this._head = new Node(data, this._head);
        }
        public void AddFirst(int rank, char suit)
        {
            AddFirst(new Card(rank, suit));
        }
        public Card RemoveFirst()
        {
            Card data;
            data = this._head.Data;
            this._head = this._head.Link;
            _numNodes = _numNodes - 1;
            return data;
        }
        public void AddLast(Card data)
        {
            Node current = this._head;
            while (current.Link != null)
                current = current.Link;
            current.Link = new Node(data, null);
            _numNodes = _numNodes + 1;
        }
        public Card RemoveLast()
        {
            Node secondtoLast = _head;
            Node current = _head.Link;
            if(_numNodes >= 2)
            {
                int _current = 2;
                while (_current != _numNodes)
                {
                    secondtoLast = current;
                    if (_current < _numNodes)
                    {
                        current = secondtoLast.Link;
                    }
                    _current++;
                }
                secondtoLast.Link = null;
                _numNodes = _numNodes - 1;
                //current.Data.Show();
                return current.Data;
            }
            else if(_numNodes == 1)
            {
                Card _output = _head.Data;
                _head = null;
                _numNodes = _numNodes - 1;
                return _output;
            }
            else
            {
                Console.WriteLine("No card to remove");
                return null;
            }
            
        }
        public void Shuffle()
        {
            if (_numNodes <= 0) return;
            Card[] _toShuffle = new Card[_numNodes];
            Node current = _head;
            int _current = 0;
            while(current != null)
            {
                _toShuffle[_current++] = current.Data;
                current = current.Link;
            }
            Random r = new Random();
            for (int i = 0; i < _numNodes - 1; i++)
            {
                int rndIdx = r.Next(i + 1, _numNodes);
                Card temp = _toShuffle[i];
                _toShuffle[i] = _toShuffle[rndIdx];
                _toShuffle[rndIdx] = temp;
            }
            RemoveAll();
            for(int i = 0; i < _toShuffle.Length; i++)
            {
                AddFirst(_toShuffle[i]);
            }
        }
        public void Show()
        {
            Node current = _head;
            while (current != null)
            {
                current.Data.Show();
                current = current.Link;
            }
        }
        public int GetValue()
        {
            Node current = _head;
            int _output = 0;
            while(current != null)
            {
                _output += current.Data.Rank;
                current = current.Link;
            }
            return _output;
        }
        public void RemoveAll()
        {
            _head = null;
            _numNodes = 0;
        }
    }
}
