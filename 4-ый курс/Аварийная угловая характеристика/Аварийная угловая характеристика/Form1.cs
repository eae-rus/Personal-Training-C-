using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Аварийная_угловая_характеристика
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // то же самое для другого графика
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
        }

        private double[,] paramets_table;
        private double Pg0;
        private double h;
        private double tk;
        private double Tj;
        private double fn;
        private double fi0;
        private double[] ugl_table;
        private double[] t_table;
        private double[] F_table;
        private int n_strok;

        private void Zapis_Click(object sender, EventArgs e)
        {
            try
            {
                paramets_table = null; // обнуление, если уже были параметры, для надёжности
                byte col_stolb = 2; //задаём колличество столбцов

                n_strok = (int)Param.Lines.Length; //определяем колличество строк в входном массиве
                string[] stroki = Param.Lines;  // передаём построчно массив

                string[] chisla_prov = stroki[0].Split();  // разбиваем строки на символы (разделитель - пробел)
                if (chisla_prov.Length == col_stolb)                 // // обработка ошибки (если неверно скопированно)
                {
                    chisla_prov = stroki[n_strok - 1].Split();  // разбиваем строки на символы (разделитель - пробел)
                    if (chisla_prov.Length != col_stolb)
                    {
                        n_strok = n_strok - 1;            // обработка ошибки (неверная строка, когда элементов в строке не столько, сколько должно быть)
                    }

                    paramets_table = new double[n_strok, col_stolb]; // создаём массив для обработки строк

                    for (int i = 0; i < n_strok; i++)    // перебор по строкам
                    {
                        string[] chisla = stroki[i].Split();  // разбиваем строки на символы (разделитель - пробел)
                        for (int j = 0; j < chisla.Length; j++)  // перебор по столбцам
                        {
                            paramets_table[i, j] = Convert.ToDouble(chisla[j]);  //запись числа
                        }

                    }

                    // строим график
                    for (int i = 0; i < n_strok - 1; i++)
                    {                                       // x        y
                        chart1.Series[0].Points.AddXY(paramets_table[i, 0], paramets_table[i, 1]);
                    }

                    Pg0 = Convert.ToDouble(textBoxP.Text);
                    fn = Convert.ToDouble(textBoxf.Text);
                    Tj = Convert.ToDouble(textBoxTj.Text);
                    h = Convert.ToDouble(textBoxh.Text);
                    tk = Convert.ToDouble(textBoxtk.Text);
                    fi0 = Convert.ToDouble(textBoxtfi.Text);
                }
            }
            catch
            {
            }
        }

        private void solve_Click(object sender, EventArgs e)
        {
            ugl_table = new double[1]; // создаём массив для обработки строк
            t_table = new double[1]; // создаём массив для обработки строк
            F_table = new double[1]; // создаём массив для обработки строк

            t_table[0] = 0;
            ugl_table[0] = fi0;
            F_table[0] = F(fi0);


            // i = 1

            double k = 360 * fn * h * h / Tj;
            double df1 = 0;
            double df2 = 0;
            double F1 = F(fi0);
            double F2 = 0;
            df1 = F1*k;
            F2 = F(fi0 + df1);

            Array.Resize(ref ugl_table, ugl_table.Length + 1); Array.Resize(ref t_table, t_table.Length + 1); Array.Resize(ref F_table, F_table.Length + 1);

           t_table[1] = h;
            ugl_table[1] = fi0+ df1;
            F_table[1] = F2;
            int i = 1;
            double di;


            while ((ugl_table[i] > 0) && (ugl_table[i]<180) && (i < (tk/h) ) )
            {
                i++;
                Array.Resize(ref ugl_table, ugl_table.Length + 1); Array.Resize(ref t_table, t_table.Length + 1); Array.Resize(ref F_table, F_table.Length + 1);
                di = ugl_table[i - 1] - ugl_table[i - 2] + k * F_table[i - 1];
                t_table[i] = t_table[i - 1] + h;
                ugl_table[i] = ugl_table[i - 1] + di;
                F_table[i] = F(ugl_table[i]);

            }


            n_strok = (int)t_table.Length; //определяем колличество строк в входном массиве
            // предварительная очистка
            while (dataGridView1.Rows.Count > 1)
                for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                    dataGridView1.Rows.Remove(dataGridView1.Rows[j]);
            // создания пустых строк
            dataGridView1.ColumnCount = 3;
            // название столбцов
            dataGridView1.Columns[0].HeaderText = "время";
            dataGridView1.Columns[1].HeaderText = "угол";
            dataGridView1.Columns[2].HeaderText = "избыточная P";

            dataGridView1.Rows.Add(n_strok);

            // запись
            for (int j = 0; j < n_strok-1; j++)
            {
                dataGridView1.Rows[j].Cells[0].Value = t_table[j];
                dataGridView1.Rows[j].Cells[1].Value = ugl_table[j];
                dataGridView1.Rows[j].Cells[2].Value = F_table[j];
            }


            // строим график
            for (int j = 0; j < n_strok - 1; j++)
            {                                       // x        y
                chart2.Series[0].Points.AddXY(t_table[j], ugl_table[j]);
            }

        }

        private double F(double fi)
        {
            double x = 0;
            for (int i=0; i < n_strok-1; i++)
            {
                if (fi < paramets_table[i, 0])
                {
                    double dP = (paramets_table[i, 1] - paramets_table[i - 1, 1]) * (fi - paramets_table[i-1, 0]) / (paramets_table[i, 0] - paramets_table[i - 1, 0]);

                    return (Pg0 - paramets_table[i - 1, 1] - dP);
                }
            }
            return x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart2.Series[0].Points.Clear();
        }
    }
}
