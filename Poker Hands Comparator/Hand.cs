using System;
using System.Collections.Generic;

namespace PokerHands
{
    class Hand : List<Card>
    {
        public Hand(List<Card> cardList)
        {
            if (cardList.Count != 5)
            {
                throw new ArgumentException("A hand must consist of 5 cards.");
            }

            this.AddRange(cardList);
            this.Sort(this.compareCards);
        }

        private int compareCards(Card first, Card second)
        {
            return second.Value - first.Value;
        }

        public enum ComparisonOutcome
        {
            Win,
            Draw,
            Lose
        };

        public ComparisonOutcome CompareTo(Hand otherHand)
        {
            throw new NotImplementedException();
        }

        public static Hand ConstructFromSanitisedInput(string validatedHandString)
        {
            List<Card> cardList = new List<Card>();

            for (int key = 0; key < 5; key++)
            {
                int cursor = key * 2;
                string cardString = validatedHandString.Substring(cursor, 2);

                char[] cardAsCharArray = cardString.ToCharArray();

                char valueChar = cardAsCharArray[0];
                int value = 0;

                if (char.IsLetter(valueChar))
                {
                    switch (valueChar)
                    {
                        case 'T':
                            value = 10;
                            break;
                        case 'J':
                            value = 11;
                            break;
                        case 'Q':
                            value = 12;
                            break;
                        case 'K':
                            value = 13;
                            break;
                        case 'A':
                            value = 14;
                            break;
                    }
                }
                else
                {
                    value = int.Parse(valueChar.ToString());
                }

                char suit = cardAsCharArray[1];

                cardList.Add(new Card(value, suit));
            }

            return new Hand(cardList);
        }
    }
}
