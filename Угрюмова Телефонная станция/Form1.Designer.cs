namespace Угрюмова_Телефонная_станция
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose (bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.FIO_txt = new System.Windows.Forms.TextBox();
            this.Adress_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Add_btn1 = new System.Windows.Forms.Button();
            this.primechanie_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UpDate_btn1 = new System.Windows.Forms.Button();
            this.Delete_btn1 = new System.Windows.Forms.Button();
            this.KodRaiona_txt = new System.Windows.Forms.TextBox();
            this.CountNumber_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Add_btn2 = new System.Windows.Forms.Button();
            this.Update_btn2 = new System.Windows.Forms.Button();
            this.Delete_btn2 = new System.Windows.Forms.Button();
            this.Add_btn3 = new System.Windows.Forms.Button();
            this.UpDate_btn3 = new System.Windows.Forms.Button();
            this.Delete_btn3 = new System.Windows.Forms.Button();
            this.NumberPhone_txt = new System.Windows.Forms.TextBox();
            this.Abonent_txt = new System.Windows.Forms.TextBox();
            this.ATS_txt = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Delete_btn1);
            this.tabPage1.Controls.Add(this.UpDate_btn1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.primechanie_txt);
            this.tabPage1.Controls.Add(this.Add_btn1);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Adress_txt);
            this.tabPage1.Controls.Add(this.FIO_txt);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(442, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Абоненты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Delete_btn2);
            this.tabPage2.Controls.Add(this.Update_btn2);
            this.tabPage2.Controls.Add(this.Add_btn2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.CountNumber_txt);
            this.tabPage2.Controls.Add(this.KodRaiona_txt);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(442, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "АТС";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 206);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(432, 191);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.checkBox2);
            this.tabPage3.Controls.Add(this.ATS_txt);
            this.tabPage3.Controls.Add(this.Abonent_txt);
            this.tabPage3.Controls.Add(this.NumberPhone_txt);
            this.tabPage3.Controls.Add(this.Delete_btn3);
            this.tabPage3.Controls.Add(this.UpDate_btn3);
            this.tabPage3.Controls.Add(this.Add_btn3);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(442, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Номера";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1, 207);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(438, 193);
            this.dataGridView3.TabIndex = 0;
            // 
            // FIO_txt
            // 
            this.FIO_txt.Location = new System.Drawing.Point(23, 27);
            this.FIO_txt.Name = "FIO_txt";
            this.FIO_txt.Size = new System.Drawing.Size(183, 20);
            this.FIO_txt.TabIndex = 1;
            // 
            // Adress_txt
            // 
            this.Adress_txt.Location = new System.Drawing.Point(23, 68);
            this.Adress_txt.Name = "Adress_txt";
            this.Adress_txt.Size = new System.Drawing.Size(183, 20);
            this.Adress_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Блокиатор";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "есть";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Add_btn1
            // 
            this.Add_btn1.Location = new System.Drawing.Point(23, 174);
            this.Add_btn1.Name = "Add_btn1";
            this.Add_btn1.Size = new System.Drawing.Size(98, 23);
            this.Add_btn1.TabIndex = 7;
            this.Add_btn1.Text = "добавить";
            this.Add_btn1.UseVisualStyleBackColor = true;
            this.Add_btn1.Click += new System.EventHandler(this.Add_btn1_Click);
            // 
            // primechanie_txt
            // 
            this.primechanie_txt.Location = new System.Drawing.Point(123, 121);
            this.primechanie_txt.Name = "primechanie_txt";
            this.primechanie_txt.Size = new System.Drawing.Size(236, 20);
            this.primechanie_txt.TabIndex = 8;
            this.primechanie_txt.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "примечание";
            this.label4.Visible = false;
            // 
            // UpDate_btn1
            // 
            this.UpDate_btn1.Location = new System.Drawing.Point(143, 174);
            this.UpDate_btn1.Name = "UpDate_btn1";
            this.UpDate_btn1.Size = new System.Drawing.Size(107, 23);
            this.UpDate_btn1.TabIndex = 10;
            this.UpDate_btn1.Text = "обновить данные";
            this.UpDate_btn1.UseVisualStyleBackColor = true;
            // 
            // Delete_btn1
            // 
            this.Delete_btn1.Location = new System.Drawing.Point(276, 174);
            this.Delete_btn1.Name = "Delete_btn1";
            this.Delete_btn1.Size = new System.Drawing.Size(99, 23);
            this.Delete_btn1.TabIndex = 11;
            this.Delete_btn1.Text = "удалить";
            this.Delete_btn1.UseVisualStyleBackColor = true;
            // 
            // KodRaiona_txt
            // 
            this.KodRaiona_txt.Location = new System.Drawing.Point(24, 33);
            this.KodRaiona_txt.Name = "KodRaiona_txt";
            this.KodRaiona_txt.Size = new System.Drawing.Size(152, 20);
            this.KodRaiona_txt.TabIndex = 1;
            // 
            // CountNumber_txt
            // 
            this.CountNumber_txt.Location = new System.Drawing.Point(24, 76);
            this.CountNumber_txt.Name = "CountNumber_txt";
            this.CountNumber_txt.Size = new System.Drawing.Size(152, 20);
            this.CountNumber_txt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "код района";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "количество номеров";
            // 
            // Add_btn2
            // 
            this.Add_btn2.Location = new System.Drawing.Point(24, 167);
            this.Add_btn2.Name = "Add_btn2";
            this.Add_btn2.Size = new System.Drawing.Size(98, 23);
            this.Add_btn2.TabIndex = 8;
            this.Add_btn2.Text = "добавить";
            this.Add_btn2.UseVisualStyleBackColor = true;
            this.Add_btn2.Click += new System.EventHandler(this.Add_btn2_Click);
            // 
            // Update_btn2
            // 
            this.Update_btn2.Location = new System.Drawing.Point(148, 167);
            this.Update_btn2.Name = "Update_btn2";
            this.Update_btn2.Size = new System.Drawing.Size(107, 23);
            this.Update_btn2.TabIndex = 11;
            this.Update_btn2.Text = "обновить данные";
            this.Update_btn2.UseVisualStyleBackColor = true;
            // 
            // Delete_btn2
            // 
            this.Delete_btn2.Location = new System.Drawing.Point(294, 167);
            this.Delete_btn2.Name = "Delete_btn2";
            this.Delete_btn2.Size = new System.Drawing.Size(99, 23);
            this.Delete_btn2.TabIndex = 12;
            this.Delete_btn2.Text = "удалить";
            this.Delete_btn2.UseVisualStyleBackColor = true;
            // 
            // Add_btn3
            // 
            this.Add_btn3.Location = new System.Drawing.Point(24, 169);
            this.Add_btn3.Name = "Add_btn3";
            this.Add_btn3.Size = new System.Drawing.Size(98, 23);
            this.Add_btn3.TabIndex = 8;
            this.Add_btn3.Text = "добавить";
            this.Add_btn3.UseVisualStyleBackColor = true;
            this.Add_btn3.Click += new System.EventHandler(this.Add_btn3_Click);
            // 
            // UpDate_btn3
            // 
            this.UpDate_btn3.Location = new System.Drawing.Point(149, 169);
            this.UpDate_btn3.Name = "UpDate_btn3";
            this.UpDate_btn3.Size = new System.Drawing.Size(107, 23);
            this.UpDate_btn3.TabIndex = 12;
            this.UpDate_btn3.Text = "обновить данные";
            this.UpDate_btn3.UseVisualStyleBackColor = true;
            // 
            // Delete_btn3
            // 
            this.Delete_btn3.Location = new System.Drawing.Point(297, 169);
            this.Delete_btn3.Name = "Delete_btn3";
            this.Delete_btn3.Size = new System.Drawing.Size(99, 23);
            this.Delete_btn3.TabIndex = 13;
            this.Delete_btn3.Text = "удалить";
            this.Delete_btn3.UseVisualStyleBackColor = true;
            this.Delete_btn3.Click += new System.EventHandler(this.Delete_btn3_Click);
            // 
            // NumberPhone_txt
            // 
            this.NumberPhone_txt.Location = new System.Drawing.Point(24, 35);
            this.NumberPhone_txt.Name = "NumberPhone_txt";
            this.NumberPhone_txt.Size = new System.Drawing.Size(100, 20);
            this.NumberPhone_txt.TabIndex = 14;
            // 
            // Abonent_txt
            // 
            this.Abonent_txt.Location = new System.Drawing.Point(24, 80);
            this.Abonent_txt.Name = "Abonent_txt";
            this.Abonent_txt.Size = new System.Drawing.Size(100, 20);
            this.Abonent_txt.TabIndex = 15;
            // 
            // ATS_txt
            // 
            this.ATS_txt.Location = new System.Drawing.Point(24, 128);
            this.ATS_txt.Name = "ATS_txt";
            this.ATS_txt.Size = new System.Drawing.Size(100, 20);
            this.ATS_txt.TabIndex = 16;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(189, 35);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "номер телефона";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "абонент";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "АТС";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(189, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "задолжность";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "дата установки";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button UpDate_btn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox primechanie_txt;
        private System.Windows.Forms.Button Add_btn1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Adress_txt;
        private System.Windows.Forms.TextBox FIO_txt;
        private System.Windows.Forms.Button Delete_btn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CountNumber_txt;
        private System.Windows.Forms.TextBox KodRaiona_txt;
        private System.Windows.Forms.Button Delete_btn2;
        private System.Windows.Forms.Button Update_btn2;
        private System.Windows.Forms.Button Add_btn2;
        private System.Windows.Forms.Button Delete_btn3;
        private System.Windows.Forms.Button UpDate_btn3;
        private System.Windows.Forms.Button Add_btn3;
        private System.Windows.Forms.TextBox ATS_txt;
        private System.Windows.Forms.TextBox Abonent_txt;
        private System.Windows.Forms.TextBox NumberPhone_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

