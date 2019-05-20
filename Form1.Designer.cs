namespace Mixer_simulation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ReactChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CtrPanel = new System.Windows.Forms.Panel();
            this.ControlTabs = new System.Windows.Forms.TabControl();
            this.SimTab = new System.Windows.Forms.TabPage();
            this.SimTL = new System.Windows.Forms.TableLayoutPanel();
            this.MaxPointBar = new System.Windows.Forms.TrackBar();
            this.SgnIn1Label = new System.Windows.Forms.Label();
            this.SgnIn1Bar = new System.Windows.Forms.TrackBar();
            this.SgnIn3Bar = new System.Windows.Forms.TrackBar();
            this.SgnIn2Label = new System.Windows.Forms.Label();
            this.SgnIn2Bar = new System.Windows.Forms.TrackBar();
            this.SgnIn3Label = new System.Windows.Forms.Label();
            this.PlotUpdateBar = new System.Windows.Forms.TrackBar();
            this.PlotUpdateLabel = new System.Windows.Forms.Label();
            this.AutoCheck = new System.Windows.Forms.CheckBox();
            this.MaxPointsLabel = new System.Windows.Forms.Label();
            this.NoiseLabel = new System.Windows.Forms.Label();
            this.NoiseBar = new System.Windows.Forms.TrackBar();
            this.ObjTab = new System.Windows.Forms.TabPage();
            this.MixerTL = new System.Windows.Forms.TableLayoutPanel();
            this.Flow1CapLabel = new System.Windows.Forms.Label();
            this.Flow1CapEdit = new System.Windows.Forms.TextBox();
            this.Flow2CapLabel = new System.Windows.Forms.Label();
            this.Flow2CapEdit = new System.Windows.Forms.TextBox();
            this.InitConcLabel = new System.Windows.Forms.Label();
            this.InitConEdit = new System.Windows.Forms.TextBox();
            this.Flow1ConcLabel = new System.Windows.Forms.Label();
            this.Flow1ConcEdit = new System.Windows.Forms.TextBox();
            this.Flow2ConcLabel = new System.Windows.Forms.Label();
            this.Flow2ConcEdit = new System.Windows.Forms.TextBox();
            this.TankVolLabel = new System.Windows.Forms.Label();
            this.TankVolEdit = new System.Windows.Forms.TextBox();
            this.LiqDensEdit = new System.Windows.Forms.TextBox();
            this.LiqDensLabel = new System.Windows.Forms.Label();
            this.ObjectPic = new System.Windows.Forms.PictureBox();
            this.PIDRegTab = new System.Windows.Forms.TabPage();
            this.PIDTL = new System.Windows.Forms.TableLayoutPanel();
            this.SetPointLabel = new System.Windows.Forms.Label();
            this.SetPointEdit = new System.Windows.Forms.TextBox();
            this.KLabel = new System.Windows.Forms.Label();
            this.KEdit = new System.Windows.Forms.TextBox();
            this.TiLabel = new System.Windows.Forms.Label();
            this.TiEdit = new System.Windows.Forms.TextBox();
            this.TdLabel = new System.Windows.Forms.Label();
            this.TdEdit = new System.Windows.Forms.TextBox();
            this.PauseBut = new System.Windows.Forms.Button();
            this.SimStartBut = new System.Windows.Forms.Button();
            this.Executor = new System.Windows.Forms.Timer(this.components);
            this.MainTL = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ReactChart)).BeginInit();
            this.CtrPanel.SuspendLayout();
            this.ControlTabs.SuspendLayout();
            this.SimTab.SuspendLayout();
            this.SimTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPointBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SgnIn1Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SgnIn3Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SgnIn2Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlotUpdateBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoiseBar)).BeginInit();
            this.ObjTab.SuspendLayout();
            this.MixerTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectPic)).BeginInit();
            this.PIDRegTab.SuspendLayout();
            this.PIDTL.SuspendLayout();
            this.MainTL.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReactChart
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea1.Name = "ChartArea1";
            this.ReactChart.ChartAreas.Add(chartArea1);
            this.ReactChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ReactChart.Legends.Add(legend1);
            this.ReactChart.Location = new System.Drawing.Point(3, 3);
            this.ReactChart.Name = "ReactChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "Reaction";
            series1.Name = "ReactSeries";
            this.ReactChart.Series.Add(series1);
            this.ReactChart.Size = new System.Drawing.Size(509, 700);
            this.ReactChart.TabIndex = 0;
            this.ReactChart.Text = "Reaction";
            // 
            // CtrPanel
            // 
            this.CtrPanel.Controls.Add(this.ControlTabs);
            this.CtrPanel.Controls.Add(this.PauseBut);
            this.CtrPanel.Controls.Add(this.SimStartBut);
            this.CtrPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CtrPanel.Location = new System.Drawing.Point(518, 3);
            this.CtrPanel.MinimumSize = new System.Drawing.Size(230, 700);
            this.CtrPanel.Name = "CtrPanel";
            this.CtrPanel.Size = new System.Drawing.Size(264, 700);
            this.CtrPanel.TabIndex = 1;
            // 
            // ControlTabs
            // 
            this.ControlTabs.Controls.Add(this.SimTab);
            this.ControlTabs.Controls.Add(this.ObjTab);
            this.ControlTabs.Controls.Add(this.PIDRegTab);
            this.ControlTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlTabs.Location = new System.Drawing.Point(0, 0);
            this.ControlTabs.Name = "ControlTabs";
            this.ControlTabs.SelectedIndex = 0;
            this.ControlTabs.Size = new System.Drawing.Size(264, 654);
            this.ControlTabs.TabIndex = 32;
            // 
            // SimTab
            // 
            this.SimTab.Controls.Add(this.SimTL);
            this.SimTab.Location = new System.Drawing.Point(4, 22);
            this.SimTab.Name = "SimTab";
            this.SimTab.Padding = new System.Windows.Forms.Padding(3);
            this.SimTab.Size = new System.Drawing.Size(256, 628);
            this.SimTab.TabIndex = 0;
            this.SimTab.Text = "Simulation";
            this.SimTab.UseVisualStyleBackColor = true;
            // 
            // SimTL
            // 
            this.SimTL.ColumnCount = 1;
            this.SimTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SimTL.Controls.Add(this.MaxPointBar, 0, 13);
            this.SimTL.Controls.Add(this.SgnIn1Label, 0, 0);
            this.SimTL.Controls.Add(this.SgnIn1Bar, 0, 1);
            this.SimTL.Controls.Add(this.SgnIn3Bar, 0, 5);
            this.SimTL.Controls.Add(this.SgnIn2Label, 0, 2);
            this.SimTL.Controls.Add(this.SgnIn2Bar, 0, 3);
            this.SimTL.Controls.Add(this.SgnIn3Label, 0, 4);
            this.SimTL.Controls.Add(this.PlotUpdateBar, 0, 11);
            this.SimTL.Controls.Add(this.PlotUpdateLabel, 0, 10);
            this.SimTL.Controls.Add(this.AutoCheck, 0, 8);
            this.SimTL.Controls.Add(this.MaxPointsLabel, 0, 12);
            this.SimTL.Controls.Add(this.NoiseLabel, 0, 14);
            this.SimTL.Controls.Add(this.NoiseBar, 0, 15);
            this.SimTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimTL.Location = new System.Drawing.Point(3, 3);
            this.SimTL.Name = "SimTL";
            this.SimTL.RowCount = 16;
            this.SimTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SimTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SimTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SimTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SimTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SimTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SimTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SimTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SimTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SimTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SimTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SimTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SimTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SimTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SimTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SimTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SimTL.Size = new System.Drawing.Size(250, 622);
            this.SimTL.TabIndex = 0;
            // 
            // MaxPointBar
            // 
            this.MaxPointBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaxPointBar.LargeChange = 3;
            this.MaxPointBar.Location = new System.Drawing.Point(3, 510);
            this.MaxPointBar.Maximum = 6;
            this.MaxPointBar.Name = "MaxPointBar";
            this.MaxPointBar.Size = new System.Drawing.Size(244, 45);
            this.MaxPointBar.TabIndex = 33;
            this.MaxPointBar.Scroll += new System.EventHandler(this.SgnInBar_Scroll);
            // 
            // SgnIn1Label
            // 
            this.SgnIn1Label.AutoSize = true;
            this.SgnIn1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SgnIn1Label.Location = new System.Drawing.Point(3, 0);
            this.SgnIn1Label.Name = "SgnIn1Label";
            this.SgnIn1Label.Size = new System.Drawing.Size(244, 13);
            this.SgnIn1Label.TabIndex = 23;
            this.SgnIn1Label.Text = "Signal Input of Concentration 1";
            // 
            // SgnIn1Bar
            // 
            this.SgnIn1Bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SgnIn1Bar.LargeChange = 50;
            this.SgnIn1Bar.Location = new System.Drawing.Point(3, 16);
            this.SgnIn1Bar.Maximum = 100;
            this.SgnIn1Bar.Name = "SgnIn1Bar";
            this.SgnIn1Bar.Size = new System.Drawing.Size(244, 45);
            this.SgnIn1Bar.TabIndex = 24;
            this.SgnIn1Bar.Scroll += new System.EventHandler(this.SgnInBar_Scroll);
            // 
            // SgnIn3Bar
            // 
            this.SgnIn3Bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SgnIn3Bar.LargeChange = 50;
            this.SgnIn3Bar.Location = new System.Drawing.Point(3, 144);
            this.SgnIn3Bar.Maximum = 100;
            this.SgnIn3Bar.Name = "SgnIn3Bar";
            this.SgnIn3Bar.Size = new System.Drawing.Size(244, 45);
            this.SgnIn3Bar.TabIndex = 28;
            this.SgnIn3Bar.Scroll += new System.EventHandler(this.SgnInBar_Scroll);
            // 
            // SgnIn2Label
            // 
            this.SgnIn2Label.AutoSize = true;
            this.SgnIn2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SgnIn2Label.Location = new System.Drawing.Point(3, 64);
            this.SgnIn2Label.Name = "SgnIn2Label";
            this.SgnIn2Label.Size = new System.Drawing.Size(244, 13);
            this.SgnIn2Label.TabIndex = 25;
            this.SgnIn2Label.Text = "Signal Input of Capacity 1";
            // 
            // SgnIn2Bar
            // 
            this.SgnIn2Bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SgnIn2Bar.LargeChange = 50;
            this.SgnIn2Bar.Location = new System.Drawing.Point(3, 80);
            this.SgnIn2Bar.Maximum = 100;
            this.SgnIn2Bar.Name = "SgnIn2Bar";
            this.SgnIn2Bar.Size = new System.Drawing.Size(244, 45);
            this.SgnIn2Bar.TabIndex = 26;
            this.SgnIn2Bar.Scroll += new System.EventHandler(this.SgnInBar_Scroll);
            // 
            // SgnIn3Label
            // 
            this.SgnIn3Label.AutoSize = true;
            this.SgnIn3Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SgnIn3Label.Location = new System.Drawing.Point(3, 128);
            this.SgnIn3Label.Name = "SgnIn3Label";
            this.SgnIn3Label.Size = new System.Drawing.Size(244, 13);
            this.SgnIn3Label.TabIndex = 27;
            this.SgnIn3Label.Text = "Signal Input of Capacity 2";
            // 
            // PlotUpdateBar
            // 
            this.PlotUpdateBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlotUpdateBar.Location = new System.Drawing.Point(3, 446);
            this.PlotUpdateBar.Maximum = 9;
            this.PlotUpdateBar.Name = "PlotUpdateBar";
            this.PlotUpdateBar.Size = new System.Drawing.Size(244, 45);
            this.PlotUpdateBar.TabIndex = 29;
            this.PlotUpdateBar.Scroll += new System.EventHandler(this.PlotUpdateBar_Scroll);
            // 
            // PlotUpdateLabel
            // 
            this.PlotUpdateLabel.AutoSize = true;
            this.PlotUpdateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlotUpdateLabel.Location = new System.Drawing.Point(3, 430);
            this.PlotUpdateLabel.Name = "PlotUpdateLabel";
            this.PlotUpdateLabel.Size = new System.Drawing.Size(244, 13);
            this.PlotUpdateLabel.TabIndex = 30;
            this.PlotUpdateLabel.Text = "Plot update";
            // 
            // AutoCheck
            // 
            this.AutoCheck.AutoSize = true;
            this.AutoCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoCheck.Location = new System.Drawing.Point(3, 195);
            this.AutoCheck.Name = "AutoCheck";
            this.AutoCheck.Size = new System.Drawing.Size(244, 17);
            this.AutoCheck.TabIndex = 31;
            this.AutoCheck.Text = "Automatic Mode";
            this.AutoCheck.UseVisualStyleBackColor = true;
            this.AutoCheck.CheckedChanged += new System.EventHandler(this.AutoCheck_CheckedChanged);
            // 
            // MaxPointsLabel
            // 
            this.MaxPointsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaxPointsLabel.Location = new System.Drawing.Point(3, 494);
            this.MaxPointsLabel.Name = "MaxPointsLabel";
            this.MaxPointsLabel.Size = new System.Drawing.Size(244, 13);
            this.MaxPointsLabel.TabIndex = 32;
            this.MaxPointsLabel.Text = "Max count of points on the plot";
            // 
            // NoiseLabel
            // 
            this.NoiseLabel.AutoSize = true;
            this.NoiseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoiseLabel.Location = new System.Drawing.Point(3, 558);
            this.NoiseLabel.Name = "NoiseLabel";
            this.NoiseLabel.Size = new System.Drawing.Size(244, 13);
            this.NoiseLabel.TabIndex = 34;
            this.NoiseLabel.Text = "Noise Level";
            // 
            // NoiseBar
            // 
            this.NoiseBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoiseBar.Location = new System.Drawing.Point(3, 574);
            this.NoiseBar.Name = "NoiseBar";
            this.NoiseBar.Size = new System.Drawing.Size(244, 45);
            this.NoiseBar.TabIndex = 35;
            this.NoiseBar.Scroll += new System.EventHandler(this.SgnInBar_Scroll);
            // 
            // ObjTab
            // 
            this.ObjTab.Controls.Add(this.MixerTL);
            this.ObjTab.Controls.Add(this.ObjectPic);
            this.ObjTab.Location = new System.Drawing.Point(4, 22);
            this.ObjTab.Name = "ObjTab";
            this.ObjTab.Padding = new System.Windows.Forms.Padding(3);
            this.ObjTab.Size = new System.Drawing.Size(256, 628);
            this.ObjTab.TabIndex = 1;
            this.ObjTab.Text = "Mixer";
            this.ObjTab.UseVisualStyleBackColor = true;
            // 
            // MixerTL
            // 
            this.MixerTL.AutoSize = true;
            this.MixerTL.ColumnCount = 2;
            this.MixerTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MixerTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MixerTL.Controls.Add(this.Flow1CapLabel, 0, 0);
            this.MixerTL.Controls.Add(this.Flow1CapEdit, 1, 0);
            this.MixerTL.Controls.Add(this.Flow2CapLabel, 0, 1);
            this.MixerTL.Controls.Add(this.Flow2CapEdit, 1, 1);
            this.MixerTL.Controls.Add(this.InitConcLabel, 0, 2);
            this.MixerTL.Controls.Add(this.InitConEdit, 1, 2);
            this.MixerTL.Controls.Add(this.Flow1ConcLabel, 0, 3);
            this.MixerTL.Controls.Add(this.Flow1ConcEdit, 1, 3);
            this.MixerTL.Controls.Add(this.Flow2ConcLabel, 0, 4);
            this.MixerTL.Controls.Add(this.Flow2ConcEdit, 1, 4);
            this.MixerTL.Controls.Add(this.TankVolLabel, 0, 5);
            this.MixerTL.Controls.Add(this.TankVolEdit, 1, 5);
            this.MixerTL.Controls.Add(this.LiqDensEdit, 1, 6);
            this.MixerTL.Controls.Add(this.LiqDensLabel, 0, 6);
            this.MixerTL.Dock = System.Windows.Forms.DockStyle.Top;
            this.MixerTL.Location = new System.Drawing.Point(3, 225);
            this.MixerTL.Name = "MixerTL";
            this.MixerTL.RowCount = 7;
            this.MixerTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MixerTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MixerTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MixerTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MixerTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MixerTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MixerTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MixerTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MixerTL.Size = new System.Drawing.Size(250, 182);
            this.MixerTL.TabIndex = 3;
            // 
            // Flow1CapLabel
            // 
            this.Flow1CapLabel.AutoSize = true;
            this.Flow1CapLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flow1CapLabel.Location = new System.Drawing.Point(3, 0);
            this.Flow1CapLabel.Name = "Flow1CapLabel";
            this.Flow1CapLabel.Size = new System.Drawing.Size(119, 26);
            this.Flow1CapLabel.TabIndex = 2;
            this.Flow1CapLabel.Text = "Flow 1 Capacity";
            // 
            // Flow1CapEdit
            // 
            this.Flow1CapEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flow1CapEdit.Location = new System.Drawing.Point(128, 3);
            this.Flow1CapEdit.Name = "Flow1CapEdit";
            this.Flow1CapEdit.Size = new System.Drawing.Size(119, 20);
            this.Flow1CapEdit.TabIndex = 1;
            this.Flow1CapEdit.TextChanged += new System.EventHandler(this.Flow1CapEdit_TextChanged);
            // 
            // Flow2CapLabel
            // 
            this.Flow2CapLabel.AutoSize = true;
            this.Flow2CapLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flow2CapLabel.Location = new System.Drawing.Point(3, 26);
            this.Flow2CapLabel.Name = "Flow2CapLabel";
            this.Flow2CapLabel.Size = new System.Drawing.Size(119, 26);
            this.Flow2CapLabel.TabIndex = 3;
            this.Flow2CapLabel.Text = "Flow 2 Capacity";
            // 
            // Flow2CapEdit
            // 
            this.Flow2CapEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flow2CapEdit.Location = new System.Drawing.Point(128, 29);
            this.Flow2CapEdit.Name = "Flow2CapEdit";
            this.Flow2CapEdit.Size = new System.Drawing.Size(119, 20);
            this.Flow2CapEdit.TabIndex = 4;
            this.Flow2CapEdit.TextChanged += new System.EventHandler(this.Flow1CapEdit_TextChanged);
            // 
            // InitConcLabel
            // 
            this.InitConcLabel.AutoSize = true;
            this.InitConcLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InitConcLabel.Location = new System.Drawing.Point(3, 52);
            this.InitConcLabel.Name = "InitConcLabel";
            this.InitConcLabel.Size = new System.Drawing.Size(119, 26);
            this.InitConcLabel.TabIndex = 5;
            this.InitConcLabel.Text = "Initial Concentration";
            // 
            // InitConEdit
            // 
            this.InitConEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InitConEdit.Location = new System.Drawing.Point(128, 55);
            this.InitConEdit.Name = "InitConEdit";
            this.InitConEdit.Size = new System.Drawing.Size(119, 20);
            this.InitConEdit.TabIndex = 6;
            this.InitConEdit.TextChanged += new System.EventHandler(this.Flow1CapEdit_TextChanged);
            // 
            // Flow1ConcLabel
            // 
            this.Flow1ConcLabel.AutoSize = true;
            this.Flow1ConcLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flow1ConcLabel.Location = new System.Drawing.Point(3, 78);
            this.Flow1ConcLabel.Name = "Flow1ConcLabel";
            this.Flow1ConcLabel.Size = new System.Drawing.Size(119, 26);
            this.Flow1ConcLabel.TabIndex = 7;
            this.Flow1ConcLabel.Text = "Flow 1 Concentration";
            // 
            // Flow1ConcEdit
            // 
            this.Flow1ConcEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flow1ConcEdit.Location = new System.Drawing.Point(128, 81);
            this.Flow1ConcEdit.Name = "Flow1ConcEdit";
            this.Flow1ConcEdit.Size = new System.Drawing.Size(119, 20);
            this.Flow1ConcEdit.TabIndex = 8;
            this.Flow1ConcEdit.TextChanged += new System.EventHandler(this.Flow1CapEdit_TextChanged);
            // 
            // Flow2ConcLabel
            // 
            this.Flow2ConcLabel.AutoSize = true;
            this.Flow2ConcLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flow2ConcLabel.Location = new System.Drawing.Point(3, 104);
            this.Flow2ConcLabel.Name = "Flow2ConcLabel";
            this.Flow2ConcLabel.Size = new System.Drawing.Size(119, 26);
            this.Flow2ConcLabel.TabIndex = 9;
            this.Flow2ConcLabel.Text = "Flow 2 Concentration";
            // 
            // Flow2ConcEdit
            // 
            this.Flow2ConcEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flow2ConcEdit.Location = new System.Drawing.Point(128, 107);
            this.Flow2ConcEdit.Name = "Flow2ConcEdit";
            this.Flow2ConcEdit.Size = new System.Drawing.Size(119, 20);
            this.Flow2ConcEdit.TabIndex = 10;
            this.Flow2ConcEdit.TextChanged += new System.EventHandler(this.Flow1CapEdit_TextChanged);
            // 
            // TankVolLabel
            // 
            this.TankVolLabel.AutoSize = true;
            this.TankVolLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TankVolLabel.Location = new System.Drawing.Point(3, 130);
            this.TankVolLabel.Name = "TankVolLabel";
            this.TankVolLabel.Size = new System.Drawing.Size(119, 26);
            this.TankVolLabel.TabIndex = 11;
            this.TankVolLabel.Text = "Tank Volume";
            // 
            // TankVolEdit
            // 
            this.TankVolEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TankVolEdit.Location = new System.Drawing.Point(128, 133);
            this.TankVolEdit.Name = "TankVolEdit";
            this.TankVolEdit.Size = new System.Drawing.Size(119, 20);
            this.TankVolEdit.TabIndex = 12;
            this.TankVolEdit.TextChanged += new System.EventHandler(this.Flow1CapEdit_TextChanged);
            // 
            // LiqDensEdit
            // 
            this.LiqDensEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LiqDensEdit.Location = new System.Drawing.Point(128, 159);
            this.LiqDensEdit.Name = "LiqDensEdit";
            this.LiqDensEdit.Size = new System.Drawing.Size(119, 20);
            this.LiqDensEdit.TabIndex = 14;
            this.LiqDensEdit.TextChanged += new System.EventHandler(this.Flow1CapEdit_TextChanged);
            // 
            // LiqDensLabel
            // 
            this.LiqDensLabel.AutoSize = true;
            this.LiqDensLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LiqDensLabel.Location = new System.Drawing.Point(3, 156);
            this.LiqDensLabel.Name = "LiqDensLabel";
            this.LiqDensLabel.Size = new System.Drawing.Size(119, 26);
            this.LiqDensLabel.TabIndex = 13;
            this.LiqDensLabel.Text = "Liquid Density";
            // 
            // ObjectPic
            // 
            this.ObjectPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.ObjectPic.Image = global::Mixer_simulation.Properties.Resources._object;
            this.ObjectPic.Location = new System.Drawing.Point(3, 3);
            this.ObjectPic.Name = "ObjectPic";
            this.ObjectPic.Size = new System.Drawing.Size(250, 222);
            this.ObjectPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ObjectPic.TabIndex = 31;
            this.ObjectPic.TabStop = false;
            // 
            // PIDRegTab
            // 
            this.PIDRegTab.Controls.Add(this.PIDTL);
            this.PIDRegTab.Location = new System.Drawing.Point(4, 22);
            this.PIDRegTab.Name = "PIDRegTab";
            this.PIDRegTab.Padding = new System.Windows.Forms.Padding(3);
            this.PIDRegTab.Size = new System.Drawing.Size(256, 628);
            this.PIDRegTab.TabIndex = 2;
            this.PIDRegTab.Text = "PID regulator";
            this.PIDRegTab.UseVisualStyleBackColor = true;
            // 
            // PIDTL
            // 
            this.PIDTL.AutoSize = true;
            this.PIDTL.ColumnCount = 2;
            this.PIDTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PIDTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PIDTL.Controls.Add(this.SetPointLabel, 0, 0);
            this.PIDTL.Controls.Add(this.SetPointEdit, 1, 0);
            this.PIDTL.Controls.Add(this.KLabel, 0, 1);
            this.PIDTL.Controls.Add(this.KEdit, 1, 1);
            this.PIDTL.Controls.Add(this.TiLabel, 0, 2);
            this.PIDTL.Controls.Add(this.TiEdit, 1, 2);
            this.PIDTL.Controls.Add(this.TdLabel, 0, 3);
            this.PIDTL.Controls.Add(this.TdEdit, 1, 3);
            this.PIDTL.Dock = System.Windows.Forms.DockStyle.Top;
            this.PIDTL.Location = new System.Drawing.Point(3, 3);
            this.PIDTL.Name = "PIDTL";
            this.PIDTL.RowCount = 4;
            this.PIDTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PIDTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PIDTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PIDTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PIDTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PIDTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PIDTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PIDTL.Size = new System.Drawing.Size(250, 104);
            this.PIDTL.TabIndex = 4;
            // 
            // SetPointLabel
            // 
            this.SetPointLabel.AutoSize = true;
            this.SetPointLabel.Location = new System.Drawing.Point(3, 0);
            this.SetPointLabel.Name = "SetPointLabel";
            this.SetPointLabel.Size = new System.Drawing.Size(50, 13);
            this.SetPointLabel.TabIndex = 2;
            this.SetPointLabel.Text = "Set Point";
            // 
            // SetPointEdit
            // 
            this.SetPointEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetPointEdit.Location = new System.Drawing.Point(128, 3);
            this.SetPointEdit.Name = "SetPointEdit";
            this.SetPointEdit.Size = new System.Drawing.Size(119, 20);
            this.SetPointEdit.TabIndex = 1;
            this.SetPointEdit.TextChanged += new System.EventHandler(this.Flow1CapEdit_TextChanged);
            // 
            // KLabel
            // 
            this.KLabel.AutoSize = true;
            this.KLabel.Location = new System.Drawing.Point(3, 26);
            this.KLabel.Name = "KLabel";
            this.KLabel.Size = new System.Drawing.Size(20, 13);
            this.KLabel.TabIndex = 3;
            this.KLabel.Text = "Kp";
            // 
            // KEdit
            // 
            this.KEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KEdit.Location = new System.Drawing.Point(128, 29);
            this.KEdit.Name = "KEdit";
            this.KEdit.Size = new System.Drawing.Size(119, 20);
            this.KEdit.TabIndex = 4;
            this.KEdit.TextChanged += new System.EventHandler(this.Flow1CapEdit_TextChanged);
            // 
            // TiLabel
            // 
            this.TiLabel.AutoSize = true;
            this.TiLabel.Location = new System.Drawing.Point(3, 52);
            this.TiLabel.Name = "TiLabel";
            this.TiLabel.Size = new System.Drawing.Size(16, 13);
            this.TiLabel.TabIndex = 5;
            this.TiLabel.Text = "Ki";
            // 
            // TiEdit
            // 
            this.TiEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TiEdit.Location = new System.Drawing.Point(128, 55);
            this.TiEdit.Name = "TiEdit";
            this.TiEdit.Size = new System.Drawing.Size(119, 20);
            this.TiEdit.TabIndex = 6;
            this.TiEdit.TextChanged += new System.EventHandler(this.Flow1CapEdit_TextChanged);
            // 
            // TdLabel
            // 
            this.TdLabel.AutoSize = true;
            this.TdLabel.Location = new System.Drawing.Point(3, 78);
            this.TdLabel.Name = "TdLabel";
            this.TdLabel.Size = new System.Drawing.Size(20, 13);
            this.TdLabel.TabIndex = 7;
            this.TdLabel.Text = "Kd";
            // 
            // TdEdit
            // 
            this.TdEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TdEdit.Location = new System.Drawing.Point(128, 81);
            this.TdEdit.Name = "TdEdit";
            this.TdEdit.Size = new System.Drawing.Size(119, 20);
            this.TdEdit.TabIndex = 8;
            this.TdEdit.TextChanged += new System.EventHandler(this.Flow1CapEdit_TextChanged);
            // 
            // PauseBut
            // 
            this.PauseBut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PauseBut.Enabled = false;
            this.PauseBut.Location = new System.Drawing.Point(0, 654);
            this.PauseBut.Name = "PauseBut";
            this.PauseBut.Size = new System.Drawing.Size(264, 23);
            this.PauseBut.TabIndex = 16;
            this.PauseBut.Text = "Pause";
            this.PauseBut.UseVisualStyleBackColor = true;
            this.PauseBut.Click += new System.EventHandler(this.PauseBut_Click);
            // 
            // SimStartBut
            // 
            this.SimStartBut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SimStartBut.Location = new System.Drawing.Point(0, 677);
            this.SimStartBut.Name = "SimStartBut";
            this.SimStartBut.Size = new System.Drawing.Size(264, 23);
            this.SimStartBut.TabIndex = 15;
            this.SimStartBut.Text = "Start";
            this.SimStartBut.UseVisualStyleBackColor = true;
            this.SimStartBut.Click += new System.EventHandler(this.SimStartBut_Click);
            // 
            // Executor
            // 
            this.Executor.Tick += new System.EventHandler(this.Executor_Tick);
            // 
            // MainTL
            // 
            this.MainTL.ColumnCount = 2;
            this.MainTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.MainTL.Controls.Add(this.ReactChart, 0, 0);
            this.MainTL.Controls.Add(this.CtrPanel, 1, 0);
            this.MainTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTL.Location = new System.Drawing.Point(0, 0);
            this.MainTL.Name = "MainTL";
            this.MainTL.RowCount = 1;
            this.MainTL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTL.Size = new System.Drawing.Size(785, 700);
            this.MainTL.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(785, 700);
            this.Controls.Add(this.MainTL);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ReactChart)).EndInit();
            this.CtrPanel.ResumeLayout(false);
            this.ControlTabs.ResumeLayout(false);
            this.SimTab.ResumeLayout(false);
            this.SimTL.ResumeLayout(false);
            this.SimTL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPointBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SgnIn1Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SgnIn3Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SgnIn2Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlotUpdateBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoiseBar)).EndInit();
            this.ObjTab.ResumeLayout(false);
            this.ObjTab.PerformLayout();
            this.MixerTL.ResumeLayout(false);
            this.MixerTL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectPic)).EndInit();
            this.PIDRegTab.ResumeLayout(false);
            this.PIDRegTab.PerformLayout();
            this.PIDTL.ResumeLayout(false);
            this.PIDTL.PerformLayout();
            this.MainTL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ReactChart;
        private System.Windows.Forms.Panel CtrPanel;
        private System.Windows.Forms.Label Flow1CapLabel;
        private System.Windows.Forms.TextBox TankVolEdit;
        private System.Windows.Forms.Label TankVolLabel;
        private System.Windows.Forms.TextBox Flow2ConcEdit;
        private System.Windows.Forms.Label Flow2ConcLabel;
        private System.Windows.Forms.TextBox Flow1ConcEdit;
        private System.Windows.Forms.Label Flow1ConcLabel;
        private System.Windows.Forms.TextBox InitConEdit;
        private System.Windows.Forms.Label InitConcLabel;
        private System.Windows.Forms.TextBox Flow2CapEdit;
        private System.Windows.Forms.Label Flow2CapLabel;
        private System.Windows.Forms.TextBox Flow1CapEdit;
        private System.Windows.Forms.TextBox LiqDensEdit;
        private System.Windows.Forms.Label LiqDensLabel;
        private System.Windows.Forms.Button PauseBut;
        private System.Windows.Forms.Button SimStartBut;
        private System.Windows.Forms.Timer Executor;
        private System.Windows.Forms.TrackBar SgnIn3Bar;
        private System.Windows.Forms.Label SgnIn3Label;
        private System.Windows.Forms.TrackBar SgnIn2Bar;
        private System.Windows.Forms.Label SgnIn2Label;
        private System.Windows.Forms.TrackBar SgnIn1Bar;
        private System.Windows.Forms.Label SgnIn1Label;
        private System.Windows.Forms.Label PlotUpdateLabel;
        private System.Windows.Forms.TrackBar PlotUpdateBar;
        private System.Windows.Forms.PictureBox ObjectPic;
        private System.Windows.Forms.TabControl ControlTabs;
        private System.Windows.Forms.TabPage SimTab;
        private System.Windows.Forms.TabPage ObjTab;
        private System.Windows.Forms.TabPage PIDRegTab;
        private System.Windows.Forms.TableLayoutPanel MixerTL;
        private System.Windows.Forms.TableLayoutPanel SimTL;
        private System.Windows.Forms.TableLayoutPanel PIDTL;
        private System.Windows.Forms.Label SetPointLabel;
        private System.Windows.Forms.TextBox SetPointEdit;
        private System.Windows.Forms.Label KLabel;
        private System.Windows.Forms.TextBox KEdit;
        private System.Windows.Forms.Label TiLabel;
        private System.Windows.Forms.TextBox TiEdit;
        private System.Windows.Forms.Label TdLabel;
        private System.Windows.Forms.TextBox TdEdit;
        private System.Windows.Forms.CheckBox AutoCheck;
        private System.Windows.Forms.TableLayoutPanel MainTL;
        private System.Windows.Forms.TrackBar MaxPointBar;
        private System.Windows.Forms.Label MaxPointsLabel;
        private System.Windows.Forms.Label NoiseLabel;
        private System.Windows.Forms.TrackBar NoiseBar;
    }
}

