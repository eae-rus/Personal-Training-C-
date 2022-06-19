using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vicmat_G;
using System.IO;

namespace Vichmat_Prokt
{
    public partial class Urav : Form
    {
        //слишком долго изменять, считается рациональным использование в дальнейшем
        private enum R_schen : byte
        {
            vibran, Nevibran

        }

         R_schen L;

        public Form MainForm;
        public Urav()
        {
            InitializeComponent();
        }
        Vichmat_Prokt.Metods_Urav metods;

        public Urav(Form mainForm)
        {
            this.MainForm = mainForm;
            Glav_Form form =mainForm as Glav_Form;
            form.Show();
            InitializeComponent();
            L = R_schen.Nevibran;
        }



        private void Urav_Load(object sender, EventArgs e)
        {
            
        }

        private void vernuts_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void a_ValueChanged(object sender, EventArgs e)
        {
            pereschet();
        }

        private void b_ValueChanged(object sender, EventArgs e)
        {
            pereschet();
        }

        private void Bisec_Checet_CheckedChanged(object sender, EventArgs e)
        {
            pereschet();
        }

        private void Log_CheckedChanged(object sender, EventArgs e)
        {
            pereschet();
        }

        private void X0_num_ValueChanged(object sender, EventArgs e)
        {
            pereschet();
        }

        private void Kasat_Chekt_CheckedChanged(object sender, EventArgs e)
        {
            pereschet();
        }

        private void W_ND_ValueChanged(object sender, EventArgs e)
        {
            pereschet();
        }

        private void Metod_Rid_Chect_CheckedChanged(object sender, EventArgs e)
        {
            pereschet();
        }
        private void Bisec_RB_CheckedChanged(object sender, EventArgs e)
        {
            pereschet();
        }
        private void Log_RB_CheckedChanged(object sender, EventArgs e)
        {
            pereschet();
        }
        private void Kasat_RB_CheckedChanged(object sender, EventArgs e)
        {
            pereschet();
        }
        private void Metod_Rid_RB_CheckedChanged(object sender, EventArgs e)
        {
            pereschet();
        }

        private void Rnov_ValueChanged(object sender, EventArgs e)
        {
            pereschet();
        }

        private void m_NU_ValueChanged(object sender, EventArgs e)
        {
            pereschet();
        }

        private void S_NU_ValueChanged(object sender, EventArgs e)
        {
            pereschet();
        }

