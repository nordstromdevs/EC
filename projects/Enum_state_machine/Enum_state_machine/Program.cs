using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_state_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Player myPlayer = new Player(25);
         
            Game._currentState = Game.GameStates.TitleScreen;

            while (Game._currentState != Game.GameStates.ExitGame)
            {
                switch (Game._currentState)
                {
                    case Game.GameStates.TitleScreen:
                        Console.WriteLine("My Fantastic Game");
                        Console.WriteLine("Start the game by pressing S");
                        Console.WriteLine("Exit the game by pressing Q");
                        var userInput = Console.ReadKey();
                        if (userInput.Key == ConsoleKey.S)
                        {
                            Game._currentState = Game.GameStates.GameRunning;
                        }
                        else if (userInput.Key == ConsoleKey.Q)
                        {
                            Game._currentState = Game.GameStates.ExitGame;
                        }
                        break;
                    case Game.GameStates.GameRunning:
                        Console.WriteLine("Game Running");
                        myPlayer.MakeNextMove();
                        break;
                    case Game.GameStates.GamePaused:
                        Console.WriteLine("Game paused");
                        break;
                    case Game.GameStates.GameOver:
                        Console.WriteLine("It's game over man!");
                        Game._currentState = Game.GameStates.ExitGame;
                        break;
                    case Game.GameStates.ExitGame:
                        break;
                    default:
                        break;
                }
            }

            Console.Write("\n\nPress any key to terminate the game!");
            Console.ReadKey();
        }
    }
}
