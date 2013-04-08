using System;
using System.Collections.Generic;

namespace PokerHands.HandType
{
    class Straight : HandType
    {
        new public readonly int Rank = 5;
        public readonly List<int> ScoringValues;

        public Straight(int _scoringValue)
        {
            this.ScoringValues = new List<int>(1);
            this.ScoringValues.Add(_scoringValue);
        }
    }
}
