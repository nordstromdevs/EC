using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_state_machine
{
    class Player
    {
        private int _money;

        public Player(int initialMoney)
        {
            _money = initialMoney;
        }

        public void MakeNextMove()
        {
            _money -= 1;

            if (_money == 0)
                Game._currentState = Game.GameStates.GameOver;
        }
    }
}
