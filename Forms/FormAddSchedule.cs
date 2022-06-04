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
    public partial class FormAddSchedule : Form
    {
        public string ConnectionString = Program.ConnectionString;
        public DataClassesDataContext dc;
        public FormAddSchedule()
        {
            InitializeComponent();
            dc = new DataClassesDataContext(ConnectionString);
            var trains = dc.ExecuteQuery<TRAINS>(@"select * from TRAINS");
            foreach (TRAINS train in trains)
            {
                comboBox1.Items.Add(train.Id);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            Schedule P = new Schedule
            {
                Train_Id = (int?)comboBox1.SelectedItem,
                WhereFrom = textBox1.Text,
                Whiter = textBox2.Text,
                Departure = dateTimePicker1.Value,
                ArrivalTime = dateTimePicker1.Value
            };
            dc.Schedule.InsertOnSubmit(P);
            dc.SubmitChanges();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
