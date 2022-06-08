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
    public partial class FormEditSchedule : Form
    {
        public string ConnectionString = Program.ConnectionString;
        public DataClassesDataContext dc;
        public int scheduleId;
        public FormEditSchedule()
        {
            InitializeComponent();
        }
        public FormEditSchedule(int schedId)
        {
            InitializeComponent();
            scheduleId = schedId;
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            var userId = dc.ExecuteQuery<Schedule>(@"select * from Schedule where Id = {0}", scheduleId);
            foreach (Schedule sched in userId)
            {
                //comboBox1.Items = sched.Train_Id.Trim();
                textBox3.Text = sched.Train_Id.ToString().Trim();
                textBox1.Text = sched.WhereFrom.Trim();
                textBox2.Text = sched.Whiter.Trim();
                dateTimePicker1.Value = (DateTime)sched.Departure;
                dateTimePicker2.Value = (DateTime)sched.ArrivalTime;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormEditSchedule_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {           
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            var userId = dc.ExecuteQuery<Schedule>(@"select * from Schedule where Id = {0}", scheduleId);
            foreach (Schedule sched in userId)
            {
                sched.Train_Id = Convert.ToInt32(textBox3.Text.ToString());
                sched.Departure= dateTimePicker1.Value;
                sched.ArrivalTime = dateTimePicker2.Value;
                sched.Whiter = textBox2.Text;
                sched.WhereFrom = textBox1.Text;
            }
            dc.SubmitChanges();
            Close();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            var userId = dc.ExecuteQuery<Schedule>(@"select * from Schedule where Id = {0}", scheduleId);
            foreach (Schedule sched in userId)
            {
                sched.Train_Id = Convert.ToInt32(textBox3.Text.ToString());
                sched.Departure = dateTimePicker1.Value;
                sched.ArrivalTime = dateTimePicker2.Value;
                sched.Whiter = textBox2.Text;
                sched.WhereFrom = textBox1.Text;
            }
            dc.SubmitChanges();
            Close();
        }
    }
}
