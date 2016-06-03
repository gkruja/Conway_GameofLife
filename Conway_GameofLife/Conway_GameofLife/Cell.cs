using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway_GameofLife
{
    class Cell
    {
        bool IsAlive { get; set; }
        int GenerationsAlive { get; set; }
        bool NextGeneration { get; set; }
    }
}
