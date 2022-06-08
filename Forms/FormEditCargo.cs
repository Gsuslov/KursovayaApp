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
    public partial class FormEditCargo : Form
    {
        public string ConnectionString = Program.ConnectionString;
        public DataClassesDataContext dc;
        public int cargoId;
        public FormEditCargo()
        {
            InitializeComponent();
        }
        public FormEditCargo(int cId)
        {
            InitializeComponent();
            cargoId = cId;
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            var cargos = dc.ExecuteQuery<Cargo>(@"select * from Cargo where Id = {0}", cargoId);
            foreach (Cargo cargo in cargos)
            {
                numericUpDown1.Value = (int)cargo.Weight;
                numericUpDown2.Value = (int)cargo.CargoPlace;
                numericUpDown3.Value = (int)cargo.FlightNumber;
                numericUpDown4.Value = (int)cargo.Schedule_Id;
                numericUpDown5.Value = (int)cargo.Customer_Id;
                textBox1.Text = cargo.CargoName;
            }

        }

        private void FormEditCargo_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext(ConnectionString);
            var Cargos = dc.ExecuteQuery<Cargo>(@"select * from Cargo where Id = {0}", cargoId);
            foreach (Cargo cargo in Cargos)
            {
                cargo.CargoName = textBox1.Text;
                cargo.Weight = (short?)numericUpDown1.Value;
                cargo.CargoPlace = (short?)numericUpDown2.Value;
                cargo.Schedule_Id = (short?)numericUpDown3.Value;
                cargo.FlightNumber = (short?)numericUpDown4.Value;
                cargo.Customer_Id = (short?)numericUpDown5.Value;
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
            var Cargos = dc.ExecuteQuery<Cargo>(@"select * from Cargo where Id = {0}", cargoId);
            foreach (Cargo cargo in Cargos)
            {
                cargo.CargoName = textBox1.Text;
                cargo.Weight = (short?)numericUpDown1.Value;
                cargo.CargoPlace = (short?)numericUpDown2.Value;
                cargo.Schedule_Id = (short?)numericUpDown3.Value;
                cargo.FlightNumber = (short?)numericUpDown4.Value;
                cargo.Customer_Id = (short?)numericUpDown5.Value;
            }
            dc.SubmitChanges();
            Close();
        }
    }
}
