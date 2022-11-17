using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        Label labelNum1;
        TextBox txtNum1;
        
        Label labelNum2;
        TextBox txtNum2;
        
        Label labelAns;
        TextBox txtAns;

        Button add, sub, mul, div;

        public Form1()
        {
            InitializeComponent();

            labelNum1 = new Label();
            labelNum1.Text = "Number 1";
            labelNum1.Font = new Font(labelNum1.Font.Name, 9);
            labelNum1.Size = new Size(80, 30);
            labelNum1.Location = new Point(20, 20);
            labelNum1.TextAlign = ContentAlignment.MiddleCenter;

            txtNum1 = new TextBox();
            txtNum1.Size = new Size(250, 30);
            txtNum1.MinimumSize = new Size(250, 30);
            txtNum1.TextAlign = HorizontalAlignment.Left;
            txtNum1.Font = new Font(txtNum1.Font.Name, 11);
            txtNum1.BackColor = Color.White;   
            txtNum1.Location = new Point(120, 20); 

            labelNum2 = new Label();
            labelNum2.Text = "Number 2";
            labelNum2.Font = new Font(labelNum2.Font.Name, 9);
            labelNum2.Size = new Size(80, 30);
            labelNum2.Location = new Point(20, 70);
            labelNum2.TextAlign = ContentAlignment.MiddleCenter;

            txtNum2 = new TextBox();
            txtNum2.Size = new Size(250, 30);
            txtNum2.MinimumSize = new Size(250, 30);
            txtNum2.TextAlign = HorizontalAlignment.Left;
            txtNum2.Font = new Font(txtNum2.Font.Name, 11);
            txtNum2.BackColor = Color.White;   
            txtNum2.Location = new Point(120, 70);

            add = new Button();
            add.Text = "+";
            add.Font = new Font(add.Font.Name, 11);
            add.Size = new Size(50, 50);
            add.Location = new Point(40, 120);
            add.Click += new EventHandler(Add);

            sub = new Button();
            sub.Text = "-";
            sub.Font = new Font(sub.Font.Name, 11);
            sub.Size = new Size(50, 50);
            sub.Location = new Point(130, 120);
            sub.Click += new EventHandler(Sub);

            mul = new Button();
            mul.Text = "x";
            mul.Font = new Font(mul.Font.Name, 11);
            mul.Size = new Size(50, 50);
            mul.Location = new Point(210, 120);
            mul.Click += new EventHandler(Mul);

            div = new Button();
            div.Text = "/";
            div.Font = new Font(div.Font.Name, 11);
            div.Size = new Size(50, 50);
            div.Location = new Point(300, 120);
            div.Click += new EventHandler(Div);

            labelAns = new Label();
            labelAns.Text = "Answer";
            labelAns.Font = new Font(labelAns.Font.Name, 9);
            labelAns.Size = new Size(80, 30);
            labelAns.Location = new Point(20, 220);
            labelAns.TextAlign = ContentAlignment.MiddleCenter;

            txtAns = new TextBox();
            txtAns.Size = new Size(250, 30);
            txtAns.MinimumSize = new Size(250, 30);
            txtAns.TextAlign = HorizontalAlignment.Left;
            txtAns.Font = new Font(txtAns.Font.Name, 11);
            txtAns.BackColor = Color.White;
            txtAns.Location = new Point(120, 220);

            this.Controls.Add(labelNum1);
            this.Controls.Add(txtNum1);
            this.Controls.Add(labelNum2);
            this.Controls.Add(txtNum2);
            this.Controls.Add(add);
            this.Controls.Add(sub);
            this.Controls.Add(mul);
            this.Controls.Add(div);
            this.Controls.Add(labelAns);
            this.Controls.Add(txtAns);
        }

        public void Add(object sender, EventArgs e)
        {
            if (txtNum1.Text != "" && txtNum2.Text != "")
            {
                int num1 = Convert.ToInt32(txtNum1.Text);
                int num2 = Convert.ToInt32(txtNum2.Text);
                int ans = num1 + num2;
                txtAns.Text = Convert.ToString(ans);
            }
        }
        
        public void Sub(object sender, EventArgs e)
        {
            if (txtNum1.Text != "" && txtNum2.Text != "")
            {
                int num1 = Convert.ToInt32(txtNum1.Text);
                int num2 = Convert.ToInt32(txtNum2.Text);
                int ans = num1 - num2;
                txtAns.Text = Convert.ToString(ans);
            }
        }
        
        public void Mul(object sender, EventArgs e)
        {
            if (txtNum1.Text != "" && txtNum2.Text != "")
            {
                int num1 = Convert.ToInt32(txtNum1.Text);
                int num2 = Convert.ToInt32(txtNum2.Text);
                int ans = num1 * num2;
                txtAns.Text = Convert.ToString(ans);
            }
        }
        
        public void Div(object sender, EventArgs e)
        {
            if (txtNum1.Text != "" && txtNum2.Text != "")
            {
                int num1 = Convert.ToInt32(txtNum1.Text);
                int num2 = Convert.ToInt32(txtNum2.Text);
                int ans = num1 / num2;
                txtAns.Text = Convert.ToString(ans);
            }
        }
    }
}
