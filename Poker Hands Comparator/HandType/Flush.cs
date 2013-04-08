using System;
using System.Collections.Generic;

namespace PokerHands.HandType
{
    class Flush : HandType
    {
        new public readonly int Rank = 6;
        public readonly List<int> ScoringValues;

        public Flush(List<int> _scoringValues)
        {
            if (_scoringValues.Count != 5)
            {
                throw new ArgumentException("This hand type requires exactly 5 scoring values");
            }
            else
            {
                this.ScoringValues = _scoringValues;
            }
        }
    }
}
