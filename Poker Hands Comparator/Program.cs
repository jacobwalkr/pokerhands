using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_Hands_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dealer dealer = new Dealer();
            Comparator comparator = new Comparator();

            string firstHandString = dealer.GetValidHandOrDieTrying();
            string secondHandString = dealer.GetValidHandOrDieTrying();

            Hand firsthand = new Hand(firstHandString);
            Hand secondHand = new Hand(secondHandString);

            // Compare hands
        }
    }
}
