using System.Drawing;
using System.Drawing.Printing;

namespace Bai7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.costValue = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel(); 
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.title.ForeColor = System.Drawing.Color.Coral;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(320, 50);
            this.title.TabIndex = 0;
            this.title.Text = "MÀN ẢNH";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.Controls.Add(this.button1);
            this.flowLayoutPanel.Controls.Add(this.button2);
            this.flowLayoutPanel.Controls.Add(this.button3);
            this.flowLayoutPanel.Controls.Add(this.button4);
            this.flowLayoutPanel.Controls.Add(this.button5);
            this.flowLayoutPanel.Controls.Add(this.button6);
            this.flowLayoutPanel.Controls.Add(this.button7);
            this.flowLayoutPanel.Controls.Add(this.button8);
            this.flowLayoutPanel.Controls.Add(this.button9);
            this.flowLayoutPanel.Controls.Add(this.button10);
            this.flowLayoutPanel.Controls.Add(this.button11);
            this.flowLayoutPanel.Controls.Add(this.button12);
            this.flowLayoutPanel.Controls.Add(this.button13);
            this.flowLayoutPanel.Controls.Add(this.button14);
            this.flowLayoutPanel.Controls.Add(this.button15);
            this.flowLayoutPanel.Location = new System.Drawing.Point(30, 70);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(262, 160);
            this.flowLayoutPanel.TabIndex = 0;
            //this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            // 
            // button1
            // 
            this.button1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.Click += new System.EventHandler(this.HandleSelectSlot);
            // 
            // button2
            // 
            this.button2.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "2";
            this.button2.Click += new System.EventHandler(this.HandleSelectSlot);
            // 
            // button3
            // 
            this.button3.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "3";
            this.button3.Click += new System.EventHandler(this.HandleSelectSlot);
            // 
            // button4
            // 
            this.button4.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "4";
            this.button4.Click += new System.EventHandler(this.HandleSelectSlot);
            // 
            // button5
            // 
            this.button5.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 0;
            this.button5.Text = "5";
            this.button5.Click += new System.EventHandler(this.HandleSelectSlot);
            // 
            // button6
            // 
            this.button6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 0;
            this.button6.Text = "6";
            this.button6.Click += new System.EventHandler(this.HandleSelectSlot);
            // 
            // button7
            // 
            this.button7.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 0;
            this.button7.Text = "7";
            this.button7.Click += new System.EventHandler(this.HandleSelectSlot);
            // 
            // button8
            //
            this.button8.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 40);
            this.button8.TabIndex = 0;
            this.button8.Text = "8";
            this.button8.Click += new System.EventHandler(this.HandleSelectSlot);
            // 
            // button9
            // 
            this.button9.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 40);
            this.button9.TabIndex = 0;
            this.button9.Text = "9";
            this.button9.Click += new System.EventHandler(this.HandleSelectSlot);
            // 
            // button10
            // 
            this.button10.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 40);
            this.button10.TabIndex = 0;
            this.button10.Text = "10";
            this.button10.Click += new System.EventHandler(this.HandleSelectSlot);
            // 
            // button11
            // 
            this.button11.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 40);
            this.button11.TabIndex = 0;
            this.button11.Text = "11";
            this.button11.Click += new System.EventHandler(this.HandleSelectSlot);
            // 
            // button12
            // 
            this.button12.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.button12.Location = new System.Drawing.Point(0, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(40, 40);
            this.button12.TabIndex = 0;
            this.button12.Text = "12";
            this.button12.Click += new System.EventHandler(this.HandleSelectSlot);
            // 
            // button13
            // 
            this.button13.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(40, 40);
            this.button13.TabIndex = 0;
            this.button13.Text = "13";
            this.button13.Click += new System.EventHandler(this.HandleSelectSlot);
            // 
            // button14
            // 
            this.button14.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.button14.Location = new System.Drawing.Point(0, 0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(40, 40);
            this.button14.TabIndex = 0;
            this.button14.Text = "14";
            this.button14.Click += new System.EventHandler(this.HandleSelectSlot);
            // 
            // button15
            // 
            this.button15.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.button15.Location = new System.Drawing.Point(0, 0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(40, 40);
            this.button15.TabIndex = 0;
            this.button15.Text = "15";
            this.button15.Click += new System.EventHandler(this.HandleSelectSlot);


            // Input 
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8);
            this.labelCost.Location = new System.Drawing.Point(30, this.flowLayoutPanel.Size.Height + this.flowLayoutPanel.Location.Y + 20);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(80, 30);
            this.labelCost.TabIndex = 0;
            this.labelCost.Text = "Thành Tiền:";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.costValue.Location = new System.Drawing.Point(this.labelCost.Location.X + this.labelCost.Size.Width, this.labelCost.Location.Y);
            this.costValue.Name = "costValue";
            this.costValue.TabIndex = 2;
            this.costValue.AutoSize = false;
            this.costValue.MinimumSize = new System.Drawing.Size(160, 30);
            this.costValue.Size = new System.Drawing.Size(160, 30);

            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(this.flowLayoutPanel.Location.X + 20, this.costValue.Location.Y + this.costValue.Size.Height + 20);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(60, 30);
            this.select.TabIndex = 0;
            this.select.Text = "Chọn";
            this.select.Click += new System.EventHandler(this.HandleSelect);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(this.select.Location.X + this.select.Width + 20, this.select.Location.Y);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(60, 30);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Hủy bỏ";
            this.cancel.Click += new System.EventHandler(this.HandleCancel);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(this.cancel.Location.X + this.cancel.Width + 20, this.select.Location.Y);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(60, 30);
            this.close.TabIndex = 0;
            this.close.Text = "Kết thúc";
            this.close.Click += new System.EventHandler(this.HandleClose);


            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(320, 350);
            this.Controls.Add(this.title);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.select);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.close);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.costValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox costValue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button close;
    }
}

