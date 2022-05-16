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
    public partial class FormAddPassanger : Form
    {
        public const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Георгий\Documents\GitHub\KursovayaApp\Database1.mdf;Integrated Security=True";
        public FormAddPassanger()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            Passanger P = dc.Passanger.FirstOrDefault(x=> x.Passport == textBox3.Text);
            dc.Passanger.FirstOrDefault(x => x.DateOfBirth == dateTimePicker1.Value);
            dc.Passanger.FirstOrDefault(x => x.Phone == numericUpDown1.ToString());
            dc.Passanger.FirstOrDefault(x => x.FIO == textBox1.Text);
            if (dc == null)
                throw new Exception("ПОЛОМАЛО");
            dc.SubmitChanges();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
