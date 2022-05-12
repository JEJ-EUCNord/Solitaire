using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    public class Card
    {
        public int Suit;
        public int Value;

        public Card (int suit, int value)
        {
            Suit = suit;
            Value = value;
        }
    }
}
