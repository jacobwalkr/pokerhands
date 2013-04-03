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

            Hand firstHandString = dealer.GetValidHandOrDieTrying();
            Hand secondHandString = dealer.GetValidHandOrDieTrying();

            // Compare hands
        }
    }
}
