using System;

namespace PokerHands.HandType
{
    class TwoPairs : HandType
    {
        new public readonly int Rank = 3;
        public int FirstScoringValue { get; private set; }
        public int SecondScoringValue { get; private set;}

        public TwoPairs(int _firstScoringValue, int _secondScoringValue)
        {
            this.FirstScoringValue = _firstScoringValue;
            this.SecondScoringValue = _secondScoringValue;
        }
    }
}
