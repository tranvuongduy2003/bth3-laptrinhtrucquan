using System.Drawing;
using System.Windows.Forms;

namespace Bai9
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
            this.info = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.Label();
            this.idValue = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.nameValue = new System.Windows.Forms.TextBox();
            this.nganh = new System.Windows.Forms.Label();
            this.nganhValue = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.Label();
            this.genderMale = new System.Windows.Forms.CheckBox();
            this.genderFemale = new System.Windows.Forms.CheckBox();
            this.select = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.ListBox();
            this.subjectQueue = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();

            // info
            this.info.Location = new System.Drawing.Point(30, 20);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(740, 350);
            this.info.TabIndex = 0;
            this.info.TabStop = false;
            this.info.Text = "Thông Tin Sinh Viên";
            this.info.Controls.Add(id);
            this.info.Controls.Add(idValue);
            this.info.Controls.Add(name);
            this.info.Controls.Add(nameValue);
            this.info.Controls.Add(nganh);
            this.info.Controls.Add(nganhValue);
            this.info.Controls.Add(gender);
            this.info.Controls.Add(genderMale);
            this.info.Controls.Add(genderFemale);
            this.info.Controls.Add(select);
            this.info.Controls.Add(subject);
            this.info.Controls.Add(subjectQueue);
            this.info.Controls.Add(add);
            this.info.Controls.Add(remove);
            this.info.Controls.Add(save);
            this.info.Controls.Add(delete);

            // id
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.id.Location = new System.Drawing.Point(150, 20);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(150, 25);
            this.id.TabIndex = 1;
            this.id.Text = "Mã sinh viên";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.idValue.Font = new System.Drawing.Font(this.idValue.Font.Name, 10F);
            this.idValue.Location = new System.Drawing.Point(this.id.Location.X + this.id.Size.Width + 10, this.id.Location.Y);
            this.idValue.Name = "idValue";
            this.idValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.idValue.Size = new System.Drawing.Size(150, 25);
            this.idValue.TabIndex = 2;
            this.idValue.AutoSize = false;

            // name
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.name.Location = new System.Drawing.Point(150, this.id.Bottom + 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(150, 25);
            this.name.TabIndex = 1;
            this.name.Text = "Họ tên";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.nameValue.Font = new System.Drawing.Font(this.nameValue.Font.Name, 10F);
            this.nameValue.Location = new System.Drawing.Point(this.name.Location.X + this.name.Size.Width + 10, this.name.Location.Y);
            this.nameValue.Name = "nameValue";
            this.nameValue.MinimumSize = new System.Drawing.Size(300, 25);
            this.nameValue.Size = new System.Drawing.Size(300, 25);
            this.nameValue.TabIndex = 2;
            this.nameValue.AutoSize = false;

            // specific
            this.nganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nganh.Location = new System.Drawing.Point(150, this.name.Bottom + 10);
            this.nganh.Name = "nganh";
            this.nganh.Size = new System.Drawing.Size(150, 25);
            this.nganh.TabIndex = 1;
            this.nganh.Text = "Ngành";
            this.nganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.nganhValue.Font = new System.Drawing.Font(this.nganhValue.Font.Name, 10F);
            this.nganhValue.Items.Add("Kỹ Thuật Phần Mềm");
            this.nganhValue.Items.Add("Công Nghệ Thông Tin");
            this.nganhValue.Items.Add("Khoa Học Máy Tính");
            this.nganhValue.Items.Add("Hệ Thống Thông Tin");
            this.nganhValue.Items.Add("An Toàn Thông Tin");
            this.nganhValue.Items.Add("Kỹ Thuật Máy Tính");
            this.nganhValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nganhValue.Location = new System.Drawing.Point(this.nganh.Location.X + this.nganh.Size.Width + 10, this.nganh.Location.Y);
            this.nganhValue.Name = "nganhValue";
            this.nganhValue.MinimumSize = new System.Drawing.Size(300, 25);
            this.nganhValue.Size = new System.Drawing.Size(300, 25);
            this.nganhValue.TabIndex = 3;
            this.nganhValue.AutoSize = false;

            //gender
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gender.Location = new System.Drawing.Point(150, this.nganh.Bottom + 10);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(150, 25);
            this.gender.TabIndex = 1;
            this.gender.Text = "Giới tính";
            this.gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.genderMale.AutoSize = false;
            this.genderMale.Location = new System.Drawing.Point(this.gender.Location.X + this.gender.Size.Width + 10, this.gender.Location.Y);
            this.genderMale.Name = "genderMale";
            this.genderMale.Size = new System.Drawing.Size(50, 25);
            this.genderMale.TabIndex = 4;
            this.genderMale.Text = "Nam";
            this.genderMale.UseVisualStyleBackColor = true;
            this.genderMale.TextAlign = ContentAlignment.MiddleLeft;

            this.genderFemale.AutoSize = false;
            this.genderFemale.Location = new System.Drawing.Point(this.genderMale.Right + 10, this.gender.Location.Y);
            this.genderFemale.Name = "genderFemale";
            this.genderFemale.Size = new System.Drawing.Size(50, 25);
            this.genderFemale.TabIndex = 4;
            this.genderFemale.Text = "Nữ";
            this.genderFemale.UseVisualStyleBackColor = true;
            this.genderMale.TextAlign = ContentAlignment.MiddleLeft;

            //select
            this.select.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.select.Location = new System.Drawing.Point(150, this.gender.Bottom + 10);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(300, 25);
            this.select.TabIndex = 1;
            this.select.Text = "Chọn Các Môn Học Tham Gia";
            this.select.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.subject.ItemHeight = 20;
            this.subject.Items.Add("Cơ Sở Dữ Liệu");
            this.subject.Items.Add("Cơ Sở Dữ Liệu NC");
            this.subject.Items.Add("PTTK Hệ Thống Thông Tin");            
            this.subject.Location = new System.Drawing.Point(150, this.select.Bottom + 10);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(250, 100);
            this.subject.TabIndex = 0;

            this.add.Location = new System.Drawing.Point(this.subject.Right + 10, this.select.Bottom + 10 + 15);
            this.add.Size = new System.Drawing.Size(40, 30);
            this.add.Text = ">";
            this.add.TabIndex = 0;
            this.add.Click += new System.EventHandler(this.HandleAdd);

            this.remove.Location = new System.Drawing.Point(this.subject.Right + 10, this.add.Bottom + 10);
            this.remove.Size = new System.Drawing.Size(40, 30);
            this.remove.Text = "<";
            this.remove.TabIndex = 0;
            this.remove.Click += new System.EventHandler(this.HandleRemove);

            this.subjectQueue.ItemHeight = 20;
            this.subjectQueue.Location = new System.Drawing.Point(this.add.Right + 10, this.select.Bottom + 10);
            this.subjectQueue.Name = "subjectQueue";
            this.subjectQueue.Size = new System.Drawing.Size(250, 100);
            this.subjectQueue.TabIndex = 0;

            // save
            this.save.Location = new System.Drawing.Point(300, this.subject.Bottom + 10);
            this.save.Size = new System.Drawing.Size(120, 30);
            this.save.Text = "Lưu Thông Tin";
            this.save.TabIndex = 0;
            this.save.Click += new System.EventHandler(this.HandleSave);

            // delete
            this.delete.Location = new System.Drawing.Point(this.save.Right + 10, this.subject.Bottom + 10);
            this.delete.Size = new System.Drawing.Size(80, 30);
            this.delete.Text = "Xóa Chọn";
            this.delete.TabIndex = 0;
            this.delete.Click += new System.EventHandler(this.HandleDelete);

            // table
            this.table.Location = new System.Drawing.Point(30, this.info.Bottom + 20);
            this.table.Size = new System.Drawing.Size(740, 290);
            this.table.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            this.table.ColumnHeadersHeight = 25;
            this.table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.table.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            this.table.ColumnCount = 5;
            this.table.Rows.Clear();
            this.table.Columns[0].Name = "MSSV";
            this.table.Columns[0].Width = this.table.Size.Width / 16 * 3;
            this.table.Columns[1].Name = "Họ Tên";
            this.table.Columns[1].Width = this.table.Size.Width / 16 * 4;
            this.table.Columns[2].Name = "Chuyên Ngành";
            this.table.Columns[2].Width = this.table.Size.Width / 16 * 4;
            this.table.Columns[3].Name = "Giới Tính";
            this.table.Columns[3].Width = this.table.Size.Width / 16 * 3;
            this.table.Columns[4].Name = "Số Môn";
            this.table.Columns[4].Width = this.table.Size.Width / 16 * 2;



            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.info);
            this.Controls.Add(this.table);
            this.Name = "Form1";
            this.Text = "Nhập Liệu Sinh Viên";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox info;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox idValue;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox nameValue;
        private System.Windows.Forms.Label nganh;
        private System.Windows.Forms.ComboBox nganhValue;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.CheckBox genderMale;
        private System.Windows.Forms.CheckBox genderFemale;
        private System.Windows.Forms.Label select;
        private System.Windows.Forms.ListBox subject;
        private System.Windows.Forms.ListBox subjectQueue;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView table;
    }
}

