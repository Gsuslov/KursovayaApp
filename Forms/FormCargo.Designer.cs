
namespace WindowsFormsApp2
{
    partial class FormCargo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSourceCargo = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.списокПассажирскихПоездовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wagonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCargo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.cargoPlaceDataGridViewTextBoxColumn,
            this.flightNumberDataGridViewTextBoxColumn,
            this.scheduleIdDataGridViewTextBoxColumn,
            this.cargoNameDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.wagonDataGridViewTextBoxColumn,
            this.scheduleDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceCargo;
            this.dataGridView1.Location = new System.Drawing.Point(16, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1301, 492);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bindingSourceCargo
            // 
            this.bindingSourceCargo.DataSource = typeof(WindowsFormsApp2.Cargo);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокПассажирскихПоездовToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1735, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // списокПассажирскихПоездовToolStripMenuItem
            // 
            this.списокПассажирскихПоездовToolStripMenuItem.Name = "списокПассажирскихПоездовToolStripMenuItem";
            this.списокПассажирскихПоездовToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.списокПассажирскихПоездовToolStripMenuItem.Text = "Список грузовых поездов поездов";
            this.списокПассажирскихПоездовToolStripMenuItem.Click += new System.EventHandler(this.списокПассажирскихПоездовToolStripMenuItem_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Width = 125;
            // 
            // cargoPlaceDataGridViewTextBoxColumn
            // 
            this.cargoPlaceDataGridViewTextBoxColumn.DataPropertyName = "CargoPlace";
            this.cargoPlaceDataGridViewTextBoxColumn.HeaderText = "Место";
            this.cargoPlaceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cargoPlaceDataGridViewTextBoxColumn.Name = "cargoPlaceDataGridViewTextBoxColumn";
            this.cargoPlaceDataGridViewTextBoxColumn.Width = 125;
            // 
            // flightNumberDataGridViewTextBoxColumn
            // 
            this.flightNumberDataGridViewTextBoxColumn.DataPropertyName = "FlightNumber";
            this.flightNumberDataGridViewTextBoxColumn.HeaderText = "Номер рейса";
            this.flightNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flightNumberDataGridViewTextBoxColumn.Name = "flightNumberDataGridViewTextBoxColumn";
            this.flightNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // scheduleIdDataGridViewTextBoxColumn
            // 
            this.scheduleIdDataGridViewTextBoxColumn.DataPropertyName = "Schedule_Id";
            this.scheduleIdDataGridViewTextBoxColumn.HeaderText = "Schedule_Id";
            this.scheduleIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scheduleIdDataGridViewTextBoxColumn.Name = "scheduleIdDataGridViewTextBoxColumn";
            this.scheduleIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // cargoNameDataGridViewTextBoxColumn
            // 
            this.cargoNameDataGridViewTextBoxColumn.DataPropertyName = "CargoName";
            this.cargoNameDataGridViewTextBoxColumn.HeaderText = "Название груза";
            this.cargoNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cargoNameDataGridViewTextBoxColumn.Name = "cargoNameDataGridViewTextBoxColumn";
            this.cargoNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "Customer_Id";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "Customer_Id";
            this.customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // wagonDataGridViewTextBoxColumn
            // 
            this.wagonDataGridViewTextBoxColumn.DataPropertyName = "Wagon";
            this.wagonDataGridViewTextBoxColumn.HeaderText = "Вагон";
            this.wagonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wagonDataGridViewTextBoxColumn.Name = "wagonDataGridViewTextBoxColumn";
            this.wagonDataGridViewTextBoxColumn.Width = 125;
            // 
            // scheduleDataGridViewTextBoxColumn
            // 
            this.scheduleDataGridViewTextBoxColumn.DataPropertyName = "Schedule";
            this.scheduleDataGridViewTextBoxColumn.HeaderText = "Расписание";
            this.scheduleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scheduleDataGridViewTextBoxColumn.Name = "scheduleDataGridViewTextBoxColumn";
            this.scheduleDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Заказчик";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1735, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCargo";
            this.Text = "FormCargo";
            this.Load += new System.EventHandler(this.FormCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCargo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem списокПассажирскихПоездовToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSourceCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wagonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
    }
}