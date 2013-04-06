﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    partial class Hand
    {
        private Hand.Rank Score()
        {
            // Cascade through score methods until a match is found
            if (this.IsStraightFlush())
            {
                return Hand.Rank.StraightFlush;
            }
            else if (this.IsFourOfAKind())
            {
                return Hand.Rank.FourOfAKind;
            }
            else if (this.IsFullHouse())
            {
                return Hand.Rank.FullHouse;
            }
            else if (this.IsFlush())
            {
                return Hand.Rank.Flush;
            }
            else if (this.IsStraight())
            {
                return Hand.Rank.Straight;
            }
            else if (this.IsThreeOfAKind())
            {
                return Hand.Rank.ThreeOfAKind;
            }
            else if (this.IsTwoPairs())
            {
                return Hand.Rank.TwoPairs;
            }
            else if (this.IsPair())
            {
                return Hand.Rank.Pair;
            }
            else
            {
                return Hand.Rank.Junk;
            }
        }

        private bool IsStraightFlush()
        {
            int previousValue = this[0].Value;
            char previousSuit = this[0].Suit;

            for (int cardIndex = 1; cardIndex < 5; cardIndex++)
            {
                int currentValue = this[cardIndex].Value;
                char currentSuit = this[cardIndex].Suit;

                if (((currentValue - previousValue) != 1) || (previousSuit != currentSuit))
                {
                    // If the values aren't consecutive or the suits aren't the same
                    return false;
                }

                previousValue = currentValue;
                previousSuit = currentSuit;
            }

            return true;
        }

        private bool IsFourOfAKind()
        {
            throw new NotImplementedException();
        }

        private bool IsFullHouse()
        {
            throw new NotImplementedException();
        }

        private bool IsFlush()
        {
            throw new NotImplementedException();
        }

        private bool IsStraight()
        {
            throw new NotImplementedException();
        }

        private bool IsThreeOfAKind()
        {
            throw new NotImplementedException();
        }

        private bool IsTwoPairs()
        {
            throw new NotImplementedException();
        }

        private bool IsPair()
        {
            throw new NotImplementedException();
        }
    }
}
