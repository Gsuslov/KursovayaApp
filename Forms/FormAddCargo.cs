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
    public partial class FormAddCargo : Form
    {
        public string ConnectionString = Program.ConnectionString;
        public DataClassesDataContext dc;
        public FormAddCargo()
        {
            InitializeComponent();
            dc = new DataClassesDataContext(ConnectionString);
            var Schedules = dc.ExecuteQuery<Schedule>(@"select * from Schedule");

            foreach (Schedule sched in Schedules)
            {
                comboBox1.Items.Add(sched.Id);
            }
            try
            {
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex) {
                MessageBox.Show("Расписания не найдены.");
            }

            var customers = dc.ExecuteQuery<Customer>(@"select * from Customer");

            foreach (Customer cust in customers)
            {
                comboBox2.Items.Add(cust.Id);
            }
            try
            {
                comboBox2.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заказчики не найдены.");
            }
        }

        private void FormAddCargo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            Cargo P = new Cargo
            {
                Weight = (short?)numericUpDown1.Value,
                CargoPlace = (short?)numericUpDown2.Value,
                FlightNumber = (short?)numericUpDown4.Value,
                CargoName = textBox1.Text,
                Schedule_Id = Convert.ToInt32(comboBox1.SelectedItem),
                Customer_Id = Convert.ToInt32(comboBox2.SelectedItem)
            };
            dc.Cargo.InsertOnSubmit(P);
            dc.SubmitChanges();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            Cargo P = new Cargo
            {
                Weight = (short?)numericUpDown1.Value,
                CargoPlace = (short?)numericUpDown2.Value,
                FlightNumber = (short?)numericUpDown4.Value,
                CargoName = textBox1.Text,
                Schedule_Id = Convert.ToInt32(comboBox1.SelectedItem),
                Customer_Id = Convert.ToInt32(comboBox2.SelectedItem)
            };
            dc.Cargo.InsertOnSubmit(P);
            dc.SubmitChanges();
        }
    }
}
