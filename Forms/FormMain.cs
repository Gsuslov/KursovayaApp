using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            dc = new DataClassesDataContext(ConnectionString);
            
        }
        public string ConnectionString = Program.ConnectionString;
        public DataClassesDataContext dc;
        private void поездаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainForm TForm = new TrainForm();
            TForm.Show();
        }

        private void рассписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сведеньяОбАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Process.Start("https://github.com/Gsuslov/site");
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://vk.com/id427803214");
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void customButton6_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Gsuslov/KursovayaApp");
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            FormSchedule FSchedule = new FormSchedule();
            FSchedule.Show();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            TrainForm trainForm = new TrainForm();
            trainForm.Show();

        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            FormCustomer fCustomer = new FormCustomer();
            fCustomer.Show();
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            FormPassanger FPassanger = new FormPassanger();
            FPassanger.Show();
        }

        private void масштабToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void полноэкранныйРежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void дефолтныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void customButton7_Click(object sender, EventArgs e)
        {
            FormCargo FCargo = new FormCargo();
            FCargo.Show();
        }

        private void customButton8_Click(object sender, EventArgs e)
        {
            FormTicket FTicket = new FormTicket();
            FTicket.Show();
        }
    }
}
