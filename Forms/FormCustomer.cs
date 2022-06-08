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
    public partial class FormCustomer : Form
    {
        public string ConnectionString = Program.ConnectionString;
        public DataClassesDataContext dc;
        public FormCustomer()
        {
            InitializeComponent();
            dc = new DataClassesDataContext(ConnectionString);
            this.Activated += FormCustomer_Activated;
        }
        private void FormCustomer_Activated(object sender, EventArgs e)
        {
            dc = new DataClassesDataContext(ConnectionString);
            dataGridView1.DataSource = dc.Customer;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dc.Customer;
            textBox2.Enabled = false;
            customButton6.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            FormAddCustomer FaddCust = new FormAddCustomer();
            FaddCust.ShowDialog();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            FormEditCustomer formEditCustomer = new FormEditCustomer((int)dataGridView1.SelectedCells[0].Value);
            formEditCustomer.ShowDialog();
        }

        private void customButton6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = checkBox1.Checked;
            customButton6.Enabled = checkBox1.Checked;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
