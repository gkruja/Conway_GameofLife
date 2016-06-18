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
    public partial class RandOptions : Form
    {
        public RandOptions()
        {
  
            InitializeComponent();

            Seed_UD.Value = Utility.seed;
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Utility.seed = (int)Seed_UD.Value;
            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rand_button_Click(object sender, EventArgs e)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            Seed_UD.Value = r.Next();
        }
    }
}
