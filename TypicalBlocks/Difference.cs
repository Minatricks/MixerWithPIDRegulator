using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixer_simulation.TypicalBlocks
{
    public class Difference:DiscreteTrasferBlock
    {
        public double x_old = 0.0;

        public void Reset()
        {
            this.x_old = 0.0;
            this.y = 0;
        }

        protected override void CalcIt()
        {
            this.y = (this.x - this.x_old) / this.dt;
            this.x_old = this.x;
        }
    }
}
