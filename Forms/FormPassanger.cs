using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormPassanger : Form
    {
        public string ConnectionString = Program.ConnectionString;
        public DataClassesDataContext dc;
        public FormPassanger()
        {
            InitializeComponent();
            dc = new DataClassesDataContext(ConnectionString);
            this.Activated += FormPassanger_Activated;
        }

        private void FormPassanger_Activated(object sender, EventArgs e)
        {
            dc = new DataClassesDataContext(ConnectionString);
            dataGridView1.DataSource = dc.Passanger;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormPassanger_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dc.Passanger;
            textBox1.Enabled = false;
            customButton1.Enabled = false;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = checkBox1.Checked;
            customButton1.Enabled = checkBox1.Checked;
             
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

            //for (int i = 0; i < dataGridView1.RowCount; i++)
            //{
            //    dataGridView1.Rows[i].Selected = false;
            //    for (int j = 0; j < dataGridView1.ColumnCount; j++)
            //        if (dataGridView1.Rows[i].Cells[j].Value != null)
            //            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
            //            {
            //                dataGridView1.Rows[i].Selected = true;
            //                break;
            //            }
            //}
            IQueryable<Passanger> q = dc.Passanger;
            if (checkBox1.Checked)
                q = q.Where(x => x.FIO.Contains((string)textBox1.Text));
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            try { 
                FormEditPassanger FedPass = new FormEditPassanger((int)dataGridView1.SelectedCells[0].Value);
                FedPass.ShowDialog();
            } catch (Exception ex) {
                MessageBox.Show("Выберите ячейку с ID записи для редактирования; Ex: "+ex.Message.ToString());
            }
}

        private void customButton2_Click(object sender, EventArgs e)
        {
            FormAddPassanger FaddPas = new FormAddPassanger();
            FaddPas.ShowDialog();
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
          //  dc.Passanger.DeleteAllOnSubmit(dc.Passanger.Where(X=>X.Id == dataGridView1.Rows.Add());
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void поВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
        }

        private void поВозрастаниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
        }

        private void поУбываниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        }

        private void поУбываниюToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
        }

        private void поВозрастаниюToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
        }

        private void фИОToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
