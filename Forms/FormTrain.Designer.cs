
namespace WindowsFormsApp2
{
    partial class TrainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allPlacesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьСортировкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вПорядкеВозрастанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вПорядкеУбыванияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поАлфавитуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вПорядкеВозрастанияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поКоличествуМестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вПорядкеУбыванияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вПорядкеВозрастанияToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.найтиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.типПеревозкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоМестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.найтиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоКатегориямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.customButton4 = new WindowsFormsApp2.Clauses.CustomButton();
            this.customButton3 = new WindowsFormsApp2.Clauses.CustomButton();
            this.customButton2 = new WindowsFormsApp2.Clauses.CustomButton();
            this.button4 = new System.Windows.Forms.Button();
            this.customButton6 = new WindowsFormsApp2.Clauses.CustomButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.customButton5 = new WindowsFormsApp2.Clauses.CustomButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.allPlacesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trainsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(430, 472);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип поезда";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // allPlacesDataGridViewTextBoxColumn
            // 
            this.allPlacesDataGridViewTextBoxColumn.DataPropertyName = "AllPlaces";
            this.allPlacesDataGridViewTextBoxColumn.HeaderText = "Количество мест ";
            this.allPlacesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.allPlacesDataGridViewTextBoxColumn.Name = "allPlacesDataGridViewTextBoxColumn";
            this.allPlacesDataGridViewTextBoxColumn.ReadOnly = true;
            this.allPlacesDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainsBindingSource
            // 
            this.trainsBindingSource.DataSource = typeof(WindowsFormsApp2.TRAINS);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fKToolStripMenuItem,
            this.выбратьСортировкуToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.поискПоКатегориямToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fKToolStripMenuItem
            // 
            this.fKToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fKToolStripMenuItem.Name = "fKToolStripMenuItem";
            this.fKToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.fKToolStripMenuItem.Text = "Список поездов";
            this.fKToolStripMenuItem.Click += new System.EventHandler(this.fKToolStripMenuItem_Click);
            // 
            // выбратьСортировкуToolStripMenuItem
            // 
            this.выбратьСортировкуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вПорядкеВозрастанияToolStripMenuItem,
            this.вПорядкеУбыванияToolStripMenuItem,
            this.поАлфавитуToolStripMenuItem,
            this.вПорядкеВозрастанияToolStripMenuItem1,
            this.поКоличествуМестToolStripMenuItem});
            this.выбратьСортировкуToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.выбратьСортировкуToolStripMenuItem.Name = "выбратьСортировкуToolStripMenuItem";
            this.выбратьСортировкуToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.выбратьСортировкуToolStripMenuItem.Text = "Выбрать сортировку";
            // 
            // вПорядкеВозрастанияToolStripMenuItem
            // 
            this.вПорядкеВозрастанияToolStripMenuItem.Name = "вПорядкеВозрастанияToolStripMenuItem";
            this.вПорядкеВозрастанияToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.вПорядкеВозрастанияToolStripMenuItem.Text = "Грузовые поезда";
            this.вПорядкеВозрастанияToolStripMenuItem.Click += new System.EventHandler(this.вПорядкеВозрастанияToolStripMenuItem_Click);
            // 
            // вПорядкеУбыванияToolStripMenuItem
            // 
            this.вПорядкеУбыванияToolStripMenuItem.Name = "вПорядкеУбыванияToolStripMenuItem";
            this.вПорядкеУбыванияToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.вПорядкеУбыванияToolStripMenuItem.Text = "Пассажирские поезда";
            this.вПорядкеУбыванияToolStripMenuItem.Click += new System.EventHandler(this.вПорядкеУбыванияToolStripMenuItem_Click);
            // 
            // поАлфавитуToolStripMenuItem
            // 
            this.поАлфавитуToolStripMenuItem.Name = "поАлфавитуToolStripMenuItem";
            this.поАлфавитуToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.поАлфавитуToolStripMenuItem.Text = "В порядке убывания";
            this.поАлфавитуToolStripMenuItem.Click += new System.EventHandler(this.поАлфавитуToolStripMenuItem_Click);
            // 
            // вПорядкеВозрастанияToolStripMenuItem1
            // 
            this.вПорядкеВозрастанияToolStripMenuItem1.Name = "вПорядкеВозрастанияToolStripMenuItem1";
            this.вПорядкеВозрастанияToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.вПорядкеВозрастанияToolStripMenuItem1.Text = "В порядке возрастания";
            this.вПорядкеВозрастанияToolStripMenuItem1.Click += new System.EventHandler(this.вПорядкеВозрастанияToolStripMenuItem1_Click);
            // 
            // поКоличествуМестToolStripMenuItem
            // 
            this.поКоличествуМестToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вПорядкеУбыванияToolStripMenuItem1,
            this.вПорядкеВозрастанияToolStripMenuItem2});
            this.поКоличествуМестToolStripMenuItem.Name = "поКоличествуМестToolStripMenuItem";
            this.поКоличествуМестToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.поКоличествуМестToolStripMenuItem.Text = "По количеству мест";
            // 
            // вПорядкеУбыванияToolStripMenuItem1
            // 
            this.вПорядкеУбыванияToolStripMenuItem1.Name = "вПорядкеУбыванияToolStripMenuItem1";
            this.вПорядкеУбыванияToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.вПорядкеУбыванияToolStripMenuItem1.Text = "В порядке убывания ";
            this.вПорядкеУбыванияToolStripMenuItem1.Click += new System.EventHandler(this.вПорядкеУбыванияToolStripMenuItem1_Click);
            // 
            // вПорядкеВозрастанияToolStripMenuItem2
            // 
            this.вПорядкеВозрастанияToolStripMenuItem2.Name = "вПорядкеВозрастанияToolStripMenuItem2";
            this.вПорядкеВозрастанияToolStripMenuItem2.Size = new System.Drawing.Size(200, 22);
            this.вПорядкеВозрастанияToolStripMenuItem2.Text = "В порядке возрастания";
            this.вПорядкеВозрастанияToolStripMenuItem2.Click += new System.EventHandler(this.вПорядкеВозрастанияToolStripMenuItem2_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idToolStripMenuItem,
            this.типПеревозкиToolStripMenuItem,
            this.количествоМестToolStripMenuItem});
            this.поискToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.поискToolStripMenuItem.Text = "Поиск по...";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // idToolStripMenuItem
            // 
            this.idToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3,
            this.найтиToolStripMenuItem2});
            this.idToolStripMenuItem.Name = "idToolStripMenuItem";
            this.idToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.idToolStripMenuItem.Text = "Id";
            this.idToolStripMenuItem.Click += new System.EventHandler(this.idToolStripMenuItem_Click);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox3.Click += new System.EventHandler(this.toolStripTextBox3_Click);
            // 
            // найтиToolStripMenuItem2
            // 
            this.найтиToolStripMenuItem2.Name = "найтиToolStripMenuItem2";
            this.найтиToolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.найтиToolStripMenuItem2.Text = "Найти";
            this.найтиToolStripMenuItem2.Click += new System.EventHandler(this.найтиToolStripMenuItem2_Click);
            // 
            // типПеревозкиToolStripMenuItem
            // 
            this.типПеревозкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.найтиToolStripMenuItem});
            this.типПеревозкиToolStripMenuItem.Name = "типПеревозкиToolStripMenuItem";
            this.типПеревозкиToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.типПеревозкиToolStripMenuItem.Text = "Тип перевозки";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click_1);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.найтиToolStripMenuItem.Text = "Найти";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // количествоМестToolStripMenuItem
            // 
            this.количествоМестToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2,
            this.найтиToolStripMenuItem1});
            this.количествоМестToolStripMenuItem.Name = "количествоМестToolStripMenuItem";
            this.количествоМестToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.количествоМестToolStripMenuItem.Text = "Количество мест";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // найтиToolStripMenuItem1
            // 
            this.найтиToolStripMenuItem1.Name = "найтиToolStripMenuItem1";
            this.найтиToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.найтиToolStripMenuItem1.Text = "Найти";
            this.найтиToolStripMenuItem1.Click += new System.EventHandler(this.найтиToolStripMenuItem1_Click);
            // 
            // поискПоКатегориямToolStripMenuItem
            // 
            this.поискПоКатегориямToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.поискПоКатегориямToolStripMenuItem.Name = "поискПоКатегориямToolStripMenuItem";
            this.поискПоКатегориямToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.поискПоКатегориямToolStripMenuItem.Text = "Поиск по категориям";
            this.поискПоКатегориямToolStripMenuItem.Click += new System.EventHandler(this.поискПоКатегориямToolStripMenuItem_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.customButton4);
            this.panel1.Controls.Add(this.customButton3);
            this.panel1.Controls.Add(this.customButton2);
            this.panel1.Location = new System.Drawing.Point(460, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 134);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(54, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Работа с записями";
            // 
            // customButton4
            // 
            this.customButton4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Location = new System.Drawing.Point(32, 95);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(143, 27);
            this.customButton4.TabIndex = 9;
            this.customButton4.Text = "Удалить";
            this.customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(32, 62);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(143, 27);
            this.customButton3.TabIndex = 8;
            this.customButton3.Text = "Редактировать запись ";
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(32, 26);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(143, 30);
            this.customButton2.TabIndex = 7;
            this.customButton2.Text = "Добавить запись";
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(492, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 54);
            this.button4.TabIndex = 5;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // customButton6
            // 
            this.customButton6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton6.FlatAppearance.BorderSize = 0;
            this.customButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton6.ForeColor = System.Drawing.Color.White;
            this.customButton6.Location = new System.Drawing.Point(968, 0);
            this.customButton6.Name = "customButton6";
            this.customButton6.Size = new System.Drawing.Size(93, 24);
            this.customButton6.TabIndex = 18;
            this.customButton6.Text = "Выход";
            this.customButton6.UseVisualStyleBackColor = false;
            this.customButton6.Click += new System.EventHandler(this.customButton6_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.customButton5);
            this.panel3.Location = new System.Drawing.Point(460, 312);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 104);
            this.panel3.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Поиск";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 7;
            // 
            // customButton5
            // 
            this.customButton5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton5.FlatAppearance.BorderSize = 0;
            this.customButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton5.ForeColor = System.Drawing.Color.White;
            this.customButton5.Location = new System.Drawing.Point(32, 74);
            this.customButton5.Name = "customButton5";
            this.customButton5.Size = new System.Drawing.Size(143, 27);
            this.customButton5.TabIndex = 6;
            this.customButton5.Text = "Поиск";
            this.customButton5.UseVisualStyleBackColor = false;
            this.customButton5.Click += new System.EventHandler(this.customButton5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(460, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 82);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "В алфавитном порядке",
            "В порядке возрастания паспортных данных",
            "В порядке убывания паспортных данных",
            "По дате рождения",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(3, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // TrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(735, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.customButton6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrainForm";
            this.Text = "FormTrain";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fKToolStripMenuItem;
        private System.Windows.Forms.BindingSource trainsBindingSource;
        private System.Windows.Forms.ToolStripMenuItem выбратьСортировкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вПорядкеВозрастанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вПорядкеУбыванияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поАлфавитуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ToolStripMenuItem вПорядкеВозрастанияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поКоличествуМестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вПорядкеУбыванияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вПорядкеВозрастанияToolStripMenuItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem idToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типПеревозкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоМестToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem2;
        private System.Windows.Forms.Label label5;
        private Clauses.CustomButton customButton4;
        private Clauses.CustomButton customButton3;
        private Clauses.CustomButton customButton2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem поискПоКатегориямToolStripMenuItem;
        private Clauses.CustomButton customButton6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allPlacesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private Clauses.CustomButton customButton5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

