using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using WindowsInput;
using System.Threading;

namespace POE_TradeChatSpammer
{


    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
static extern bool SetForegroundWindow(IntPtr hWnd);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(txtTimer.Text.ToString());

            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
            timer1.Enabled = true;
            timer1.Start();
            timer1_Tick(null, null);

        }

        void ActivateApp(string processName)
        {
            //Process[] x = Process.GetProcesses();
            Process[] p = Process.GetProcessesByName(processName);

            // Activate the first application we find with this name
            if (p.Count() > 0)
                SetForegroundWindow(p[0].MainWindowHandle);
        }

        void SendMessage(int repeat, int sChannel, int eChannel, int fChannel)
        {
            /*
press enter
backspace 2x
/trade x
press enter
enter message
press enter
 * */
            int cChannel = sChannel;
            while (cChannel <= eChannel)
            {
                int i = 0;
                InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
                InputSimulator.SimulateKeyPress(VirtualKeyCode.BACK);
                InputSimulator.SimulateKeyPress(VirtualKeyCode.BACK);
                InputSimulator.SimulateTextEntry("/trade " + cChannel);
                InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(1000);
                while (i < repeat)
                {
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.BACK);
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.BACK);
                    InputSimulator.SimulateTextEntry(txtMessage.Text);
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
                    Thread.Sleep(2000);
                    i++;
                }
                Thread.Sleep(2000);
                cChannel++;
            }
            InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
            InputSimulator.SimulateKeyPress(VirtualKeyCode.BACK);
            InputSimulator.SimulateKeyPress(VirtualKeyCode.BACK);
            InputSimulator.SimulateTextEntry("/trade " + fChannel);
            InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //PathOfExile.exe
            disableForm();
            ActivateApp("PathOfExile");
            //InputSimulator.SimulateTextEntry(txtMessage.Text);
            SendMessage(Convert.ToInt32(txtSpamCnt.Text), Convert.ToInt32(txtFChannel.Text), Convert.ToInt32(txtTChannel.Text), Convert.ToInt32(txtFinChannel.Text));
            enableForm();
        }

        private void disableForm()
        {
            btnStop.Visible = false;
            button1.Visible = false;
            txtMessage.Enabled = false;
            txtChanDel.Enabled = false;
            txtFChannel.Enabled = false;
            txtSpamCnt.Enabled = false;
            txtTChannel.Enabled = false;
        }
        private void enableForm()
        {
            btnStop.Visible = true;
            button1.Visible = true;
            txtMessage.Enabled = true;
            txtChanDel.Enabled = true;
            txtFChannel.Enabled = true;
            txtSpamCnt.Enabled = true;
            txtTChannel.Enabled = true;
        }

    }
}
