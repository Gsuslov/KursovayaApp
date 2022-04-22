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
        public SqlConnection sqlConnection4 = null;
        public SqlDataAdapter SqlDataAdapter4 = null;
        public DataTable table4 = null;
        public FormCargo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void списокПассажирскихПоездовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table4.Clear();
            SqlDataAdapter4.Fill(table4);
            dataGridView1.DataSource = table4;
        }

        private void FormCargo_Load(object sender, EventArgs e)
        {
            sqlConnection4 = new SqlConnection(@"Data Source=WIN-ER4GG7E4229\SQLEXPRESS;Initial Catalog=LogikDatabase;Integrated Security=True");
            sqlConnection4.Open();
            SqlDataAdapter4 = new SqlDataAdapter("SELECT * FROM Cargo", sqlConnection4);
            table4 = new DataTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
