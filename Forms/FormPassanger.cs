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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void customButton3_Click(object sender, EventArgs e)
        {
         
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
    }
}
