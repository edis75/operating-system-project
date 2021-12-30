using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace isletim
{
    public partial class system_resource : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(

           int nLeft,
           int nTop,
           int nRight,
           int nBottom,
           int nWidthEllipse,
           int nHeightEllipse


           );
            // ^ button round script 
        private System.Timers.Timer _timer;
        bool startflag = false;
        public system_resource()
        {
           
            InitializeComponent();
            _timer = new System.Timers.Timer();
            _timer.Interval = 3000;
            _timer.Elapsed += OntimedEvent;
            _timer.AutoReset = true;
        }


        private void OntimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
           
            int cpuValue = GetCpuValue();
            int memoryValeu = GetMemValue();

            if (progressBarCPU.InvokeRequired)
            {
                progressBarCPU.Invoke(new Action(() => progressBarCPU.Value = cpuValue));
            }
            else
            {
                progressBarCPU.Value = cpuValue;
            }

            if (lblCpu.InvokeRequired)
            {
                lblCpu.Invoke(new Action(() => lblCpu.Text = cpuValue.ToString()+"%"));
            }
            else
            {
                lblCpu.Text = cpuValue.ToString() + "%";
            }


            if (progressBarMEM.InvokeRequired)
            {
                progressBarMEM.Invoke(new Action(() => progressBarMEM.Value = memoryValeu));
            }
            else
            {
                progressBarMEM.Value = memoryValeu;
            }

            if (lblMem.InvokeRequired)
            {
                lblMem.Invoke(new Action(() => lblMem.Text = memoryValeu.ToString() + "%"));
            }
            else
            {
                lblMem.Text = memoryValeu.ToString() + "%";
            }


        }
        // CPU DEĞERİNİ AL
        private int GetCpuValue()
        {
            var CpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            CpuCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            int returnValue = (int)CpuCounter.NextValue();
            return returnValue; ;

        }
        // Memory değerini al
        private int GetMemValue()
        {
            var MemCounter = new PerformanceCounter("Memory", "% Committed Bytes in Use");
            int returnValue = (int)MemCounter.NextValue();
            return returnValue;
        }

        private void buttonStrart_Click(object sender, EventArgs e)
        {
            if (startflag == false)
            {
                startflag = true;
                _timer.Enabled = true;
                buttonStrart.Text = "Stop";
            }
            else
            {
                startflag = false;
                _timer.Enabled = false;
                buttonStrart.Text = "Start";
            }
        }
        private void islemlerListele()
        {
            Process[] Bellek = Process.GetProcesses();

            foreach (Process islem in Bellek)
            {
                islemler.Items.Add(islem.ProcessName);
                 
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            islemler.Items.Clear();
            islemlerListele();
            islemler.BackColor = Color.Cyan;
        }

        private void islemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            // işlemler list box

            
            }

        private void system_resource_Load(object sender, EventArgs e)
        {
            buttonStrart.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonStrart.Width, buttonStrart.Height, 30, 30));
            islemler.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, islemler.Width, islemler.Height,60, 60));

        }
    }
      /* private void system_resource_Load(object sender, EventArgs e)
        {

        }*/
    }

