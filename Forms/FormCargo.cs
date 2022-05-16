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
        public const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Георгий\Documents\GitHub\KursovayaApp\Database1.mdf;Integrated Security=True";
        public DataClassesDataContext dc;
        public FormCargo()
        {
            InitializeComponent();
            dc = new DataClassesDataContext(ConnectionString);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void списокПассажирскихПоездовToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void FormCargo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dc.Cargo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
