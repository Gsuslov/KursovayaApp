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
    public partial class FormEditTicket : Form
    {
        public string ConnectionString = Program.ConnectionString;
        public DataClassesDataContext dc;
        public int ticketID;
        public FormEditTicket()
        {
            InitializeComponent();
        }

        public FormEditTicket(int tID)
        {
            InitializeComponent();
            ticketID = tID;
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            var userId = dc.ExecuteQuery<Ticket>(@"select * from Ticket where Id = {0}", ticketID);
            foreach (Ticket sched in userId)
            {
                comboBox1.Items.Add(sched.Schedule_Id);
                comboBox3.Items.Add(sched.Passanger_Id);
                comboBox1.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
                comboBox1.Enabled = false;
                comboBox3.Enabled = false;

                var soldedTickets = dc.ExecuteQuery<Ticket>(@"select * from Ticket where Schedule_Id = {0}", sched.Schedule_Id);
                List<int> places = new List<int>();
                foreach (Ticket ticket in soldedTickets)
                {
                    places.Add((int)ticket.Place);
                }
                var trainPlacesCount = dc.ExecuteQuery<TRAINS>(@"select * from TRAINS where Id in (select Train_id from schedule where Id = {0})", sched.Schedule_Id);
                int trainPlacesCountResult;
                comboBox2.Items.Clear();
                comboBox2.Items.Add(sched.Place);
                comboBox2.SelectedItem = 0;
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

        }

        private void FormEditTicket_Load(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            var tickets = dc.ExecuteQuery<Ticket>(@"select * from Ticket where Id = {0}", ticketID);
            foreach (Ticket ticket in tickets)
            {
                ticket.Place = Convert.ToInt32(comboBox2.SelectedItem.ToString());
            }
            dc.SubmitChanges();
            Close();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
