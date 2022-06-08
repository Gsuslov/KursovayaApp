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
    public partial class FormAddTicket : Form
    {
        public string ConnectionString = Program.ConnectionString;
        public DataClassesDataContext dc;
        public FormAddTicket()
        {
            InitializeComponent();
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            var Schedules = dc.ExecuteQuery<Schedule>(@"select * from Schedule");
            comboBox1.Items.Clear();
            foreach (Schedule sched in Schedules)
            {
                comboBox1.Items.Add(sched.Id + ": " + sched.WhereFrom.Trim() + " - " + sched.Whiter);
            }
            
            try
            {
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                comboBox1.Text = "";
                MessageBox.Show("Рейсы не найдены");
            }

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

            var Passangers = dc.ExecuteQuery<Passanger>(@"select * from Passanger");
            foreach (Passanger pass in Passangers)
            {
                comboBox3.Items.Add(pass.Id);
            }
            comboBox3.SelectedIndex = 0;
        }

        

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
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

    private void FormAddTicket_Load(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            Ticket P = new Ticket
            {
                Schedule_Id = Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(':')[0]),
                Place = Convert.ToInt32(comboBox2.SelectedItem),
                Passanger_Id = Convert.ToInt32(comboBox3.SelectedItem),
            };
            dc.Ticket.InsertOnSubmit(P);
            dc.SubmitChanges();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
