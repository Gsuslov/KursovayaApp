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
    }
}
