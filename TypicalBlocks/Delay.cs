using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixer_simulation.TypicalBlocks
{
    public class Delay:DiscreteTrasferBlock //Блок запізнення.
    {
        protected Queue<double> buff;
        protected int cap;
        public override double dt
        {
            get { return base.dt; }
            set
            {
                base.dt = value;
                this.recap();
            }
        }
        public double Time
        {
            get { return this.inputs["Time"]; }
            set
            {
                this.inputs["Time"] = value;
                this.recap();
            }
        }

        private void recap()
        { this.cap = (int)(this.Time / this.dt); }

        protected override void CalcIt()
        {
            buff.Enqueue(this.x);
            this.y = this.buff.Count < this.cap ? 0 : buff.Dequeue(); //Якщо попередніх значень набралося не достатньо, блок повертає нуль.
        }

        public Delay(double Time = 1.0, double dt = 1.0) : base(dt)
        {
            this.inputs.Bus.Add("Time", Time);
            this.buff = new Queue<double>(0);
        }

        public void Reset() //Очистка буферу.
        {
            try
            {
                this.buff.Clear();
            }
            finally { }
        }
    }
}
