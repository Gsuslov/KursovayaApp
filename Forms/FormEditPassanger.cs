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
    public partial class FormEditPassanger : Form
    {
        public string ConnectionString = Program.ConnectionString;
        public DataClassesDataContext dc;
        public int passangerId;
        public FormEditPassanger()
        {
            InitializeComponent();
        }

        public FormEditPassanger(int passId)
        {
            InitializeComponent();
            passangerId = passId;
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            var userId = dc.ExecuteQuery<Passanger>(@"select * from Passanger where Id = {0}", passangerId);
            foreach (Passanger pass in userId)
            {
                textBox1.Text = pass.FIO.Trim();
                textBox3.Text = pass.Passport.Trim();
                dateTimePicker1.Value = (DateTime)pass.DateOfBirth;
                textBox2.Text = pass.Phone.Trim();
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            var userId = dc.ExecuteQuery<Passanger>(@"select * from Passanger where Id = {0}", passangerId);
            foreach (Passanger pass in userId)
            {
                pass.DateOfBirth = dateTimePicker1.Value;
                pass.Passport = textBox3.Text;
                pass.FIO = textBox1.Text;
                pass.Phone = textBox2.Text;
            }
            dc.SubmitChanges();
        }

        private void FormEditPassanger_Load(object sender, EventArgs e)
        {

        }
    }
}
