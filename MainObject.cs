using Mixer_simulation.TypicalBlocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixer_simulation
{
    public class MainObject:BaseBlock //Клас змішувача.
    {
        public System.Double Output //Вихідна величина концентрації.
        {
            get { return this.outputs["output"]; }
            protected set { this.outputs["output"] = value; }
        }
        /*
        public System.Double Pause
        {
            get => this.delay.Time;
            set => this.delay.Time = value;
        }

        public System.Double NoiseVolume
        {
            get => this.noise.Volume;
            set => this.noise.Volume = value;
        }*/

        public System.Double InputGain1 //Вхід для першої концентрації.
        {
            get { return this.inputs["inputGain1"]; }
            set
            {
                this.inputs["inputGain1"] = this.InputClamp[value];
            }
        }
        public System.Double InputGain2 //Вхід для першої ємності потоку.
        {
            get { return this.inputs["inputGain2"]; }
            set
            {
                this.inputs["inputGain2"] = this.InputClamp[value];
            }
        }
        public System.Double InputGain3 //Вхід для другої ємності потоку.
        {
            get { return this.inputs["inputGain3"]; }
            set
            {
                this.inputs["inputGain3"] = this.InputClamp[value];
            }
        }
        
        public System.Double Time //Поточний час, в якому перебуває об'єкт.
        {
            get { return this.outputs["time"]; }
            protected set { this.outputs["time"] = value; }
        }
        protected System.Double time //Внутрішній час, за яким орієнтується об'єкт.
        {
            get { return this.inputs["time"]; }
            set { this.inputs["time"] = value; }
        }

        public System.Double dt
        {
            get { return this.inputs["dt"]; }
            set
            {
                this.inputs["dt"] = value;
                this.delay.dt = value;
                this.Ap.dt = value;
            }
        }



        public MixerCoeficients Coeficients
        { get; protected set; }
        protected Gain gain1;
        protected Gain gain2;
        protected Gain gain3;
        protected Clamp InputClamp; //Клапан, що обмежує подачу на входи.

        protected DAperiodic Ap;
        public Delay delay
        { get; protected set; }
        public Noise noise
        { get; protected set; }

        public MainObject()
        {
            this.outputs.Bus.Add("output", 0.0);
            this.outputs.Bus.Add("time", 0.0);
            this.inputs.Bus.Add("time", 0.0);
            this.inputs.Bus.Add("dt", 1.0);
            this.inputs.Bus.Add("inputGain1", 0.0);
            this.inputs.Bus.Add("inputGain2", 0.0);
            this.inputs.Bus.Add("inputGain3", 0.0);
            this.Ap = new DAperiodic(0, this.dt);
            this.Coeficients = new MixerCoeficients();
            //this.Coeficients.OnPortChanged += this.OnObjectsChange;
            this.delay = new Delay(100, this.dt);
            //this.delay.OnPortChanged += this.OnObjectsChange;
            this.noise = new Noise();
            //this.noise.OnPortChanged += this.OnObjectsChange;
            this.InputClamp = new Clamp(0, 100);
            this.gain1 = new Gain();
            this.gain2 = new Gain();
            this.gain3 = new Gain();
        }

        protected override void CalcIt()
        {
            this.gain1.gain = this.Coeficients.k1; //Заповнення вхідних параметрів.
            this.gain2.gain = this.Coeficients.k2;
            this.gain3.gain = this.Coeficients.k3;
            this.gain1.x = this.InputGain1;
            this.gain2.x = this.InputGain2;
            this.gain3.x = this.InputGain3;
            this.Ap.Time = 1 / this.Coeficients.T;
            this.Ap.x = this.gain1.y + this.gain2.y + this.gain3.y; //Розрахунок вихідних параметрів.
            this.delay.x = this.Ap.y;
            this.noise.x = this.delay.y;
            this.Output = this.noise.y >= 0.0 ? this.noise.y : 0.0; //"Костиль", аби уникнути від'ємної концентрації.
            this.Time = this.time;
        }

        protected void OnObjectsChange(BaseBlock block, BlockIOPortChanged portChanged)
        {
            if (block == this.Coeficients || block == this.noise || block == this.delay && portChanged.Name != "dt") this.IsChanged = true;
            if (portChanged.Name == "dt" && portChanged.Value != this.dt)
            {
                this.dt = this.dt;
                throw new ArgumentException("\"dt\" should be single for whole system.", portChanged.Name);
            }
        }

        public void Reset() //Скидання деяких значень об'єкта, аби його можна було використовувати повторно.
        {
            this.Time = 0;
            this.time = 0;
            this.Ap.Reset();
            this.delay.Reset();
        }

        public void NextTime() //Переведення часу на крок вперед, аби можна було би отримати наступні значення.
        {
            this.time += this.dt;
        }
    }
}
