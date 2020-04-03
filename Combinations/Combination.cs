using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Poker
{
    public class Combination
    {
        public int Strength { get; set; }
        public string CombinationName { get; set; }

        public Combination(int strengthOfCombination, string combinationName)
        {
            Strength = strengthOfCombination;
            CombinationName = combinationName;
        }

    }
}
