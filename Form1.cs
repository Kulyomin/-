using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;


namespace ET200
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Timer timer = new Timer();
        DateTime startTime;
        double full_time = 1;
        double current_C = 0;
        bool kal_flag = false;
        double k_kal_old = 1;
        double k_kal = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            // Добавляем названия столбцов в DataGridView
            dataGridView1.Columns.Add("Дата", "Дата");
            dataGridView1.Columns.Add("Концентрация", "Концентрация");
            dataGridView1.Columns.Add("t_Кюветы", "t_Кюветы");
            dataGridView1.Columns.Add("Разряжение", "Разряжение");

            // Убедитесь, что путь к изображению указан правильно
            string imagePath = "C:\\Users\\Kulyomin\\Desktop\\ET200\\Logo_Etek.jpg";

            // Загрузка изображения в PictureBox
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        /*
         * Функция инициализации таймера
         */
        private void InitializeTimer()
        {
            timer.Interval = 1000; // 1 секунда
            timer.Tick += Timer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_save.Enabled = false;
            btn_kal.Enabled = false;
        }

        /*
         * Функция работы таймера, генерации значений параметров и внесения их в dataGridView
         */
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            double elapsedTimeMinutes = elapsedTime.TotalMinutes;

            if (elapsedTimeMinutes <= full_time)
            {
                double concentration = PrintConcentration(elapsedTimeMinutes);
                double t_kuv = random.Next(74, 76);
                double pressure = random.Next(16, 24);
                current_C = concentration;
                dataGridView1.Rows.Add(DateTime.Now, Math.Round(concentration), t_kuv, pressure);
                Trends();
            }
            else
            {
                if (kal_flag == true)
                {
                    btn_kal.Enabled = true;
                    label_kal.ForeColor = System.Drawing.Color.Green;
                    k_kal = (k_kal_old * Convert.ToDouble(cBoxBallon.Text)) / current_C;
                    current_C = current_C * k_kal;
                    double concentration_new = current_C;
                    double t_kuv_new = random.Next(74, 76);
                    double pressure_new = random.Next(16, 24);
                    dataGridView1.Rows.Add(DateTime.Now, Math.Round(concentration_new), t_kuv_new, pressure_new);
                    Trends();
                    label_kal.Text = "ДОСТОВЕРНЫ";
                }
                else
                {
                    btn_kal.Enabled = true;
                    double concentration_new = current_C;
                    double t_kuv_new = random.Next(74, 76);
                    double pressure_new = random.Next(16, 24);
                    dataGridView1.Rows.Add(DateTime.Now, Math.Round(concentration_new), t_kuv_new, pressure_new);
                    Trends();
                }
            }
        }

        /*
         * Функция вывода концентрации.
         */
        private double PrintConcentration(double elapsedTimeMinutes)
        {
            double C = Convert.ToDouble(cBoxBallon.Text);
            double finalConcentration = ((elapsedTimeMinutes / full_time) * C) * 0.9;
            return finalConcentration;
        }

        /*
         * Функция обработки кнопки "ВКЛЮЧИТЬ".
         */
        private void btn_on_Click(object sender, EventArgs e)
        {
            label_on_off.Text = "ВКЛЮЧЕН";
            label_on_off.ForeColor = System.Drawing.Color.Green;
        }

        /*
         * Функция обработки кнопки "ВЫКЛЮЧИТЬ".
         */
        private void btn_off_Click(object sender, EventArgs e)
        {
            label_on_off.Text = "ВЫКЛЮЧЕН";
            label_on_off.ForeColor = System.Drawing.Color.Red;
            MessageBox.Show("Прибор выключен", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /*
         * Функция вывода данных с dataGridView на график.
         */
        private void Trends()
        {
            chart1.Series.Clear();
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                Series series = new Series(dataGridView1.Columns[i].HeaderText);
                series.ChartType = SeriesChartType.Line;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    double value;
                    if (row.Cells[i].Value != null && double.TryParse(row.Cells[i].Value.ToString(), out value))
                    {
                        series.Points.AddY(value);
                    }
                }
                chart1.Series.Add(series);
            }
        }

        /*
         * Функция обработки кнопки "НАЧАТЬ".
         */
        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (label_on_off.Text == "ВКЛЮЧЕН")
                {
                    if (cBoxBallon.Text != string.Empty)
                    {
                        dataGridView1.Rows.Clear();
                        // Начинаем отсчет времени и запускаем таймер для генерации данных
                        startTime = DateTime.Now;
                        timer.Start();
                        label_work.Text = "В ПРОЦЕССЕ ИЗМЕРЕНИЯ";
                        btn_start.Enabled = false;
                        cBoxBallon.Enabled = false;
                        btn_on.Enabled = false;
                        btn_off.Enabled = false;
                        btn_kal.Enabled = false;
                        btn_save.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали баллон!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Прибор выключен!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * Функция обработки кнопки "ОСТАНОВИТЬ".
         */
        private void btn_stop_Click(object sender, EventArgs e)
        {
            // Остановка таймера
            timer.Stop();
            btn_start.Enabled = true;
            cBoxBallon.Enabled = true;
            btn_on.Enabled = true;
            btn_off.Enabled = true;
            btn_save.Enabled = true;
            btn_kal.Enabled = false;
            label_datetime.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            label_work.Text = "ЗАВЕРШИЛ РАБОТУ";
            if (kal_flag == true)
            {
                label_kal_word.Text = "ПРОВЕДЕНА";
            }
            else
            {
                label_kal_word.Text = "НЕ ТРЕБУЕТСЯ";
            }
            label_t_kuv.Text = "В ПРЕДЕЛАХ НОРМЫ";
            label_pressure.Text = "В ПРЕДЕЛАХ НОРМЫ";
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        /*
         * Функция обработки кнопки "КАЛИБРОВАТЬ".
         */
        private void btn_kal_Click(object sender, EventArgs e)
        {
            if (kal_flag == false)
            {
                kal_flag = true;
            }
        }

        /*
         * Функция обработки кнопки "СОХРАНИТЬ" для данных с dataGridView.
         */
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);
                    // Устанавливаем контекст лицензии
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Data");
                        // Добавление заголовков столбцов
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
                        }
                        // Добавление самих данных
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                // Проверка, не является ли значение ячейки null
                                if (dataGridView1.Rows[i].Cells[j].Value != null)
                                {
                                    worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value.ToString();
                                }
                                else
                                {
                                    worksheet.Cells[i + 2, j + 1].Value = string.Empty; // Если значение null, записываем пустую строку
                                }
                            }
                        }
                        package.Save();
                    }
                    MessageBox.Show("Данные успешно сохранены в файл Excel.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Нет данных для сохранения.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*
         * Функция обработки кнопки "СОХРАНИТЬ" для отчёта.
         */
        private void btn_save_word_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word files (*.docx)|*.docx|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                // Create a Wordprocessing document.
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    // Add a new main document part.
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                    // Create the document structure and add some text.
                    mainPart.Document = new Document();
                    Body body = new Body();

                    // Add paragraphs with text to the body.
                    body.Append(CreateParagraph($"Дата: {label_datetime.Text}"));
                    body.Append(CreateParagraph("Газоанализатор: завершил работу"));
                    body.Append(CreateParagraph($"Калибровка: {label_kal_word.Text}"));
                    body.Append(CreateParagraph($"Температура кюветы: {label_t_kuv.Text}"));
                    body.Append(CreateParagraph($"Разряжение: {label_pressure.Text}"));

                    mainPart.Document.Append(body);
                    mainPart.Document.Save();
                }
                MessageBox.Show("Данные успешно сохранены в файл Word.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*
         * Функция для создания абзацев в файле docx.
         */
        private Paragraph CreateParagraph(string text)
        {
            Paragraph paragraph = new Paragraph();
            Run run = new Run();
            Text t = new Text(text);
            run.Append(t);
            paragraph.Append(run);
            return paragraph;
        }
    }
}