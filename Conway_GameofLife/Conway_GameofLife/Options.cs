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
            
            bool temp = Utility.ViewHud;
            Utility.TimeInterval = (int)Timer_UD.Value;
            Utility.Width = (int)Width_UD.Value;
            Utility.Height = (int)Height_UD.Value;
        }

        public Options()
        {
            InitializeComponent();
            // set the options values from the utility;
            Timer_UD.Value = Utility.TimeInterval;
            Width_UD.Value = Utility.Width;
            Height_UD.Value = Utility.Height;
            GridColorButton.BackColor = Utility.Gridlines;
            Grid_10ColorButton.BackColor = Utility.Gridlinesx10;
            BackgroundColorButton.BackColor = Utility.BackGroundColor;
            LiveLivingCellColorButton.BackColor = Utility.StillAliveColor;
            LivingCellColorButton.BackColor = Utility.DyingNextColor;
            DeadLivingCellColorButton.BackColor = Utility.LivingNextColor;
            if (Utility.TypeOfUniverse)
                Torodial_radio.Checked = true;
            else
                Finit_radio.Checked = true;

        }
        private void GridColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog grid = new ColorDialog();
            grid.Color = Utility.Gridlines;
            if (DialogResult.OK == grid.ShowDialog())
            {
                Utility.Gridlines = grid.Color;
                GridColorButton.BackColor = grid.Color;
            }
        }

        private void Grid_10ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog grid10 = new ColorDialog();
            grid10.Color = Utility.Gridlinesx10;
            if (DialogResult.OK == grid10.ShowDialog())
            {
                Utility.Gridlinesx10 = grid10.Color;
                Grid_10ColorButton.BackColor = grid10.Color;
            }
        }

        private void BackgroundColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog background = new ColorDialog();
            background.Color = Utility.BackGroundColor;
            if (DialogResult.OK == background.ShowDialog())
            {
                Utility.BackGroundColor = background.Color;
                BackgroundColorButton.BackColor = background.Color;
            }

        }

        private void LiveLivingCellColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog LL = new ColorDialog();
            LL.Color = Utility.StillAliveColor;
            if (DialogResult.OK == LL.ShowDialog())
            {
                Utility.StillAliveColor = LL.Color;
                LiveLivingCellColorButton.BackColor = LL.Color;
            }

        }

        private void LivingCellColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog LC = new ColorDialog();
            LC.Color = Utility.DyingNextColor;
            if (DialogResult.OK == LC.ShowDialog())
            {
                Utility.DyingNextColor = LC.Color;
                LivingCellColorButton.BackColor = LC.Color;
            }

        }

        private void DeadLivingCellColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog DL = new ColorDialog();
            DL.Color = Utility.LivingNextColor;
            if (DialogResult.OK == DL.ShowDialog())
            {
                Utility.LivingNextColor = DL.Color;
                DeadLivingCellColorButton.BackColor = DL.Color;
            }

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            // default hard codded values that go in decided by me.
            Utility.Width = 50;
            Utility.Height = 50;
            Utility.TimeInterval = 20;
            Utility.NeightborCountColor = Color.Red;
            Utility.LivingNextColor = Color.LightYellow;
            Utility.DyingNextColor = Color.LightGray;
            Utility.StillAliveColor = Color.LightGreen;
            Utility.TypeOfUniverse = true;
            Utility.ViewGrid = true;
            Utility.ViewHud = true;
            Utility.ViewNeightbors = true;
            Utility.Gridlines = Color.Black;
            Utility.Gridlinesx10 = Color.Black;
            Utility.BackGroundColor = Color.White;
        }

        private void Finit_radio_CheckedChanged(object sender, EventArgs e)
        {
            // set type of universe depended on a radio and a bool;
            if (Finit_radio.Checked)
            {
                Utility.TypeOfUniverse = false;
            }
            else
            {
                Utility.TypeOfUniverse = true;
            }
        }
    }
}
