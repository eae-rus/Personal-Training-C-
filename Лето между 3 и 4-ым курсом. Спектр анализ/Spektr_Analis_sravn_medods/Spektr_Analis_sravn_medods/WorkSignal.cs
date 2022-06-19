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
    public partial class WorkSignal : Form
    {
        // задание существенных параметров сигнала, реализованы публичными, так как могут использоваться и вне класса - на данный момент точно не известно
        // уже не публичные
        private double[,] paramets_table; // параметры гармоник
        private double[,] signal_table;    // значения массива сигнала
        private double[,] spectr_table;    // значения массива спекстра
        private double fn;    // номинальная частота сигнала
        private double f_fact;    // фактическая частота сигнала
        private int N_one_period;    // количество точек на период
        private int n_periods;    // количество периодов оцифровки
        private double A_shum_White;    // Амплитуда белого шума
        private TimeSpan t_rasch; // время расчёта одним методом
        private string Okno_name; // переменная сохраняющая в себе вид используемого окна
        private bool graf1_ris; // переменная отвечает за то, будет ли отображаться график созданного сигнала
        private bool znach_write; // переменная отвечает за то, будет ли отображаться график созданного сигнала
        private bool otsechca; // переменна отвечающая за то, будет ли расчитываться вторая част спектра
        private string Shum_name; // переменная сохраняющая в себе способ задания шума
        private double znach_obnul; // переменная задающая порог обнуления
        private double zzz; // переменная задающая задающая особый параметр для окон ДПФ
        private double f_inter; //переменная задающая частоту интергармоники
        private double A_inter; //переменная задающая частоту интергармоники


        public WorkSignal()
        {
            InitializeComponent();
            // задание нулевых значений существенных параметров
            fn = Convert.ToDouble(fn_TB.Text);
            f_fact = Convert.ToDouble(f_fact_TB.Text);
            N_one_period = Convert.ToInt32(N_one_period_TB.Text);
            n_periods = Convert.ToInt32(n_Period_TB.Text);
            A_shum_White = Convert.ToDouble(shum_white_TB.Text);
            Okno_name = "Прямоугольное окно";
            graf1_ris = graf_ishod_ChB.Checked;
            znach_write = znach_write_ChB.Checked;
            otsechca = otsechka_ChB.Checked;
            Shum_name = "Амплитуда";
            znach_obnul = Convert.ToDouble(obnul_TB.Text);
            f_inter = Convert.ToDouble(f_Inter_TB.Text);
            A_inter = Convert.ToDouble(A_Inter_TB.Text);
        }

        private void WorkSignal_Load(object sender, EventArgs e)
        {
            // добавление возможности масштабирования по оси
            Signal_char.ChartAreas[0].CursorX.IsUserEnabled = true;
            // добавление возможности выбора интервала для масштабирования
            Signal_char.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            // включим масштабирование по оси х
            Signal_char.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            // полоса прокрутки
            Signal_char.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            // добавление возможности масштабирования по оси
            Signal_char.ChartAreas[0].CursorY.IsUserEnabled = true;
            // добавление возможности выбора интервала для масштабирования
            Signal_char.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            // включим масштабирование по оси х
            Signal_char.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            // полоса прокрутки
            Signal_char.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

            // то же самое для другого графика
            All_spectr_chart.ChartAreas[0].CursorX.IsUserEnabled = true;
            All_spectr_chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            All_spectr_chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            All_spectr_chart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            All_spectr_chart.ChartAreas[0].CursorY.IsUserEnabled = true;
            All_spectr_chart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            All_spectr_chart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            All_spectr_chart.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
        }

        private void DeletOne_param_button_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = parametrs_DGV.SelectedCells[0].RowIndex;
                parametrs_DGV.Rows.RemoveAt(ind);
            }
            catch
            {

            }
        }

        private void DeletAll_param_button_Click(object sender, EventArgs e)
        {
            try
            {
                while (parametrs_DGV.Rows.Count > 1)
                    for (int i = 0; i < parametrs_DGV.Rows.Count - 1; i++)
                        parametrs_DGV.Rows.Remove(parametrs_DGV.Rows[i]);
            }
            catch
            {

            }
        }

        // запись в таблицу гармоник, код будет рассмотрен для этого случая, для сигнала всё аналогично
        private void Write_button_Click(object sender, EventArgs e)
        {
            try
            {
                paramets_table = null; // обнуление, если уже были параметры, для надёжности
                byte col_stolb = 3; //задаём колличество столбцов

                int n_strok = (int)Vstavka_TB.Lines.Length; //определяем колличество строк в входном массиве
                string[] stroki = Vstavka_TB.Lines;  // передаём построчно массив

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
                    // предварительная очистка
                    while (parametrs_DGV.Rows.Count > 1)
                        for (int i = 0; i < parametrs_DGV.Rows.Count - 1; i++)
                            parametrs_DGV.Rows.Remove(parametrs_DGV.Rows[i]);
                    // создания пустых строк
                    parametrs_DGV.ColumnCount = col_stolb;
                    // название столбцов
                    parametrs_DGV.Columns[0].HeaderText = "Номер гармоники";
                    parametrs_DGV.Columns[1].HeaderText = "Амплитула";
                    parametrs_DGV.Columns[2].HeaderText = "Фаза (град)";

                    parametrs_DGV.Rows.Add(n_strok);

                    // запись
                    for (int i = 0; i < n_strok; i++)
                    {
                        parametrs_DGV.Rows[i].Cells[0].Value = paramets_table[i, 0];
                        parametrs_DGV.Rows[i].Cells[1].Value = paramets_table[i, 1];
                        parametrs_DGV.Rows[i].Cells[2].Value = paramets_table[i, 2];
                    }
                }
            }
            catch
            {
            }                              

        }


        // заполнение таблицы с сигналом - Если уже есть данные
        private void Write_sinal_button_Click(object sender, EventArgs e)
        {
            try
            {

                signal_table = null; // обнуление, если уже были параметры, для надёжности
                byte col_stolb = 2;

                int n_strok = (int)Vstavka_TB.Lines.Length;
                string[] stroki = Vstavka_TB.Lines;

                string[] chisla_prov = stroki[0].Split();  // разбиваем строки на символы (разделитель - пробел)
                if (chisla_prov.Length == col_stolb)       // обработка ошибки (если неверно скопированно)
                {
                    chisla_prov = stroki[n_strok - 1].Split();  // разбиваем строки на символы (разделитель - пробел)
                    if (chisla_prov.Length != col_stolb)
                    {
                        n_strok = n_strok - 1;            // обработка ошибки (неверная строка, когда элементов в строке не столько, сколько должно быть)
                    }

                    signal_table = new double[n_strok, col_stolb];

                    for (int i = 0; i < n_strok; i++)
                    {
                        string[] chisla = stroki[i].Split();
                        for (int j = 0; j < chisla.Length; j++)
                        {
                            signal_table[i, j] = Convert.ToDouble(chisla[j]);
                        }

                    }
                    // предварительная очистка
                    while (Signal_dGV.Rows.Count > 1)
                        for (int i = 0; i < Signal_dGV.Rows.Count - 1; i++)
                            Signal_dGV.Rows.Remove(Signal_dGV.Rows[i]);
                    // создания пустых строк
                    Signal_dGV.ColumnCount = col_stolb;
                    Signal_dGV.Columns[0].HeaderText = "время (с)";
                    Signal_dGV.Columns[1].HeaderText = "Мгновенное значение";


                    // запись
                    if (znach_write)
                    {
                        Signal_dGV.Rows.Add(n_strok); // создание строк
                        for (int i = 0; i < N_one_period * n_periods; i++)
                        {
                            Signal_dGV.Rows[i].Cells[0].Value = signal_table[i, 0];
                            Signal_dGV.Rows[i].Cells[1].Value = signal_table[i, 1];
                        }
                    }

                }


                // строим график
                Grafics_Draw_VX(N_one_period * n_periods, signal_table);
            }
            catch
            {
            }

        }

        private void Fn_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fn = Convert.ToDouble(fn_TB.Text);
            }
            catch
            {
            }
        }

        private void N_one_period_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                N_one_period = Convert.ToInt32(N_one_period_TB.Text);
            }
            catch
            {

            }
        }

        private void N_Period_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n_periods = Convert.ToInt32(n_Period_TB.Text);
            }
            catch
            {

            }
        }

        private void F_fact_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                f_fact = Convert.ToDouble(f_fact_TB.Text);
            }
            catch
            {

            }
        }





        // создание сигнала
        private void MadeSignal_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (paramets_table != null)
                {
                    signal_table = null; // обнуление, если уже были параметры, для надёжности

                    int nGarmon = paramets_table.GetLength(0);            // определяется количество гармоник
                    Metods metods = new Metods();
                    signal_table = metods.Made_Signal_garmon(paramets_table, N_one_period, n_periods,fn,f_fact,f_inter,A_inter);

                    // добавление рандомного шума
                    signal_table = metods.Add_shum_Wite(signal_table, N_one_period, n_periods,A_shum_White);

                    // запись в столбец
                    byte col_stolb = 2;
                    // предварительная очистка
                    while (Signal_dGV.Rows.Count > 1)
                        for (int i = 0; i < Signal_dGV.Rows.Count - 1; i++)
                            Signal_dGV.Rows.Remove(Signal_dGV.Rows[i]);
                    // создания пустых строк
                    Signal_dGV.ColumnCount = col_stolb;
                    Signal_dGV.Columns[0].HeaderText = "время (с)";
                    Signal_dGV.Columns[1].HeaderText = "Мгновенное значение";

                    // запись
                    if (znach_write)
                    {
                        Signal_dGV.Rows.Add(N_one_period * n_periods); // создание строк
                        for (int i = 0; i < N_one_period * n_periods; i++)
                        {
                            Signal_dGV.Rows[i].Cells[0].Value = signal_table[i, 0];
                            Signal_dGV.Rows[i].Cells[1].Value = signal_table[i, 1];
                        }
                    }


                    // строим график
                    if (graf1_ris)
                    {
                        Grafics_Draw_VX(N_one_period * n_periods, signal_table);
                    }
                }
            }
            catch
            {

            }
        }


        private void Grafics_Draw_VX(int dlina,double [,] f)
        {

            // рандомный цвет 

            for (int i = 0; i < dlina-1; i++)
            {                                       // x        y
                Signal_char.Series[0].Points.AddXY(f[i, 0], f[i, 1]);
            }
        }


        private void ObnovlParametrs_button_Click(object sender, EventArgs e)
        {
            try
            {
                // определяем количество строк
                int n_strok = parametrs_DGV.Rows.Count - 1;
                paramets_table = null; // обнуление, если уже были параметры, для надёжности
                byte col_stolb = 3; //задаём колличество столбцов
                                    // иницилизируем массив
                paramets_table = new double[n_strok, col_stolb]; // создаём массив для обработки строк

                for (int i = 0; i < n_strok; i++)
                {
                    paramets_table[i, 0] = Convert.ToDouble(parametrs_DGV.Rows[i].Cells[0].Value);
                    paramets_table[i, 1] = Convert.ToDouble(parametrs_DGV.Rows[i].Cells[1].Value);
                    paramets_table[i, 2] = Convert.ToDouble(parametrs_DGV.Rows[i].Cells[2].Value);
                }
            }
            catch
            {
            } 

        }

        private void Clear_char_Click(object sender, EventArgs e)
        {
            Signal_char.Series[0].Points.Clear();
        }

        private void shum_white_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Shum_name == "Амплитуда")
                {
                    A_shum_White = Convert.ToDouble(shum_white_TB.Text);
                }
                if (Shum_name == "Отношение Шум/сигнал (о.е)")
                {
                    double A = 0;
                    for (int i = 0; i < paramets_table.GetLength(0); i++)
                    {
                        A = A + paramets_table[i, 1] * paramets_table[i, 1];
                    }
                    A = Math.Sqrt(A);
                    A_shum_White = A * Convert.ToDouble(shum_white_TB.Text);
                }
                if (Shum_name == "Отношение Шум/сигнал (дБ) ")
                {
                    double A = 0;
                    for (int i = 0; i < paramets_table.GetLength(0); i++)
                    {
                        A = A + paramets_table[i, 1] * paramets_table[i, 1];
                    }
                    A = Math.Sqrt(A);
                    A_shum_White = A * Math.Pow(10, Convert.ToDouble(shum_white_TB.Text) / 20);
                }

                    
            }
            catch
            {
                MessageBox.Show("Введите сперва сигнал (гармонический состав) или выберите другой способ задания шума");
            }
        }

        private void DPF_button_Click(object sender, EventArgs e)
        {
            try
            {
                spectr_table = new double[N_one_period * n_periods, 3];
                Metods metods = new Metods();
                DateTime tn = DateTime.Now; // задаём время пуска 
                if (DPF_radioButton.Checked)  // ДПФ
                {
                    spectr_table = metods.DPF_with_okna(signal_table, N_one_period, n_periods, fn, Okno_name, otsechca, zzz);
                } 
                if  (FFT_radioButton.Checked)  // БПФ
                {
                    spectr_table = metods.fft(signal_table, N_one_period * n_periods, fn, n_periods, Okno_name, zzz,FFT_0_CB.SelectedItem.ToString());
                }
                // сохранение времени
                t_rasch = DateTime.Now - tn;
                T_rasch_TB.Text = Convert.ToString(t_rasch.TotalMilliseconds);


                int col_stolb = 3;
                int n_strok = N_one_period * n_periods - 1; //-1 т.к. нумерация с 0
                                                            // предварительная очистка
                while (Spectr_DGV.Rows.Count > 1)
                    for (int i = 0; i < Spectr_DGV.Rows.Count - 1; i++)
                        Spectr_DGV.Rows.Remove(Spectr_DGV.Rows[i]);

                // записывать в в таблицу, если это указанно
                if (ZapisatSpectr_ChB.Checked)
                {
                    // создания пустых строк
                    Spectr_DGV.ColumnCount = col_stolb;
                    // название столбцов
                    Spectr_DGV.Columns[0].HeaderText = "частота";
                    Spectr_DGV.Columns[1].HeaderText = "Амплитула";
                    Spectr_DGV.Columns[2].HeaderText = "Фаза (град)";

                    // создание строк
                    if (otsechca)
                    {
                        Spectr_DGV.Rows.Add(Convert.ToInt32(n_strok / 2) + 1);
                        // запись
                        for (int i = 0; i < Convert.ToInt32(n_strok / 2) + 1; i++)
                        {
                            Spectr_DGV.Rows[i].Cells[0].Value = spectr_table[i, 0];
                            if (spectr_table[i, 1] < znach_obnul)
                            {
                                Spectr_DGV.Rows[i].Cells[1].Value = 0;
                                Spectr_DGV.Rows[i].Cells[2].Value = 0;
                            }
                            else
                            {
                                Spectr_DGV.Rows[i].Cells[1].Value = spectr_table[i, 1];
                                Spectr_DGV.Rows[i].Cells[2].Value = spectr_table[i, 2];
                            }
                        }
                    }
                    else
                    {
                        Spectr_DGV.Rows.Add(n_strok);
                        // запись
                        for (int i = 0; i < n_strok; i++)
                        {
                            Spectr_DGV.Rows[i].Cells[0].Value = spectr_table[i, 0];
                            if (spectr_table[i, 1] < znach_obnul)
                            {
                                Spectr_DGV.Rows[i].Cells[1].Value = 0;
                                Spectr_DGV.Rows[i].Cells[2].Value = 0;
                            }
                            else
                            {
                                Spectr_DGV.Rows[i].Cells[1].Value = spectr_table[i, 1];
                                Spectr_DGV.Rows[i].Cells[2].Value = spectr_table[i, 2];
                            }
                        }
                    }
                }             


                // строим весь спектр                            
                if (otsechca)
                {
                    for (int i = 0; i < Convert.ToInt32(n_strok / 2); i++)
                    {                                                  // x        y
                        All_spectr_chart.Series[0].Points.AddXY(spectr_table[i, 0], spectr_table[i, 1]);
                    }
                }
                else
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                                  // x        y
                        All_spectr_chart.Series[0].Points.AddXY(spectr_table[i, 0], spectr_table[i, 1]);
                    }
                }

                // строим окна
                if (Okno_name == "Прямоугольное окно")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                            // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], 1);
                    }
                }
                if (Okno_name == "Треугольное окно")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_triangle(n_strok + 1, i));
                    }
                }
                if (Okno_name == "Окно Бартлетта")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_Bartlett(n_strok + 1, i));
                    }
                }
                if (Okno_name == "Синус-окно")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_sin(n_strok + 1, i));
                    }
                }
                if (Okno_name == "Окно Ланцоша")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_Lanczos(n_strok + 1, i));
                    }
                }
                if (Okno_name == "Окно Ханна")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_Hann(n_strok + 1, i));
                    }
                }
                if (Okno_name == "Окно Бартлетта-Ханна")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_Bartlett_Hann(n_strok + 1, i));
                    }
                }
                if (Okno_name == "Окно Хэмминга")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_Hemming(n_strok + 1, i));
                    }
                }
                if (Okno_name == "Окно Блэкмена")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_Blackman(n_strok + 1, i));
                    }
                }
                if (Okno_name == "Окно Блэкмана-Харриса")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_Blackman_Harris(n_strok + 1, i));
                    }
                }
                if (Okno_name == "Окно Наталла")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_Nuttall(n_strok + 1, i));
                    }
                }
                if (Okno_name == "Окно Блэкмена-Наталла")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_Blackman_Nuttall(n_strok + 1, i));
                    }
                }
                if (Okno_name == "Окно с плоской вершиной")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_Flat_Top(n_strok + 1, i));
                    }
                }
                if (Okno_name == "Окно Бомена")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_Bohman(n_strok + 1, i));
                    }
                }
                if (Okno_name == "Окно Парзена")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_Parzen(n_strok + 1, i));
                    }
                }
                if (Okno_name == "Окно Тьюки")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_Tukey(n_strok + 1, i,zzz));
                    }
                }
                if (Okno_name == "Окно Кайзера")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_Kaiser(n_strok + 1, i, zzz));
                    }
                }
                if (Okno_name == "Окно Гаусса")
                {
                    for (int i = 0; i < n_strok; i++)
                    {                                              // x        y
                        Okno_chart.Series[0].Points.AddXY(signal_table[i, 0], metods.w_Gauss(n_strok + 1, i, zzz));
                    }
                }
            }
            catch
            {

            }         

        }

        private void Copy_isxod_button_Click(object sender, EventArgs e)
        {
        }

        private void okna_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Okno_name = okna_CB.SelectedItem.ToString();
            if (Okno_name == "Окно Тьюки")
            {
                zzz_TB.Visible = true;
                zzz_TB.Text = "0,5";
                zzz = 0.5;
                label_zzz.Visible = true;
                label_zzz.Text = "- r (степень зануления)" + "\n" + "0 - 1  (100%)";
            }
            else if (Okno_name == "Окно Кайзера")
            {
                zzz_TB.Visible = true;
                zzz_TB.Text = "5";
                zzz = 5;
                label_zzz.Visible = true;
                label_zzz.Text = "- бетта";
                MessageBox.Show("Работает неверно");
            }
            else if (Okno_name == "Окно Гаусса")
            {
                zzz_TB.Visible = true;
                zzz_TB.Text = "0,5";
                zzz = 2.5;
                label_zzz.Visible = true;
                label_zzz.Text = "- сигма";
            }
            else
            {
                zzz_TB.Visible = false;
                label_zzz.Visible = false;
            }
        }

        private void Okna_ChB_CheckedChanged(object sender, EventArgs e)
        {
            if (Okna_ChB.Checked == true)
            {
                okna_CB.Enabled = true;
                try
                {
                    Okno_name = okna_CB.SelectedItem.ToString();
                }
                catch
                {
                }
            }
            else
            {
                okna_CB.Enabled = false;
                Okno_name = "Прямоугольное окно";
            }
        }

        private void graf_ishod_ChB_CheckedChanged(object sender, EventArgs e)
        {
            graf1_ris = graf_ishod_ChB.Checked;
        }

        private void znach_write_ChB_CheckedChanged(object sender, EventArgs e)
        {
            znach_write = znach_write_ChB.Checked;
        }

        private void Clean_graf_button_Click(object sender, EventArgs e)
        {
            All_spectr_chart.Series[0].Points.Clear();
            Okno_chart.Series[0].Points.Clear();
        }

        private void otsechka_ChB_CheckedChanged(object sender, EventArgs e)
        {
            otsechca = otsechka_ChB.Checked;
        }

        private void Shum_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shum_name = Shum_CB.SelectedItem.ToString();
        }

        private void obnul_ChB_CheckedChanged(object sender, EventArgs e)
        {
            if (obnul_ChB.Checked)
            {
                obnul_TB.Enabled = true;
                try
                {
                    znach_obnul = Convert.ToDouble(obnul_TB.Text);
                }
                catch
                {
                    MessageBox.Show("некорректно введено значение");
                }
            }
            else
            {
                obnul_TB.Enabled = false;
                znach_obnul = 0;

            }
        }

        private void obnul_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                znach_obnul = Convert.ToDouble(obnul_TB.Text);
            }
            catch
            {
                MessageBox.Show("некорректно введено значение");
            }
        }

        private void Worksignal_button_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(amplitudasignal_TB.Text);
            int N_max = Convert.ToInt32(maxGarmonick_TB.Text);
            // пытаемся считать шум
            double Shum_sugnak;
            try
            {
                Shum_sugnak = Convert.ToDouble(Shum_sugnak_TB.Text);
            }
            catch
            {
                Shum_sugnak = 0;
                MessageBox.Show("некорректный ввод величины");
            }
            int n_usred = Convert.ToInt32(usred_TB.Text);
            TimeSpan tsum = DateTime.Now - DateTime.Now; // задаём время пуска 

            // создание массива для сигнала
            double[,] signal = new double[N_one_period*n_periods, 2];
            // создание массива спектра
            double[,] spectr = new double[N_max, 3];
            // создание малого массива спектра, для приёма из метода
            double[,] spectr_one = new double[1, 3];
            // создание малого массива параметров для генерации сигнала
            double[,] param = new double[1, 3];
            // открытия класса методов
            Metods metods = new Metods();

            if (pogresh_vid_CB.SelectedItem.ToString() == "Среднеарифметическую")
            {
                for (int n = 0; n < n_usred; n++)
                {
                    // 0 - это первая гармоника
                    for (int i = 0; i < N_max; i++)
                    {
                        // задания параметров гармоники
                        param[0, 0] = i + 1; param[0, 1] = A; param[0, 2] = 0;
                        //создание сигнала
                        signal = metods.Made_Signal_garmon(param, N_one_period, n_periods, fn, f_fact, f_inter, A_inter);
                        // добавление рандомного шума
                        signal = metods.Add_shum_Wite(signal, N_one_period, n_periods, Shum_sugnak * A);
                        DateTime tn = DateTime.Now; // задаём время пуска 
                        spectr_one = metods.DPF_with_okna(i + 1, signal, N_one_period, n_periods, fn, Okno_name,zzz);
                        tsum = tsum + (DateTime.Now - tn);
                        spectr[i, 0] = spectr[i, 0] + spectr_one[0, 0];
                        spectr[i, 1] = spectr[i, 1] + Math.Abs((A - spectr_one[0, 1]) / A * 100);
                        spectr[i, 2] = spectr[i, 2] + Math.Abs(spectr_one[0, 2]);
                    }
                    // ввод паузы для сна
                    //System.Threading.Thread.Sleep(10);
                }
            }
            if (pogresh_vid_CB.SelectedItem.ToString() == "Максимальную")
            {
                for (int n = 0; n < n_usred; n++)
                {
                    // 0 - это первая гармоника
                    for (int i = 0; i < N_max; i++)
                    {
                        // задания параметров гармоники
                        param[0, 0] = i + 1; param[0, 1] = A; param[0, 2] = 0;
                        //создание сигнала
                        signal = metods.Made_Signal_garmon(param, N_one_period, n_periods, fn, f_fact, f_inter, A_inter);
                        // добавление рандомного шума
                        signal = metods.Add_shum_Wite(signal, N_one_period, n_periods, Shum_sugnak * A);
                        DateTime tn = DateTime.Now; // задаём время пуска 
                        spectr_one = metods.DPF_with_okna(i + 1, signal, N_one_period, n_periods, fn, Okno_name,zzz);
                        tsum = tsum + (DateTime.Now - tn);
                        spectr[i, 0] = spectr[i, 0] + spectr_one[0, 0];
                        spectr[i, 1] = Math.Max( (Math.Abs(A - spectr_one[0, 1])) / A * 100,  spectr[i, 1] );
                        spectr[i, 2] = Math.Max(Math.Abs(spectr_one[0, 2]), spectr[i, 2]);
                    }
                    // ввод паузы для сна
                    //System.Threading.Thread.Sleep(10);
                }
            }

            // вывод времени
            t_pogresh_TB.Text = tsum.TotalMilliseconds / n_usred + "";


            // вывод значений
            int col_stolb = 3;
            int n_strok = N_max;
            // предварительная очистка
            while (workSignal_DGV.Rows.Count > 1)
                for (int i = 0; i < workSignal_DGV.Rows.Count - 1; i++)
                    workSignal_DGV.Rows.Remove(workSignal_DGV.Rows[i]);
            // создания пустых строк
            workSignal_DGV.ColumnCount = col_stolb;
            // название столбцов
            workSignal_DGV.Columns[0].HeaderText = "Гармоника";
            workSignal_DGV.Columns[1].HeaderText = "Амплитудная "+ "\n" + "погрешность";
            workSignal_DGV.Columns[2].HeaderText = "Фаза (град)";

            // создание строк
            workSignal_DGV.Rows.Add(n_strok);
            // запись
            for (int i = 0; i < n_strok; i++)
            {
                workSignal_DGV.Rows[i].Cells[0].Value = spectr[i, 0] / n_usred;
                if (spectr[i, 1] < znach_obnul)
                {
                    workSignal_DGV.Rows[i].Cells[1].Value = 0;
                }
                else
                {
                    if (pogresh_vid_CB.SelectedItem.ToString() == "Среднеарифметическую")
                    {
                        workSignal_DGV.Rows[i].Cells[1].Value = spectr[i, 1] / n_usred;
                    }
                    if (pogresh_vid_CB.SelectedItem.ToString() == "Максимальную")
                    {
                        workSignal_DGV.Rows[i].Cells[1].Value = spectr[i, 1];
                    }
                }
                if (spectr[i, 2] < znach_obnul)
                {
                    workSignal_DGV.Rows[i].Cells[2].Value = 0;
                }
                else
                {
                    if (pogresh_vid_CB.SelectedItem.ToString() == "Среднеарифметическую")
                    {
                        workSignal_DGV.Rows[i].Cells[2].Value = spectr[i, 2] / n_usred;
                    }
                    if (pogresh_vid_CB.SelectedItem.ToString() == "Максимальную")
                    {
                        workSignal_DGV.Rows[i].Cells[2].Value = spectr[i, 2];
                    }
                }
            }

        }

        private void amplitudasignal_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pogresh_vid_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zzz_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                zzz = Convert.ToDouble(zzz_TB.Text);
            }
            catch
            { }
        }

        private void FFT_radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SaveSignal_TSMI_Click(object sender, EventArgs e)
        {
            // открываем диалоговое окно;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt файлы (*.txt)|*.txt|все файлы (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = Application.StartupPath;

            saveFileDialog1.ShowDialog();

            string put = saveFileDialog1.FileName;

            try
            {
                // создание текстового массива сигнала
                string text = null;
                text = "t (c)" + "\t" + "x" + "\n";
                for (int i = 0; i < signal_table.GetLength(0); i++)
                {
                    if (i < signal_table.GetLength(0) - 1)
                    {
                        text = text + signal_table[i, 0] + "\t" + signal_table[i, 1] + "\n";
                    }
                    else
                    {
                        text = text + signal_table[i, 0] + "\t" + signal_table[i, 1];
                    }
                }


                System.IO.File.WriteAllText(put, text);
            }
            catch
            {
            }
        }

        private void SaveSpectr_TSMI_Click(object sender, EventArgs e)
        {
            // открываем диалоговое окно;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt файлы (*.txt)|*.txt|все файлы (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = Application.StartupPath;

            saveFileDialog1.ShowDialog();

            string put = saveFileDialog1.FileName;

            try
            {
                // создание текстового массива сигнала
                string text = null;
                text = "f (Гц)" + "\t" + "A" + "\t" + "fi (град)" + "\n";
                for (int i = 0; i < spectr_table.GetLength(0); i++)
                {
                    if (i < spectr_table.GetLength(0) - 1)
                    {
                        text = text + spectr_table[i, 0] + "\t" + spectr_table[i, 1] + "\t" + spectr_table[i, 2] + "\n";
                    }
                    else
                    {
                        text = text + spectr_table[i, 0] + "\t" + spectr_table[i, 1] + "\t" + spectr_table[i, 2];
                    }
                }

                // собственно сама запись
                System.IO.File.WriteAllText(put, text);
            }
            catch
            {
            }
        }

        private void f_Inter_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                f_inter = Convert.ToDouble(f_Inter_TB.Text);
            }
            catch
            { }
        }

        private void A_Inter_TB_TextChanged(object sender, EventArgs e)
        {
                try
            {
                A_inter = Convert.ToDouble(A_Inter_TB.Text);
            }
            catch
            { }
        }
    }
}
