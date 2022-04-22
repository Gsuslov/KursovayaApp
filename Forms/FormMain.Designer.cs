
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
            this.входОтИмениАдминистратораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьЧтотоРандомноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.customButton6 = new WindowsFormsApp2.Clauses.CustomButton();
            this.customButton5 = new WindowsFormsApp2.Clauses.CustomButton();
            this.customButton4 = new WindowsFormsApp2.Clauses.CustomButton();
            this.customButton3 = new WindowsFormsApp2.Clauses.CustomButton();
            this.customButton2 = new WindowsFormsApp2.Clauses.CustomButton();
            this.customButton1 = new WindowsFormsApp2.Clauses.CustomButton();
            this.масштабToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полноэкранныйРежимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дефолтныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочнаяИнформацияToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.входОтИмениАдминистратораToolStripMenuItem,
            this.показатьЧтотоРандомноеToolStripMenuItem,
            this.масштабToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
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
            this.справочнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(166, 20);
            this.справочнаяИнформацияToolStripMenuItem.Text = "Справочная информация";
            // 
            // поездаToolStripMenuItem
            // 
            this.поездаToolStripMenuItem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.поездаToolStripMenuItem.Name = "поездаToolStripMenuItem";
            this.поездаToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.поездаToolStripMenuItem.Text = "Поезда";
            this.поездаToolStripMenuItem.Click += new System.EventHandler(this.поездаToolStripMenuItem_Click);
            // 
            // рассписаниеToolStripMenuItem
            // 
            this.рассписаниеToolStripMenuItem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.рассписаниеToolStripMenuItem.Name = "рассписаниеToolStripMenuItem";
            this.рассписаниеToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
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
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // сведеньяОбАвтореToolStripMenuItem
            // 
            this.сведеньяОбАвтореToolStripMenuItem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.сведеньяОбАвтореToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.сведеньяОбАвтореToolStripMenuItem.Name = "сведеньяОбАвтореToolStripMenuItem";
            this.сведеньяОбАвтореToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.сведеньяОбАвтореToolStripMenuItem.Text = "Сведения о программе";
            this.сведеньяОбАвтореToolStripMenuItem.Click += new System.EventHandler(this.сведеньяОбАвтореToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.просмотрToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.просмотрToolStripMenuItem.Text = "Сведения об авторе";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
            // 
            // входОтИмениАдминистратораToolStripMenuItem
            // 
            this.входОтИмениАдминистратораToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("входОтИмениАдминистратораToolStripMenuItem.BackgroundImage")));
            this.входОтИмениАдминистратораToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.входОтИмениАдминистратораToolStripMenuItem.Name = "входОтИмениАдминистратораToolStripMenuItem";
            this.входОтИмениАдминистратораToolStripMenuItem.Size = new System.Drawing.Size(202, 20);
            this.входОтИмениАдминистратораToolStripMenuItem.Text = "Вход от имени администратора";
            // 
            // показатьЧтотоРандомноеToolStripMenuItem
            // 
            this.показатьЧтотоРандомноеToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.показатьЧтотоРандомноеToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("показатьЧтотоРандомноеToolStripMenuItem.BackgroundImage")));
            this.показатьЧтотоРандомноеToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.показатьЧтотоРандомноеToolStripMenuItem.Name = "показатьЧтотоРандомноеToolStripMenuItem";
            this.показатьЧтотоРандомноеToolStripMenuItem.Size = new System.Drawing.Size(173, 20);
            this.показатьЧтотоРандомноеToolStripMenuItem.Text = "Показать чтото рандомное";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // listView1
            // 
            this.listView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView1.BackgroundImage")));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-11, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(232, 497);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.customButton6);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(865, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 497);
            this.panel1.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Данное приложение",
            "направлено на ",
            "просмотр справочной",
            "информации по теме",
            "Ж/Д перевозки"});
            this.listBox1.Location = new System.Drawing.Point(3, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 0;
            // 
            // customButton6
            // 
            this.customButton6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customButton6.BackgroundImage")));
            this.customButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customButton6.FlatAppearance.BorderSize = 0;
            this.customButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton6.ForeColor = System.Drawing.Color.Black;
            this.customButton6.Location = new System.Drawing.Point(18, 391);
            this.customButton6.Name = "customButton6";
            this.customButton6.Size = new System.Drawing.Size(88, 80);
            this.customButton6.TabIndex = 1;
            this.customButton6.UseVisualStyleBackColor = false;
            this.customButton6.Click += new System.EventHandler(this.customButton6_Click);
            // 
            // customButton5
            // 
            this.customButton5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton5.FlatAppearance.BorderSize = 0;
            this.customButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton5.ForeColor = System.Drawing.Color.White;
            this.customButton5.Location = new System.Drawing.Point(899, 0);
            this.customButton5.Name = "customButton5";
            this.customButton5.Size = new System.Drawing.Size(93, 24);
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
            this.customButton4.Location = new System.Drawing.Point(0, 307);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(221, 50);
            this.customButton4.TabIndex = 10;
            this.customButton4.Text = "Редактирование информации";
            this.customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(0, 227);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(221, 50);
            this.customButton3.TabIndex = 9;
            this.customButton3.Text = "Оформить заказ";
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(0, 145);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(221, 50);
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
            this.customButton1.Location = new System.Drawing.Point(0, 61);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(221, 50);
            this.customButton1.TabIndex = 7;
            this.customButton1.Text = "Расписание ";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // масштабToolStripMenuItem
            // 
            this.масштабToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.полноэкранныйРежимToolStripMenuItem,
            this.дефолтныйToolStripMenuItem});
            this.масштабToolStripMenuItem.Name = "масштабToolStripMenuItem";
            this.масштабToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.масштабToolStripMenuItem.Text = "Масштаб";
            // 
            // полноэкранныйРежимToolStripMenuItem
            // 
            this.полноэкранныйРежимToolStripMenuItem.Name = "полноэкранныйРежимToolStripMenuItem";
            this.полноэкранныйРежимToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.полноэкранныйРежимToolStripMenuItem.Text = "Полноэкранный режим";
            // 
            // дефолтныйToolStripMenuItem
            // 
            this.дефолтныйToolStripMenuItem.Name = "дефолтныйToolStripMenuItem";
            this.дефолтныйToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.дефолтныйToolStripMenuItem.Text = "Дефолтный";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(992, 521);
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
        private System.Windows.Forms.ToolStripMenuItem входОтИмениАдминистратораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.ToolStripMenuItem показатьЧтотоРандомноеToolStripMenuItem;
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
    }
}