using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOF_CLICKER
{
    class GradientPanel : Panel
    {
        public Color topColor { get; set; }
        public Color bottomColor { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.topColor, this.bottomColor, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);

            base.OnPaint(e);    
        }
    }
}
