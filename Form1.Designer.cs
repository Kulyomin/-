namespace ET200
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxBallon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_off = new System.Windows.Forms.Button();
            this.btn_on = new System.Windows.Forms.Button();
            this.label_on_off = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_save = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label_kal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_kal = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_save_word = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label_datetime = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_pressure = new System.Windows.Forms.Label();
            this.label_t_kuv = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_kal_word = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_work = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(676, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Подключение";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(558, 341);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxBallon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(366, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(259, 178);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // cBoxBallon
            // 
            this.cBoxBallon.FormattingEnabled = true;
            this.cBoxBallon.Items.AddRange(new object[] {
            "100",
            "150",
            "200",
            "250",
            "300",
            "350",
            "400",
            "450",
            "500",
            "550",
            "600",
            "650",
            "700",
            "750",
            "800",
            "850",
            "900",
            "950",
            "1000"});
            this.cBoxBallon.Location = new System.Drawing.Point(88, 50);
            this.cBoxBallon.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxBallon.Name = "cBoxBallon";
            this.cBoxBallon.Size = new System.Drawing.Size(92, 21);
            this.cBoxBallon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ВЫБОР БАЛЛОНА";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(272, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "ЕТ-200";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btn_start);
            this.groupBox7.Controls.Add(this.btn_stop);
            this.groupBox7.Location = new System.Drawing.Point(184, 266);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(254, 98);
            this.groupBox7.TabIndex = 24;
            this.groupBox7.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_start.Location = new System.Drawing.Point(12, 17);
            this.btn_start.Margin = new System.Windows.Forms.Padding(2);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(102, 62);
            this.btn_start.TabIndex = 13;
            this.btn_start.Text = "НАЧАТЬ";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_stop.Location = new System.Drawing.Point(140, 16);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(2);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(102, 64);
            this.btn_stop.TabIndex = 14;
            this.btn_stop.Text = "ЗАВЕРШИТЬ";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_off);
            this.groupBox4.Controls.Add(this.btn_on);
            this.groupBox4.Controls.Add(this.label_on_off);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(40, 67);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(243, 173);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btn_off
            // 
            this.btn_off.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_off.Location = new System.Drawing.Point(55, 103);
            this.btn_off.Margin = new System.Windows.Forms.Padding(2);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(130, 47);
            this.btn_off.TabIndex = 8;
            this.btn_off.Text = "ОТКЛЮЧИТЬ";
            this.btn_off.UseVisualStyleBackColor = true;
            this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
            // 
            // btn_on
            // 
            this.btn_on.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_on.Location = new System.Drawing.Point(55, 50);
            this.btn_on.Margin = new System.Windows.Forms.Padding(2);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(130, 48);
            this.btn_on.TabIndex = 7;
            this.btn_on.Text = "ПОДКЛЮЧИТЬ";
            this.btn_on.UseVisualStyleBackColor = true;
            this.btn_on.Click += new System.EventHandler(this.btn_on_Click);
            // 
            // label_on_off
            // 
            this.label_on_off.AutoSize = true;
            this.label_on_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_on_off.ForeColor = System.Drawing.Color.Red;
            this.label_on_off.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_on_off.Location = new System.Drawing.Point(126, 15);
            this.label_on_off.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_on_off.Name = "label_on_off";
            this.label_on_off.Size = new System.Drawing.Size(112, 20);
            this.label_on_off.TabIndex = 6;
            this.label_on_off.Text = "ВЫКЛЮЧЕН";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(4, 15);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 21);
            this.label14.TabIndex = 5;
            this.label14.Text = "СОСТОЯНИЕ:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_save);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(676, 396);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Мониторинг";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_save.Location = new System.Drawing.Point(503, 73);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(102, 63);
            this.btn_save.TabIndex = 28;
            this.btn_save.Text = "СОХРАНИТЬ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(445, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "СОХРАНИТЬ ДАННЫЕ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(436, 394);
            this.dataGridView1.TabIndex = 26;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.chart1);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(676, 396);
            this.tabPage8.TabIndex = 9;
            this.tabPage8.Text = "Тренды";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(2, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(647, 396);
            this.chart1.TabIndex = 28;
            this.chart1.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(676, 396);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Калибровка";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label_kal);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.btn_kal);
            this.groupBox8.Location = new System.Drawing.Point(154, 2);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(348, 323);
            this.groupBox8.TabIndex = 27;
            this.groupBox8.TabStop = false;
            // 
            // label_kal
            // 
            this.label_kal.AutoSize = true;
            this.label_kal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_kal.Location = new System.Drawing.Point(157, 18);
            this.label_kal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_kal.Name = "label_kal";
            this.label_kal.Size = new System.Drawing.Size(182, 24);
            this.label_kal.TabIndex = 6;
            this.label_kal.Text = "НЕДОСТОВЕРНЫ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "ПОКАЗАНИЯ:";
            // 
            // btn_kal
            // 
            this.btn_kal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_kal.Location = new System.Drawing.Point(59, 87);
            this.btn_kal.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kal.Name = "btn_kal";
            this.btn_kal.Size = new System.Drawing.Size(205, 112);
            this.btn_kal.TabIndex = 2;
            this.btn_kal.Text = "КАЛИБРОВАТЬ";
            this.btn_kal.UseVisualStyleBackColor = true;
            this.btn_kal.Click += new System.EventHandler(this.btn_kal_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_save_word);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label_datetime);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label_pressure);
            this.tabPage4.Controls.Add(this.label_t_kuv);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label_kal_word);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label_work);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(676, 396);
            this.tabPage4.TabIndex = 6;
            this.tabPage4.Text = "Отчёты";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_save_word
            // 
            this.btn_save_word.Location = new System.Drawing.Point(275, 306);
            this.btn_save_word.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save_word.Name = "btn_save_word";
            this.btn_save_word.Size = new System.Drawing.Size(114, 56);
            this.btn_save_word.TabIndex = 28;
            this.btn_save_word.Text = "СОХРАНИТЬ";
            this.btn_save_word.UseVisualStyleBackColor = true;
            this.btn_save_word.Click += new System.EventHandler(this.btn_save_word_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(243, 262);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 24);
            this.label16.TabIndex = 27;
            this.label16.Text = "Сохранить отчёт";
            // 
            // label_datetime
            // 
            this.label_datetime.AutoSize = true;
            this.label_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_datetime.Location = new System.Drawing.Point(391, 32);
            this.label_datetime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_datetime.Name = "label_datetime";
            this.label_datetime.Size = new System.Drawing.Size(17, 24);
            this.label_datetime.TabIndex = 26;
            this.label_datetime.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(245, 32);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "Дата:";
            // 
            // label_pressure
            // 
            this.label_pressure.AutoSize = true;
            this.label_pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pressure.Location = new System.Drawing.Point(391, 188);
            this.label_pressure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_pressure.Name = "label_pressure";
            this.label_pressure.Size = new System.Drawing.Size(17, 24);
            this.label_pressure.TabIndex = 24;
            this.label_pressure.Text = "-";
            // 
            // label_t_kuv
            // 
            this.label_t_kuv.AutoSize = true;
            this.label_t_kuv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_t_kuv.Location = new System.Drawing.Point(391, 148);
            this.label_t_kuv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_t_kuv.Name = "label_t_kuv";
            this.label_t_kuv.Size = new System.Drawing.Size(17, 24);
            this.label_t_kuv.TabIndex = 23;
            this.label_t_kuv.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(179, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Разряжение:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(94, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Температура кюветы:";
            // 
            // label_kal_word
            // 
            this.label_kal_word.AutoSize = true;
            this.label_kal_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_kal_word.Location = new System.Drawing.Point(391, 112);
            this.label_kal_word.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_kal_word.Name = "label_kal_word";
            this.label_kal_word.Size = new System.Drawing.Size(17, 24);
            this.label_kal_word.TabIndex = 20;
            this.label_kal_word.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(184, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Калибровка:";
            // 
            // label_work
            // 
            this.label_work.AutoSize = true;
            this.label_work.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_work.Location = new System.Drawing.Point(335, 74);
            this.label_work.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_work.Name = "label_work";
            this.label_work.Size = new System.Drawing.Size(132, 24);
            this.label_work.TabIndex = 18;
            this.label_work.Text = "не работает";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(145, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Газоанализатор:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Controls.Add(this.label17);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(676, 396);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Text = "Техобслуживание";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(172, 266);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(358, 17);
            this.label18.TabIndex = 6;
            this.label18.Text = "УКАЗАННЫМ ВО ВКЛАДКЕ \"ТЕХПОДДЕРЖКА\"";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(136, 235);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(429, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "ОБРАЩАТЬСЯ ПО ПОЧТЕ ИЛИ ПО НОМЕРУ ТЕЛЕФОНА";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(124, 206);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(470, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "ПО ВСЕМ ВОПРОСАМ, СВЯЗАННЫМ С ТЕХОБСЛУЖИВАНИЕМ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(308, 96);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 31);
            this.label11.TabIndex = 3;
            this.label11.Text = "1 РАЗ В МЕСЯЦ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(91, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 31);
            this.label10.TabIndex = 2;
            this.label10.Text = "КАЛИБРОВКА:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(308, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "1 РАЗ В ГОД";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(145, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "ПОВЕРКА:";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label24);
            this.tabPage7.Controls.Add(this.label23);
            this.tabPage7.Controls.Add(this.label22);
            this.tabPage7.Controls.Add(this.label21);
            this.tabPage7.Controls.Add(this.label20);
            this.tabPage7.Controls.Add(this.label19);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(676, 396);
            this.tabPage7.TabIndex = 8;
            this.tabPage7.Text = "Техподдержка";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(245, 123);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(193, 24);
            this.label24.TabIndex = 5;
            this.label24.Text = "ltd.etek@gmail.com";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(8, 123);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(245, 24);
            this.label23.TabIndex = 4;
            this.label23.Text = "ЭЛЕКТРОННАЯ ПОЧТА:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(245, 66);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(183, 24);
            this.label22.TabIndex = 3;
            this.label22.Text = "+7 (499) 181-24-03";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(40, 66);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(211, 24);
            this.label21.TabIndex = 2;
            this.label21.Text = "НОМЕР ТЕЛЕФОНА:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(245, 11);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(390, 20);
            this.label20.TabIndex = 1;
            this.label20.Text = "Москва, ул. Сельскохозяйственная, д. 12 \"А\"";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(4, 11);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(248, 24);
            this.label19.TabIndex = 0;
            this.label19.Text = "АДРЕС ПРЕДПРИЯТИЯ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 434);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ET200";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_off;
        private System.Windows.Forms.Button btn_on;
        private System.Windows.Forms.Label label_on_off;
        private System.Windows.Forms.Label label14;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btn_kal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxBallon;
        private System.Windows.Forms.Label label_kal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_work;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_kal_word;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_pressure;
        private System.Windows.Forms.Label label_t_kuv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_datetime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_save_word;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

