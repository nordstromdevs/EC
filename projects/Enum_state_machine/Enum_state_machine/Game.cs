using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_state_machine
{
    class Game
    {
        public static GameStates _currentState;

        public enum GameStates
        {
            TitleScreen,
            GameRunning,
            GamePaused,
            GameOver,
            ExitGame
        }
    }
}
