using System;

namespace GameOfLife_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(40, 16);
            var gui = new Gui();

            while (true)
            {
                game.GotoNextGeneration();
                gui.Render(game.Cells);

                Console.ReadKey();
            }

        }
    }
}
