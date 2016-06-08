using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Conway_GameofLife.Properties;


namespace Conway_GameofLife
{
    public partial class Form1 : Form
    {
        int generation = 0, living = 0;
        bool[,] universe = new bool[Settings.Default.Width, Settings.Default.Height];
        bool[,] UniverseNext = new bool[Settings.Default.Width, Settings.Default.Height];
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            Settings.Default.ViewNeightbors = false;
            timer.Interval = Settings.Default.TimeInterval;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            // Call next generation
            living = 0;
            generation++;
            Utility.NextGeneration(universe, UniverseNext);
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



            if (Settings.Default.ViewGrid ==true)
            {
                Utility.DrawGrid_10(e.Graphics, graphicsPanel1);
                Utility.DrawGrid(universe, e.Graphics, graphicsPanel1);
            }
            if (Settings.Default.ViewHud ==true)
            {
                Utility.HUD(e.Graphics, graphicsPanel1, generation, living);

            }

            toolStripStatusLabel1.Text = "Generation: " + generation.ToString() + "  Living cells: " + living.ToString();

        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            float width = (float)graphicsPanel1.ClientSize.Width / (float)Settings.Default.Width;
            float height = (float)graphicsPanel1.ClientSize.Height / (float)Settings.Default.Height;

            int x = (int)(e.X /width);
            int y = (int)(e.Y /height);

            if (universe[x, y] == false)
                living++;
            else
                living--;
            universe[x, y] = !universe[x, y];
                graphicsPanel1.Invalidate();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Array.Clear(universe, 0, universe.Length);
            generation = 0;
            living = 0;
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

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options temp = new Options();

            if (DialogResult.OK == temp.ShowDialog())
            {
                Array.Clear(universe, 0, universe.Length);
                universe = ResizeArray(universe, Settings.Default.Width, Settings.Default.Height);
                UniverseNext = ResizeArray(UniverseNext, Settings.Default.Width, Settings.Default.Height);
                timer.Interval = Settings.Default.TimeInterval;
                graphicsPanel1.Invalidate();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Settings.Default.Save();
        }

        private void SteptoolStripButton_Click(object sender, EventArgs e)
        {
            Timer_Tick(sender, e);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            
            //OpenFileDialog open = new OpenFileDialog();
            
            //if (DialogResult.OK == open.ShowDialog())
            //{
            //    try
            //    {
            //        if (open.OpenFile() != null)
            //        {
            //            StreamReader read = new StreamReader(open.FileName);
            //            string Fileread = read.ReadToEnd();
            //            string[] split = { "\r\n" };

            //            Settings.Default.Width = 50;
            //            Settings.Default.Height = 50;
            //            Array.Clear(universe, 0, universe.Length);
            //            universe = ResizeArray(universe, 50, 50);
            //            UniverseNext = ResizeArray(UniverseNext, 50,50);

            //            string [] ReadSplit = Fileread.Split(split,StringSplitOptions.RemoveEmptyEntries);
            //            for (int i = 0; i < ReadSplit.Length ; ++i)
            //            {
            //                if (ReadSplit[i].Contains("!"))
            //                {
                                
            //                }
            //                else
            //                {
            //                    for (int j = 0; j < ReadSplit[i].Length;j++)
            //                    {
            //                         if (ReadSplit[i][j] == 'O')
            //                            universe[j,i] = true;                                    
            //                    }
            //                }
            //            }
            //            read.Close();

            //        }

            //    }
            //    catch (IOException)
            //    {

            //        MessageBox.Show("(File Not Found!");
            //    }
                
            //    graphicsPanel1.Invalidate();

            //}
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }













        //  Change and work with this code (Taken from stack overload)
        //  http://stackoverflow.com/questions/6539571/how-to-resize-multidimensional-2d-array-in-c
        T[,] ResizeArray<T>(T[,] original, int rows, int cols)
        {
            Array.Clear(original, 0, original.Length);
            var newArray = new T[rows, cols];
            int minRows = Math.Min(rows, original.GetLength(0));
            int minCols = Math.Min(cols, original.GetLength(1));
            for (int i = 0; i < minRows; i++)
                for (int j = 0; j < minCols; j++)
                    newArray[i, j] = original[i, j];
            return newArray;
        }
    }
}
