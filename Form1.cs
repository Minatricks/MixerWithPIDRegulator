using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mixer_simulation
{
    public partial class Form1 : Form
    {
        public MainObject Object //Змішувач, що керується.
        { get; protected set; }
        public ControledObject Control
        { get; protected set; }
        public bool InWork //Вказує чи проводиться зараз симуляція.
        { get; protected set; }
        public bool IsPaused //Вказує чи симуляція зараз тимчасово перервана.
        { get; protected set; }
        protected System.UInt16 maxPoints;
        public System.UInt16 MaxPointsOnPlot
        {
            get => this.maxPoints;
            set
            {
                this.maxPoints = value;
                this.ReactChart.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
            this.Object = new MainObject();
            this.Control = new ControledObject(this.Object);

            this.Control.mainObject.OnPortChanged += this.OnInpChange;
            //this.Control.mainObject.noise.OnPortChanged += this.OnInpChange;

            this.InWork = false;
            this.IsPaused = true;
            this.Object.Reset();
            this.Object.delay.Time = 10;
            this.Object.noise.Volume = 0;
            this.Object.dt = 1;
            this.Executor.Interval = 1000;

            this.MaxPointBar.Value = 2;
            this.MaxPointsOnPlot = 50;

            this.Flow1CapEdit.Text = "0,006"; //Заповнення полів параметрів об'єкта, аби не "морати руки".
            this.Flow2CapEdit.Text = "0,017";
            this.Flow1ConcEdit.Text = "0,02";
            this.Flow2ConcEdit.Text = "0,07";
            this.InitConEdit.Text = "0,05";
            this.TankVolEdit.Text = "7";
            this.LiqDensEdit.Text = "900";

            this.SetPointEdit.Text = "30";
            this.KEdit.Text = "0,174";
            this.TiEdit.Text = "0,0174";
            this.TdEdit.Text = "0,0174";
        }

        private void SimStartBut_Click(object sender, EventArgs e)
        {
            if (this.InWork)
            { //Зупинка симуляції.
                this.Executor.Stop();
                this.Control.Reset();
                this.ReactChart.Series[0].Points.Clear();
                this.IsPaused = true;
                this.SimStartBut.Text = "Start";
                this.PauseBut.Text = "Pause";
                this.PauseBut.Enabled = false;
            }
            else
            { //Повторний її запуск.
                this.Executor.Start();
                this.IsPaused = false;
                this.SimStartBut.Text = "Reset";
                this.PauseBut.Enabled = true;
            }
            this.InWork = !this.InWork;
        }

        private void PauseBut_Click(object sender, EventArgs e) //Перерва в симуляції.
        {
            if (!this.InWork) return;
            if (this.IsPaused)
            {
                this.Executor.Start();
                this.PauseBut.Text = "Pause";
            }
            else
            {
                this.Executor.Stop();
                this.PauseBut.Text = "Resume";
            }
            this.IsPaused = !this.IsPaused;
        }

        private void Flow1CapEdit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double to_parse = 0.0;
                if (Double.TryParse(((TextBox)sender).Text, out to_parse))
                { 
                    //Заповнення параметрів об'єкта.
                    ((TextBox)sender).BackColor = Color.White; //Якщо значення витримано в правильному форматі, поле його вводу стає білим.
                    if (sender == this.Flow1CapEdit) this.Object.Coeficients.G_in1 = to_parse;
                    if (sender == this.Flow2CapEdit) this.Object.Coeficients.G_in2 = to_parse;
                    if (sender == this.Flow1ConcEdit) this.Object.Coeficients.c_in1 = to_parse;
                    if (sender == this.Flow2ConcEdit) this.Object.Coeficients.c_in2 = to_parse;
                    if (sender == this.InitConEdit) this.Object.Coeficients.c0 = to_parse;
                    if (sender == this.TankVolEdit) this.Object.Coeficients.Volume = to_parse;
                    if (sender == this.LiqDensEdit) this.Object.Coeficients.Density = to_parse;

                    if (sender == this.SetPointEdit) this.Control.SetPoint = to_parse;
                    if (sender == this.KEdit) this.Control.Regulator.Kp = to_parse;
                    if (sender == this.TiEdit)
                    {
                        if (to_parse == 0.0) ((TextBox)sender).BackColor = Color.Red;
                        this.Control.Regulator.Ki = to_parse;
                    }
                    if (sender == TdEdit)
                    {
                        if (to_parse == 0.0) ((TextBox)sender).BackColor = Color.Red;
                        this.Control.Regulator.Kd = to_parse;
                    }
                }
                else ((TextBox)sender).BackColor = Color.Red; //Якщо значення введено в не правильному форматі, поле його вводу стає червоним.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Executor_Tick(object sender, EventArgs e)
        {
            this.ReactChart.Series[0].Points.AddXY(this.Object.Time, this.Object.Output); //Додаавання точки на графік.
            if (this.ReactChart.Series[0].Points.Count > this.maxPoints)
            {
                this.ReactChart.ChartAreas[0].AxisX.ScaleView.Zoom(this.Object.Time - Convert.ToDouble(this.MaxPointsOnPlot), this.Object.Time);
                this.ReactChart.ChartAreas[0].AxisX.Maximum = this.Object.Time;
            }
            else this.ReactChart.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(this.maxPoints);
            this.Object.NextTime(); //Переведення об'єкта на наступний час.
        }

        private void SgnInBar_Scroll(object sender, EventArgs e) //Змінення величин що входять в об'єкт.
        {
            if (sender == this.SgnIn1Bar) this.Object.InputGain1 = Convert.ToDouble(this.SgnIn1Bar.Value);
            if (sender == this.SgnIn2Bar) this.Object.InputGain2 = Convert.ToDouble(this.SgnIn2Bar.Value);
            if (sender == this.SgnIn3Bar) this.Object.InputGain3 = Convert.ToDouble(this.SgnIn3Bar.Value);

            if (sender == this.MaxPointBar)
            {
                System.UInt16 AreaSize = 0;
                switch (this.MaxPointBar.Value)
                {
                    case 0:
                        AreaSize = 10;
                        break;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        AreaSize = 25;
                        for (System.UInt16 i = 1; i < this.MaxPointBar.Value; i++) AreaSize += AreaSize;
                        break;
                    case 5:
                        AreaSize = 500;
                        break;
                    case 6:
                        AreaSize = 1000;
                        break;
                }
                this.MaxPointsOnPlot = AreaSize;
            }
            if (sender == this.NoiseBar) this.Control.mainObject.noise.Volume = this.NoiseBar.Value;
        }

        private void OnInpChange(BaseBlock block, BlockIOPortChanged portChanged)
        {
            if (block==this.Control.mainObject)
            {
                switch(portChanged.Name)
                {
                    case "inputGain1":
                        this.SgnIn1Label.Text = "Signal Input of Concentration 1 (" + portChanged.Value + "%)";
                        break;
                    case "inputGain2":
                        this.SgnIn2Label.Text = "Signal Input of Capacity 1 (" + portChanged.Value + "%)";
                        break;
                    case "inputGain3":
                        this.SgnIn3Label.Text = "Signal Input of Capacity 2 (" + portChanged.Value + "%)";
                        break;
                }
            }
            if (block == this.Control.mainObject.noise && portChanged.Name == "noise") this.NoiseLabel.Text = "Noise Level (" + portChanged.Value + ")";
        }

        private void PlotUpdateBar_Scroll(object sender, EventArgs e) //Змінна швидкості оновлення графіку.
        {
            this.Executor.Interval = 1000 - (this.PlotUpdateBar.Value * 100);
            this.PlotUpdateLabel.Text = "Plot update (" + this.Executor.Interval.ToString() + "ms)";
        }

        private void AutoCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.SgnIn2Bar.Enabled = !(this.Control.Auto = !this.Control.Auto);
            if (!this.Control.Auto)
            {
                this.SgnIn2Bar.Value = Convert.ToUInt16(this.Control.mainObject.InputGain2);
            }
        }
    }
}
