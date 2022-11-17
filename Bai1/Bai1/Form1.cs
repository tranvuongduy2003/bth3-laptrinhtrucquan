using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            sr.WriteLine("1-Move");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sr.WriteLine("2-Load");
        }



        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            sr.WriteLine("3-VisibleChange");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            sr.WriteLine("4-Activated");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            sr.WriteLine("5-Shown");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            sr.WriteLine("6-Paint");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            sr.WriteLine("7-Deactivate");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sr.WriteLine("8-Closing");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sr.WriteLine("9-Closed");
        }

    }
}
