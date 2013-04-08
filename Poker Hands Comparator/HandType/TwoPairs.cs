using System;
using System.Collections.Generic;

namespace PokerHands.HandType
{
    class TwoPairs : HandType
    {
        new public readonly int Rank = 3;
        public readonly List<int> ScoringValues;

        public TwoPairs(List<int> _scoringValues)
        {
            if (_scoringValues.Count != 3)
            {
                throw new ArgumentException("This hand type requires exactly 3 scoring values");
            }
            else
            {
                this.ScoringValues = _scoringValues;
            }
        }
    }
}
