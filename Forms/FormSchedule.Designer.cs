
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.рассписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оформитьЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.билетНаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказНаПеревозкуГрузаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассписаниеToolStripMenuItem,
            this.оформитьЗаказToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // рассписаниеToolStripMenuItem
            // 
            this.рассписаниеToolStripMenuItem.Name = "рассписаниеToolStripMenuItem";
            this.рассписаниеToolStripMenuItem.Size = new System.Drawing.Size(165, 20);
            this.рассписаниеToolStripMenuItem.Text = "Посмотреть рассписание";
            this.рассписаниеToolStripMenuItem.Click += new System.EventHandler(this.рассписаниеToolStripMenuItem_Click);
            // 
            // оформитьЗаказToolStripMenuItem
            // 
            this.оформитьЗаказToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.билетНаToolStripMenuItem,
            this.заказНаПеревозкуГрузаToolStripMenuItem});
            this.оформитьЗаказToolStripMenuItem.Name = "оформитьЗаказToolStripMenuItem";
            this.оформитьЗаказToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.оформитьЗаказToolStripMenuItem.Text = "Услуги";
            // 
            // билетНаToolStripMenuItem
            // 
            this.билетНаToolStripMenuItem.Name = "билетНаToolStripMenuItem";
            this.билетНаToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.билетНаToolStripMenuItem.Text = "билет на поезд";
            this.билетНаToolStripMenuItem.Click += new System.EventHandler(this.билетНаToolStripMenuItem_Click);
            // 
            // заказНаПеревозкуГрузаToolStripMenuItem
            // 
            this.заказНаПеревозкуГрузаToolStripMenuItem.Name = "заказНаПеревозкуГрузаToolStripMenuItem";
            this.заказНаПеревозкуГрузаToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.заказНаПеревозкуГрузаToolStripMenuItem.Text = "Заказ на перевозку груза";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 423);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(715, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 54);
            this.button4.TabIndex = 10;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(715, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 54);
            this.button3.TabIndex = 9;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(715, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSchedule";
            this.Text = "FormSchedule";
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            this.InputLanguageChanging += new System.Windows.Forms.InputLanguageChangingEventHandler(this.FormSchedule_InputLanguageChanging);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem рассписаниеToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem оформитьЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem билетНаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказНаПеревозкуГрузаToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}