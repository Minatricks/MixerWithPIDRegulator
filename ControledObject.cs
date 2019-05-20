using Mixer_simulation.TypicalBlocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixer_simulation
{
    public class ControledObject
    {
        public PIDregulator Regulator
        { get; protected set; }
        public MainObject mainObject
        { get; protected set; }
        protected System.Boolean auto = false;
        public System.Boolean Auto
        {
            get => this.auto;
            set
            {
                this.SetRegulator();
                this.auto = value;
            }
        }
        public System.Double SetPoint;

        private void SetRegulator() //Функція приведення регулятора з ручного в автоматичний режим.
        {
            System.Double x = (this.mainObject.InputGain2 * this.dt) / ((this.Regulator.Kp + this.Regulator.Ki * this.dt) * this.dt + this.Regulator.Kd);
            this.Regulator.Reset();
            this.Regulator.Integral.x_old = x;
            this.Regulator.difference.x_old = x;
        }

        private System.Double dt_main = 1.0;
        public System.Double dt
        {
            get => this.dt_main;
            set
            {
                this.dt_main = value;
                this.Regulator.dt = value;
                this.mainObject.dt = value;
            }
        }

        protected void OnBlocksChange(BaseBlock block, BlockIOPortChanged portChanged)
        {
            if (portChanged.Name == "dt" && portChanged.Value != this.dt)
            {
                this.dt = this.dt;
                throw new ArgumentException("\"dt\" should be single for whole system.", portChanged.Name);
            }
            if (block == this.mainObject && portChanged.Name == "time" && this.auto) this.mainObject.InputGain2 = this.Regulator.y; //Задання регулятором положення клапана в автоматичному режимі.
        }

        protected void OnMainObjectComplete(BaseBlock block)
        {
            if (block == this.mainObject && this.auto)
             this.Regulator.x = this.mainObject.Output - this.SetPoint; //Внесення відхилення в регулятор.
        }

        public ControledObject(MainObject main = null, PIDregulator regulator = null, System.Double dt = 1.0)
        {
            this.Regulator = regulator ?? new PIDregulator();
            this.mainObject = main ?? new MainObject();
            this.mainObject.OnChangesApplied += this.OnMainObjectComplete;
            this.mainObject.OnPortChanged += this.OnBlocksChange;
            this.Regulator.OnPortChanged += this.OnBlocksChange;
            this.dt = dt;
        }

        public void Reset()
        {
            this.mainObject.Reset();
            this.Regulator.Reset();
        }
    }
}
