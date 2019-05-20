using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixer_simulation.TypicalBlocks
{
    public class Integral : DiscreteTrasferBlock //Інтегральний блок.
    {
        public double x_old = 0.0; //Попереднє значення "x".

        protected override void CalcIt()
        {
            this.y = this.y + this.dt * (this.x_old + this.x) / 2;
            this.x_old = this.x;
        }

        public void Reset()
        {
            this.x_old = 0.0;
            this.y = 0;
        }
    }
}
