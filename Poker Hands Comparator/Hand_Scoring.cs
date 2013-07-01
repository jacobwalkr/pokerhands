using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerHands.HandType;

namespace PokerHands
{
    partial class Hand
    {
        private HandType.HandType Score()
        {
            // Cascade through score methods until a match is found
            if (this.IsStraightFlush())
            {
                return new HandType.StraightFlush(this[0].Value);
            }
            else if (this.IsFourOfAKind())
            {
                // Cards in the hand are sorted, so if the hand is four of a kind it must look like this:
                // ABBBB or AAAAB
                // Therefore the second, third and fourth cards will always be part of the group of four.

                return new HandType.FourOfAKind(this[1].Value);
            }
            else if (this.IsFullHouse())
            {
                // By the same logic as above, a full house must look like this:
                // AABBB or AAABB
                // Therefore the third card will always be part of the group of three.

                return new HandType.FullHouse(this[2].Value);

                // These two (four of a kind and full house) could probably be merged. I'll leave it for
                // now with a view to optimising and tidying up later.
            }
            else if (this.IsFlush())
            {
                List<int> scoringValues = new List<int>(5);

                foreach (Card card in this)
                {
                    scoringValues.Add(card.Value);
                }

                return new HandType.Flush(scoringValues);
            }
            else if (this.IsStraight())
            {
                return new HandType.Straight(this[0].Value);
            }
            else if (this.IsThreeOfAKind())
            {
                return new HandType.ThreeOfAKind(this[0].Value);
            }
            else
            {
                int numPairs = this.CountPairs();

                if (numPairs == 2)
                {
                    
                }
                else if (numPairs == 1)
                {
                    
                }
                else
                {
                    List<int> scoringValues = new List<int>(5);

                    foreach (Card card in this)
                    {
                        scoringValues.Add(card.Value);
                    }

                    return new HandType.Junk(scoringValues);
                }
            }
        }

        private bool IsStraightFlush()
        {
            int previousValue = this[0].Value;
            char previousSuit = this[0].Suit;

            for (int cardIndex = 1; cardIndex < 5; cardIndex++)
            {
                if (((this[cardIndex].Value - previousValue) != 1) || !this[cardIndex].Suit.Equals(previousSuit))
                {
                    // If the values aren't consecutive or the suits aren't the same
                    return false;
                }

                previousValue = this[cardIndex].Value;
                previousSuit = this[cardIndex].Suit;
            }

            return true;
        }

        private bool IsFourOfAKind()
        {
            int[] valueOccurrences = new int[15];

            foreach (Card card in this)
            {
                valueOccurrences[card.Value]++;
            }

            foreach (int occurrences in valueOccurrences)
            {
                if (occurrences == 4)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsFullHouse()
        {
            int[] valueOccurrences = new int[15];
            bool three = false;
            bool two = false;

            foreach (Card card in this)
            {
                valueOccurrences[card.Value]++;
            }

            foreach (int occurrences in valueOccurrences)
            {
                if (occurrences == 2)
                {
                    two = true;
                }
                else if (occurrences == 3)
                {
                    three = true;
                }
            }

            if (three && two)
            {
                return true;
            }

            return false;
        }

        private bool IsFlush()
        {
            char previousSuit = this[0].Suit;

            for (int cardIndex = 1; cardIndex < 5; cardIndex++)
            {
                if (this[cardIndex].Suit != previousSuit)
                {
                    return false;
                }
                else
                {
                    previousSuit = this[cardIndex].Suit;
                }
            }

            return true;
        }

        private bool IsStraight()
        {
            int previousValue = this[0].Value;

            foreach (Card card in this)
            {
                if ((card.Value - previousValue) != 1)
                {
                    // If the values aren't consecutive
                    return false;
                }

                previousValue = card.Value;
            }

            return true;
        }

        private bool IsThreeOfAKind()
        {
            int[] valueOccurrences = new int[15];

            foreach (Card card in this)
            {
                valueOccurrences[card.Value]++;
            }

            foreach (int occurrences in valueOccurrences)
            {
                if (occurrences == 3)
                {
                    return true;
                }
            }

            return false;
        }

        private int CountPairs()
        {
            int[] valueOccurrences = new int[15];

            foreach (Card card in this)
            {
                valueOccurrences[card.Value]++;
            }

            int numPairs = 0;

            foreach (int occurrences in valueOccurrences)
            {
                if (occurrences == 2)
                {
                    numPairs++;
                }
            }

            return numPairs;
        }
    }
}
