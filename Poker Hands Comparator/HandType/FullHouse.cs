using System;
using System.Collections.Generic;

namespace PokerHands.HandType
{
    class FullHouse : HandType
    {
        new public readonly int Rank = 7;
        public readonly List<int> ScoringValues;

        public FullHouse(int _scoringValue)
        {
            this.ScoringValues = new List<int>(1);
            this.ScoringValues.Add(_scoringValue);
        }
    }
}
