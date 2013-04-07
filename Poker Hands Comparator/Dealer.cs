using System;
using System.Text.RegularExpressions;

namespace PokerHands
{
    class Dealer
    {
        public Hand GetValidHandOrDieTrying()
        {
            while (true)
            {
                string handString = this.promptForHand();

                if (this.validateHand(handString))
                {
                    this.thankUser();
                    string sanitisedHandString = this.sanitiseHand(handString);
                    return Hand.ConstructFromSanitisedInput(sanitisedHandString);
                }

                this.chastiseUser();
            }
        }

        public bool RetryWithNewHand()
        {
            Console.WriteLine("Repeat with a new hand? (y/n)");
            Console.Write("> ");

            string input = Console.ReadLine();

            if (input.Equals("y") || input.Equals("Y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string promptForHand()
        {
            Console.WriteLine("Enter hand");
            Console.Write("> ");
            return Console.ReadLine();
        }

        private void thankUser()
        {
            Console.WriteLine("A valid hand - thanks!");
            Console.WriteLine();
        }

        private void chastiseUser()
        {
            Console.WriteLine("That's not a valid hand and you know it. C'mon now.");
            Console.WriteLine();
        }

        private bool validateHand(string handString)
        {
            string validHandPattern = @"^([2-9TJQKA] *[CDHS] *){5}$";
            RegexOptions options = RegexOptions.IgnoreCase;

            Match match = Regex.Match(handString, validHandPattern, options);

            return match.Success;
        }

        private string sanitiseHand(string unsanitisedHand)
        {
            string handWithoutSpaces = unsanitisedHand.Replace(" ", string.Empty);
            return handWithoutSpaces.ToUpper();
        }
    }
}
