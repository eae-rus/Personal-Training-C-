using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Деовой_калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Обновление_формы()
        {
            Сумма.Text = "$" + ((uint)Конечный_км_цифра.Value - (uint)Начальный_км_цифра.Value) * 0.39;
        }

        private void Посчитать_Click(object sender, EventArgs e)
        {
            if (((uint)Конечный_км_цифра.Value - (uint)Начальный_км_цифра.Value) > 0)
            {
                Обновление_формы();
            }
            else 
            {
                MessageBox.Show("Начальная координата должна быть меньше конечной","Ошибка");
            }
        }

        private void Пройдено_км_Click(object sender, EventArgs e)
        {
            if (((uint)Конечный_км_цифра.Value - (uint)Начальный_км_цифра.Value) > 0)
            {
                MessageBox.Show(" " + ((uint)Конечный_км_цифра.Value - (uint)Начальный_км_цифра.Value), "Пройдено км");
            }
            else
            {
                MessageBox.Show("Начальная координата должна быть меньше конечной", "Ошибка");
            }
        }
    }
}
