using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Media;
using System.Diagnostics;
using System.Threading;
using System.Windows;

namespace OOF_CLICKER
{
    public partial class Form1 : Form
    {
        private int toggle;

        private int MinCPS;
        private int MaxCPS;

        private const int MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */

        private LowLevelKeyboardHook hook;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo); //Hey! Remember This!

        public Form1()
        {
            InitializeComponent();
            gradientPanel1.SendToBack();

            this.KeyPreview = true;
            //this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
        }

        /*
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == ";".ToString() && MinCPS > 0 && MaxCPS > 0)
            {
                toggleClicker();
                e.Handled = true;
            }
            else if (MinCPS <= 0 || MaxCPS <= 0)
            {
                MessageBox.Show(this, "Must set to min/max values greater than 0 to start clicking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
        */

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            MinCPSText.Text = "" + trackBar1.Value;
            MinCPS = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            MaxCPSText.Text = "" + trackBar2.Value;
            MaxCPS = trackBar2.Value;
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            if (MinCPS != 0 && MaxCPS != 0)
            {
                toggleClicker();
            }
            else
            {
                MessageBox.Show(this, "Must set to min/max values greater than 0 to start clicking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toggleClicker()
        {
            toggle += 1;
            if (toggle == 1)
            {
                timer1.Start();
                button1.Text = "Toggle Off";
            }
            else
            {
                timer1.Stop();
                toggle = 0;
                button1.Text = "Toggle On";
            }
        }

        //Timer method to click
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int minVal;
            int maxVal;

            minVal = (1000 / MinCPS);
            maxVal = (1000 / MaxCPS);

            timer1.Interval = rand.Next(maxVal, minVal);
            if (checkBox1.Checked)
            {
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                }
            }
            else
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            toggle = 0;
            button1.Text = "Toggle On";

            toggleButtonTooltip.SetToolTip(button1, "Toggle Autoclicker, Hotkey is (`)");
            minimumCPSTooltip.SetToolTip(trackBar1, "Set the minimum CPS while clicking");
            maximumCPSTooltip.SetToolTip(trackBar2, "Set the maximum CPS while clicking");
            mouseDownTooltip.SetToolTip(checkBox1, "Set the autoclicker to only click if the mouse is down (while its checked)");
            epicImageTooltip1.SetToolTip(pictureBox2, "Epic Image");
            epicImageTooltip2.SetToolTip(pictureBox1, "Epic Image");

            hook = new LowLevelKeyboardHook();
            hook.OnKeyPressed += hook_OnKeyPressed;

            hook.HookKeyboard();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void hook_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            if (e.KeyPressed.ToString() == Key.Oem3.ToString() && MinCPS != 0 && MaxCPS != 0)
            {
                toggleClicker();
            }
            else if (MinCPS == 0 || MaxCPS == 0)
            {
                MessageBox.Show(this, "Must set to min / max values greater than 0 to start clicking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            hook.UnHookKeyboard();
        }
    }
}
