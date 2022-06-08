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


namespace WindowsFormsApp2
{
    public partial class FormTicket : Form
    {
        public string ConnectionString = Program.ConnectionString;
        public DataClassesDataContext dc;
        public FormTicket()
        {
            InitializeComponent();
            dc = new DataClassesDataContext(ConnectionString);
            this.Activated += FormTicket_Activated;
        }

        private void FormTicket_Activated(object sender, EventArgs e)
        {
            dc = new DataClassesDataContext(ConnectionString);
            dataGridView1.DataSource = dc.Ticket;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
        private void FormTicket_Load(object sender, EventArgs e)
        {

            bindingSourceTicket.DataSource = dc.Ticket;
            textBox1.Enabled = false;
            customButton1.Enabled = false;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void списокПассажирскихПоездовToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPassanger FAdd = new FormPassanger();
            FAdd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void customButton1_Click_1(object sender, EventArgs e)
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = checkBox1.Checked;
            customButton1.Enabled = checkBox1.Checked;
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            try {
                FormEditTicket formEditTicket = new FormEditTicket((int)dataGridView1.SelectedCells[0].Value);
                formEditTicket.ShowDialog();
            } catch (Exception ex) {
                MessageBox.Show("Выберите ячейку с ID записи для редактирования; Ex: "+ex.Message.ToString());
            }
}

        private void поВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
        }

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        }

        private void поУбываниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }

        private void поВозрастаниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            FormAddTicket fAddTicket = new FormAddTicket();
            fAddTicket.ShowDialog();
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            int selectedRow = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить данную запись?", "Удаление записи", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    
                    dc = new DataClassesDataContext(ConnectionString);
                    dc.Ticket.DeleteAllOnSubmit(dc.Ticket.Where(X => X.Id == selectedRow));
                    dc.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Выберите ячейку с ID записи для редактирования; Ex: " + ex.Message.ToString());
                }
                this.Hide();
                this.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
