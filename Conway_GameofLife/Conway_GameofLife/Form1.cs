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
            Utility.SetUtility();


            viewHUDToolStripMenuItem.Checked = Utility.ViewHud;
            viewNeighborsToolStripMenuItem.Checked = Utility.ViewNeightbors;
            vIewGridToolStripMenuItem.Checked = Utility.ViewGrid;

            timer.Interval = Utility.TimeInterval;
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
            if (Utility.ViewGrid ==true)
            {
                Utility.DrawGrid_10(e.Graphics, graphicsPanel1);
            }
            Utility.DrawGrid(universe, e.Graphics, graphicsPanel1);

            if (Utility.ViewHud ==true)
            {
                Utility.HUD(e.Graphics, graphicsPanel1, generation, living);
            }
            toolStripStatusLabel1.Text = "Generation: " + generation.ToString() + "  Living cells: " + living.ToString();

        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                float width = (float)graphicsPanel1.ClientSize.Width / (float)Utility.Width;
                float height = (float)graphicsPanel1.ClientSize.Height / (float)Utility.Height;

                int x = (int)(e.X / width);
                int y = (int)(e.Y / height);

                if (universe[x, y] == false)
                    living++;
                else
                    living--;
                universe[x, y] = !universe[x, y];
                graphicsPanel1.Invalidate();
            }
            else
            {
                Point p = new Point(e.X + Location.X, Location.Y + e.Y);
                contextMenuStrip1.Show(p);
            }
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
                universe = ResizeArray(universe, Utility.Width, Utility.Height);
                UniverseNext = ResizeArray(UniverseNext, Utility.Width, Utility.Height);
                timer.Interval = Utility.TimeInterval;
                graphicsPanel1.Invalidate();
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utility.SetSettings();
            Settings.Default.Save();
        }
        private void SteptoolStripButton_Click(object sender, EventArgs e)
        {
            Timer_Tick(sender, e);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            PausetoolStripButton_Click(sender, e);


            OpenFileDialog open = new OpenFileDialog();

            if (DialogResult.OK == open.ShowDialog())
            {
                try
                {
                    if (open.OpenFile() != null)
                    {
                        StreamReader read = new StreamReader(open.FileName);
                        string Fileread = read.ReadToEnd();
                        string[] split = { "\n" ,"\r\n"};


                        int max = 0;
                        int comment = 0;
                        string[] ReadSplit = Fileread.Split(split, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < ReadSplit.Length; i++)
                        {
                            if (ReadSplit[i].Contains("!"))
                            {
                                comment++;
                                continue;
                            }

                            if (max < ReadSplit[i].Length)
                                max = ReadSplit[i].Length;
                        }
                            //resize universe with a padding of 5 on all sides.
                        Utility.Width = max+10;
                        Utility.Height = (ReadSplit.Length - comment) +10;
                        Array.Clear(universe, 0, universe.Length);
                        universe = ResizeArray(universe, Utility.Width, Utility.Height);
                        UniverseNext = ResizeArray(UniverseNext,Utility.Width, Utility.Height);
                        // coppy file into bool array

                        for (int i = 0+comment; i < ReadSplit.Length; i++)
                        {
                                for (int j = 0; j < max; j++)
                                {
                                    if (ReadSplit[i][j] == 'O')
                                {
                                    universe[(j) + 5, (i - 2) + 5] = true;
                                    living++;

                                }
                            }
                            
                        }
                        read.Close();
                    }

                }
                catch (IOException)
                {

                    MessageBox.Show("(File Not Found!");
                }

                graphicsPanel1.Invalidate();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            PausetoolStripButton_Click(sender, e);

            SaveFileDialog open = new SaveFileDialog();
            open.Filter = "txt files (*.txt)|*.txt";
            // saves with default value
            if (DialogResult.OK == open.ShowDialog())
            {
                string userName = Environment.UserName;
                StreamWriter write = new StreamWriter(open.FileName);
                write.Write("! Written by "+  userName +"\r\n");
                write.Write("! Design was auto generated by a program\r\n");
                for (int y = 0; y < Utility.Height; y++)
                {
                    for (int x = 0; x < Utility.Width; x++)
                    {
                        if (universe[x, y] == true)
                            write.Write('O');
                        else
                            write.Write('.');
                    }
                    write.Write("\r\n");
                }
                write.Close();
            }

         }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void vIewGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vIewGridToolStripMenuItem.Checked)
            {
                vIewGridToolStripMenuItem.Checked = false;
                viewGridToolStripMenuItem1.Checked = false;
                Utility.ViewGrid = false;
            }
            else
            {
                vIewGridToolStripMenuItem.Checked = true;
                viewGridToolStripMenuItem1.Checked = true;
                Utility.ViewGrid = true;
            }
            graphicsPanel1.Invalidate();

        }

        private void viewHUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewHUDToolStripMenuItem.Checked)
            {
                viewHUDToolStripMenuItem.Checked = false;
                viewHUDToolStripMenuItem1.Checked = false;
                Utility.ViewHud = false;
            }
            else
            {
                viewHUDToolStripMenuItem.Checked = true;
                viewHUDToolStripMenuItem1.Checked = true;
                Utility.ViewHud = true;
            }
            graphicsPanel1.Invalidate();

        }

        private void viewNeighborsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewNeighborsToolStripMenuItem.Checked)
            {
                viewNeighborsToolStripMenuItem.Checked = false;
                viewNeightborsToolStripMenuItem.Checked = false;
                Utility.ViewNeightbors = false;
            }
            else
            {
                viewNeighborsToolStripMenuItem.Checked = true;
                viewNeightborsToolStripMenuItem.Checked = true;

                Utility.ViewNeightbors = true;
            }
            graphicsPanel1.Invalidate();

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PausetoolStripButton_Click(sender, e);
            OpenFileDialog open = new OpenFileDialog();

            if (DialogResult.OK == open.ShowDialog())
            {
                try
                {
                    if (open.OpenFile() != null)
                    {
                        StreamReader read = new StreamReader(open.FileName);

                        string Fileread = read.ReadToEnd();
                        string[] split = { "\r\n" ,"\n"};
                        string[] ReadSplit = Fileread.Split(split, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < ReadSplit.Length; ++i)
                        {
                            if (ReadSplit[i].Contains("!"))
                            {

                            }
                            else
                            {
                                for (int j = 0; j < ReadSplit[i].Length; j++)
                                {
                                    if (ReadSplit[i][j] == 'O' && j< Utility.Width)
                                    {
                                        if (universe[j, i - 2] != true)
                                            living++;

                                        universe[j, i - 2] = true;
                                    }

                                }
                            }
                        }
                        read.Close();
                    }
                }
                catch (IOException)
                {

                    MessageBox.Show("(File Not Found!");
                }
                graphicsPanel1.Invalidate();
            }
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
