using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conway_GameofLife.Properties;

namespace Conway_GameofLife
{
    public partial class Options : Form
    {

        private void OkButton_Click(object sender, EventArgs e)
        {
            
            bool temp = Settings.Default.ViewHud;
            Settings.Default.TimeInterval = (int)Timer_UD.Value;
            Settings.Default.Width = (int)Width_UD.Value;
            Settings.Default.Height = (int)Height_UD.Value;
        }

        public Options()
        {
            InitializeComponent();
            
            Timer_UD.Value = Settings.Default.TimeInterval;
            Width_UD.Value = Settings.Default.Width;
            Height_UD.Value = Settings.Default.Height;
            GridColorButton.BackColor = Settings.Default.Gridlines;
            Grid_10ColorButton.BackColor = Settings.Default.Gridlinesx10;
            BackgroundColorButton.BackColor = Settings.Default.BackGroundColor;
            LiveLivingCellColorButton.BackColor = Settings.Default.StillAliveColor;
            LivingCellColorButton.BackColor = Settings.Default.DyingNextColor;
            DeadLivingCellColorButton.BackColor = Settings.Default.LivingNextColor;

        }

        private void GridColorButton_Click(object sender, EventArgs e)
        {

        }

        private void Grid_10ColorButton_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundColorButton_Click(object sender, EventArgs e)
        {

        }

        private void LiveLivingCellColorButton_Click(object sender, EventArgs e)
        {

        }

        private void LivingCellColorButton_Click(object sender, EventArgs e)
        {

        }

        private void DeadLivingCellColorButton_Click(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //Settings.Default.Width = 50;
            //Settings.Default.Height = 50;
            //Settings.Default.TimeInterval = 20;
            //Settings.Default.NeightborCountColor = Color.Red;
            //Settings.Default.LivingNextColor = Color.LightYellow;
            //Settings.Default.DyingNextColor = Color.LightGray;
            //Settings.Default.StillAliveColor = Color.LightGreen;
            //Settings.Default.TypeOfUniverse = "finite";
            //Settings.Default.ViewGrid = true;
            //Settings.Default.ViewHud = true;
            //Settings.Default.ViewNeightbors = true;
            //Settings.Default.Gridlines = Color.Black;
            //Settings.Default.Gridlinesx10 = Color.Black;
            //Settings.Default.BackGroundColor = Color.White;
        }
    }
}
