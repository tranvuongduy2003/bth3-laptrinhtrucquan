using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        static string[] subjectList = new string[] { };
        public Form1()
        {
            InitializeComponent();
        }

        private void HandleAdd(object sender, EventArgs e)
        {
            this.subjectQueue.Items.Add(this.subject.SelectedItem);
            this.subject.Items.Remove(this.subject.SelectedItem);
        }
        private void HandleRemove(object sender, EventArgs e)
        {
            this.subject.Items.Add(this.subjectQueue.SelectedItem);
            this.subjectQueue.Items.Remove(this.subjectQueue.SelectedItem);
        }
        private void HandleSave(object sender, EventArgs e)
        {
            if (this.id.Text != "")
            {
                foreach (DataGridViewRow row in this.table.Rows)
                {
                    string value = row.Cells["MSSV"].Value?.ToString();
                    if (value == this.idValue.Text)
                    {
                        if (this.nameValue.Text != "")
                            row.Cells[1].Value = this.nameValue.Text;
                        if (this.nganh.Text != "")
                            row.Cells[2].Value = this.nganh.Text;
                        if (this.genderMale.Checked)
                            row.Cells[3].Value = "Nam";
                        else if (this.genderFemale.Checked)
                            row.Cells[3].Value = "Nữ";
                        row.Cells[4].Value = this.subjectQueue.Items.Count.ToString();
                        return;
                    }
                }
                string genderStr = "";
                if (this.genderMale.Checked)
                    genderStr = "Nam";
                else if (this.genderFemale.Checked)
                    genderStr = "Nữ";
                string[] newRow = new string[] { this.idValue.Text, this.nameValue.Text, this.nganh.Text, genderStr, this.subjectQueue.Items.Count.ToString() };
                this.table.Rows.Add(newRow);
            }
            this.idValue.Text = "";
            this.nameValue.Text = "";
            this.nganh.Text = "";
            this.genderMale.Checked = false;
            this.genderFemale.Checked = false;
            this.subjectQueue.Items.Clear();
            this.subject.Items.AddRange(this.subjectQueue.Items);
            this.subjectQueue.Items.Clear();
        }
        private void HandleDelete(object sender, EventArgs e)
        {
            this.idValue.Text = "";
            this.nameValue.Text = "";
            this.nganh.Text = "";
            this.genderMale.Checked = false;
            this.genderFemale.Checked = false;
            this.subject.Items.AddRange(this.subjectQueue.Items);
            this.subjectQueue.Items.Clear();
        }
    }
}
