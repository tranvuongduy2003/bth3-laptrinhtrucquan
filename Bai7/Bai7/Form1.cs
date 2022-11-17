using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public class Ve
    {
    }

    public class VeLoA : Ve
    {
        private int gia;
        private int[] ghe = { 1, 2, 3, 4, 5 };

        public int Gia { get => 5000; }
        public int[] Ghe { get => ghe; }
        
        bool IsA(int soGhe)
        {
            return ghe.Contains(soGhe);
        }
    }
    
    public class VeLoB : Ve
    {
        private int gia;
        private int[] ghe = { 6, 7, 8, 9, 10 };

        public int Gia { get => 6500; }
        public int[] Ghe { get => ghe; }

        bool IsB(int soGhe)
        {
            return ghe.Contains(soGhe);
        }
    }
    public class VeLoC : Ve
    {
        private int gia;
        private int[] ghe = { 11, 12, 13, 14, 15 };

        public int Gia { get => 8000; }
        public int[] Ghe { get => ghe; }

        bool IsA(int soGhe)
        {
            return ghe.Contains(soGhe);
        }
    }

    public partial class Form1 : Form
    {
        static private ArrayList selectedSlot = new ArrayList {};
        static private ArrayList pendingSlot = new ArrayList {};
        static private ArrayList availableSlot = new ArrayList { 1,  2,  3,  4,  5,
                                                        6,  7,  8,  9,  10,
                                                        11, 12, 13, 14, 15 };
        static private int cost;
        static public int Cost { get => cost; set { cost = value; } }

        public Form1()
        {
            InitializeComponent();
        }

        private void HandleSelectSlot(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int slotIndex = Convert.ToInt32(button.Text);

            if (cost != 0 || this.costValue.Text != "")
            {
                cost = 0;
                this.costValue.Text = "";
            }

            if (availableSlot.Contains(slotIndex))
            {
                button.BackColor = Color.Blue;
                pendingSlot.Add(slotIndex);
                availableSlot.Remove(slotIndex);
            }
            else if (pendingSlot.Contains(slotIndex))
            {
                button.BackColor = Color.Transparent;
                pendingSlot.Add(slotIndex);
                availableSlot.Remove(slotIndex);
            } else if (selectedSlot.Contains(slotIndex))
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!");
            }
        }

        private void HandleSelect(object sender, EventArgs e)
        {
            foreach (Control slot in this.flowLayoutPanel.Controls)
            {
                int slotIndex = Convert.ToInt32(slot.Text);
                if (pendingSlot.Contains(slotIndex))
                {
                    slot.BackColor = Color.Yellow;
                    pendingSlot.Remove(slotIndex);
                    selectedSlot.Add(slotIndex);
                    if (new VeLoA().Ghe.Contains(slotIndex))
                        cost += new VeLoA().Gia;
                    else if (new VeLoB().Ghe.Contains(slotIndex))
                        cost += new VeLoB().Gia;
                    else if (new VeLoC().Ghe.Contains(slotIndex))
                        cost += new VeLoC().Gia;
                }
            }
            this.costValue.Text = cost.ToString();
            cost = 0;
        }
        private void HandleCancel(object sender, EventArgs e)
        {
            foreach (Control slot in this.flowLayoutPanel.Controls)
            {
                int slotIndex = Convert.ToInt32(slot.Text);
                if (pendingSlot.Contains(slotIndex))
                {
                    slot.BackColor = Color.Transparent;
                    pendingSlot.Remove(slotIndex);
                    availableSlot.Add(slotIndex);
                }
            }
        }
        private void HandleClose(object sender, EventArgs e)
        {
            foreach (Control slot in this.flowLayoutPanel.Controls)
            {
                int slotIndex = Convert.ToInt32(slot.Text);
                slot.BackColor = Color.Transparent;
                selectedSlot.Clear();
                pendingSlot.Clear();
                availableSlot = new ArrayList { 1,  2,  3,  4,  5,
                                                6,  7,  8,  9,  10,
                                                11, 12, 13, 14, 15 };
                this.costValue.Text = "";
                cost = 0;
            }
        }
    }

}
