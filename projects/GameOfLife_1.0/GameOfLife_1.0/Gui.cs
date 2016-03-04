using System;

namespace GameOfLife_1._0
{
    class Gui
    {
        public void Render(bool[,] cells)
        {
            var rows = cells.GetLength(0);
            var columns = cells.GetLength(1);

            for (int y = 0; y < columns; y++)
            {
                for (int x = 0; x < rows; x++)
                {
                    var fgColor = cells[x, y] ? ConsoleColor.Cyan : ConsoleColor.Blue;
                    var bgColor = cells[x, y] ? ConsoleColor.Green : ((x+y)%2==0 ? ConsoleColor.Black : ConsoleColor.DarkGray);

                    RenderCell(x, y, bgColor, fgColor);


                }
            }
        }

        private void RenderCell(int x, int y, ConsoleColor bgColor, ConsoleColor fgColor)
        {
            Console.ForegroundColor = fgColor;
            Console.BackgroundColor = bgColor;
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
    }
}
