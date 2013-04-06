using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    partial class Hand
    {
        public enum Rank
        {
            Junk = 1,
            Pair = 2,
            TwoPairs = 3,
            ThreeOfAKind = 4,
            Straight = 5,
            Flush = 6,
            FullHouse = 7,
            FourOfAKind = 8,
            StraightFlush = 9
        }

        public enum ComparisonOutcome
        {
            Win,
            Draw,
            Lose
        }
    }
}
