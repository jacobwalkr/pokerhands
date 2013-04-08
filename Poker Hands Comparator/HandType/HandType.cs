using System.Collections.Generic;

namespace PokerHands.HandType
{
    abstract class HandType
    {
        public readonly int Rank = 0;
        public readonly List<int> ScoringValues;
    }
}
