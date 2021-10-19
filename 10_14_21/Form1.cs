using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_14_21
{

    public partial class Form1 : Form
    {
        
        private Graphics graphics;
        private GameEngine gameEngine;
        private int resolution;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void StartGame()
        {
            if (gameEngine == null)
            {
                resolution = (int)resolutionNum.Value;
                int rows = pictureBox1.Height / resolution;
                int colums = pictureBox1.Width / resolution;
                gameEngine = new GameEngine(rows, colums, (int)densityNum.Value);
            }

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();
            UpdateField();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        
        private void UpdateField()
        {
            graphics.Clear(Color.Black);
            for (int x = 0; x < gameEngine.Colums; x++)
            {
                for (int y = 0; y < gameEngine.Rows; y++)
                {
                    if (gameEngine.Field[x, y])
                    {
                        FillCell(x, y, false);
                    }
                    if(borderRadioButton1.Checked)
                        FillCell(x, y, true);
                }
            }
            pictureBox1.Refresh();

        }
        private void FillCell(int x, int y, bool drawOnlyBorder)
        {
            Rectangle rectangle = new Rectangle(x * resolution, y * resolution, resolution, resolution);
            if (!drawOnlyBorder)
            {
                graphics.FillRectangle(Brushes.Crimson, rectangle);
            }
            ControlPaint.DrawBorder(graphics, rectangle ,Color.DarkGray, ButtonBorderStyle.Solid);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            gameEngine.NextGeneration();
            UpdateField();
            Text = $"Generation: {gameEngine.CurrentGeneration}";
        }
        private void StopGame()
        {
            if (!timer1.Enabled)
                return;
            timer1.Stop();
            resolutionNum.Enabled = true;
            densityNum.Enabled = true;

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            StopGame();
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var validationPassed = ValidateMousePosition(x, y);
                if (validationPassed)
                    gameEngine.SetCellState(x, y, true);
                UpdateField();
            }
            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var validationPassed = ValidateMousePosition(x, y);
                if (validationPassed)
                    gameEngine.SetCellState(x, y, true);
                UpdateField();
            }
        }
        private bool ValidateMousePosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < gameEngine.Colums && y < gameEngine.Rows;
        }
    }
    
}
    
