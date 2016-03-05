using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class CellHandler
    {       
        private List<Cell> _cells, _snapShot;
        public List<Cell> Cells {  get { return _cells; } }

        private int _cellCount, _cellSize;

        public CellHandler(int cellCount, int cellSize)
        {
            _cellCount = cellCount;
            _cellSize = cellSize;

            _cells = new List<Cell>();
            _snapShot = new List<Cell>();

            InitCells();
        }

        private void InitCells()
        {
            Random random = new Random();
            for (int y = 0; y < _cellCount; y++)
                for (int x = 0; x < _cellCount; x++)
                    _cells.Add(new Cell { X = x, Y = y, IsAlive = random.Next(38) < 6 ? true : false });
        }
       

        public void UpdateCells()
        {
            /*
            Any live cell with fewer than two live neighbours dies, as if caused by under-population.
            Any live cell with two or three live neighbours lives on to the next generation.
            Any live cell with more than three live neighbours dies, as if by over-population.
            Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
            */

            TakeSnapShot();

            foreach (var item in _cells)
            {
                item.TouchCount = GetTouchCount(item);

                if (item.IsAlive && item.TouchCount < 2)
                {
                    item.IsAlive = false;
                    item.State = Cell.AliveState.Dying;
                }
                else if (item.IsAlive && (item.TouchCount == 2 || item.TouchCount == 3))
                {
                    item.IsAlive = true;
                    item.State = Cell.AliveState.Alive;
                }
                else if (item.IsAlive && item.TouchCount > 3)
                {
                    item.IsAlive = false;
                    item.State = Cell.AliveState.Dying;
                }
                else if (!item.IsAlive && item.TouchCount == 3)
                {
                    item.IsAlive = true;
                    item.State = Cell.AliveState.Living;
                }
                else
                {
                    if (item.State == Cell.AliveState.Dying)
                        item.State = Cell.AliveState.Dead;
                    else if (item.State == Cell.AliveState.Living)
                        item.State = Cell.AliveState.Alive;
                }
            }
        }       

        private int GetTouchCount(Cell cell)
        {
            var result = 0;

            // Y+-0
            var lCell = _snapShot.SingleOrDefault(n => n.X == cell.X - 1 && n.Y == cell.Y);
            var rCell = _snapShot.SingleOrDefault(n => n.X == cell.X + 1 && n.Y == cell.Y);

            // Y-1      
            var luCell = _snapShot.SingleOrDefault(n => n.X == cell.X - 1 && n.Y == cell.Y - 1);
            var muCell = _snapShot.SingleOrDefault(n => n.X == cell.X && n.Y == cell.Y - 1);
            var ruCell = _snapShot.SingleOrDefault(n => n.X == cell.X + 1 && n.Y == cell.Y - 1);

            // Y+1      
            var ldCell = _snapShot.SingleOrDefault(n => n.X == cell.X - 1 && n.Y == cell.Y + 1);
            var mdCell = _snapShot.SingleOrDefault(n => n.X == cell.X && n.Y == cell.Y + 1);
            var rdCell = _snapShot.SingleOrDefault(n => n.X == cell.X + 1 && n.Y == cell.Y + 1);

            if (lCell != null && lCell.IsAlive) result++;
            if (rCell != null && rCell.IsAlive) result++;

            if (luCell != null && luCell.IsAlive) result++;
            if (muCell != null && muCell.IsAlive) result++;
            if (ruCell != null && ruCell.IsAlive) result++;

            if (ldCell != null && ldCell.IsAlive) result++;
            if (mdCell != null && mdCell.IsAlive) result++;
            if (rdCell != null && rdCell.IsAlive) result++;

            return result;
        }

        private void TakeSnapShot()
        {
            _snapShot.Clear();

            foreach (var item in _cells)
                _snapShot.Add(item.Clone());
        }
    }
}
