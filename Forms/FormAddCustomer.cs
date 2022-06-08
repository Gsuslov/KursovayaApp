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
    public partial class FormAddCustomer : Form
    {
        public string ConnectionString = Program.ConnectionString;
        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            Customer C = new Customer
            {
                FIO = textBox1.Text,
                Product =textBox2.Text,
                Payment = checkBox1.Checked
            };
            dc.Customer.InsertOnSubmit(C);
            dc.SubmitChanges();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
