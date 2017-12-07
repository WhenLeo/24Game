using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch10CardLib;
using static System.Console;

namespace Ch10CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Card tempCard=myDeck.GetCard(i);
                if (i != 51)
                    Write(tempCard.ToString() + ", ");
                else
                    WriteLine();
            }
            ReadKey();
        }
    }
}
