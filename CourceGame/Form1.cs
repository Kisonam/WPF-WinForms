using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using GameCore;
using System.Collections.Generic;

namespace CourceGame
{
    public partial class Form1 : Form
    {
        int[,] _map = new int[50,50];
        int viewX = 0;
        int viewY = 0;

        float playerX = 0;
        float playerY = 0;

        int curentBlock;

        Image _groundBlock = Resource1.Ground1;
        Image _sendBlock = Resource1.Ground2;
        Image _player = Resource1.Player;

        const int blockHeight = 80, blockWidth = 80;

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer, true);

            KeyPreview = true;
            GenerateWorld();
        }
        private void MainLoopTimer_Tick(object sender, EventArgs e)
        {
            Point cursor = PointToClient(Cursor.Position);

            MoveCameraHorizontal(cursor);
            MoveCameraVertical(cursor);

            log.Text = cursor.ToString();
            
            if (!isGrounded())
            {
                float prevY = playerY;
                playerY += (1f / 10f);

                if ((int)playerY < Math.Round(prevY, MidpointRounding.AwayFromZero))
                {
                    playerY = (int)Math.Round(prevY, MidpointRounding.AwayFromZero);
                }
            }

            

            Invalidate(); // redrawing scene
            Refresh();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Help metods
        private void GenerateWorld()
        {
            CleanWold();

            Random r = new Random();
            int direction = 1;
            int y = 20;
            for (int x = 0; x < _map.GetLength(0); x++)
            {
                y += direction;
                direction = r.Next(-1, 2);
                for (int _y = y; _y < _map.GetLength(1); _y++)
                {
                    _map[x, _y] = r.Next(1,3);
                }
            }

            for (int i = 0; i < _map.GetLength(1); i++)
            {
                if (_map[3, i] != 0)
                {
                    playerY = i - 1;
                    playerX = 3;
                    break;
                }
            }
        }
        private void SaveWorld()
        {
            File.Delete("first.world");
            for (int x = 0; x < _map.GetLength(0); x++)
            {
                for (int y = 0; y < _map.GetLength(1); y++) 
                {
                    if (_map[x, y] != 0)
                    {
                        File.AppendAllText("first.world", $"Block:X={x};Y={y};Type={_map[x, y]}\n");
                    }
                }
            }
            File.AppendAllText("first.world", $"Camera:X={viewX};Y={viewY}\n");
            File.AppendAllText("first.world", $"Player:X={(int)playerX};Y={(int)playerY}\n");

        }
        /// <summary>
        /// 
        /// </summary>

        private void CleanWold()
        {
            for (int x = 0; x < _map.GetLength(0); x++)
            {
                for (int y = 0; y < _map.GetLength(1); y++)
                {
                    _map[x, y] = 0;
                }
            }
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

            g.DrawImage(currentImage, rect);
        }
        private void MoveCameraHorizontal(Point cursor)
        {
            float deep = 0; // ... 50
            float borderRadius = 50;
            float speed;

            if (cursor.X > 800 || cursor.X < 0)
                return;

            if (cursor.X > 750)
            {
                deep = 50 - (Width - cursor.X);
            }
            else if (cursor.X < 50)
            {
                deep = -50 + cursor.X;
            }

            deep = Clamp((int)deep, -50, 50);

            speed = 30 * (deep / borderRadius);

            viewX += (int)speed;
            viewX = Clamp(viewX, 0, _map.GetLength(0) * blockWidth - 800);


        }
        private void MoveCameraVertical(Point cursor)
        {
            float deep = 0; // ... 50
            float borderRadius = 50;
            float speed;

            if (cursor.Y > 600 || cursor.Y < 0)
                return;

            if (cursor.Y > 550)
            {
                deep = 50 - (Height - cursor.Y);
            }
            else if (cursor.Y < 50)
            {
                deep = -50 + cursor.Y;
            }

            deep = Clamp((int)deep, -50, 50);

            speed = 30 * (deep / borderRadius);

            viewY += (int)speed;
            viewY = Clamp(viewY, 0, _map.GetLength(1) * blockHeight - 600);


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
        private void DestroyNotChainedBlocks()
        {
            List<Point> whiteList = new List<Point>();

            Queue<Point> queue = new Queue<Point>();

            for(int x = 0; x < _map.GetLength(0); x++)
            {
                queue.Enqueue(new Point(x,49));

                while(queue.Count > 0)
                {
                    Point current = queue.Dequeue();
                    whiteList.Add(current);

                    Point[] points =
                    {
                        new Point(current.X + 1, current.Y - 1),    
                        new Point(current.X + 1, current.Y + 1),
                        new Point(current.X - 1, current.Y - 1),
                        new Point(current.X - 1, current.Y + 1),    
                        new Point(current.X, current.Y - 1),
                        new Point(current.X, current.Y + 1),
                        new Point(current.X - 1, current.Y),
                        new Point(current.X + 1, current.Y),
                    };

                    for (int i = 0; i < points.Length; i++)
                    {
                        if (points[i].X > 49 || points[i].X < 0) continue;
                        if (points[i].Y > 49 || points[i].Y < 0) continue;

                        if (!whiteList.Contains(points[i]) && _map[points[i].X, points[i].Y] != 0)
                        {
                            whiteList.Add(points[i]);
                            queue.Enqueue(points[i]);
                        }
                    }
                }

            }

            for (int x = 0; x < _map.GetLength(0); x++)
            {
                for (int y = 0; y < _map.GetLength(1); y++)
                {
                    if (!whiteList.Contains(new Point(x, y)))
                    {
                        _map[x, y] = 0;
                    }
                }
            }
        }
        private bool isGrounded()
        {
            if (playerY == _map.GetLength(1) - 1) return true;


            if (_map[(int)playerX, (int)playerY + 1] != 0)
            {
                return true;
            }
            if (_map[(int)Math.Round(playerX, MidpointRounding.AwayFromZero), (int)playerY + 1] != 0)
            {
                return true;
            }
            return false;

        }
        #endregion

        #region Forms metods
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                playerX += 0.2f;
            }
            if (e.KeyCode == Keys.A)
            {
                playerX -= 0.2f;
            }
            if (e.KeyCode == Keys.E)
            {
                viewX = (int)playerX * blockWidth;
                viewY = (int)playerY * blockHeight;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Click(object sender, EventArgs e)
        {
            Point cursor = PointToClient(Cursor.Position);

            if (cursor.X < 0 || cursor.Y < 0 || cursor.X > 800 || cursor.Y > 600)
            {
                return;
            }

            int x, y;

            x = (cursor.X + viewX) / blockWidth;
            y = (cursor.Y + viewY) / blockHeight;

            _map[x, y] = curentBlock;

            if (curentBlock == 0)
                DestroyNotChainedBlocks();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int x = 0; x < _map.GetLength(0); x++)
            {
                for (int y = 0; y < _map.GetLength(1); y++)
                {
                    int blockType = _map[x, y];
                    Rectangle rect = new Rectangle((x * blockWidth) - viewX, (y * blockHeight) - viewY, blockWidth, blockHeight);
                    DrawBlock(rect, blockType, g);
                }
            }

            g.DrawImage(_player, new Rectangle((int)(playerX * blockWidth) - viewX, (int)(playerY * blockHeight) - viewY, blockWidth, blockHeight));   
        }

        #endregion

        #region UI
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateWorld();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveWorld();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            CleanWold();
            _map = Core.LoadWorld(); 
            viewX = Core._viewX;
            viewY = Core._viewY;
            playerX = Core._playerX;
            playerY  = Core._playerY;
        }
        private void EmptyBox_Click(object sender, EventArgs e)
        {
            curentBlock = 0;
        }
        private void GroundBox_Click(object sender, EventArgs e)
        {
            curentBlock = 1;
        }
        private void SendBox_Click(object sender, EventArgs e)
        {
            curentBlock = 2;
        }
        #endregion
    }
}
