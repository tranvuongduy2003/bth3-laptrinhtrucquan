using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form1 : Form
    {
        static private int totalMoney = 0;

        public int TotalMoney { get { return totalMoney; } set { totalMoney = value; } }

        public Form1()
        {
            InitializeComponent();
        }

        private void HandleExit(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HandleDelete(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in this.table.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    DataGridViewRow row = this.table.Rows[oneCell.RowIndex];
                    totalMoney -= Convert.ToInt32(row.Cells[4].Value);
                    this.totalValue.Text = totalMoney.ToString();
                    this.table.Rows.RemoveAt(oneCell.RowIndex);
                }
            }
        }
        private void HandleUpdate(object sender, EventArgs e)
        {
            if (this.id.Text != "")
            {
                foreach (DataGridViewRow row in this.table.Rows)
                {
                    string value = row.Cells["Mã tài khoản"].Value?.ToString();
                    if (value == this.idValue.Text)
                    {
                        if (this.moneyValue.Text != "")
                        {
                            totalMoney -= Convert.ToInt32(row.Cells[4].Value);
                            totalMoney += Convert.ToInt32(this.moneyValue.Text);
                            row.Cells[4].Value = this.moneyValue.Text;
                            this.totalValue.Text = totalMoney.ToString();
                        }
                        if (this.nameValue.Text != "")
                            row.Cells[2].Value = this.nameValue.Text;
                        if (this.addressValue.Text != "")
                            row.Cells[3].Value = this.addressValue.Text;
                        return;
                    }
                }
                if (this.moneyValue.Text != "")
                {
                    totalMoney += Convert.ToInt32(this.moneyValue.Text);
                    this.totalValue.Text = totalMoney.ToString();
                }
                string[] newRow = new string[] { "", this.idValue.Text, this.nameValue.Text, this.addressValue.Text, this.moneyValue.Text };
                this.table.Rows.Add(newRow);
            }
            this.idValue.Text = "";
            this.nameValue.Text = "";
            this.addressValue.Text = "";
            this.moneyValue.Text = "";
        }
    }
}
