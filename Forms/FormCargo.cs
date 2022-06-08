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
    public partial class FormCargo : Form
    {
        public string ConnectionString = Program.ConnectionString;
        public DataClassesDataContext dc;
        public FormCargo()
        {
            InitializeComponent();
            dc = new DataClassesDataContext(ConnectionString);
            this.Activated += FormCargo_Activated;
        }

        private void FormCargo_Activated(object sender, EventArgs e)
        {
            dc = new DataClassesDataContext(ConnectionString);
            dataGridView1.DataSource = dc.Cargo;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void списокПассажирскихПоездовToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void FormCargo_Load(object sender, EventArgs e)
        {
            dc = new DataClassesDataContext(ConnectionString);
            dataGridView1.DataSource = dc.Cargo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void customButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            try
            {
                FormEditCargo formEditCargo = new FormEditCargo((int)dataGridView1.SelectedCells[0].Value);
                formEditCargo.ShowDialog();
            }
            catch (Exception ex) {
                MessageBox.Show("Выберите ячейку с ID записи для редактирования; Ex: "+ex.Message.ToString());
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            FormAddCargo FAddCargo = new FormAddCargo();
            FAddCargo.ShowDialog();
        }
    }
}
