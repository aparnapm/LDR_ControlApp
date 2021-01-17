using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace LDRSimulator
{
    public partial class Form1 : Form
    {
        private int reading;
        Random generator = new Random();
        Thread thread1;
        public bool isStopButtonClicked= false;
        public Form1()
        {
            InitializeComponent();
            getAvailablePorts();
        }
        
        void getAvailablePorts()
        {

            String[] ports = SerialPort.GetPortNames();
            portBox.Items.AddRange(ports);

        }
        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            serverPort.PortName = portBox.Text;
            serverPort.BaudRate = int.Parse(baudBox.Text);
            serverPort.Open();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(new ThreadStart(StartFunction));
            thread1.Start();
        }
        void StartFunction()
        {
            while (!isStopButtonClicked)
            {
                if (manualcheck.Checked)
                {
                    reading = int.Parse(manualval.Text);
                }
                else
                {
                    reading = generator.Next(0, 99);
                }
                serverPort.WriteLine(reading + "");
                Thread.Sleep(1000);
            }
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            isStopButtonClicked = true;
        }
    }
}
