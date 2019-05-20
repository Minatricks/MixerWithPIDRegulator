using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixer_simulation.TypicalBlocks
{
    public class Gain : TransferBlock //Блок підсилення.
    {
        public double gain //Коефіцієнт підсилення.
        {
            get { return this.inputs["k"]; }
            set { this.inputs["k"] = value; }
        }

        protected override void CalcIt()
        {
            this.y = this.x * this.gain;
        }

        public Gain(double gain = 1.0) : base()
        {
            this.inputs.Bus.Add("k", gain);
        }
    }
}
