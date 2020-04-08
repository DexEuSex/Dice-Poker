using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Poker.GamePlay
{
    class Player
    {
        public int CoinsAmount { get; set; } = 200;
        public int WinCounts { get; set; } = 0;

        Combination droppedCombination;

        public Player(Combination combination)
        {
            droppedCombination = combination;
        }

    }
}
