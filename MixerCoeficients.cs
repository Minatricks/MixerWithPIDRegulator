using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixer_simulation
{
    public class MixerCoeficients:BaseBlock //Коефіцієнти для розрахунку змішувача.
    {
        public double T //Розраховуваний коефіцієнт "T".
        {
            get { return this.outputs["T"]; }
            protected set { this.outputs["T"] = value; }
        }

        public double k1 //Розраховуваний коефіцієнт "k1".
        {
            get { return this.outputs["k1"]; }
            protected set { this.outputs["k1"] = value; }
        }

        public double k2 //Розраховуваний коефіцієнт "k2".
        {
            get { return this.outputs["k2"]; }
            protected set { this.outputs["k2"] = value; }
        }
        
        public double k3 //Розраховуваний коефіцієнт "k3".
        {
            get { return this.outputs["k3"]; }
            protected set { this.outputs["k3"] = value; }
        }

        public double G_in1 //Ємність першого потоку (кг/с).
        {
            get { return this.inputs["G_in1"]; }
            set { this.inputs["G_in1"] = value; }
        }

        public double G_in2 //Ємність другого потоку (кг/с).
        {
            get { return this.inputs["G_in2"]; }
            set { this.inputs["G_in2"] = value; }
        }
        
        public double c_in1 //Концентрація першого потоку (кг/кг).
        {
            get { return this.inputs["c_in1"]; }
            set { this.inputs["c_in1"] = value; }
        }

        public double c_in2 //Концентрація другого потоку (кг/кг).
        {
            get { return this.inputs["c_in2"]; }
            set { this.inputs["c_in2"] = value; }
        }
        
        public double c0 //Початкова концентрація в резервуарі.
        {
            get { return this.inputs["c0"]; }
            set { this.inputs["c0"] = value; }
        }
        
        public double Density //Густина в усіх потоках та резервуарі. (кг/м3).
        {
            get { return this.inputs["density"]; }
            set { this.inputs["density"] = value; }
        }
        
        public double Volume //Об'єм резервуару (м3).
        {
            get { return this.inputs["volume"]; }
            set { this.inputs["volume"] = value; }
        }

        protected override void CalcIt() //Розрахунок коефіцієнтів.
        {
            this.T = (Density * Volume) / (G_in1 + G_in2);
            this.k1 = G_in1 / (G_in1 + G_in2);
            this.k2= (c_in1 - c0) / (G_in1 + G_in2);
            this.k3 = (c_in2 - c0) / (G_in1 + G_in2);
        }

        public MixerCoeficients(double g_in1 = 0.0, double g_in2 = 0.0, double c_in1 = 0.0, double c_in2 = 0.0, double c0 = 0.0, double density = 0.0, double volume = 0.0) : base()
        {
            this.inputs.Bus.Add("G_in1", g_in1);
            this.inputs.Bus.Add("G_in2", g_in2);
            this.inputs.Bus.Add("c_in1", c_in1);
            this.inputs.Bus.Add("c_in2", c_in2);
            this.inputs.Bus.Add("c0", c_in1);
            this.inputs.Bus.Add("density", c_in1);
            this.inputs.Bus.Add("volume", c_in1);

            this.outputs.Bus.Add("T", 0.0);
            this.outputs.Bus.Add("k1", 0.0);
            this.outputs.Bus.Add("k2", 0.0);
            this.outputs.Bus.Add("k3", 0.0);
        }
    }
}
