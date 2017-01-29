using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeCaptcha.Screen
{
    class Capture
    {
        Bitmap bmpScreenshot;
        static Size gameZone = new Size(525, 90);
        public short[,] anaGameZone = new short[gameZone.Width, gameZone.Height];

        public Bitmap Screenshot()
        {
            bmpScreenshot = new Bitmap(gameZone.Width, gameZone.Height);

            using (var g = Graphics.FromImage(bmpScreenshot))
            {
                g.CopyFromScreen(87, 162, 0, 0, Screen.PrimaryScreen.Bounds.Size);
            }


            return bmpScreenshot;
        }
    }
}
