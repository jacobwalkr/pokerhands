using System;
using System.Collections.Generic;

namespace PokerHands.HandType
{
    class Pair : HandType
    {
        new public readonly int Rank = 2;
        public readonly List<int> ScoringValues;

        public Pair(List<int> _scoringValues)
        {
            if (_scoringValues.Count != 4)
            {
                throw new ArgumentException("This hand type requires exactly 4 scoring values");
            }
            else
            {
                this.ScoringValues = _scoringValues;
            }
        }
    }
}
