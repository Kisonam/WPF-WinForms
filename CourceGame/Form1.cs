using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace CourceGame
{
    public partial class Form1 : Form
    {
        int[,] _map = new int[50,50];
        int _viewX = 0;
        int _viewY = 0;
        int curentBlock;

        Image _groundBlock = Resource1.Ground1;
        Image _sendBlock = Resource1.Ground2;

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

        private void GenerateWorld()
        {
            Random r = new Random();
            int direction = 1;
            int y = 5;
            for (int x = 0; x < _map.GetLength(0); x++)
            {
                y += direction;
                direction = r.Next(-1, 2);
                for (int i = y; i < _map.GetLength(1); i++)
                {
                    _map[x, i] = 1;

                }
            }
        }

        private void MainLoopTimer_Tick(object sender, EventArgs e)
        {
            Point cursor = PointToClient(Cursor.Position);
            MoveCameraHorizontal(cursor);
            MoveCameraVertical(cursor);
            log.Text = cursor.ToString();

            Invalidate(); // redrawing scene
            Refresh();
        }
        private void MoveCameraHorizontal(Point cursor)
        {
            

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
            _viewX = Clamp(_viewX, 0, _map.GetLength(0) * blockWidth - 800);

            
        }
        private void MoveCameraVertical(Point cursor) 
        {


            float deep = 0; // ... 50
            float borderRadius = 50;
            float speed;

            if (cursor.Y > 550)
            {
                deep = 50 - (Height - cursor.Y);
            }
            else if (cursor.Y < 50)
            {
                deep = -50 + cursor.Y;
            }

            deep = Clamp((int)deep, -50, 50);

            speed = 20 * (deep / borderRadius);

            _viewY += (int)speed;
            _viewY = Clamp(_viewY, 0, _map.GetLength(1) * blockHeight - 600);


        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for(int x= 0; x < _map.GetLength(0); x++)
            {
                for (int y = 0; y < _map.GetLength(1); y++)
                {
                    int blockType = _map[x, y]; 
                    Rectangle rect = new Rectangle((x * blockWidth) - _viewX,(y * blockHeight) - _viewY, blockWidth, blockHeight);
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

            x = (cursor.X + _viewX) / blockWidth ;
            y = (cursor.Y + _viewY) / blockHeight ;

            _map[x,y] = curentBlock;
        }

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

            g.DrawImage(currentImage,rect);
        }

        private void LoadWorld()
        {
            CleanWold();
            string[] lines = File.ReadAllLines("first.world");
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] tagAndDAta = line.Split(':');
                if (tagAndDAta[0] == "Block")
                {
                    int x = 0, y = 0, type = 0;
                    string[] data = tagAndDAta[1].Split(';');
                    for (int j = 0; j < data.Length; j++)
                    {
                        string[] nameAndValue = data[j].Split('=');
                        if(nameAndValue[0] == "X")
                        {
                            x = int.Parse(nameAndValue[1]);

                        }else if (nameAndValue[0] == "Y")
                        {   
                            y = int.Parse(nameAndValue[1]);

                        }else if (nameAndValue[0] == "Type") 
                        {
                            type = int.Parse(nameAndValue[1]);
                        }
                    }
                    _map[x, y] = type;
                }
                else if (tagAndDAta[0] == "Camera")
                {

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
                    if (_map[x,y] != 0)
                    {
                        File.AppendAllText("first.world", $"Block:X={x};Y={y};Type={_map[x,y]}\n");
                    }
                }
            }
            File.AppendAllText("first.world", $"Camera:X={_viewX};Y={_viewY}\n");

        }
        // UI
        private void GroundBox_Click(object sender, EventArgs e)
        {
            curentBlock = 1;
        }

        private void SendBox_Click(object sender, EventArgs e)
        {
            curentBlock = 2;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            CleanWold();
            GenerateWorld();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveWorld();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadWorld();
        }

        private void EmptyBox_Click(object sender, EventArgs e)
        {
            curentBlock = 0;
        }

    }
}
