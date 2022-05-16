﻿
namespace WindowsFormsApp2
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поездаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сведеньяОбАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.масштабToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полноэкранныйРежимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дефолтныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.customButton8 = new WindowsFormsApp2.Clauses.CustomButton();
            this.customButton7 = new WindowsFormsApp2.Clauses.CustomButton();
            this.customButton6 = new WindowsFormsApp2.Clauses.CustomButton();
            this.customButton5 = new WindowsFormsApp2.Clauses.CustomButton();
            this.customButton4 = new WindowsFormsApp2.Clauses.CustomButton();
            this.customButton3 = new WindowsFormsApp2.Clauses.CustomButton();
            this.customButton2 = new WindowsFormsApp2.Clauses.CustomButton();
            this.customButton1 = new WindowsFormsApp2.Clauses.CustomButton();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.логиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочнаяИнформацияToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.масштабToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1323, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочнаяИнформацияToolStripMenuItem
            // 
            this.справочнаяИнформацияToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("справочнаяИнформацияToolStripMenuItem.BackgroundImage")));
            this.справочнаяИнформацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поездаToolStripMenuItem,
            this.рассписаниеToolStripMenuItem});
            this.справочнаяИнформацияToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.справочнаяИнформацияToolStripMenuItem.Name = "справочнаяИнформацияToolStripMenuItem";
            this.справочнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.справочнаяИнформацияToolStripMenuItem.Text = "Справочная информация";
            // 
            // поездаToolStripMenuItem
            // 
            this.поездаToolStripMenuItem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.поездаToolStripMenuItem.Name = "поездаToolStripMenuItem";
            this.поездаToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.поездаToolStripMenuItem.Text = "Поезда";
            this.поездаToolStripMenuItem.Click += new System.EventHandler(this.поездаToolStripMenuItem_Click);
            // 
            // рассписаниеToolStripMenuItem
            // 
            this.рассписаниеToolStripMenuItem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.рассписаниеToolStripMenuItem.Name = "рассписаниеToolStripMenuItem";
            this.рассписаниеToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.рассписаниеToolStripMenuItem.Text = "Расписание";
            this.рассписаниеToolStripMenuItem.Click += new System.EventHandler(this.рассписаниеToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.справкаToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("справкаToolStripMenuItem.BackgroundImage")));
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сведеньяОбАвтореToolStripMenuItem,
            this.просмотрToolStripMenuItem});
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // сведеньяОбАвтореToolStripMenuItem
            // 
            this.сведеньяОбАвтореToolStripMenuItem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.сведеньяОбАвтореToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.сведеньяОбАвтореToolStripMenuItem.Name = "сведеньяОбАвтореToolStripMenuItem";
            this.сведеньяОбАвтореToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.сведеньяОбАвтореToolStripMenuItem.Text = "Сведения о программе";
            this.сведеньяОбАвтореToolStripMenuItem.Click += new System.EventHandler(this.сведеньяОбАвтореToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.просмотрToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.просмотрToolStripMenuItem.Text = "Сведения об авторе";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
            // 
            // масштабToolStripMenuItem
            // 
            this.масштабToolStripMenuItem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.масштабToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.полноэкранныйРежимToolStripMenuItem,
            this.дефолтныйToolStripMenuItem});
            this.масштабToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.масштабToolStripMenuItem.Name = "масштабToolStripMenuItem";
            this.масштабToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.масштабToolStripMenuItem.Text = "Масштаб";
            this.масштабToolStripMenuItem.Click += new System.EventHandler(this.масштабToolStripMenuItem_Click);
            // 
            // полноэкранныйРежимToolStripMenuItem
            // 
            this.полноэкранныйРежимToolStripMenuItem.Name = "полноэкранныйРежимToolStripMenuItem";
            this.полноэкранныйРежимToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.полноэкранныйРежимToolStripMenuItem.Text = "Полноэкранный режим";
            this.полноэкранныйРежимToolStripMenuItem.Click += new System.EventHandler(this.полноэкранныйРежимToolStripMenuItem_Click);
            // 
            // дефолтныйToolStripMenuItem
            // 
            this.дефолтныйToolStripMenuItem.Name = "дефолтныйToolStripMenuItem";
            this.дефолтныйToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.дефолтныйToolStripMenuItem.Text = "Дефолтный";
            this.дефолтныйToolStripMenuItem.Click += new System.EventHandler(this.дефолтныйToolStripMenuItem_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView1.BackgroundImage")));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-15, 33);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(309, 641);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.customButton6);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(1153, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 641);
            this.panel1.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Данное приложение",
            "направлено на ",
            "просмотр справочной",
            "информации по теме",
            "Ж/Д перевозки"});
            this.listBox1.Location = new System.Drawing.Point(4, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 196);
            this.listBox1.TabIndex = 0;
            // 
            // customButton8
            // 
            this.customButton8.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton8.FlatAppearance.BorderSize = 0;
            this.customButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton8.ForeColor = System.Drawing.Color.White;
            this.customButton8.Location = new System.Drawing.Point(0, 583);
            this.customButton8.Margin = new System.Windows.Forms.Padding(4);
            this.customButton8.Name = "customButton8";
            this.customButton8.Size = new System.Drawing.Size(295, 62);
            this.customButton8.TabIndex = 14;
            this.customButton8.Text = "Список билетов";
            this.customButton8.UseVisualStyleBackColor = false;
            this.customButton8.Click += new System.EventHandler(this.customButton8_Click);
            // 
            // customButton7
            // 
            this.customButton7.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton7.FlatAppearance.BorderSize = 0;
            this.customButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton7.ForeColor = System.Drawing.Color.White;
            this.customButton7.Location = new System.Drawing.Point(0, 477);
            this.customButton7.Margin = new System.Windows.Forms.Padding(4);
            this.customButton7.Name = "customButton7";
            this.customButton7.Size = new System.Drawing.Size(295, 62);
            this.customButton7.TabIndex = 13;
            this.customButton7.Text = "Список грузов";
            this.customButton7.UseVisualStyleBackColor = false;
            this.customButton7.Click += new System.EventHandler(this.customButton7_Click);
            // 
            // customButton6
            // 
            this.customButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customButton6.BackgroundImage")));
            this.customButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customButton6.FlatAppearance.BorderSize = 0;
            this.customButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton6.ForeColor = System.Drawing.Color.Black;
            this.customButton6.Location = new System.Drawing.Point(24, 510);
            this.customButton6.Margin = new System.Windows.Forms.Padding(4);
            this.customButton6.Name = "customButton6";
            this.customButton6.Size = new System.Drawing.Size(117, 98);
            this.customButton6.TabIndex = 1;
            this.customButton6.UseVisualStyleBackColor = false;
            this.customButton6.Click += new System.EventHandler(this.customButton6_Click);
            // 
            // customButton5
            // 
            this.customButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton5.FlatAppearance.BorderSize = 0;
            this.customButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton5.ForeColor = System.Drawing.Color.White;
            this.customButton5.Location = new System.Drawing.Point(1199, 0);
            this.customButton5.Margin = new System.Windows.Forms.Padding(4);
            this.customButton5.Name = "customButton5";
            this.customButton5.Size = new System.Drawing.Size(124, 30);
            this.customButton5.TabIndex = 11;
            this.customButton5.Text = "Выход";
            this.customButton5.UseVisualStyleBackColor = false;
            this.customButton5.Click += new System.EventHandler(this.customButton5_Click);
            // 
            // customButton4
            // 
            this.customButton4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Location = new System.Drawing.Point(0, 378);
            this.customButton4.Margin = new System.Windows.Forms.Padding(4);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(295, 62);
            this.customButton4.TabIndex = 10;
            this.customButton4.Text = "Список пассажиров";
            this.customButton4.UseVisualStyleBackColor = false;
            this.customButton4.Click += new System.EventHandler(this.customButton4_Click);
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(0, 279);
            this.customButton3.Margin = new System.Windows.Forms.Padding(4);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(295, 62);
            this.customButton3.TabIndex = 9;
            this.customButton3.Text = "Список заказчиков";
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(0, 178);
            this.customButton2.Margin = new System.Windows.Forms.Padding(4);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(295, 62);
            this.customButton2.TabIndex = 8;
            this.customButton2.Text = "Список поездов\r\n";
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton1
            // 
            this.customButton1.AllowDrop = true;
            this.customButton1.AutoSize = true;
            this.customButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(0, 75);
            this.customButton1.Margin = new System.Windows.Forms.Padding(4);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(295, 62);
            this.customButton1.TabIndex = 7;
            this.customButton1.Text = "Расписание ";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.логиToolStripMenuItem});
            this.настройкиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // логиToolStripMenuItem
            // 
            this.логиToolStripMenuItem.Name = "логиToolStripMenuItem";
            this.логиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.логиToolStripMenuItem.Text = "Логи";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1323, 670);
            this.Controls.Add(this.customButton8);
            this.Controls.Add(this.customButton7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customButton5);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поездаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рассписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сведеньяОбАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.ListView listView1;
        private Clauses.CustomButton customButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private Clauses.CustomButton customButton5;
        private Clauses.CustomButton customButton4;
        private Clauses.CustomButton customButton3;
        private Clauses.CustomButton customButton2;
        private Clauses.CustomButton customButton6;
        private System.Windows.Forms.ToolStripMenuItem масштабToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полноэкранныйРежимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дефолтныйToolStripMenuItem;
        private Clauses.CustomButton customButton7;
        private Clauses.CustomButton customButton8;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem логиToolStripMenuItem;
    }
}