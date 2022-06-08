using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp2
{

    public partial class FormSchedule : Form
    {
        public string ConnectionString = Program.ConnectionString;

        public DataClassesDataContext dc;
        public FormSchedule()
        {
            InitializeComponent();
            dc = new DataClassesDataContext(ConnectionString);
            this.Activated += FormSchedule_Activated;
        }

        private void FormSchedule_Activated(object sender, EventArgs e)
        {
            dc = new DataClassesDataContext(ConnectionString);
            bindingSource1.DataSource = dc.Schedule;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void рассписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void FormSchedule_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {

        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {
           
            bindingSource1.DataSource = dc.Schedule;
            textBox1.Enabled = false;
            customButton1.Enabled = false;
        }


        private void билетНаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTicket FTicket = new FormTicket();
            FTicket.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {                       
               MessageBox.Show("dataGridView1.Rows.RemoveAt(item.Index)");   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оформитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddSchedule FaddSched = new FormAddSchedule();
            FaddSched.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
                FormEditSchedule formEditSchedule = new FormEditSchedule((int)dataGridView1.SelectedCells[0].Value);
                formEditSchedule.ShowDialog();
            } catch (Exception ex) {
                MessageBox.Show("Выберите ячейку с ID записи для редактирования; Ex: "+ex.Message.ToString());
            }
}

        private void customButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = checkBox1.Checked;
            customButton1.Enabled = checkBox1.Checked;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            FormAddSchedule FaddSched = new FormAddSchedule();
            FaddSched.ShowDialog();
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            try
            {
                FormEditSchedule formEditSchedule = new FormEditSchedule((int)dataGridView1.SelectedCells[0].Value);
                formEditSchedule.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выберите ячейку с ID записи для редактирования; Ex: " + ex.Message.ToString());
            }
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dataGridView1.Rows.RemoveAt(item.Index)");
        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void вПорядкеВозрастанияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
        }

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
        }

        private void поУбываниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
        }

        private void поВозрастаниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Descending);
        }

        private void поВозрастаниюToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
        }

        private void поУбываниюToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
        }

        private void вПорядкеВозрастанияToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void поВозрастаниюToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
        }

        private void поУбываниюToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        }
    }
}
