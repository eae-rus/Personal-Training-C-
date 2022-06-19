using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vichmat
{


    public partial class Forma_int : Form
    {
        Metods_Int metods_int; 

        public Forma_int()
        {
            InitializeComponent();
        }
        private decimal I = 0.80845744785M;

        private void Vibor_Metoda_prymougol(object sender, EventArgs e)
        {
            Proverka_vivod();
        }

        private void KoL_rabienii(object sender, EventArgs e)
        {
            Proverka_vivod();
        }


        private void Text_okno(object sender, EventArgs e)
        {

        }

        private void b_ValueChanged(object sender, EventArgs e)
        {
            Proverka_vivod();
        }

        private void a_ValueChanged(object sender, EventArgs e)
        {
            Proverka_vivod();
        }

        private void Text_pogresh_okno(object sender, EventArgs e)
        {
            Proverka_vivod();
        }

        private void Vibor_metoda_trapec(object sender, EventArgs e)
        {
            Proverka_vivod();
        }

        private void Vibor_Metoda_Simpsona(object sender, EventArgs e)
        {
            Proverka_vivod();
        }

        private void Vibor_Metoda_Simpsona3_8(object sender, EventArgs e)
        {
            Proverka_vivod();
        }

        private void Vibor_Metoda_Gausa_Legandra(object sender, EventArgs e)
        {
            Proverka_vivod();
            if (Gausa_legandra_nagat.Checked)
            {
                P.Visible = true;
                Текст_Р.Visible = true;
            }
            else {

                P.Visible = false;
                Текст_Р.Visible = false;
            }
        }

        private void Текст_Р_Click(object sender, EventArgs e)
        {
            Proverka_vivod();
        }

        private void P_ValueChanged(object sender, EventArgs e)
        {
            Proverka_vivod();
        }

        private void Vibor_Metoda_Monte_Karlo(object sender, EventArgs e)
        {
            Proverka_vivod();
        }



        private void Proverka_vivod()
        {
            String stroka_text_okno = null;
            string stroka_text_pogresh = null;
            metods_int = new Metods_Int();
            // проверка для прямоугольников
            if (Vibor_metod_prymougol.Checked)
            {
                float IL = metods_int.Prymougol((float)a.Value, (float)b.Value, (float)N.Value, (float)0);
                float el =Math.Abs(((float)I - IL) / (float)I * 100);

                float IS = metods_int.Prymougol((float)a.Value, (float)b.Value, (float)N.Value, (float)0.5);
                float es = Math.Abs(((float)I - IS) / (float)I * 100);

                float IP = metods_int.Prymougol((float)a.Value, (float)b.Value, (float)N.Value, (float)1);
                float ep = Math.Abs(((float)I-IP) / (float)I * 100);

                stroka_text_okno += "Методами прямоугольника"+Environment.NewLine+"  Iл = " + IL + Environment.NewLine + "\n Iс = " + IS+ Environment.NewLine + "\n Iп = " + IP+Environment.NewLine ;
               stroka_text_pogresh += Environment.NewLine + "Методами прямоугольника \n Eл = " + el + "%\n Eс = " + Environment.NewLine+ es + "%\n Eп = " + Environment.NewLine + ep + "%"+ Environment.NewLine ;
            }
            // проверка для трапеций
            if (Vibor_metod_trap.Checked)
            {
                float IT = metods_int.Trapecii((float)a.Value, (float)b.Value, (float)N.Value);
                float eT = Math.Abs(((float)I - IT) / (float)I * 100);

                stroka_text_okno += Environment.NewLine + "Методом трапеций \n IT = " + IT;
                stroka_text_pogresh += Environment.NewLine + "Методом трапеций \n ET = " + eT + "%\n";
            }


            if (Vibor_metod_Simpson.Checked)
            {
                if (N.Value % 2 == 0)
                {
                    float ISim = metods_int.Simpsona((float)a.Value, (float)b.Value, (float)N.Value);
                    float eSim = Math.Abs(((float)I - ISim) / (float)I * 100);

                    stroka_text_okno += Environment.NewLine + "Методом Сиспсона \n ISim = " + ISim;
                    stroka_text_pogresh += Environment.NewLine + "Методом Сиспсона \n ESim = " + eSim + "%\n";
                }
                else
                {
                    stroka_text_okno += Environment.NewLine + "Нелььзя использовать метод Симпсна, так как N нечётно";
                }
            }


            if (Vibor_metod_simpsina3_8.Checked)
            {
                if (N.Value >= 6)
                {
                    float ISim = metods_int.Simpsona3_8((float)a.Value, (float)b.Value, (float)N.Value);
                    float eSim = Math.Abs(((float)I - ISim) / (float)I * 100);

                    stroka_text_okno += Environment.NewLine + "Методом Симпсона 3/8 \n ISim3/8 = " + ISim;
                    stroka_text_pogresh += Environment.NewLine + "Методом Сиспсона 3/8 \n ESim3/8 = " + eSim + "%\n";
                }
                else
                {
                    stroka_text_okno += Environment.NewLine + "Нелььзя использовать метод Симпсна, так как N <6";
                }
                   
            }



            if (Gausa_legandra_nagat.Checked)
            {
               
                    float IG = metods_int.Gausa_Legandra((float)a.Value, (float)b.Value, (float)N.Value,(byte)P.Value);
                    float eG = Math.Abs(((float)I - IG) / (float)I * 100);

                    stroka_text_okno += Environment.NewLine + "Методом Гауса Лежандра \n IГ = " + IG;
                    stroka_text_pogresh += Environment.NewLine + "Методом Гауса Лежандра \n EГ = " + eG + "%\n";
                
            }


            if (Vibor_metod_Monte_Karlo.Checked)
            {

                float IM = metods_int.Monte_Karlo((float)a.Value, (float)b.Value, (float)N.Value);
                float eM = Math.Abs(((float)I - IM) / (float)I * 100);

                stroka_text_okno += Environment.NewLine + "Методом Монте Карло \n IM = " + IM;
                stroka_text_pogresh += Environment.NewLine + "Методом Монте Карло \n EM = " + eM + "%\n";

            }



            if (stroka_text_okno == null)
            {
                stroka_text_okno = "Здесь будет отображаться результат счёт";
            }
            if (stroka_text_pogresh == null)
            {
                stroka_text_pogresh = "Здесь будет отображаться результат счёт";
            }

            Выводимый_текст.Text = stroka_text_okno;
            Погрешность.Text = stroka_text_pogresh;
        }

        private void Vernutsa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
