using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ChatITochka
{
    internal class Uilist
    {
        public static int GetTextHeight(System.Windows.Forms.Label lb)
        {
            using (Graphics g = lb.CreateGraphics())
            {
                SizeF size = g.MeasureString(lb.Text, lb.Font, 495);
                return (int)Math.Ceiling(size.Height);
            }
        }
    }
}
