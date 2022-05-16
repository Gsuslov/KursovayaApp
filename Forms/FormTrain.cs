﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
    public partial class TrainForm : Form
    {
        public const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Георгий\Documents\GitHub\KursovayaApp\Database1.mdf;Integrated Security=True";
        public DataClassesDataContext dc;
        public TrainForm()
        {
            InitializeComponent();
            dc = new DataClassesDataContext(ConnectionString);
        }

        private void fKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dc.TRAINS;  

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sqlConnection = new SqlConnection(@"Data Source=WIN-ER4GG7E4229\SQLEXPRESS;Initial Catalog=LogikDatabase;Integrated Security=True");
            //sqlConnection.Open();
            //SqlDataAdapter = new SqlDataAdapter("DELETE FROM Trains WHERE"+ dataGridView1.SelectedCells[0].RowIndex , sqlConnection);
            //table = new DataTable();
            //{
            //    int delet = dataGridView1.SelectedCells[0].RowIndex;
            //    dataGridView1.Rows.RemoveAt(delet);
            //}
            //table.Clear();
            //SqlDataAdapter.Fill(table);
            //dataGridView1.DataSource = table;
        }

        private void вПорядкеВозрастанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }

        private void вПорядкеУбыванияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
        }

        private void поАлфавитуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void вПорядкеВозрастанияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
        }

        private void вПорядкеУбыванияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
        }

        private void вПорядкеВозрастанияToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(toolStripTextBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void найтиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(toolStripTextBox2.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void найтиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(toolStripTextBox3.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void idToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void поискПоКатегориямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
          
        }

        private void customButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
