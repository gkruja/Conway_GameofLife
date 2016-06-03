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
        Size universe_size = new Size(50, 25);
        int generation = 0, living = 0;
        bool[,] universe = new bool[50, 25];
        bool[,] UniverseNext = new bool[50, 25];
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Call next generation
            living = 0;
            generation++;
            NextGeneration();
            bool[,] temp = universe;
            universe = UniverseNext;
            UniverseNext = temp;
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    if (universe[x,y] == true)
                    {
                        living ++;   
                    }
                }
            }

            // update toolstrip
            toolStripStatusLabel1.Text = "Generation: " + generation.ToString()+"  Living cells: "+living.ToString();

            // Paint
            graphicsPanel1.Invalidate();

            
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            float width = (float)graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
            float height = (float)graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);
            float width10 = (float)graphicsPanel1.ClientSize.Width / (float)(universe_size.Width/10);
            float height10 = (float)graphicsPanel1.ClientSize.Height / (universe_size.Height / 10);

            for (int i = 0; i < height10 / height; i++)
            {
                Pen mypen = new Pen(Brushes.Black, 2f);

                e.Graphics.DrawLine(mypen, 0, height * i * 10, (float)graphicsPanel1.ClientSize.Width, height * i * 10);

            }
            for (int j = 0; j < width10 / width; j++)
            {
                Pen mypen = new Pen(Brushes.Black, 2f);

                e.Graphics.DrawLine(mypen, width * j * 10, 0, width * j * 10, (float)graphicsPanel1.ClientSize.Height);
            }


            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    
                    RectangleF temp = RectangleF.Empty;
                    temp.X = x * width;
                    temp.Y = y * height;
                    temp.Width = width;
                    temp.Height = height;

                    if (universe[x,y] == true)
                    {
                        if (GetNaighbors(x, y) == 2 || GetNaighbors(x, y) == 3)
                        {
                            e.Graphics.FillRectangle(Brushes.Green, temp);
                        }
                        else
                        {
                            e.Graphics.FillRectangle(Brushes.Gray, temp);
                        }
                       
                    }
                    else if (universe[x, y] == false && GetNaighbors(x, y) == 3)
                    {
                        e.Graphics.FillRectangle(Brushes.LightYellow, temp);
                    }
                    


                    e.Graphics.DrawRectangle(Pens.Black,temp.X,temp.Y,temp.Width,temp.Height);
                    if (GetNaighbors(x,y)>0)
                    {
                        float size = Math.Min(width, height);
                        Font font = new Font("Arial", 0.5f*size);

                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;


                        e.Graphics.DrawString(GetNaighbors(x,y).ToString(), font, Brushes.Red, temp, stringFormat);
                    }
                    

                }
            }
            
            if (true)
            {
                Font font = new Font("Arial", 16f);
                
                string hud = "Generation: " + generation + "\nCell Count: " + living + "\nBoundry Type: N/A" + "\nUniverse Size: " + universe_size;
                e.Graphics.DrawString(hud,font , Brushes.Red, new PointF(0, graphicsPanel1.ClientSize.Height - 100));
            }
            toolStripStatusLabel1.Text = "Generation: " + generation.ToString() + "  Living cells: " + living.ToString();

        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            float width = (float)graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
            float height = (float)graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);

            int x = (int)(e.X /width);
            int y = (int)(e.Y /height);

            if (universe[x, y] == false)
                living++;
            else
                living--;
            universe[x, y] = !universe[x, y];
                graphicsPanel1.Invalidate();
        }



        private void NextGeneration()
        {
            Array.Clear(UniverseNext, 0, UniverseNext.Length);

            //for (int y  = 0; y < universe.GetLength(1); y++)
            //{
            //    for (int x = 0; x < universe.GetLength(0); x++)
            //    {
                    //bool test = false;
                    //if (universe[x, y] == true && GetNaighbors(x,y) <2 )
                    //{
                    //    test = false;
                    //}

                    //if (universe[x, y] == true && (GetNaighbors(x, y) == 2 || GetNaighbors(x, y) == 3))
                    //{
                    //    test = true;
                    //}

                    //if (universe[x, y] == true && GetNaighbors(x,y) >3)
                    //{
                    //    test = false;
                    //}
                    //if (universe[x, y] == false && GetNaighbors(x, y) == 3)
                    //{
                    //    test = true;
                    //}
                    //UniverseNext[x, y] = test;

                    for ( int y = 0; y < universe.GetLength(1); y++)
                    {
                        for ( int x = 0; x < universe.GetLength(0); x++)
                        {



                    if (universe[x, y] == true)
                    {
                        if (GetNaighbors(x, y) == 2 || GetNaighbors(x, y) == 3)
                        {
                            UniverseNext[x, y] = true;
                        }
                        else
                        {
                            UniverseNext[x, y] = false;
                        }

                    }
                    else if (universe[x, y] == false && GetNaighbors(x, y) == 3)
                    {
                        UniverseNext[x, y] = true;
                    }
                    else
                        UniverseNext[x, y] = false;

                    }
            }

        }



        private int GetNaighbors(int x, int y)
        {
            
            int count = 0;

            if (x > 0)
            {
                if (universe[x - 1, y] == true)
                    count++;
            }
            if (y > 0)
            {
                if (universe[x, y - 1] == true)
                    count++;
            }
            if (y > 0 && x > 0)
            {
                if (universe[x - 1, y - 1] == true)
                    count++;
            }
            if (x < universe.GetLength(0)-1)
            {
                if (universe[x + 1, y] == true)
                    count++;
            }
            if (y < universe.GetLength(1) - 1)
            {
                if (universe[x, y + 1] == true)
                    count++;
            }
            if (y < universe.GetLength(1)-1 && x < universe.GetLength(0)-1 )
            {
                if (universe[x + 1, y + 1] == true)
                    count++;
            }
            if (x>0 && y < universe.GetLength(1)-1)
            {
                if (universe[x - 1, y + 1] == true)
                    count++;
            }
            if (y > 0 && x < universe.GetLength(0)-1)
            {
                if (universe[x + 1, y - 1] == true)
                    count++;
            }


            return count;
        }

        

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Array.Clear(universe, 0, universe.Length);
            generation = 0;
            timer.Enabled = false;
            toolStripStatusLabel1.Text = "Generation: " + generation.ToString();
            graphicsPanel1.Invalidate();
        }

        private void PlaytoolStripButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            PlaytoolStripButton.Enabled = false;
            PausetoolStripButton.Enabled = true;
        }

        private void PausetoolStripButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            PlaytoolStripButton.Enabled = true;
            PausetoolStripButton.Enabled = false;
        }

        private void SteptoolStripButton_Click(object sender, EventArgs e)
        {
            Timer_Tick(sender, e);
        }
    }
}
