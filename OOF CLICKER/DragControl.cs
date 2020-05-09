using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OOF_CLICKER
{
    class DragControl : Component
    {
        private Control handleControl;

        public Control SelectControl
        {
            get
            {
                return this.handleControl;
            }
            set
            {
                this.handleControl = value;
                this.handleControl.MouseDown += new MouseEventHandler(this.MouseDragForm);
            }
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr a, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MouseDragForm(object sender, MouseEventArgs e)
        {
            bool flag = e.Button == MouseButtons.Left;
            if (flag)
            {
                ReleaseCapture();
                SendMessage(SelectControl.FindForm().Handle, 161, 2, 0);
            }
        }
    }
}
