using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Стоимость_Пати
{
    public partial class Form1 : Form
    {
        Подсчёт подсчёт;
        День_Рождения день_рождения;
        public Form1()
        {
            день_рождения = new День_Рождения();
            подсчёт = new Подсчёт();
            InitializeComponent();
            Цена.Text = " $" + подсчёт.Итог((byte)КолГостей.Value, оформление.Checked, ЗдоровыйВариант.Checked);

        }

        private void ЗдоровыйВариант_CheckedChanged(object sender, EventArgs e)
        {
            Цена.Text = " $" + подсчёт.Итог((byte)КолГостей.Value, оформление.Checked, ЗдоровыйВариант.Checked);
        }

        private void оформление_CheckedChanged(object sender, EventArgs e)
        {
            Цена.Text = " $" + подсчёт.Итог((byte)КолГостей.Value, оформление.Checked, ЗдоровыйВариант.Checked);
        }

        private void КолГостей_ValueChanged(object sender, EventArgs e)
        {
            Цена.Text = " $" + подсчёт.Итог((byte)КолГостей.Value, оформление.Checked, ЗдоровыйВариант.Checked);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Кол_гостей_ДР_ValueChanged(object sender, EventArgs e)
        {
            Цена_ДР.Text = "$" +  день_рождения.Цена_Др((byte)Кол_гостей_ДР.Value, Оформление_ДР.Checked, Надпись.Text);
        }

        private void Оформление_ДР_CheckedChanged(object sender, EventArgs e)
        {
            Цена_ДР.Text = "$" + день_рождения.Цена_Др((byte)Кол_гостей_ДР.Value, Оформление_ДР.Checked, Надпись.Text);
        }

        private void Надпись_TextChanged(object sender, EventArgs e)
        {
            Цена_ДР.Text = "$" + день_рождения.Цена_Др((byte)Кол_гостей_ДР.Value, Оформление_ДР.Checked, Надпись.Text);
        }

        private void Цена_ДР_Click(object sender, EventArgs e)
        {

        }
    }
}
