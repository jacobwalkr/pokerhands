using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_Hands_Comparator
{
    class Card
    {
        private char suit;
        private char value;

        public Card(char _value, char _suit)
        {
            this.value = _value;
            this.suit = _suit;
        }
    }
}
