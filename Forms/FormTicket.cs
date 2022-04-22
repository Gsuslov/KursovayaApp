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
using WindowsFormsApp2.Forms;

namespace WindowsFormsApp2
{
    public partial class FormTicket : Form
    {
        public SqlConnection sqlConnection3 = null;
        public SqlDataAdapter SqlDataAdapter3 = null;
        public DataTable table3 = null;
        public FormTicket()
        {
            InitializeComponent();
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            
            sqlConnection3 = new SqlConnection(@"Data Source=WIN-ER4GG7E4229\SQLEXPRESS;Initial Catalog=LogikDatabase;Integrated Security=True");
            sqlConnection3.Open();
            SqlDataAdapter3 = new SqlDataAdapter("SELECT * FROM Ticket", sqlConnection3);
            table3 = new DataTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void списокПассажирскихПоездовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table3.Clear();
            SqlDataAdapter3.Fill(table3);
            dataGridView1.DataSource = table3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdd FAdd = new FormAdd();
            FAdd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
