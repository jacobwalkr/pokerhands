using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Hands_Comparator
{
    class Hand
    {
        private List<Card> hand;

        public Hand(List<Card> cards)
        {
            this.hand = cards;
        }
    }
}
