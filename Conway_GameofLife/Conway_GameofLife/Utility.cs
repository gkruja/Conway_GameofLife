using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Conway_GameofLife.Properties;


namespace Conway_GameofLife
{
    static class Utility
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int TimeInterval { get; set; }
        public static Color NeightborCountColor { get; set; }
        public static Color LivingNextColor { get; set; }
        public static Color DyingNextColor { get; set; }
        public static Color StillAliveColor { get; set; }
        public static string TypeOfUniverse { get; set; }
        public static bool ViewGrid { get; set; }
        public static bool ViewHud { get; set; }
        public static bool ViewNeightbors { get; set; }
        public static Color Gridlines { get; set; }
        public static Color Gridlinesx10 { get; set; }
        public static Color BackGroundColor { get; set; }


        public static void DrawGrid_10(Graphics e,GraphicsPanel graphicsPanel1)
        {
            float width = (float)graphicsPanel1.ClientSize.Width / (float)Settings.Default.Width;
            float height = (float)graphicsPanel1.ClientSize.Height / (float)Settings.Default.Height;
            float width10 = (float)graphicsPanel1.ClientSize.Width / (float)(Settings.Default.Width / 10);
            float height10 = (float)graphicsPanel1.ClientSize.Height / (float)(Settings.Default.Height / 10);


            if (float.IsInfinity(height10))
                height10 = 0;
            if (float.IsInfinity(width10))
                width10 = 0;
                for (int i = 0; i < height10 / height; i++)
                {
                    Pen mypen = new Pen(Settings.Default.Gridlinesx10, 2f);

                    e.DrawLine(mypen, 0, height * i * 10, (float)graphicsPanel1.ClientSize.Width, height * i * 10);
                }
                        
                for (int j = 0; j < width10 / width; j++)
                {
                    Pen mypen = new Pen(Settings.Default.Gridlinesx10, 2f);
                    e.DrawLine(mypen, width * j * 10, 0, width * j * 10, (float)graphicsPanel1.ClientSize.Height);
                }
            


        }
        public static void DrawGrid(bool[,] universe,Graphics e, GraphicsPanel graphicsPanel1)
        {
            float width = (float)graphicsPanel1.ClientSize.Width / (float)Utility.Width;
            float height = (float)graphicsPanel1.ClientSize.Height / (float)Utility.Height;
            
            for (int y = 0; y < Utility.Height; y++)
            {
                for (int x = 0; x < Utility.Width; x++)
                {

                    RectangleF temp = RectangleF.Empty;
                    temp.X = x * width;
                    temp.Y = y * height;
                    temp.Width = width;
                    temp.Height = height;
                    
                    if (universe[x, y] == true)
                    {
                        if (GetNaighbors(x, y,universe) == 2 || GetNaighbors(x, y,universe) == 3)
                        {
                            
                            e.FillRectangle(new Pen(Utility.StillAliveColor).Brush, temp);
                        }
                        else
                        {
                            
                            e.FillRectangle(new Pen(Utility.DyingNextColor).Brush, temp);
                        }

                    }
                    else if (universe[x, y] == false && GetNaighbors(x, y,universe) == 3)
                    {
                        e.FillRectangle(new Pen(Utility.LivingNextColor).Brush, temp);
                    }

                    e.DrawRectangle(Pens.Black, temp.X, temp.Y, temp.Width, temp.Height);
                    if (GetNaighbors(x,y,universe) > 0 && Utility.ViewNeightbors ==true)
                    {
                        float size = Math.Min(width, height);
                        Font font = new Font("Arial", 0.5f * size);
                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;
                        e.DrawString(GetNaighbors(x, y,universe).ToString(), font, new Pen(Utility.NeightborCountColor).Brush, temp, stringFormat);
                    }


                }
            }
        }

