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

    public partial class FormSchedule : Form
    {

        public FormSchedule()
        {
            InitializeComponent();

        }
        public SqlConnection sqlConnection2 = null;
        public SqlDataAdapter SqlDataAdapter2 = null;
        public DataTable table2 = null;

        private void рассписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table2.Clear();
            SqlDataAdapter2.Fill(table2);
            dataGridView1.DataSource = table2;
 

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void FormSchedule_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {

        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {
   sqlConnection2 = new SqlConnection(@"Data Source=WIN-ER4GG7E4229\SQLEXPRESS;Initial Catalog=LogikDatabase;Integrated Security=True");
            sqlConnection2.Open();
            SqlDataAdapter2 = new SqlDataAdapter("SELECT * FROM Schedule", sqlConnection2);
            table2 = new DataTable();
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
    }
}
