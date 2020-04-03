using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Poker.Combinations
{
    public class BattleOfCombinations<A, B> 
        where A: Combination
        where B: Combination
    {

        public int StartBattle(A Player1Combination, B Player2Combination)
        {
            int winner = 0;

            if (Player1Combination.Strength > Player2Combination.Strength)
            {
                winner = 1;
            }
            else winner = 2;

            return winner;
        }
    }
}