        public static int GetNaighbors(int x,int y, bool[,] universe)
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
            if (x < universe.GetLength(0) - 1)
            {
                if (universe[x + 1, y] == true)
                    count++;
            }
            if (y < universe.GetLength(1) - 1)
            {
                if (universe[x, y + 1] == true)
                    count++;
            }
            if (y < universe.GetLength(1) - 1 && x < universe.GetLength(0) - 1)
            {
                if (universe[x + 1, y + 1] == true)
                    count++;
            }
            if (x > 0 && y < universe.GetLength(1) - 1)
            {
                if (universe[x - 1, y + 1] == true)
                    count++;
            }
            if (y > 0 && x < universe.GetLength(0) - 1)
            {
                if (universe[x + 1, y - 1] == true)
                    count++;
            }


            return count;
        }

        public static void HUD(Graphics e,GraphicsPanel graphicsPanel1, int generation,int living)
        {

                Font font = new Font("Arial", 16f);

                string hud = "Generation: " + generation + "\nCell Count: " + living + "\nTime Interval(ms): " + Utility.TimeInterval+ "\nBoundry Type: Finite" + "\nUniverse Size: " + "{Width="+ Utility.Width+" , "+"Height="+ Utility.Height+" }";
                e.DrawString(hud, font, Brushes.Red, new PointF(0, graphicsPanel1.ClientSize.Height - 125));

        }

        public static void NextGeneration(bool[,] universe,bool[,] UniverseNext)
        {
            for (int y = 0; y < Utility.Height; y++)
            {
                for (int x = 0; x < Utility.Width; x++)
                {
                    if (universe[x, y] == true)
                    {
                        if (GetNaighbors(x, y,universe) == 2 || GetNaighbors(x, y,universe) == 3)
                        {
                            UniverseNext[x, y] = true;
                        }
                        else
                        {
                            UniverseNext[x, y] = false;
                        }

                    }
                    else if (universe[x, y] == false && GetNaighbors(x, y,universe) == 3)
                    {
                        UniverseNext[x, y] = true;
                    }
                    else
                        UniverseNext[x, y] = false;
                }
            }
        }

        public static void SetUtility()
        {
            Utility.Width = Settings.Default.Width;
            Utility.Height = Settings.Default.Height;
            Utility.TimeInterval = Settings.Default.TimeInterval;
            Utility.NeightborCountColor = Settings.Default.NeightborCountColor;
            Utility.LivingNextColor = Settings.Default.LivingNextColor;
            Utility.DyingNextColor = Settings.Default.DyingNextColor;
            Utility.StillAliveColor = Settings.Default.StillAliveColor;
            Utility.TypeOfUniverse = Settings.Default.TypeOfUniverse;
            Utility.ViewGrid = Settings.Default.ViewGrid;
            Utility.ViewHud = Settings.Default.ViewHud;
            Utility.ViewNeightbors = Settings.Default.ViewNeightbors;
            Utility.Gridlines = Settings.Default.Gridlines;
            Utility.Gridlinesx10 = Settings.Default.Gridlinesx10;
            Utility.BackGroundColor = Settings.Default.BackGroundColor;
        }
        public static void SetSettings()
        {
            Settings.Default.Width = Utility.Width;
            Settings.Default.Height = Utility.Height;
            Settings.Default.TimeInterval = Utility.TimeInterval;
            Settings.Default.NeightborCountColor = Utility.NeightborCountColor;
            Settings.Default.LivingNextColor = Utility.LivingNextColor;
            Settings.Default.DyingNextColor = Utility.DyingNextColor;
            Settings.Default.StillAliveColor = Utility.StillAliveColor;
            Settings.Default.TypeOfUniverse = Utility.TypeOfUniverse;
            Settings.Default.ViewGrid = Utility.ViewGrid;
            Settings.Default.ViewHud = Utility.ViewHud;
            Settings.Default.ViewNeightbors = Utility.ViewNeightbors;
            Settings.Default.Gridlines = Utility.Gridlines;
            Settings.Default.Gridlinesx10 = Utility.Gridlinesx10;
            Settings.Default.BackGroundColor = Utility.BackGroundColor;
        }
    }
}
