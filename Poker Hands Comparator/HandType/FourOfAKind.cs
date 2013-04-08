using System;
using System.Collections.Generic;

namespace PokerHands.HandType
{
    class FourOfAKind : HandType
    {
        new public readonly int Rank = 8;
        public readonly List<int> ScoringValues;

        public FourOfAKind(List<int> _scoringValues)
        {
            this.ScoringValues = new List<int>(1);
            this.ScoringValues.Add(_scoringValue);
        }
    }
}
