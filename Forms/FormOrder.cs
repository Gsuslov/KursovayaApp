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
        public bool isUserAlreadyExists = false;
        public FormOrder()
        {
            InitializeComponent();
            dc = new DataClassesDataContext(ConnectionString);
            var Schedules = dc.ExecuteQuery<Schedule>(@"select * from Schedule where Departure > {0}", dateTimePicker1.Value.ToString("dd.MM.yyyy HH:mm:ss"));

            foreach (Schedule sched in Schedules)
            {
                comboBox4.Items.Add(sched.WhereFrom);
                comboBox4.SelectedIndex = 0;
                comboBox3.Items.Add(sched.Whiter);
                comboBox3.SelectedIndex = 0;
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
                isUserAlreadyExists = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Schedules = dc.ExecuteQuery<Schedule>(@"select * from Schedule where Departure > {0} and WhereFrom = {1} and Whiter = {2} and Train_Id in (select id from TRAINS where Type = {3})", 
                dateTimePicker1.Value.ToString("dd.MM.yyyy HH:mm:ss"), comboBox4.SelectedItem, comboBox3.SelectedItem, groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);

            comboBox1.Items.Clear();
            foreach (Schedule sched in Schedules)
            {
                comboBox1.Items.Add(sched.Id + ": " + sched.WhereFrom.Trim() + " - " + sched.Whiter);
            }
            comboBox1.MouseDown += ComboBox1_MouseDown;
            try
            {
                comboBox1.SelectedIndex = 0;
            } catch (Exception ex) {
                comboBox1.Text="";
                MessageBox.Show("Рейсы не найдены");
            }

        }

        private void ComboBox1_MouseDown(object sender, MouseEventArgs e)
        {
            var soldedTickets = dc.ExecuteQuery<Ticket>(@"select * from Ticket where Schedule_Id = {0}", comboBox1.SelectedItem.ToString().Split(':')[0]);
            List<int> places = new List<int>();
            foreach (Ticket ticket in soldedTickets)
            {
                places.Add((int)ticket.Place);
            }
            var trainPlacesCount = dc.ExecuteQuery<TRAINS>(@"select * from TRAINS where Id in (select Train_id from schedule where Id = {0})", comboBox1.SelectedItem.ToString().Split(':')[0]);
            int trainPlacesCountResult;

            comboBox2.Items.Clear();

            foreach (TRAINS train in trainPlacesCount)
            {
                trainPlacesCountResult = (int)train.AllPlaces;
                for (int i = 0; i < trainPlacesCountResult; i++)
                {
                    if (!places.Contains(i))
                    {
                        comboBox2.Items.Add(i);
                    }
                }
                try
                {
                    comboBox2.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    comboBox2.Text = "";
                    MessageBox.Show("Свободных мест нет");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем пользователя, если не нашили по серии-номеру
            if (!isUserAlreadyExists) {
                DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
                Passanger P = new Passanger
                {
                    FIO = textBox3.Text + ' ' + textBox4.Text + ' ' + textBox5.Text,
                    Passport = textBox1.Text,
                    DateOfBirth = dateTimePicker2.Value,
                    Phone = textBox6.Text
                };
                dc.Passanger.InsertOnSubmit(P);
                dc.SubmitChanges();
            }
            var userId = dc.ExecuteQuery<Passanger>(@"select * from Passanger where Passport = {0}", textBox1.Text);
            int passangerId = 0;
            foreach (Passanger pass in userId) {
                passangerId = pass.Id;
            }

            dc = new DataClassesDataContext(ConnectionString);
            Ticket T = new Ticket
            {
                Passanger_Id = (int)passangerId,
                Place = (int)comboBox2.SelectedItem,
                Schedule_Id = Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(':')[0]),
            };
            dc.Ticket.InsertOnSubmit(T);
            dc.SubmitChanges();


        }
    }
}
