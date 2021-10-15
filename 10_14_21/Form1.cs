﻿using System;
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
        private int currentGeneration = 0;
        private Graphics graphics;
        private int resolution;
        private bool[,] field;
        private int rows;
        private int colums;
        public Form1()
        {
            InitializeComponent();
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void StartGame()
        {
            if (timer1.Enabled)
                return;
            currentGeneration = 0;
            resolutionNum.Enabled = false;
            densityNum.Enabled = false;
            resolution = (int)resolutionNum.Value;
            rows = pictureBox1.Height / resolution;
            colums = pictureBox1.Width / resolution;
            field = new bool[colums, rows];
            RandomizeField();

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();
            UpdateField();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void NextGeneration()
        {
            graphics.Clear(Color.Black);
            var newField = new bool[colums, rows];

            for (int x = 0; x < colums; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighboursCount = CountNeighbours(x, y);
                    var hasLife = field[x, y];
                    if (!hasLife && neighboursCount == 3)
                    {
                        newField[x, y] = true;
                    }
                    else if (hasLife && (neighboursCount < 2 || neighboursCount > 3))
                    {
                        newField[x, y] = false;
                    }
                    else
                    {
                        newField[x, y] = field[x, y];
                    }
                    if (hasLife)
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution, resolution);
                }
            }
            field = newField;
            pictureBox1.Refresh();
            currentGeneration++;

        }
        private int CountNeighbours(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + j + colums) % colums;
                    var row = (y + i + rows) % rows;

                    var isSelfCheking = col == x && row == y;
                    var hasLife = field[col, row];
                    if (hasLife && !isSelfCheking)
                        count++;
                }

            return count;
        }
        private void UpdateField()
        {

            for (int x = 0; x < colums; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (field[x, y])
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution, resolution);
                }
            }
            pictureBox1.Refresh();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            NextGeneration();
            Text = $"Generation: {currentGeneration}";
        }
        private void RandomizeField()
        {
            Random random = new Random();
            for (int x = 0; x < colums; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next((int)densityNum.Value) == 0;
                }
            }
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
            if (!timer1.Enabled)
                return;
            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var validationPassed = ValidateMousePosition(x, y);
                if(validationPassed)
                    field[x, y] = true;
                
            }
            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y /
    resolution;
                var validationPassed = ValidateMousePosition(x, y);
                if (validationPassed)
                    field[x, y] = false;
            }
        }
        private bool ValidateMousePosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < colums && y < rows;
        }
    }
    
}
    
