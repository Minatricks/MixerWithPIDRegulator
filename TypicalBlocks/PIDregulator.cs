using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixer_simulation.TypicalBlocks
{
    public class PIDregulator:DiscreteTrasferBlock
    {
        public double Kp
        {
            get
            { return this.Kp_gain.gain; }
            set
            {
                this.Kp_gain.gain = value;
                this.IsChanged = true;
            }
        }

        public double Ki
        {
            get { return this.Ki_gain.gain; }
            set
            {
                if (value != 0.0)
                {
                    this.Ki_gain.gain = value;
                    this.IsChanged = true;
                }
                else throw new DivideByZeroException("'Ki' attribute can't be equal zero, because 'Ti' will be infinite.");
            }
        }

        public double Kd
        {
            get { return this.Kd_gain.gain; }
            set
            {
                if (value != 0.0)
                {
                    this.Kd_gain.gain = value;
                    this.IsChanged = true;
                }
                else throw new DivideByZeroException("'Kd' attribute can't be equal zero, because 'Td' will be infinite.");
            }
        }

        public override double dt
        {
            get { return base.dt; }
            set
            {
                base.dt = value;
                this.Integral.dt = value;
                this.difference.dt = value;
            }
        }

        public Gain Kp_gain
        { get; protected set; }
        public Gain Ki_gain
        { get; protected set; }
        public Gain Kd_gain
        { get; protected set; }
        public Integral Integral
        { get; protected set; }
        public Difference difference
        { get; protected set; }

        protected override void CalcIt()
        { //Математичний апарат ПІД-регулятора
            this.y = this.Kp_gain[x] + this.Ki_gain[this.Integral[this.x]] + this.Kd_gain[this.difference[this.x]];
        }

        public void Reset()
        {
            this.Integral.Reset();
            this.difference.Reset();
        }

        public PIDregulator(double k = 1.0, double ki = 1.0, double kd = 1.0, double dt = 1.0) : base(dt)
        {
            this.Kp_gain = new Gain(k);
            this.Ki_gain = new Gain(ki);
            this.Kd_gain = new Gain(kd);
            this.Integral = new Integral();
            this.difference = new Difference();
            this.dt = dt;
        }
    }
}
