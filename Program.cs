//This is HW2 Pt3 for Professor JBara's PCP2 Class by Seth Barrett
//This program plays the game of War with the deck being represented by a Linked List
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck main = new Deck(true);
            main.Shuffle();
            Player p1, p2;
            p1 = new Player("Player 1");
            p2 = new Player("Player 2");
            while (main.GetSize() >= 2)
            {
                p1.TakeCard(main.DealCard());
                p2.TakeCard(main.DealCard());
            }
            int turn = 0;
            while (p1.CanPlay() && p2.CanPlay() && turn < 1000000)
            {
                Card cP1 = p1.Play();
                Card cP2 = p2.Play();
                int result = cP1.Compare(cP2);
                if (result == 1) {
                    p1.TakeCard(cP1);
                    p1.TakeCard(cP2);
                }
                else
                if (result == -1)
                {
                    p2.TakeCard(cP1);
                    p2.TakeCard(cP2);
                }
                else
                {
                    p1.TakeCard(cP1);
                    p2.TakeCard(cP2);
                }
                turn++;
            }
            int sP1, sP2;
            sP1 = p1.Score();
            sP2 = p2.Score();
            p1.Show();
            p2.Show();
            if (sP1 > sP2)
                Console.WriteLine($"Player 1 is the winner with a score of {sP1}");
            else
                if (sP1 < sP2)
                Console.WriteLine($"Player 2 is the winner with a score of {sP2}");
            else
                Console.WriteLine("There is a tie!");
        }
    }
}
