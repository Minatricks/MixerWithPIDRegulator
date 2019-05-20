using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixer_simulation.TypicalBlocks
{
    public class DAperiodic : DiscreteTrasferBlock //Аперіодична ланка 1-го порядку, за рекурентною формулою.
    {
        public double Time //Коефцієнт "1/Т".
        {
            get { return this.inputs["Time"]; }
            set { this.inputs["Time"] = value; }
        }

        public DAperiodic(double time, double dt = 1.0) : base(dt)
        {
            this.inputs.Bus.Add("Time", time);
        }

        protected override void CalcIt()
        {
            this.y = (this.x * this.dt + this.Time * this.y) / (this.Time + this.dt);
        }

        public void Reset() //Скидання блоку перед повторним застосуванням.
        {
            this.y = 0;
        }
    }
}
