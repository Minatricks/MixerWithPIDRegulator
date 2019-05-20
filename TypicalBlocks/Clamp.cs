using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixer_simulation.TypicalBlocks
{
    public class Clamp:TransferBlock //Пропускний клапан обмеження потоку.
    {
        public double Max //Максимум який може видати клапан.
        {
            get { return this.inputs["max"]; }
            set { this.inputs["max"] = value; }
        }

        public double Min //Мінімум який може видати клапан.
        {
            get { return this.inputs["min"]; }
            set { this.inputs["min"] = value; }
        }

        protected override void CalcIt()
        {
            this.y = this.x < this.Min ? this.Min : this.x > this.Max ? this.Max : this.x;
        }

        public Clamp(double min, double max):base()
        {
            this.inputs.Bus.Add("min", min);
            this.inputs.Bus.Add("max", max);
        }
    }
}
