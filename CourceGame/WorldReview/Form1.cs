using GameCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldReview
{
    public partial class Form1 : Form
    {
        int[,] _map;
        public Form1()
        {
            InitializeComponent();
            _map = new int[0,0];
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            //Color PenColor 
            Graphics g = e.Graphics;
            for(int x = 0; x < _map.GetLength(0); x++)
            {
                for (int y = 0; y < _map.GetLength(1); y++)
                {
                    if(_map[x, y] != 0)
                    {
                        Pen p = new Pen(SetColor(x, y));
                        if (_map[x, y] == 1)
                            g.DrawRectangle(p, new Rectangle(x * 10, y * 10, 10, 10));
                        else if (_map[x,y] == 2)
                            g.DrawRectangle(p, new Rectangle(x * 10, y * 10, 10, 10));
                    }
                       
                }
            }
        }

        private void btnOpenWorld_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                _map = Core.LoadWorld(openFileDialog1.FileName);
            }

            Invalidate();
            Refresh();
        }

        private Color SetColor(int x, int y)
        {
            switch (_map[x,y])
            {
                case 1:
                    return Color.Cyan;
                case 2:
                    return Color.Black;
            }
            return Color.White;
        }
    }
}
