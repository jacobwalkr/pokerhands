using System;
using System.Collections.Generic;

namespace Poker_Hands_Comparator
{
    class Hand : List<Card>
    {
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

        public static Hand ConstructFromUnsanitisedValidatedInput(string validatedHandString)
        {
            Hand hand = new Hand();

            string handWithoutSpaces = validatedHandString.Replace(" ", string.Empty);
            string upperHandWithoutSpaces = handWithoutSpaces.ToUpper();

            for (int key = 0; key < 5; key++)
            {
                int cursor = key * 2;
                string cardString = validatedHandString.Substring(cursor, 2);

                char value = cardString.ToCharArray()[0];
                char suit = cardString.ToCharArray()[1];
                Card card = new Card(value, suit);

                hand.Add(card);
            }

            return hand;
        }
    }
}
