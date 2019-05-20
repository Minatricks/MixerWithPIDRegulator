using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixer_simulation.TypicalBlocks
{
    public class Noise:TransferBlock //Блок шумів.
    {
        public double Volume //Поріг шуму.
        {
            get { return this.inputs["noise"]; }
            set { this.inputs["noise"] = value; }
        }

        protected Random random;

        protected override void CalcIt()
        {
            double absn = this.x * this.Volume / 100;
            this.y= this.x + 2 * absn * this.random.NextDouble() - absn;
        }

        public Noise(double noise = 1.0) : base()
        {
            this.random = new Random();
            this.inputs.Bus.Add("noise", noise);
        }
    }
}
