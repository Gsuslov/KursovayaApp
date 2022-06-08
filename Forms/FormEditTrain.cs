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
    public partial class FormEditTrain : Form
    {
        public string ConnectionString = Program.ConnectionString;
        public DataClassesDataContext dc;
        public int trainID;
        public FormEditTrain()
        {
            InitializeComponent();
        }

        public FormEditTrain(int tID)
        {
            InitializeComponent();
            trainID = tID;
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            var trains = dc.ExecuteQuery<TRAINS>(@"select * from TRAINS where Id = {0}", trainID);
            foreach (TRAINS tr in trains)
            {
                numericUpDown1.Value = (int)tr.AllPlaces;
                if (tr.Type == "Пассажирская")
                {
                    radioButton1.Checked=true;
                }
                else {
                    radioButton2.Checked=true;
                }
            }
        }

        private void FormEditTrain_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            var trains = dc.ExecuteQuery<TRAINS>(@"select * from TRAINS where Id = {0}", trainID);
            foreach (TRAINS tr in trains)
            {
                tr.AllPlaces = (short?)numericUpDown1.Value;
                tr.Type = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            }
            dc.SubmitChanges();
            Close();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            var trains = dc.ExecuteQuery<TRAINS>(@"select * from TRAINS where Id = {0}", trainID);
            foreach (TRAINS tr in trains)
            {
                tr.AllPlaces = (short?)numericUpDown1.Value;
                tr.Type = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            }
            dc.SubmitChanges();
            Close();
        }
    }
}
