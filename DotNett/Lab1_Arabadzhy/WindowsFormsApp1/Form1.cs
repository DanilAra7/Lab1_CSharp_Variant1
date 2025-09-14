using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab1_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение введённых данных
                double startX = Convert.ToDouble(textBox1.Text);
                double endX = Convert.ToDouble(textBox2.Text);
                double step = Convert.ToDouble(textBox3.Text);

                Calculations calc = new Calculations();
                dataGridView1.Rows.Clear();
                chart1.Series.Clear();
                chart1.Series.Add("f1");
                chart1.Series.Add("f2");
                chart1.Series.Add("f3");
                chart1.Series["f1"].ChartType = SeriesChartType.Line;
                chart1.Series["f2"].ChartType = SeriesChartType.Line;
                chart1.Series["f3"].ChartType = SeriesChartType.Line;

                // Табуляция и вывод
                for (double x = startX; x <= endX; x += step)
                {
                    double y1 = calc.CalculateF1(x);
                    double y2 = calc.CalculateF2(x);
                    double y3 = calc.CalculateF3(x);

                    dataGridView1.Rows.Add(x, y1, y2, y3);
                    chart1.Series["f1"].Points.AddXY(x, y1);
                    chart1.Series["f2"].Points.AddXY(x, y2);
                    chart1.Series["f3"].Points.AddXY(x, y3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}