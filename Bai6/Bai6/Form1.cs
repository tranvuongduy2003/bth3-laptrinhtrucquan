using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public class Menu : MainMenu
    {
        MenuItem edit;
        MenuItem view;
        MenuItem help;

        public Menu()
        {
            edit = new MenuItem();
            edit.Text = "Edit";

            view = new MenuItem();
            view.Text = "View";

            help = new MenuItem();
            help.Text = "Help";

            this.MenuItems.Add(edit);
            this.MenuItems.Add(view);
            this.MenuItems.Add(help);
        }

        private void InitializeComponent()
        {

        }
    }

    public class Calc
    {
        string add, sub, mul, div;

        public static string Add { get => "+"; }
        public static string Sub { get => "-"; }
        public static string Mul { get => "*"; }
        public static string Div { get => "/"; }
    }

    public partial class Form1 : Form
    {

        Menu menu;

        TextBox ans;
        Label square;

        Button backspace, ce, c;
        Button num0, num1, num2, num3, num4, num5, num6, num7, num8, num9, dot, negative;
        Button add, sub, mul, div, equal, sqrtButton, mod, reverse;
        Button mc, mr, ms, mplus;

        static double answer = Double.NaN;
        static string strOp = "";
        static double memoryValue = Double.NaN;
        bool hasOp = false;
        bool newCalc = true;

            
        public Form1()
        {
            InitializeComponent();

            menu = new Menu();

            ans = new TextBox();
            ans.Font = new Font(ans.Font.Name, 15);
            ans.TextAlign = HorizontalAlignment.Right;
            ans.Size = new Size(300, 40);
            ans.MinimumSize = new Size(300, 40);
            ans.Location = new Point(20, 10);
            ans.BackColor = Color.White;

            square = new Label();
            square.Size = new Size(40, 40);
            square.Location = new Point(20, 70);
            square.BorderStyle = BorderStyle.Fixed3D;

            backspace = new Button();
            backspace.Text = "Backspace";
            backspace.Size = new Size(220 / 3, 40);
            backspace.Location = new Point(80, 70);
            backspace.Click += new EventHandler(BackSpace);

            ce = new Button();
            ce.Text = "CE";
            ce.Size = new Size(220 / 3, 40);
            ce.Location = new Point(backspace.Location.X + backspace.Size.Width + 10, 70);
            ce.Click += new EventHandler(DeleteCE);
            
            c = new Button();
            c.Text = "C";
            c.Size = new Size(220 / 3, 40);
            c.Location = new Point(ce.Location.X + ce.Size.Width + 10, 70);
            c.Click += new EventHandler(DeleteC);

            //Number 

            num7 = new Button();
            num7.Text = "7";
            num7.Size = new Size(40, 40);
            num7.Location = new Point(80, 130);
            num7.Click += new EventHandler(SelectNum);
            this.Controls.Add(num7);
            
            num8 = new Button();
            num8.Text = "8";
            num8.Size = new Size(40, 40);
            num8.Location = new Point(num7.Location.X + 50, num7.Location.Y);
            num8.Click += new EventHandler(SelectNum);
            this.Controls.Add(num8);
            
            num9 = new Button();
            num9.Text = "9";
            num9.Size = new Size(40, 40);
            num9.Location = new Point(num8.Location.X + 50, num7.Location.Y);
            num9.Click += new EventHandler(SelectNum);
            this.Controls.Add(num9);
            
            num4 = new Button();
            num4.Text = "4";
            num4.Size = new Size(40, 40);
            num4.Location = new Point(80, 180);
            num4.Click += new EventHandler(SelectNum);
            this.Controls.Add(num4);

            num5 = new Button();
            num5.Text = "5";
            num5.Size = new Size(40, 40);
            num5.Location = new Point(num4.Location.X + 50, num4.Location.Y);
            num5.Click += new EventHandler(SelectNum);
            this.Controls.Add(num5);
            
            num6 = new Button();
            num6.Text = "6";
            num6.Size = new Size(40, 40);
            num6.Location = new Point(num5.Location.X + 50, num4.Location.Y);
            num6.Click += new EventHandler(SelectNum);
            this.Controls.Add(num6);

            num1 = new Button();
            num1.Text = "1";
            num1.Size = new Size(40, 40);
            num1.Location = new Point(80, 230);
            num1.Click += new EventHandler(SelectNum);
            this.Controls.Add(num1);

            num2 = new Button();
            num2.Text = "2";
            num2.Size = new Size(40, 40);
            num2.Location = new Point(num1.Location.X + 50, num1.Location.Y);
            num2.Click += new EventHandler(SelectNum);
            this.Controls.Add(num2);

            num3 = new Button();
            num3.Text = "3";
            num3.Size = new Size(40, 40);
            num3.Location = new Point(num2.Location.X + 50, num1.Location.Y);
            num3.Click += new EventHandler(SelectNum);
            this.Controls.Add(num3);

            num0 = new Button();
            num0.Text = "0";
            num0.Size = new Size(40, 40);
            num0.Location = new Point(80, 280);
            num0.Click += new EventHandler(SelectNum);
            this.Controls.Add(num0);
            
            dot = new Button();
            dot.Text = ".";
            dot.Size = new Size(40, 40);
            dot.Location = new Point(num3.Location.X, num3.Location.Y + 50);
            dot.Click += new EventHandler(SelectNum);
            this.Controls.Add(dot);
            
            negative = new Button();
            negative.Text = "+/-";
            negative.Size = new Size(40, 40);
            negative.Location = new Point(num0.Location.X + 50, num0.Location.Y);
            negative.Click += new EventHandler(NegativeNum);
            this.Controls.Add(negative);


            //Calculation

            add = new Button();
            add.Text = "+";
            add.Size = new Size(40, 40);
            add.Location = new Point(num9.Location.X + 50, num7.Location.Y);
            add.Click += new EventHandler(SelectOperator);
            this.Controls.Add(add);
            
            sub = new Button();
            sub.Text = "-";
            sub.Size = new Size(40, 40);
            sub.Location = new Point(add.Location.X, num4.Location.Y);
            sub.Click += new EventHandler(SelectOperator);
            this.Controls.Add(sub);
            
            mul = new Button();
            mul.Text = "*";
            mul.Size = new Size(40, 40);
            mul.Location = new Point(add.Location.X, num1.Location.Y);
            mul.Click += new EventHandler(SelectOperator);
            this.Controls.Add(mul);
            
            div = new Button();
            div.Text = "/";
            div.Size = new Size(40, 40);
            div.Location = new Point(add.Location.X, mul.Location.Y + 50);
            div.Click += new EventHandler(SelectOperator);
            this.Controls.Add(div);
            
            mod = new Button();
            mod.Text = "%";
            mod.Size = new Size(40, 40);
            mod.Location = new Point(sub.Location.X + 50, sub.Location.Y);
            mod.Click += new EventHandler(SelectOperator);
            this.Controls.Add(mod);
            
            equal = new Button();
            equal.Text = "=";
            equal.Size = new Size(40, 40);
            equal.Location = new Point(add.Location.X + 50, div.Location.Y);
            equal.Click += new EventHandler(Calculate);
            this.Controls.Add(equal);

            sqrtButton = new Button();
            sqrtButton.Text = "sqrt";
            sqrtButton.Size = new Size(40, 40);
            sqrtButton.Location = new Point(add.Location.X + 50, add.Location.Y);
            sqrtButton.Click += new EventHandler(SqrtCalc);
            this.Controls.Add(sqrtButton);
            
            reverse = new Button();
            reverse.Text = "1/x";
            reverse.Size = new Size(40, 40);
            reverse.Location = new Point(mul.Location.X + 50, mul.Location.Y);
            reverse.Click += new EventHandler(ReverseCalc);
            this.Controls.Add(reverse);

            //Memory

            mc = new Button();
            mc.Text = "MC";
            mc.Size = new Size(40, 40);
            mc.Location = new Point(20, 130);
            mc.Click += new EventHandler(MemoryClear);
            this.Controls.Add(mc);
            
            mr = new Button();
            mr.Text = "MR";
            mr.Size = new Size(40, 40);
            mr.Location = new Point(20, mc.Location.Y + 50);
            mr.Click += new EventHandler(MemoryRecall);
            this.Controls.Add(mr);

            ms = new Button();
            ms.Text = "MS";
            ms.Size = new Size(40, 40);
            ms.Location = new Point(20, mr.Location.Y + 50);
            ms.Click += new EventHandler(MemorySave);
            this.Controls.Add(ms);
            
            mplus = new Button();
            mplus.Text = "M+";
            mplus.Size = new Size(40, 40);
            mplus.Location = new Point(20, ms.Location.Y + 50);
            mplus.Click += new EventHandler(MemoryPlus);
            this.Controls.Add(mplus);

            

            this.Menu = menu;
            this.Controls.Add(ans);
            this.Controls.Add(square);
            this.Controls.Add(backspace);
            this.Controls.Add(ce);
            this.Controls.Add(c);
        }

        private void SelectNum(object sender, EventArgs e)
        {
            if (newCalc)
            {
                ans.Clear();
                answer = Double.NaN;
                newCalc = false;
            }

            if (ans.Text == "" || hasOp)
                ans.Clear();

            hasOp = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!ans.Text.Contains("."))
                    ans.Text += button.Text;
            }
            else
                ans.Text += button.Text;
        }

        private void SelectOperator(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (!Double.IsNaN(answer))
            {
                ans.Text = "";
                strOp = button.Text;
                hasOp = true;
                newCalc = false;
            }
            else
            {
                strOp = button.Text;
                answer = Double.Parse(ans.Text);
                hasOp = true;
            }
        }

        private void DeleteCE(object sender, EventArgs e)
        {
            ans.Text = "";
        }
        
        private void DeleteC(object sender, EventArgs e)
        {
            ans.Text = "";
            answer = Double.NaN;
            strOp = "";
            hasOp = false;
        }

        private void BackSpace(object sender, EventArgs e)
        {
            string initNum = ans.Text;
            if (initNum != "")
            {
                ans.Text = initNum.Remove(initNum.Length - 1, 1);
            }
        }

        private void Calculate(object sender, EventArgs e)
        {
            switch (strOp)
            {
                case "+":
                    ans.Text = (answer + Double.Parse(ans.Text)).ToString();
                    break;

                case "-":
                    ans.Text = (answer - Double.Parse(ans.Text)).ToString();
                    break;

                case "*":
                    ans.Text = (answer * Double.Parse(ans.Text)).ToString();
                    break;

                case "/":
                    ans.Text = (answer / Double.Parse(ans.Text)).ToString();
                    break;
                
                case "%":
                    ans.Text = (answer % Double.Parse(ans.Text)).ToString();
                    break;

                default:
                    break;

            }
            answer = Double.Parse(ans.Text);
            hasOp = false;
            newCalc = true;
        }

        private void SqrtCalc(object sender, EventArgs e)
        {
            ans.Text = (Math.Sqrt(Double.Parse(ans.Text))).ToString();
            if (strOp == "")
            {
                answer = Double.Parse(ans.Text);
                newCalc = true;
            }
        }
        
        private void ReverseCalc(object sender, EventArgs e)
        {
            ans.Text = (1 / Double.Parse(ans.Text)).ToString();
            if (strOp == "")
            {
                answer = Double.Parse(ans.Text);
                newCalc = true;
            }
        }
        
        private void NegativeNum(object sender, EventArgs e)
        {
            
            double initNum = Double.Parse(ans.Text);
            ans.Text = (-initNum).ToString();
        }

        private void MemorySave(object sender, EventArgs e)
        {
            memoryValue = answer;
        }
        
        private void MemoryRecall(object sender, EventArgs e)
        {
            ans.Text = memoryValue.ToString();
        }

        private void MemoryClear(object sender, EventArgs e)
        {
            memoryValue = Double.NaN;
        }

        private void MemoryPlus(object sender, EventArgs e)
        {
            if (ans.Text != "")
            {
                memoryValue += Double.Parse(ans.Text);
            }
        }
    }
}
