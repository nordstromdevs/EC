using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace GameOfLife
{
    public partial class MainForm : Form
    {
        private const int CELL_COUNT = 30;
        private const int CELL_SIZE = 15;

        private CellHandler _cellHandler;
        private Graphics _frameG, _g;
        private Bitmap _frame;
        private int _iterations;     
        private bool _running = false;                

        public MainForm()
        {
            InitializeComponent();

            _cellHandler = new CellHandler(CELL_COUNT, CELL_SIZE);

            _g = _canvas.CreateGraphics();
            _frame = new Bitmap(_canvas.DisplayRectangle.Width, _canvas.DisplayRectangle.Height);
            _frameG = Graphics.FromImage(_frame);

            this.FormClosing += (s,e) => _running = false;                    
        }

        private void _btnRestart_Click(object sender, EventArgs e)
        {
            _iterations = 0;
            _cellHandler = new CellHandler(CELL_COUNT, CELL_SIZE);
        }

        private async void _btnGo_Click(object sender, EventArgs e)
        {            
            _running = !_running;                                        
            _btnGo.Text = _running ? "Pause..." : "Go..";

            // To make the GUI fluent we need to await an asynchronous anonymous method
            await Task.Run(() =>
            {
                while (_running)
                {
                    _cellHandler.UpdateCells();
                    DrawCellGrid();

                    // We want to set the label on the Form, but in order to avoid cross-threading exception
                    // we need to Invoke an Action on the GUI-main thread
                    this.Invoke(new Action(() => _lblCount.Text = "" + ++_iterations));
                }
            });                    
        }       
        
        private void DrawCellGrid()
        {
            DrawCells(_frameG);
            DrawGrid(_frameG, CELL_COUNT, CELL_SIZE);

            // flip back buffer
            _g.DrawImage(_frame, 0, 0);            
        }                      

        private void DrawCells(Graphics g)
        {
            foreach (var item in _cellHandler.Cells)
            {
                var blueValue = Math.Min(255, item.Y * 3);
                switch (item.State)
                {
                    case Cell.AliveState.Alive:
                        DrawCell(g, item.X, item.Y, CELL_SIZE, Color.FromArgb(200, 0, blueValue));
                        break;
                    case Cell.AliveState.Dying:
                        DrawCell(g, item.X, item.Y, CELL_SIZE, Color.FromArgb(100, 0, blueValue));
                        break;
                    case Cell.AliveState.Living:
                        DrawCell(g, item.X, item.Y, CELL_SIZE, Color.FromArgb(255, 0, blueValue));
                        break;
                    case Cell.AliveState.Dead:
                        DrawCell(g, item.X, item.Y, CELL_SIZE, Color.FromArgb(10, 0, blueValue));
                        break;
                    default:
                        break;
                }
            }
        }

        private void DrawCell(Graphics g, int x, int y, int size, Color color)
        {
            g.FillRectangle(new SolidBrush(color), x*size, y*size, size, size);                
        }       

        private void DrawGrid(Graphics g, int numberOfCells, int size)
        {
            var myPen = new Pen(Color.FromArgb(20, 20, 20));
            for (var i = 0; i <= numberOfCells; i++)
            {
                g.DrawLine(myPen, 0, i * size, (numberOfCells * size), i * size);
                g.DrawLine(myPen, i * size, 0, i * size, (numberOfCells * size));
            }
        }


    }
}
