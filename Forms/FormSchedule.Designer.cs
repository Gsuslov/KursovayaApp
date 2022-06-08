﻿
namespace WindowsFormsApp2
{
    partial class FormSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchedule));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.customButton1 = new WindowsFormsApp2.Clauses.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.customButton4 = new WindowsFormsApp2.Clauses.CustomButton();
            this.customButton3 = new WindowsFormsApp2.Clauses.CustomButton();
            this.customButton2 = new WindowsFormsApp2.Clauses.CustomButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выбратьСортировкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вПорядкеВозрастанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вПорядкеУбыванияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поАлфавитуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.вПорядкеВозрастанияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customButton5 = new WindowsFormsApp2.Clauses.CustomButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whereFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whiterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
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
            this.trainIdDataGridViewTextBoxColumn,
            this.whereFromDataGridViewTextBoxColumn,
            this.whiterDataGridViewTextBoxColumn,
            this.departureDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 441);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsApp2.Schedule);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.customButton1);
            this.panel2.Location = new System.Drawing.Point(809, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 112);
            this.panel2.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 7;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(49, 70);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(120, 27);
            this.customButton1.TabIndex = 6;
            this.customButton1.Text = "Поиск";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.customButton4);
            this.panel1.Controls.Add(this.customButton3);
            this.panel1.Controls.Add(this.customButton2);
            this.panel1.Location = new System.Drawing.Point(809, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 134);
            this.panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(46, 10);
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
            this.customButton4.Click += new System.EventHandler(this.customButton4_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьСортировкуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выбратьСортировкуToolStripMenuItem
            // 
            this.выбратьСортировкуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вПорядкеВозрастанияToolStripMenuItem,
            this.вПорядкеУбыванияToolStripMenuItem,
            this.поАлфавитуToolStripMenuItem,
            this.вПорядкеВозрастанияToolStripMenuItem1});
            this.выбратьСортировкуToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.выбратьСортировкуToolStripMenuItem.Name = "выбратьСортировкуToolStripMenuItem";
            this.выбратьСортировкуToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.выбратьСортировкуToolStripMenuItem.Text = "Выбрать сортировку";
            // 
            // вПорядкеВозрастанияToolStripMenuItem
            // 
            this.вПорядкеВозрастанияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поУбываниюToolStripMenuItem,
            this.поВозрастаниюToolStripMenuItem});
            this.вПорядкеВозрастанияToolStripMenuItem.Name = "вПорядкеВозрастанияToolStripMenuItem";
            this.вПорядкеВозрастанияToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.вПорядкеВозрастанияToolStripMenuItem.Text = "Время прибытия";
            this.вПорядкеВозрастанияToolStripMenuItem.Click += new System.EventHandler(this.вПорядкеВозрастанияToolStripMenuItem_Click);
            // 
            // поУбываниюToolStripMenuItem
            // 
            this.поУбываниюToolStripMenuItem.Name = "поУбываниюToolStripMenuItem";
            this.поУбываниюToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.поУбываниюToolStripMenuItem.Text = "По убыванию ";
            this.поУбываниюToolStripMenuItem.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem_Click);
            // 
            // поВозрастаниюToolStripMenuItem
            // 
            this.поВозрастаниюToolStripMenuItem.Name = "поВозрастаниюToolStripMenuItem";
            this.поВозрастаниюToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.поВозрастаниюToolStripMenuItem.Text = "По возрастанию";
            this.поВозрастаниюToolStripMenuItem.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem_Click);
            // 
            // вПорядкеУбыванияToolStripMenuItem
            // 
            this.вПорядкеУбыванияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поУбываниюToolStripMenuItem1,
            this.поВозрастаниюToolStripMenuItem1});
            this.вПорядкеУбыванияToolStripMenuItem.Name = "вПорядкеУбыванияToolStripMenuItem";
            this.вПорядкеУбыванияToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.вПорядкеУбыванияToolStripMenuItem.Text = "Поезд";
            // 
            // поУбываниюToolStripMenuItem1
            // 
            this.поУбываниюToolStripMenuItem1.Name = "поУбываниюToolStripMenuItem1";
            this.поУбываниюToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.поУбываниюToolStripMenuItem1.Text = "По убыванию";
            this.поУбываниюToolStripMenuItem1.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem1_Click);
            // 
            // поВозрастаниюToolStripMenuItem1
            // 
            this.поВозрастаниюToolStripMenuItem1.Name = "поВозрастаниюToolStripMenuItem1";
            this.поВозрастаниюToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.поВозрастаниюToolStripMenuItem1.Text = "По возрастанию";
            this.поВозрастаниюToolStripMenuItem1.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem1_Click);
            // 
            // поАлфавитуToolStripMenuItem
            // 
            this.поАлфавитуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поВозрастаниюToolStripMenuItem2,
            this.поУбываниюToolStripMenuItem2});
            this.поАлфавитуToolStripMenuItem.Name = "поАлфавитуToolStripMenuItem";
            this.поАлфавитуToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.поАлфавитуToolStripMenuItem.Text = "Место прибытия";
            // 
            // поВозрастаниюToolStripMenuItem2
            // 
            this.поВозрастаниюToolStripMenuItem2.Name = "поВозрастаниюToolStripMenuItem2";
            this.поВозрастаниюToolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
            this.поВозрастаниюToolStripMenuItem2.Text = "По возрастанию";
            this.поВозрастаниюToolStripMenuItem2.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem2_Click);
            // 
            // поУбываниюToolStripMenuItem2
            // 
            this.поУбываниюToolStripMenuItem2.Name = "поУбываниюToolStripMenuItem2";
            this.поУбываниюToolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
            this.поУбываниюToolStripMenuItem2.Text = "По убыванию";
            this.поУбываниюToolStripMenuItem2.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem2_Click);
            // 
            // вПорядкеВозрастанияToolStripMenuItem1
            // 
            this.вПорядкеВозрастанияToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поВозрастаниюToolStripMenuItem3,
            this.поУбываниюToolStripMenuItem3});
            this.вПорядкеВозрастанияToolStripMenuItem1.Name = "вПорядкеВозрастанияToolStripMenuItem1";
            this.вПорядкеВозрастанияToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.вПорядкеВозрастанияToolStripMenuItem1.Text = "Место отправления";
            this.вПорядкеВозрастанияToolStripMenuItem1.Click += new System.EventHandler(this.вПорядкеВозрастанияToolStripMenuItem1_Click);
            // 
            // поВозрастаниюToolStripMenuItem3
            // 
            this.поВозрастаниюToolStripMenuItem3.Name = "поВозрастаниюToolStripMenuItem3";
            this.поВозрастаниюToolStripMenuItem3.Size = new System.Drawing.Size(165, 22);
            this.поВозрастаниюToolStripMenuItem3.Text = "По возрастанию";
            this.поВозрастаниюToolStripMenuItem3.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem3_Click);
            // 
            // поУбываниюToolStripMenuItem3
            // 
            this.поУбываниюToolStripMenuItem3.Name = "поУбываниюToolStripMenuItem3";
            this.поУбываниюToolStripMenuItem3.Size = new System.Drawing.Size(165, 22);
            this.поУбываниюToolStripMenuItem3.Text = "По убыванию";
            this.поУбываниюToolStripMenuItem3.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem3_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1034, 25);
            this.bindingNavigator1.TabIndex = 15;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // customButton5
            // 
            this.customButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton5.FlatAppearance.BorderSize = 0;
            this.customButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton5.ForeColor = System.Drawing.Color.White;
            this.customButton5.Location = new System.Drawing.Point(841, 425);
            this.customButton5.Name = "customButton5";
            this.customButton5.Size = new System.Drawing.Size(143, 40);
            this.customButton5.TabIndex = 16;
            this.customButton5.Text = "Назад";
            this.customButton5.UseVisualStyleBackColor = false;
            this.customButton5.Click += new System.EventHandler(this.customButton5_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainIdDataGridViewTextBoxColumn
            // 
            this.trainIdDataGridViewTextBoxColumn.DataPropertyName = "Train_Id";
            this.trainIdDataGridViewTextBoxColumn.HeaderText = "Id Поезда";
            this.trainIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainIdDataGridViewTextBoxColumn.Name = "trainIdDataGridViewTextBoxColumn";
            this.trainIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // whereFromDataGridViewTextBoxColumn
            // 
            this.whereFromDataGridViewTextBoxColumn.DataPropertyName = "WhereFrom";
            this.whereFromDataGridViewTextBoxColumn.HeaderText = "Место отправления";
            this.whereFromDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.whereFromDataGridViewTextBoxColumn.Name = "whereFromDataGridViewTextBoxColumn";
            this.whereFromDataGridViewTextBoxColumn.Width = 125;
            // 
            // whiterDataGridViewTextBoxColumn
            // 
            this.whiterDataGridViewTextBoxColumn.DataPropertyName = "Whiter";
            this.whiterDataGridViewTextBoxColumn.HeaderText = "Место прибытия";
            this.whiterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.whiterDataGridViewTextBoxColumn.Name = "whiterDataGridViewTextBoxColumn";
            this.whiterDataGridViewTextBoxColumn.Width = 125;
            // 
            // departureDataGridViewTextBoxColumn
            // 
            this.departureDataGridViewTextBoxColumn.DataPropertyName = "Departure";
            this.departureDataGridViewTextBoxColumn.HeaderText = "Время отравления";
            this.departureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departureDataGridViewTextBoxColumn.Name = "departureDataGridViewTextBoxColumn";
            this.departureDataGridViewTextBoxColumn.Width = 125;
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "Время прибытия";
            this.arrivalTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            this.arrivalTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1034, 505);
            this.Controls.Add(this.customButton5);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSchedule";
            this.Text = "FormSchedule";
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            this.InputLanguageChanging += new System.Windows.Forms.InputLanguageChangingEventHandler(this.FormSchedule_InputLanguageChanging);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Clauses.CustomButton customButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Clauses.CustomButton customButton4;
        private Clauses.CustomButton customButton3;
        private Clauses.CustomButton customButton2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьСортировкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вПорядкеВозрастанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вПорядкеУбыванияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поАлфавитуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вПорядкеВозрастанияToolStripMenuItem1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private Clauses.CustomButton customButton5;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whereFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whiterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
    }
}