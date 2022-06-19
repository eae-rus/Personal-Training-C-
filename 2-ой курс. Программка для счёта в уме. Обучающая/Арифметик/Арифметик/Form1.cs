using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Арифметик
{
    public partial class Арифметик : Form
    {
        Мат_часть мат_часть;
        public Арифметик()
        {
            мат_часть = new Мат_часть();
            InitializeComponent();
            Числа.Text = мат_часть.Выдать_Строку((byte)Сложность.Value);

        }

        private void Арифметик_Load(object sender, EventArgs e)
        {

        }

        private void Ответ_TextChanged(object sender, EventArgs e)
        {

        }

        private void Посчитать_Click(object sender, EventArgs e)
        {
            if (мат_часть.Ответ(Ответ.Text))
            {
                Числа.Text = мат_часть.Выдать_Строку((byte)Сложность.Value);
                Ответ.Text = "";
            }
            else
            {}
        }

        private void Сложность_ValueChanged(object sender, EventArgs e)
        {
            Числа.Text = мат_часть.Выдать_Строку((byte)Сложность.Value);
        }

        private void Ответ_TextChanged_1(object sender, EventArgs e)
        {
            if (мат_часть.Ответ(Ответ.Text))
            {
                Числа.Text = мат_часть.Выдать_Строку((byte)Сложность.Value);
                Ответ.Text = "";
            }
        }
    }
}
