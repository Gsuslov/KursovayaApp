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
    public partial class FormOrder : Form
    {
        public string ConnectionString = Program.ConnectionString;
        public DataClassesDataContext dc;
        public FormOrder()
        {
            InitializeComponent();
            dc = new DataClassesDataContext(ConnectionString);
            var Schedules = dc.ExecuteQuery<Schedule>(@"select * from Schedule where Departure > '{0}'", dateTimePicker1.Value.ToString("dd.MM.yyyy"));

            foreach (Schedule sched in Schedules)
            {
                comboBox4.Items.Add(sched.WhereFrom);
                comboBox3.Items.Add(sched.Whiter);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var passangers = dc.ExecuteQuery<Passanger>(@"select top 1 * from Passanger where Passport={0}",textBox1.Text);
            foreach (Passanger pass in passangers)
            {
                textBox3.Text = pass.FIO.Split(' ')[0];
                textBox4.Text = pass.FIO.Split(' ')[1];
                textBox5.Text = pass.FIO.Split(' ')[2];
                dateTimePicker2.Text=pass.DateOfBirth.ToString();
                textBox6.Text = pass.Phone;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
