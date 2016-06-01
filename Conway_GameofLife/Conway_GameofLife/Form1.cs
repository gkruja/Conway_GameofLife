using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conway_GameofLife
{
    public partial class Form1 : Form
    {
        bool[,] universe = new bool[7, 7];
        Timer timer = new Timer();
        int generation = 0;
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            // Call next generation
            generation++;

            // update toolstrip

            // Paint
            graphicsPanel1.Invalidate();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            float width = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            float height = graphicsPanel1.ClientSize.Height / universe.GetLength(1);


            for (int y = 0; y < universe.GetLength(0); y++)
            {
                for (int x = 0; x < universe.GetLength(1); x++)
                {
                    
                    RectangleF temp = RectangleF.Empty;
                    temp.X = x * width;
                    temp.Y = y * height;
                    temp.Width = width;
                    temp.Height = height;

                    if (universe[x,y] == true)
                    {
                        e.Graphics.FillRectangle(Brushes.Gray, temp);
                    }
                    e.Graphics.DrawRectangle(Pens.Black,temp.X,temp.Y,temp.Width,temp.Height);

                }
            }
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            int width = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            int height = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

            int x = e.X /width;
            int y = e.Y /height;


            universe[x, y] = !universe[x, y];
                graphicsPanel1.Invalidate();
        }
    }
}
