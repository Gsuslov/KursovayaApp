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
        }

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
            
            Process.Start( "https://github.com/Gsuslov/site");
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
            Process.Start("https://github.com/Gsuslov/site");
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
    }
}
