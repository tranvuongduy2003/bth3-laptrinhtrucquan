using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        MainMenu menu;
        MenuItem format;
        MenuItem color;

        public Form1()
        {
            InitializeComponent();
            menu = new MainMenu(); 
            format = new MenuItem();
            format.Text = "Format";
            color = new MenuItem();
            color.Text = "Color";
            color.Click += new EventHandler(OpenChangeColorDialog);

            format.MenuItems.Add(color);
            menu.MenuItems.Add(format);
            this.Menu = menu; 
        }

        public void OpenChangeColorDialog(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dlg.Color;
            }
        }
    }
}
