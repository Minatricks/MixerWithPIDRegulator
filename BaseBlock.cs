using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixer_simulation
{

    public class BaseBlock //Каркас для обчислювальних блоків.
    {
        public class IOBus //Клас для умовної шини даних.
        {
            private Dictionary<System.String, Double> bus; //Набір портів.
            protected BaseBlock Block; //Обчислювальний блок якому вони належать.
            protected bool is_input = true; //Чи є цей набір входами.
            public double this[System.String name] //Оператор для зверненя до портів.
            {
                get
                {
                    if (!is_input && this.Block.IsChanged) //Якщо набір портів є вхідним, і об'єкт змінив свій стан, то здійснюється розрахунок нових вихідних значень блоку.
                    {
                        this.Block.IsChanged = false; //Прапорець зміни стану змінююється відразу, аби при звернені до виходів, всередині класу, не траплялася рекурсія.
                        this.Block.CalcIt();
                        this.Block.OnChangesApplied?.Invoke(this.Block);
                    }
                    return this.bus[name];
                }
                set
                {
                    this.bus[name] = value;
                    if (this.is_input)
                    {
                        this.Block.IsChanged = true; //Якщо порти вхідні, вони сигналізують про зміну вхідних параметрів.
                        this.Block.OnPortChanged?.Invoke(this.Block, new BlockIOPortChanged(name, value));
                    }
                }
            }

            public Dictionary<System.String, Double> Bus //Доступ до шин.
            {
                get { return this.bus; }
                protected set
                {
                    this.bus = value;
                    this.Block.IsChanged = true;
                }
            }


            public IOBus(BaseBlock block, List<System.String> names, bool is_inp = true)
            {
                this.Block = block;
                this.is_input = is_inp;
                this.Bus = new Dictionary<string, double>();
                foreach (System.String name in names) Bus.Add(name, 0.0);
            }
            public IOBus(BaseBlock block, bool is_inp = true)
            {
                this.Block = block;
                this.is_input = is_inp;
                this.Bus = new Dictionary<string, double>();
            }
        }

        protected IOBus inputs;
        protected IOBus outputs;

        public bool IsChanged //Прапорець про зміну стану
        { get; protected set; }

        public delegate void ChangedHandler(BaseBlock block, BlockIOPortChanged portChanged);
        public delegate void ChangesAppliedHandler(BaseBlock block);

        public event ChangedHandler OnPortChanged;
        public event ChangesAppliedHandler OnChangesApplied;

        protected virtual void CalcIt() //Метод для розрахунку значень для виходів в залежності від входів.
        {
            throw new NotImplementedException("You should define \"CalcIt\" method in the class");
        }

        public BaseBlock()
        {
            this.inputs = new IOBus(this);
            this.outputs = new IOBus(this, false);
            this.IsChanged = true;
        }
    }

    public class BlockIOPortChanged:EventArgs
    {
        public System.String Name
        { get; protected set; }
        public System.Double Value
        { get; protected set; }

        public BlockIOPortChanged(System.String name, System.Double value)
        {
            this.Name = name;
            this.Value = value;
        }
    }

    public class TransferBlock : BaseBlock //Стандартний блок для полегшення розробки лінійних блоків.
    {
        public virtual double x //Приклад входу.
        {
            get { return this.inputs["x"]; }
            set { this.inputs["x"] = value; }
        }
        public virtual double y //Приклад виходу.
        {
            get { return this.outputs["y"]; }
            protected set { this.outputs["y"] = value; }
        }

        public double this[double x]
        {
            get
            {
                this.x = x;
                return this.y;
            }
        }

        public TransferBlock() : base()
        {
            this.inputs.Bus.Add("x", 0.0); //Така ініціалізація портів обов'язкова.
            this.outputs.Bus.Add("y", 0.0);
        }
    }

    public class DiscreteTrasferBlock:TransferBlock //Трансферний блок з дискретизацією
    {
        public virtual double dt //Розмір кванту часу для розрахунку.
        {
            get { return this.inputs["dt"]; }
            set { this.inputs["dt"] = value; }
        }

        public DiscreteTrasferBlock(double dt = 1.0) : base()
        {
            this.inputs.Bus.Add("dt", dt);
        }
    }
}
