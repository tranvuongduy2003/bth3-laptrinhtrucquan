using System.Drawing;
using System.Windows.Forms;

namespace Bai8
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
            this.id = new System.Windows.Forms.Label();
            this.idValue = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.nameValue = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.addressValue = new System.Windows.Forms.TextBox();
            this.money = new System.Windows.Forms.Label();
            this.moneyValue = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.total = new System.Windows.Forms.Label();
            this.totalValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();


            // title
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.title.ForeColor = System.Drawing.Color.Blue;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(800, 50);
            this.title.TabIndex = 0;
            this.title.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            // id
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.id.Location = new System.Drawing.Point(10, this.title.Height + 20);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(200, 25);
            this.id.TabIndex = 1;
            this.id.Text = "Số tài khoản";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.idValue.Font = new System.Drawing.Font(this.idValue.Font.Name, 10F);
            this.idValue.Location = new System.Drawing.Point(this.id.Location.X + this.id.Size.Width + 10, this.id.Location.Y);
            this.idValue.Name = "idValue";
            this.idValue.MinimumSize = new System.Drawing.Size(450, 25);
            this.idValue.Size = new System.Drawing.Size(450, 25);
            this.idValue.TabIndex = 2;
            this.idValue.AutoSize = false;

            // name
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.name.Location = new System.Drawing.Point(10, this.id.Bottom + 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 25);
            this.name.TabIndex = 1;
            this.name.Text = "Tên khách hàng";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.nameValue.Font = new System.Drawing.Font(this.nameValue.Font.Name, 10F);
            this.nameValue.Location = new System.Drawing.Point(this.name.Location.X + this.name.Size.Width + 10, this.name.Location.Y);
            this.nameValue.Name = "nameValue";
            this.nameValue.MinimumSize = new System.Drawing.Size(450, 25);
            this.nameValue.Size = new System.Drawing.Size(450, 25);
            this.nameValue.TabIndex = 2;
            this.nameValue.AutoSize = false;

            // address
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.address.Location = new System.Drawing.Point(10, this.name.Bottom + 10);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(200, 25);
            this.address.TabIndex = 1;
            this.address.Text = "Địa chỉ khách hàng";
            this.address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.addressValue.Font = new System.Drawing.Font(this.addressValue.Font.Name, 10F);
            this.addressValue.Location = new System.Drawing.Point(this.address.Location.X + this.address.Size.Width + 10, this.address.Location.Y);
            this.addressValue.Name = "addressValue";
            this.addressValue.MinimumSize = new System.Drawing.Size(450, 25);
            this.addressValue.Size = new System.Drawing.Size(450, 25);
            this.addressValue.TabIndex = 2;
            this.addressValue.AutoSize = false;

            // money
            this.money.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.money.Location = new System.Drawing.Point(10, this.address.Bottom + 10);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(200, 25);
            this.money.TabIndex = 1;
            this.money.Text = "Số tiền trong tài khoản";
            this.money.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.moneyValue.Font = new System.Drawing.Font(this.moneyValue.Font.Name, 10F);
            this.moneyValue.Location = new System.Drawing.Point(this.money.Location.X + this.money.Size.Width + 10, this.money.Location.Y);
            this.moneyValue.Name = "moneyValue";
            this.moneyValue.MinimumSize = new System.Drawing.Size(450, 25);
            this.moneyValue.Size = new System.Drawing.Size(450, 25);
            this.moneyValue.TabIndex = 2;
            this.moneyValue.AutoSize = false;


            // exit
            this.exit.Size = new System.Drawing.Size(80, 25);
            this.exit.Location = new System.Drawing.Point(this.moneyValue.Right - this.exit.Size.Width, this.moneyValue.Bottom + 10);
            this.exit.TabIndex = 1;
            this.exit.Text = "Thoát";
            this.exit.Click += new System.EventHandler(this.HandleExit);

            // delete
            this.delete.Size = new System.Drawing.Size(80, 25);
            this.delete.Location = new System.Drawing.Point(this.exit.Left - this.delete.Size.Width - 20, this.moneyValue.Bottom + 10);
            this.delete.TabIndex = 1;
            this.delete.Text = "Xóa";
            this.delete.Click += new System.EventHandler(this.HandleDelete);

            // update
            this.update.Size = new System.Drawing.Size(100, 25);
            this.update.Location = new System.Drawing.Point(this.delete.Left - this.update.Size.Width - 20, this.moneyValue.Bottom + 10);
            this.update.TabIndex = 1;
            this.update.Text = "Thêm/Cập nhật";
            this.update.Click += new System.EventHandler(this.HandleUpdate);

            // table
            this.table.Location = new System.Drawing.Point(10, this.exit.Bottom + 20);
            this.table.Size = new System.Drawing.Size(780, 290);
            this.table.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            this.table.ColumnHeadersHeight = 25;
            this.table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.table.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            this.table.RowHeadersVisible = false;
            this.table.ColumnCount = 5;
            this.table.Rows.Clear();
            this.table.Columns[0].Name = "STT";
            this.table.Columns[0].Width = this.table.Size.Width / 16;
            this.table.Columns[1].Name = "Mã tài khoản";
            this.table.Columns[1].Width = this.table.Size.Width / 16 * 3;
            this.table.Columns[2].Name = "Tên khách hàng";
            this.table.Columns[2].Width = this.table.Size.Width / 4;
            this.table.Columns[3].Name = "Địa chỉ";
            this.table.Columns[3].Width = this.table.Size.Width / 3;
            this.table.Columns[4].Name = "Số tiền";
            this.table.Columns[4].Width = this.table.Size.Width / 6;

            // total
            this.totalValue.Font = new System.Drawing.Font(this.totalValue.Font.Name, 10F);
            this.totalValue.Name = "totalValue";
            this.totalValue.MinimumSize = new System.Drawing.Size(200, 25);
            this.totalValue.Size = new System.Drawing.Size(200, 25);
            this.totalValue.Location = new System.Drawing.Point(this.table.Right - this.totalValue.Size.Width, this.table.Bottom + 10);
            this.totalValue.TabIndex = 2;
            this.totalValue.AutoSize = false;

            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.total.Size = new System.Drawing.Size(200, 25);
            this.total.Location = new System.Drawing.Point(this.totalValue.Left - 5 - this.total.Size.Width, this.table.Bottom + 10);
            this.total.Name = "total";
            this.total.TabIndex = 1;
            this.total.Text = "Thành tiền:";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            

            // Form1
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.idValue);
            this.Controls.Add(this.id);
            this.Controls.Add(this.title);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.address);
            this.Controls.Add(this.addressValue);
            this.Controls.Add(this.money);
            this.Controls.Add(this.moneyValue);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.table);
            this.Controls.Add(this.total);
            this.Controls.Add(this.totalValue);
            this.Name = "Form1";
            this.Text = "Quản Lý Tài Khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox idValue;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox nameValue;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox addressValue;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.TextBox moneyValue;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox totalValue;
    }
}

