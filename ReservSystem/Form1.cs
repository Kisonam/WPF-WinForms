using System;
using System.Windows.Forms;

namespace ReservSystem
{
    public partial class Form1 : Form
    {
        ProgressBar[] progressBars;
        public Form1()
        {
            InitializeComponent();
            progressBars = new ProgressBar[]
            {
                progressBar1,
                progressBar2,
                progressBar3,
                progressBar4,
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BuyPlace_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int btnIndex = Convert.ToInt32(button.Tag);
            ProgressBar bars = progressBars[btnIndex];
            Information.Text = $"Table: {btnIndex + 1}. Avalibles places: {bars.Maximum - bars.Value}";


            if (bars.Value != bars.Maximum)
            {
                bars.Value += bars.Step;
                
            }
            else
                Information.Text = $"All places in {btnIndex + 1} table is full! ";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
