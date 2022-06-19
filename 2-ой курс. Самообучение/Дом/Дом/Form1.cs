using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Дом
{
    public partial class Описание_помещения : Form
    {
        Обработчик обработчик;
        byte ходов = 0;
        public Описание_помещения()
        {
            InitializeComponent();
            обработчик = new Обработчик();
            Описание_помещ_.Text = обработчик.выдать_строку_в_описание();
            Соседние_помещ.Items.Clear();
            for (byte i = 0; i < обработчик.кол_сосед_помещ(); i++)
            { Соседние_помещ.Items.Add(обработчик.выдать_строку_сосед_помещ(i)); }

            if (обработчик.выдать_есть_ли_дверь())
            {
                Зайти_выйти.Visible = true;
                Зайти_выйти.Text = обработчик.выдать_в_доме_ли_помещ();
            }
            else
            { Зайти_выйти.Visible = false; }

            //прятки
            Проверить.Visible = обработчик.начата_ли_игра;
            Места.Visible = обработчик.начата_ли_игра;
            Укромные_места.Visible = обработчик.начата_ли_игра;
        }



        private void Перем_в_ук_помещ_Click(object sender, EventArgs e)
        {
            if (Соседние_помещ.Text == "")
            { MessageBox.Show("Вы не определились, куда идти", "Ошибка"); }
            else
            {
                if (обработчик.Условие_перехода(Соседние_помещ.Text))
                    { MessageBox.Show("Невозможно свободное перемещение, так как мешается дверь \nнеоходимо её открыть нажатием на кнопку", "Дверь"); }
                 else
                {
                    обработчик.перемещение(Соседние_помещ.Text);
                    Описание_помещ_.Text = обработчик.выдать_строку_в_описание();
                    Соседние_помещ.Items.Clear();
                    for (byte i = 0; i < обработчик.кол_сосед_помещ(); i++)
                    { Соседние_помещ.Items.Add(обработчик.выдать_строку_сосед_помещ(i)); }

                    if (обработчик.выдать_есть_ли_дверь())
                    {
                        Зайти_выйти.Visible = true;
                        Зайти_выйти.Text = обработчик.выдать_в_доме_ли_помещ();
                    }
                    else
                    { Зайти_выйти.Visible = false; }
                }
                //sssssssssssssssssssssssssss
                Места.Items.Clear();
                for (byte i = 0; i < обработчик.выдать_количество_строк_о(); i++)
                {
                    Места.Items.Add(обработчик.выдать_одну_строку(i));
                }
                //sssssssssssssssssssssssssss
               
            }
        }

        private void Зайти_выйти_Click(object sender, EventArgs e)
        {

            обработчик.перемещение_вход_выход();
            Описание_помещ_.Text = обработчик.выдать_строку_в_описание();
            Соседние_помещ.Items.Clear();
            for (byte i = 0; i < обработчик.кол_сосед_помещ(); i++)
            { Соседние_помещ.Items.Add(обработчик.выдать_строку_сосед_помещ(i)); }

            if (обработчик.выдать_есть_ли_дверь())
            {
                Зайти_выйти.Visible = true;
                Зайти_выйти.Text = обработчик.выдать_в_доме_ли_помещ();
            }
            else
            { Зайти_выйти.Visible = false; }
            //sssssssssssssssssssssssssss
            Места.Items.Clear();
            for (byte i = 0; i < обработчик.выдать_количество_строк_о(); i++)
            {
                Места.Items.Add(обработчик.выдать_одну_строку(i));
            }
            //sssssssssssssssssssssssssss
        }

        private void Соседние_помещ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Описание_помещ__Click(object sender, EventArgs e)
        {

        }

        private void Начать_игру_Click(object sender, EventArgs e)
        {
            обработчик.спрятаться_обр();
            обработчик.начата_ли_игра = true;
            Укромные_места.Visible = обработчик.начата_ли_игра;
            for (byte i = 1; i <= 10; i++)
            {
                Укромные_места.Text = "Отсчёт времени:\n" + i;
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
            }
            Проверить.Visible = обработчик.начата_ли_игра;
            Места.Visible = обработчик.начата_ли_игра;
            //sssssssssssssssssssssssssss
            Места.Items.Clear();
            for (byte i = 0; i < обработчик.выдать_количество_строк_о(); i++)
            {
                Места.Items.Add(обработчик.выдать_одну_строку(i));
            }
            //sssssssssssssssssssssssssss


        }

        private void Проверить_Click(object sender, EventArgs e)
        {
            if (Места.Text  == "")
            {
                MessageBox.Show("Вы не решили, где искать, либо тут нет укромных мест", "Ошибка");
            }
            else
            {
                if (обработчик.тут_ли_игрок(Места.Text))
            { 
                MessageBox.Show("Он тут");
                Укромные_места.Text = "" + ходов;
                обработчик.начата_ли_игра = false;
                Укромные_места.Visible = обработчик.начата_ли_игра;
                Проверить.Visible = обработчик.начата_ли_игра;
                Места.Visible = обработчик.начата_ли_игра;
                ходов = 0;
            }
            else
            { 
                MessageBox.Show("Он не тут"); 
                ходов += 1; 
                Укромные_места.Text = "вы совершили ходов (мест проверили)\n" + ходов;  
            }
            }
        }

        
    }
}
