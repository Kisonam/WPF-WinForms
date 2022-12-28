﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourceGame
{
    public partial class Form1 : Form
    {
        int[,] _map = new int[50,50];
        int _viewX = 0;

        Image _groundBlock = Resource1.Ground1;
        Image _sendBlock = Resource1.Ground2;

        const int blockHeight = 80, blockWidth = 80;

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer, true );

            Random r = new Random();

            for (int x = 0; x < _map.GetLength(0); x++)
            {
                for (int y = 0; y < _map.GetLength(1); y++)
                {
                    _map[x, 0] = 1;
                }
            }
        }
        private void MainLoopTimer_Tick(object sender, EventArgs e)
        {
            Point cursor = PointToClient(Cursor.Position);

            float deep = 0; // ... 50
            float borderRadius = 50;
            float speed;

            if (cursor.X > 750)
            {
                deep = 50 - (Width - cursor.X);  
            }
            else if (cursor.X < 50)
            {
                deep = -50 + cursor.X;
            }

            deep = Clamp((int)deep, -50, 50);

            speed = 20 * (deep / borderRadius);

            _viewX += (int)speed;
            _viewX = Clamp(_viewX, 0, _map.Length * blockWidth - 800);

            log.Text = cursor.ToString();

            Invalidate(); // redrawing scene
            Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for(int x= 0; x < _map.GetLength(0); x++)
            {
                for (int y = 0; y < _map.GetLength(1); y++)
                {
                    int blockType = _map[x, y]; 
                    Rectangle rect = new Rectangle((x * blockWidth) - _viewX,(y * blockHeight), blockWidth, blockHeight);
                    DrawBlock(rect, blockType, g);
                }
            }
        }
        private int Clamp(int value, int min, int max)
        {
            if (value > max)
            {
                return max;
            }
            else if (value < min)
            {
                return min;
            }

            return value;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DrawBlock(Rectangle rect, int blockType, Graphics g)
        {
            Image currentImage = null;
            if (blockType == 1)
            {
                currentImage = _groundBlock;
            }
            else if (blockType == 2)
            {
                currentImage = _sendBlock;
            }

            if (currentImage == null)
            {
                return;
            }

            g.DrawImage(currentImage,rect);
        }
    }
}
