using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands.HandType
{
    abstract class HandType
    {
        public const int Rank = 0;
        abstract public Hand.ComparisonOutcome CompareToSimilar(Hand hand);
    }
}
