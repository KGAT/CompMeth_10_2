namespace CompMethodsTask10_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.integr_step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_1_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_2_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_doub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deltaV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_corr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Up_step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Down_step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Уравнение малых затухающих колебаний \r\nс затуханием пропорционально квадрату скор" +
    "ости\r\n\r\nu\'\' + a*(u\')^2 + b*u = 0\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Начальное условие:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "u(0) = ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Коэфф. затухания:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "a = ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(41, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Собств. частота системы:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "b = ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(53, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(41, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Начальный шаг:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "h = ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(52, 218);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(42, 20);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "0,01";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Контроль ЛП:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "ε =";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(53, 260);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(41, 20);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "0,0001";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 26);
            this.label12.TabIndex = 16;
            this.label12.Text = "Контроль выхода\r\nна границу:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "k =";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(53, 315);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(41, 20);
            this.textBox6.TabIndex = 18;
            this.textBox6.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 338);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 26);
            this.label14.TabIndex = 19;
            this.label14.Text = "Максимальное\r\nколичество шагов:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 373);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "N = ";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(52, 370);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(42, 20);
            this.textBox7.TabIndex = 21;
            this.textBox7.Text = "100";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 22;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 40);
            this.button3.TabIndex = 24;
            this.button3.Text = "Сброс графика";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(331, 12);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(478, 297);
            this.cartesianChart1.TabIndex = 25;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.integr_step,
            this.x_i,
            this.v_1_i,
            this.v_2_i,
            this.v_doub,
            this.deltaV,
            this.v_result,
            this.S,
            this.e,
            this.v_corr,
            this.Up_step,
            this.Down_step});
            this.dataGridView1.Location = new System.Drawing.Point(15, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 211);
            this.dataGridView1.TabIndex = 26;
            // 
            // number
            // 
            this.number.HeaderText = "№";
            this.number.Name = "number";
            // 
            // integr_step
            // 
            this.integr_step.HeaderText = "h_i-1";
            this.integr_step.Name = "integr_step";
            // 
            // x_i
            // 
            this.x_i.HeaderText = "x_i";
            this.x_i.Name = "x_i";
            // 
            // v_1_i
            // 
            this.v_1_i.HeaderText = "v_1_i";
            this.v_1_i.Name = "v_1_i";
            // 
            // v_2_i
            // 
            this.v_2_i.HeaderText = "v_2_i";
            this.v_2_i.Name = "v_2_i";
            // 
            // v_doub
            // 
            this.v_doub.HeaderText = "v_удв";
            this.v_doub.Name = "v_doub";
            // 
            // deltaV
            // 
            this.deltaV.HeaderText = "v_i - v_удв";
            this.deltaV.Name = "deltaV";
            // 
            // v_result
            // 
            this.v_result.HeaderText = "v_итог";
            this.v_result.Name = "v_result";
            // 
            // S
            // 
            this.S.HeaderText = "S";
            this.S.Name = "S";
            // 
            // e
            // 
            this.e.HeaderText = "e";
            this.e.Name = "e";
            // 
            // v_corr
            // 
            this.v_corr.HeaderText = "v_corr";
            this.v_corr.Name = "v_corr";
            // 
            // Up_step
            // 
            this.Up_step.HeaderText = "Up_step";
            this.Up_step.Name = "Up_step";
            // 
            // Down_step
            // 
            this.Down_step.HeaderText = "Down_step";
            this.Down_step.Name = "Down_step";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(127, 92);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(42, 20);
            this.textBox8.TabIndex = 27;
            this.textBox8.Text = "1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(175, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 24);
            this.label16.TabIndex = 28;
            this.label16.Text = ")";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(111, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 24);
            this.label17.TabIndex = 29;
            this.label17.Text = ",";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(48, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 24);
            this.label18.TabIndex = 30;
            this.label18.Text = "(";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Фазовый портрет",
            "X и V1",
            "X и V2"});
            this.comboBox1.Location = new System.Drawing.Point(519, 335);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(150, 283);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Правая граница:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(159, 318);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "X* = ";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(195, 315);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(42, 20);
            this.textBox9.TabIndex = 34;
            this.textBox9.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 631);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Лаб. работа №2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn integr_step;
        private System.Windows.Forms.DataGridViewTextBoxColumn x_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_1_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_2_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_doub;
        private System.Windows.Forms.DataGridViewTextBoxColumn deltaV;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.DataGridViewTextBoxColumn e;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_corr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Up_step;
        private System.Windows.Forms.DataGridViewTextBoxColumn Down_step;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox9;
    }
}

