using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spektr_Analis_sravn_medods
{
    public partial class MadeSignal : Form
    {
        public MadeSignal()
        {
            InitializeComponent();
        }

        public double f_osn;            // несущая частота (номинал)
        public double f_fact;           // частота фактического сигнала
        public int N_onePeriod;         // количество точек на один период (несущей частоты)
        public int n_Periodov;          // количество периодов
        public double [,] sign_param;   // 2-ух мерная таблица, 1-ый столбец - номер гармоники, 2-ой - амплитуда, 3-ий - фаза (град)
        public double[,] signal;        // 2-ух мерная таблица, 1-ый столбец - время, 2-ой - мгновен значение

        private void MadeSignal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcelReaderInterop reader = new ExcelReaderInterop();
            object[,] parametrs = reader.ExcelReadTableOneShets(Application.StartupPath + @"\ParamerSign.xlsx", 1);
            f_osn  = Convert.ToDouble(parametrs[1, 1]);
            f_fact = Convert.ToDouble(parametrs[2, 1]);         // счтывание параметров
            N_onePeriod = Convert.ToInt32(parametrs[3, 1]);
            n_Periodov  = Convert.ToInt32(parametrs[4, 1]);

            int nStrok = parametrs.GetLength(0); // количество строк
            sign_param = new double[nStrok-5, 3]; // стоит иметь ввиду, что если строк 5, то последня 4-ая, так как нумерация с 0

            for (int i = 6; i < nStrok; i++) 
            {
                sign_param[i - 6, 0] = Convert.ToDouble(parametrs[i, 1]);
                sign_param[i - 6, 1] = Convert.ToDouble(parametrs[i, 2]);
                sign_param[i - 6, 2] = Convert.ToDouble(parametrs[i, 3]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelReaderInterop writer = new ExcelReaderInterop();

            writer.ExcelWriterTableOneShets(Application.StartupPath + @"\Signal.xlsx", 1, "A1", f_osn);
            writer.ExcelWriterTableOneShets(Application.StartupPath + @"\Signal.xlsx", 1, "A2", f_fact);
            writer.ExcelWriterTableOneShets(Application.StartupPath + @"\Signal.xlsx", 1, "A3", N_onePeriod);
            writer.ExcelWriterTableOneShets(Application.StartupPath + @"\Signal.xlsx", 1, "A4", n_Periodov);
            writer.ExcelWriterTableOneShets(Application.StartupPath + @"\Signal.xlsx", 1, "A6", signal);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExcelReaderInterop x = new ExcelReaderInterop();
            x.ExcelOpenVisable(Application.StartupPath + @"\ParamerSign.xlsx");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int nGarmon = sign_param.GetLength(0);            // определяется количество гармоник
            signal = new double[n_Periodov*N_onePeriod, 2];   // сразу иницилизируется матрица сигнала

            if (sign_param[0, 0] == 0)
            {
                for (int i = 0; i < n_Periodov * N_onePeriod; i++)
                {
                    signal[i, 0] = i / f_osn / N_onePeriod;
                    signal[i, 1] = sign_param[0, 1];
                    for (int j = 1; j < nGarmon; j++)
                    {
                        signal[i, 1] = signal[i, 1] + sign_param[j, 1]*Math.Sin(2*Math.PI*f_fact* sign_param[j, 0]* signal[i, 0] + sign_param[j, 2]*Math.PI/180);
                        //в этой формуле                 амплитуда   *   sin (   2*pi    *f_fact * ngarmon         *  t           + fi0)
                    }

                }
            }
            else
            {
                for (int i = 0; i < n_Periodov * N_onePeriod; i++)
                {
                    signal[i, 0] = i / f_osn / N_onePeriod;
                    for (int j = 0; j < nGarmon; j++)
                    {
                        signal[i, 1] = signal[i, 1] + sign_param[j, 1] * Math.Sin(2 * Math.PI * f_fact * sign_param[j, 0] * signal[i, 0] + sign_param[j, 2] * Math.PI / 180);
                        //в этой формуле                 амплитуда   *   sin (   2*pi    *f_fact * ngarmon         *  t           + fi0)
                    }

                }
            }
        }
    }
}
