using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Hands_Comparator
{
    class Hand : List<Card>
    {
        public enum ComparisonOutcome
        {
            Win,
            Draw,
            Lose
        };

        public ComparisonOutcome CompareTo(Hand otherHand)
        {
            throw new NotImplementedException();
        }
    }
}