        private void pereschet()
        {
            if (Bisec_Checet.Checked || Log.Checked || Kasat_Chekt.Checked || Metod_Rid_Chect.Checked || Bisec_RB.Checked || Log_RB.Checked || Kasat_RB.Checked || Metod_Rid_RB.Checked)
            {
                a.Visible = true;
                b.Visible = true;
                A_text.Visible = true;
                b_text.Visible = true;
                fraz.Visible = true;
            }
            else {
                a.Visible = false;
                b.Visible = false;
                A_text.Visible = false;
                b_text.Visible = false;
                fraz.Visible = false;
            }

            if (Kasat_Chekt.Checked || Kasat_RB.Checked)
            {
                W_ND.Visible = true;
                w_text.Visible = true;

            }
            else
            {
                W_ND.Visible = false;
                w_text.Visible = false;
            }


            metods = new Metods_Urav();
            string stroka = null;

            if (Bisec_Checet.Checked || Bisec_RB.Checked)
            {

                if (L == R_schen.vibran)
                {
                    double xz = 0;                                   
                        double x = metods.bisect((float)a.Value, (float)b.Value, (double)Rnov.Value,(byte) m_NU.Value,(double)S_NU.Value/100);
                        if (Math.Abs(xz - x) > 0.001)
                        {
                            if (Math.Abs(metods.R(x, (double)S_NU.Value / 100, (byte)m_NU.Value, (double)Rnov.Value)) < 0.001)
                            {
                                stroka += "Метод Бисекции корень уравнения =" + x + Environment.NewLine + "количество шагов = " + metods.N + Environment.NewLine + "значение F=" + metods.R(x, (double)S_NU.Value / 100, (byte)m_NU.Value, (double)Rnov.Value) + Environment.NewLine + Environment.NewLine;

                            }
                        }
                    
                }
                else
                {
                    float[,] inter = metods.naxogd_Interval((float)a.Value, (float)b.Value);
                    double xz = 0;
                    for (int i = 1; i <= inter[0, 0]; i++)
                    {
                        double x = metods.bisect((double)inter[i, 0], (double)inter[i, 1]);
                        if (Math.Abs(xz - x) > 0.001)
                        {
                            if (Math.Abs(metods.F(x)) < 0.001)
                            {
                                stroka += "Метод Бисекции корень уравнения =" + x + Environment.NewLine + "количество шагов = " + metods.N + Environment.NewLine + "значение F=" + metods.F(x) + Environment.NewLine + Environment.NewLine;

                            }
                        }
                        xz = x;
                    }
                }

            }

            if (Log.Checked || Log_RB.Checked)
            {
                if (L == R_schen.vibran)
                {
                    double xz = 0;
                    double x = metods.Lognogo_pol((float)a.Value, (float)b.Value, (double)Rnov.Value, (byte)m_NU.Value, (double)S_NU.Value / 100);
                    if (Math.Abs(xz - x) > 0.001)
                    {
                        if (Math.Abs(metods.R(x, (double)S_NU.Value / 100, (byte)m_NU.Value, (double)Rnov.Value)) < 0.001)
                        {
                            stroka += "Метод Ложного положения корень уравнения =" + x + Environment.NewLine + "количество шагов = " + metods.N + Environment.NewLine + "значение F=" + metods.R(x, (double)S_NU.Value / 100, (byte)m_NU.Value, (double)Rnov.Value) + Environment.NewLine + Environment.NewLine;
                        }
                    }
                }
                else
                {
                    float[,] inter = metods.naxogd_Interval((float)a.Value, (float)b.Value);
                    double xz = 0;
                    for (int i = 1; i <= inter[0, 0]; i++)
                    {
                        double x = metods.Lognogo_pol((double)inter[i, 0], (double)inter[i, 1]);
                        if (Math.Abs(xz - x) > 0.001)
                        {
                            if (Math.Abs(metods.F(x)) < 0.001)
                            {
                                stroka += "Метод Ложного положения корень уравнения =" + x + Environment.NewLine + "количество шагов = " + metods.N + Environment.NewLine + "значение F=" + metods.F(x) + Environment.NewLine + Environment.NewLine;
                            }
                        }
                        xz = x;
                    }
                }
            }




            if (Kasat_Chekt.Checked || Kasat_RB.Checked)
            {
                if (L == R_schen.vibran)
                {
                    double xz = 0;
                    double x = metods.kasat((float)a.Value, (float)b.Value, (double)W_ND.Value, (double)Rnov.Value, (byte)m_NU.Value, (double)S_NU.Value / 100);
                    if (Math.Abs(xz - x) > 0.001)
                    {
                        if (Math.Abs(metods.R(x, (double)S_NU.Value / 100, (byte)m_NU.Value, (double)Rnov.Value)) < 0.001)
                        {
                            stroka += "Метод Ложного положения корень уравнения =" + x + Environment.NewLine + "количество шагов = " + metods.N + Environment.NewLine + "значение F=" + metods.R(x, (double)S_NU.Value / 100, (byte)m_NU.Value, (double)Rnov.Value) + Environment.NewLine + Environment.NewLine;
                        }
                    }
                }
                else
                {
                    float[,] inter = metods.naxogd_Interval((float)a.Value, (float)b.Value);
                    double xz = 0;
                    for (int i = 1; i <= inter[0, 0]; i++)
                    {
                        double x = metods.kasat((double)inter[i, 0], (double)inter[i, 1], (double)W_ND.Value);
                        if (Math.Abs(xz - x) > 0.001)
                        {
                            if (Math.Abs(metods.F(x)) < 0.001)
                            {
                                stroka += "Метод касательных корень уравнения =" + x + Environment.NewLine + "количество шагов = " + metods.N + Environment.NewLine + "значение F=" + metods.F(x) + Environment.NewLine + Environment.NewLine;
                            }
                        }
                        xz = x;
                    }
                }

            }
          

            if (Metod_Rid_Chect.Checked || Metod_Rid_RB.Checked)
            {
                if (L == R_schen.vibran)
                {
                    double xz = 0;
                    double x = metods.M_Rid((float)a.Value, (float)b.Value, (double)Rnov.Value, (byte)m_NU.Value, (double)S_NU.Value / 100);
                    if (Math.Abs(xz - x) > 0.001)
                    {
                        if (Math.Abs(metods.R(x, (double)S_NU.Value / 100, (byte)m_NU.Value, (double)Rnov.Value)) < 0.001)
                        {
                            stroka += "Метод Ложного положения корень уравнения =" + x + Environment.NewLine + "количество шагов = " + metods.N + Environment.NewLine + "значение F=" + metods.R(x, (double)S_NU.Value / 100, (byte)m_NU.Value, (double)Rnov.Value) + Environment.NewLine + Environment.NewLine;
                        }
                    }
                }
                else
                {
                    float[,] inter = metods.naxogd_Interval((float)a.Value, (float)b.Value);
                    double xz = 0;
                    for (int i = 1; i <= inter[0, 0]; i++)
                    {
                        double x = metods.M_Rid((double)inter[i, 0], (double)inter[i, 1]);
                        if (Math.Abs(xz - x) > 0.001)
                        {
                            if (Math.Abs(metods.F(x)) < 0.001)
                            {
                                stroka += "Метод Ридрса корень уравнения =" + x + Environment.NewLine + "количество шагов = " + metods.N + Environment.NewLine + "значение F=" + metods.F(x) + Environment.NewLine + Environment.NewLine;
                            }
                        }
                        xz = x;
                    }
                }
                
            }


            if (stroka == null)
            {
                stroka += "Здесь будут корни и количество шагов";
            }

            text_okno.Text = stroka;

        }

