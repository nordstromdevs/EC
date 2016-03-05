using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Cell
    {
        public enum AliveState
        {
            Alive,
            Dying,
            Living,
            Dead
        }

        public int X { get; set; }
        public int Y { get; set; }
        public bool IsAlive { get; set; }
        public int TouchCount { get; set; }
        public AliveState State { get; set; }

        public Cell()
        {
            this.State = Cell.AliveState.Dead;
        }

        public Cell Clone()
        {
            var result = new Cell
            {
                IsAlive = this.IsAlive,
                State = this.State,
                TouchCount = this.TouchCount,
                X = this.X,
                Y = this.Y
            };

            return result;
        }

    }
}
