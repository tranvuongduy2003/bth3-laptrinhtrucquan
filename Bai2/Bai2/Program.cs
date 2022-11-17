using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 paint = new Form1();
            paint.Click += new EventHandler(paint_Click);

            Application.Run(paint);
        }

        static void paint_Click(Object sender, EventArgs e)
        {
            var rand = new Random();
            Form f = (Form)sender;
            Graphics g = f.CreateGraphics();
            g.DrawString("Paint Event", f.Font, Brushes.Black, (float)(rand.NextDouble() * f.Width), (float)(rand.NextDouble() * f.Height));
        }

    }
}
