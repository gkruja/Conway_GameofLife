using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway_GameofLife
{
    class Cell
    {
        public Cell ()
        {
            IsAlive = false;
            GenerationsAlive = 0;
        }
        public bool IsAlive { get; set; }
        public int GenerationsAlive { get; set; }
    }
}
