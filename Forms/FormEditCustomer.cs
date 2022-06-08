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
    public partial class FormEditCustomer : Form
    {
        public string ConnectionString = Program.ConnectionString;
        public DataClassesDataContext dc;
        public int customerId;
        public FormEditCustomer()
        {
            InitializeComponent();
        }
        public FormEditCustomer(int cusId)
        {
            InitializeComponent();
            customerId = cusId;
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            var userId = dc.ExecuteQuery<Customer>(@"select * from Customer where Id = {0}", customerId);
            foreach (Customer cus in userId)
            {
                textBox1.Text = cus.FIO.Trim();
                textBox2.Text = cus.Product.Trim();
                checkBox1.Checked = cus.Payment.Value;
            }
        }


            private void FormEditCustomer_Load(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            var userId = dc.ExecuteQuery<Customer>(@"select * from Customer where Id = {0}", customerId);
            foreach (Customer cus in userId)
            {
                cus.FIO = textBox1.Text;
                cus.Product = textBox2.Text;
                cus.Payment = checkBox1.Checked;
            }
            dc.SubmitChanges();
        }
    }
}