        private void text_okno_TextChanged(object sender, EventArgs e)
        {

        }

        private void zapisat_Click(object sender, EventArgs e)
        {
            
            //Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt файлы (*.txt)|*.txt|все файлы (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = Application.StartupPath+ @"\zapisi";

            saveFileDialog1.ShowDialog();

            string put = saveFileDialog1.FileName;


            try
            {
                //File.WriteAllText(put, text_okno.Text);
                System.IO.File.WriteAllText(put, text_okno.Text);
            }
            catch
            {
            }

        }

        private void zagruzka_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "txt файлы (*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.ShowDialog();

            string put = openFileDialog.FileName;


            try
            {
                //File.WriteAllText(put, text_okno.Text);
                text_okno.Text = System.IO.File.ReadAllText(put);
            }
            catch 
            {
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dop_GB_Enter(object sender, EventArgs e)
        {

        }

        private void Iskl_TS_Menu_Click(object sender, EventArgs e)
        {
            Iskl_GB.Visible = true;
            Bisec_Checet.Checked = false;  Log.Checked = false; Kasat_Chekt.Checked = false; Metod_Rid_Chect.Checked = false;
            dop_GB.Visible = false;
        }

        private void Dop_TS_Menu_Click(object sender, EventArgs e)
        {
            dop_GB.Visible = true;
            Bisec_RB.Checked = false; Log_RB.Checked = false; Kasat_RB.Checked = false; Metod_Rid_RB.Checked = false;
            Iskl_GB.Visible = false;
        }

        private void RITM_Click(object sender, EventArgs e)
        {
            a.Value = 0;
            b.Value = 500;
            RnovText.Visible = true;
            Rnov.Visible = true;
            MLabel.Visible = true;
            m_NU.Visible = true;
            SLabel.Visible = true;
            S_NU.Visible = true;

            L= R_schen.vibran;

        }

        private void Vernet_UravTM_Click(object sender, EventArgs e)
        {
            a.Value = -3;
            b.Value = 4;
            RnovText.Visible = false;
            Rnov.Visible = false;
            MLabel.Visible = false;
            m_NU.Visible = false;
            SLabel.Visible = false;
            S_NU.Visible = false;

            L = R_schen.Nevibran;
        }


    }
}
