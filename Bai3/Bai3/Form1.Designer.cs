using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Bai3
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
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.ResumeLayout(false);

            Button changeColor = new Button();
            changeColor.Size = new System.Drawing.Size(200, 40);
            changeColor.Text = "Change Color";
            changeColor.BackColor = Color.White;
            changeColor.Font = new System.Drawing.Font(changeColor.Font.Name, 10);
            changeColor.Location = new System.Drawing.Point(250, 230);
            changeColor.Click += new EventHandler(this.ChangeColor);

            this.Controls.Add(changeColor);
        }




        #endregion
    }
}

