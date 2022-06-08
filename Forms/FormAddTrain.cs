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
    public partial class FormAddTrain : Form
    {
        public string ConnectionString = Program.ConnectionString;
        public FormAddTrain()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            TRAINS P = new TRAINS
            {
                Type = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text,
                AllPlaces = (int?)numericUpDown1.Value
            };
            dc.TRAINS.InsertOnSubmit(P);
            dc.SubmitChanges();
        }

        private void FormAddTrain_Load(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            TRAINS P = new TRAINS
            {
                Type = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text,
                AllPlaces = (int?)numericUpDown1.Value
            };
            dc.TRAINS.InsertOnSubmit(P);
            dc.SubmitChanges();
            Close();
        }
    }
}
